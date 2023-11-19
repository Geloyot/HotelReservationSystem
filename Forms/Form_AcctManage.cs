using HotelReservationSystem.Appdata;
using HotelReservationSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class Form_AcctManage : Form
    {
        private UserRepository UserRepos;
        private int? SelectedUserId = null;

        public bool IsLoggingOut = false;

        public Form_AcctManage()
        {
            InitializeComponent();
        }

        private void Form_AcctManage_Load(object sender, EventArgs e)
        {
            Timer_Clock.Start();
            UserRepos = new UserRepository();
            LoadUsersDatabase();
        }

        private void LoadUsersDatabase()
        {
            Dgv_AcctManage.DataSource = UserRepos.GetUserAccountList();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            string username = Txt_Username.Text;
            string password = Txt_Password.Text;

            if (String.IsNullOrEmpty(username)) 
            {
                ErrorProviderInput.SetError(Txt_Username, "Username field is empty!");
                return;
            } else if (String.IsNullOrEmpty(password)) 
            {
                ErrorProviderInput.SetError(Txt_Password, "Password field is empty!");
                return;
            }

            DBSYSEntities Database = new DBSYSEntities();
            Database.SP_NewUserAccount(username, password, DateTime.Now, DateTime.Now, 1, CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userId, CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userName);

            MessageBox.Show(username + " is successfully registered!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadUsersDatabase();

            ErrorProviderInput.Clear();
            Txt_Username.Clear();
            Txt_Password.Clear();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            
            string username = Txt_Username.Text;
            string password = Txt_Password.Text;
            string status = "ACTIVE";

            if (String.IsNullOrEmpty(username))
            {
                ErrorProviderInput.SetError(Txt_Username, "Username field is empty!");
                return;
            }
            else if (String.IsNullOrEmpty(password))
            {
                ErrorProviderInput.SetError(Txt_Password, "Password field is empty!");
                return;
            }
            else if (Label_Status.Text != "ACTIVE" && Label_Status.Text != "INACTIVE") 
            {
                ErrorProviderInput.SetError(Btn_UserStatus, "Invalid user account status!");
                return;
            }

            DBSYSEntities Database = new DBSYSEntities();
            Database.SP_UpdateUserAccount(SelectedUserId, username, password, status, DateTime.Now);

            ErrorProviderInput.Clear();
            Txt_Username.Clear();
            Txt_Password.Clear();

            MessageBox.Show(username + " is successfully updated!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsersDatabase();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult Action = MessageBox.Show("Are you sure you want to remove this account?\nThis action cannot be undone.", "Remove Account", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (Action == DialogResult.Yes)
            {
                string username = Txt_Username.Text;

                DBSYSEntities Database = new DBSYSEntities();
                Database.SP_DeleteUserAccount(SelectedUserId);

                ErrorProviderInput.Clear();
                Txt_Username.Clear();
                Txt_Password.Clear();

                MessageBox.Show(username + " is successfully removed!", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SelectedUserId = null;
                Btn_Register.Focus();
                LoadUsersDatabase();
            }
        }

        private void Dgv_AcctManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                SelectedUserId = Convert.ToInt32(Dgv_AcctManage.Rows[e.RowIndex].Cells[0].Value);
                Txt_Username.Text = Dgv_AcctManage.Rows[e.RowIndex].Cells[1].Value.ToString();
                Txt_Password.Text = Dgv_AcctManage.Rows[e.RowIndex].Cells[2].Value.ToString();
                Label_Status.Text = Dgv_AcctManage.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (Label_Status.Text == "ACTIVE")
                {
                    Label_Status.ForeColor = System.Drawing.Color.DarkGreen;
                }
                else
                {
                    Label_Status.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Cell Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Form_Login FormLogin = new Form_Login();
            FormLogin.ShowDialog();
        }

        private void Checkbox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox_ShowPass.Checked == true)
            {
                Txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("d");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Form_AcctManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsLoggingOut)
            {
                Application.Exit();
            }
            else 
            {
                Form_Login FormLogin = new Form_Login();
                FormLogin.Show();
                this.Dispose();

                IsLoggingOut = false;
            }
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            Form_AcctManage_FormClosed(sender, null);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Form_Dashboard_Admin dashboard = new Form_Dashboard_Admin();
            dashboard.Show();
            this.Dispose();
        }

        private void Dgv_AcctManage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_UserStatus_Click(object sender, EventArgs e)
        {
            DBSYSEntities Database = new DBSYSEntities();

            if (Label_Status.Text == "ACTIVE")
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to deactivate this account?", "Account Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialog == DialogResult.Yes)
                {
                    Label_Status.Text = "INACTIVE";
                    Label_Status.ForeColor = System.Drawing.Color.Red;
                    Database.SP_UpdateUserAccountStatus(Txt_Username.Text, "INACTIVE");
                }
            }
            else 
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to activate this account?", "Account Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialog == DialogResult.Yes)
                {
                    Label_Status.Text = "ACTIVE";
                    Label_Status.ForeColor = System.Drawing.Color.DarkGreen;
                    Database.SP_UpdateUserAccountStatus(Txt_Username.Text, "ACTIVE");
                }
            }

            LoadUsersDatabase();
        }
    }
}
