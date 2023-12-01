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
    public partial class Admin_AcctManage : Form
    {
        private UserRepository UserRepos;
        private int? SelectedUserId = null;
        private UserAccount SelectedUserAccount;

        public bool IsLoggingOut = false;

        public Admin_AcctManage()
        {
            InitializeComponent();
        }

        private void Form_AcctManage_Load(object sender, EventArgs e)
        {
            Timer_Clock.Start();
            UserRepos = new UserRepository();
            LoadUsersDB();

            Label_AccountCount.Text = "No. of Accounts: " + UserRepos.GetUserAccountCount();
        }

        private void LoadUsersDB()
        {
            Dgv_AcctManage.DataSource = UserRepos.GetUserAccountList();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            try 
            {
                string username = Txt_Username.Text;
                string password = Txt_Password.Text;

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

                DBSYSEntities DB = new DBSYSEntities();
                DB.SP_NewUserAccount(username, password, DateTime.Now, DateTime.Now, 1, CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userId, CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userName);

                MessageBox.Show(username + " is successfully registered!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsersDB();

                ErrorProviderInput.Clear();
                Txt_Username.Clear();
                Txt_Password.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! \n" + ex.Message, "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Txt_Username.Text;
                string password = Txt_Password.Text;
                string status = Label_Status.Text;

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
                ErrorProviderInput.Clear();

                DBSYSEntities DB = new DBSYSEntities();
                DB.SP_UpdateUserAccount(SelectedUserId, username, password, status, DateTime.Now);

                ErrorProviderInput.Clear();
                Txt_Username.Clear();
                Txt_Password.Clear();

                MessageBox.Show(username + " is successfully updated!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsersDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! \n" + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try 
            { 
                DialogResult Action = MessageBox.Show("Are you sure you want to remove this account?\nThis action cannot be undone.", "Remove Account", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (Action == DialogResult.Yes)
                {
                    string username = Txt_Username.Text;

                    DBSYSEntities DB = new DBSYSEntities();
                    DB.SP_DeleteUserAccount(SelectedUserId);

                    ErrorProviderInput.Clear();
                    Txt_Username.Clear();
                    Txt_Password.Clear();

                    MessageBox.Show(username + " is successfully removed!", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SelectedUserId = null;
                    Btn_Register.Focus();
                    LoadUsersDB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! \n" + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgv_AcctManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                SelectedUserId = Convert.ToInt32(Dgv_AcctManage.Rows[e.RowIndex].Cells[0].Value);
                SelectedUserAccount = UserRepos.GetUserByUserID(SelectedUserId);

                Txt_Username.Text = SelectedUserAccount.userName;
                Txt_Password.Text = SelectedUserAccount.userPassword;
                Label_Status.Text = SelectedUserAccount.userStatus;
                if (SelectedUserAccount.userStatus == "ACTIVE")
                {
                    Label_Status.ForeColor = System.Drawing.Color.DarkGreen;
                }
                else
                {
                    Label_Status.ForeColor = System.Drawing.Color.Red;
                }
                if (SelectedUserAccount.roleId != 1)
                {
                    Btn_ViewStaff.Visible = true;
                }
                else 
                {
                    Btn_ViewStaff.Visible = false;
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
            Label_Calendar.Text = DateTime.Now.ToString("MMMM dd, yyyy");
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
                IsLoggingOut = false;

                Form_Login FormLogin = new Form_Login();
                FormLogin.Show();
                this.Dispose();
            }
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            this.Dispose();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Form_Dashboard_Admin dashboard = new Form_Dashboard_Admin();
            dashboard.Show();
            this.Dispose();
        }

        private void Btn_UserStatus_Click(object sender, EventArgs e)
        {
            try
            {
                string OldStatus = Label_Status.Text;
                string NewStatus;
                if (OldStatus == "ACTIVE") { NewStatus = "INACTIVE"; }
                else { NewStatus = "ACTIVE"; }

                DialogResult dialog = MessageBox.Show("Are you sure you want to change this account's status to " + NewStatus + "?", "Account Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dialog == DialogResult.Yes)
                {
                    ChangeUserStatus(OldStatus);
                    LoadUsersDB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeUserStatus(string status) 
        {
            DBSYSEntities DB = new DBSYSEntities();
            UserAccount user = UserRepos.GetUserByUserID(SelectedUserId);

            if (status == "ACTIVE")
            {
                Label_Status.Text = "INACTIVE";
                Label_Status.ForeColor = System.Drawing.Color.Red;
                DB.SP_UpdateUserAccountStatus(Txt_Username.Text, "INACTIVE");
            }
            else
            {
                Label_Status.Text = "ACTIVE";
                Label_Status.ForeColor = System.Drawing.Color.DarkGreen;
                DB.SP_UpdateUserAccountStatus(Txt_Username.Text, "ACTIVE");
            }
            if (user.roleId != 1) 
            {
                ChangeStaffStatus(status, DB);
            }
        }

        private void ChangeStaffStatus(string status, DBSYSEntities DB) 
        {
            StaffInfo staff = UserRepos.GetStaffInfoByUserID(SelectedUserId);
            if (status == "ACTIVE")
            {
                Label_Status.Text = "INACTIVE";
                Label_Status.ForeColor = System.Drawing.Color.Red;

                staff.StaffStatus = "INACTIVE";
            }
            else
            {
                Label_Status.Text = "ACTIVE";
                Label_Status.ForeColor = System.Drawing.Color.DarkGreen;

                staff.StaffStatus = "ACTIVE";
            }
            DB.SaveChanges();
        }

        private void SearchByUsername() 
        {
            DBSYSEntities DB = new DBSYSEntities();
            if (String.IsNullOrEmpty(Txt_UsernameSearch.Text))
            {
                LoadUsersDB();
            }
            else
            {
                Dgv_AcctManage.DataSource = DB.SP_SearchUA_Username(Txt_UsernameSearch.Text).ToList();
            }
        }

        private void Txt_UsernameSearch_Leave(object sender, EventArgs e)
        {
            LoadUsersDB();
        }

        private void Txt_UsernameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SearchByUsername();
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            SearchByUsername();
        }

        private void Btn_ViewFull_Click(object sender, EventArgs e)
        {
            LoadUsersDB();
        }

        private void Btn_ViewRoles_Click(object sender, EventArgs e)
        {
            Dgv_AcctManage.DataSource = UserRepos.GetUserAccountRolesList();
        }

        private void Btn_ViewActive_Click(object sender, EventArgs e)
        {
            Dgv_AcctManage.DataSource = UserRepos.GetUserAccountActiveList();
        }

        private void Btn_ViewInactive_Click(object sender, EventArgs e)
        {
            Dgv_AcctManage.DataSource = UserRepos.GetUserAccountInactiveList();
        }

        private void Btn_ViewStaff_Click(object sender, EventArgs e)
        {
            Admin_Staff staff = new Admin_Staff(SelectedUserAccount);
            staff.ShowDialog();
        }
    }
}
