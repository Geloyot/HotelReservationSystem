using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Appdata;
using HotelReservationSystem.Forms;

namespace HotelReservationSystem
{
    public partial class Form_Login : Form
    {
        private UserRepository UserRepos;
        private bool IsExiting = true;
        public string login_username;

        public Form_Login()
        {
            InitializeComponent();
            UserRepos = new UserRepository();
        }

        //public void DEBUGMODE() 
        //{
        //    Txt_Username.Text = "gelobotAdmin";
        //    Txt_Password.Text = "22204390";
        //    Btn_Login_Click(null, null);
        //}

        private void Form_Login_Load(object sender, EventArgs e)
        {
            Timer_Clock.Start();
            //DEBUGMODE();
        }
        
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            login_username = Txt_Username.Text;

            if (String.IsNullOrEmpty(login_username)) 
            {
                ErrorProviderInput.SetError(Txt_Username, "Username field is empty!");
                return;
            }
            if (String.IsNullOrEmpty(Txt_Password.Text))
            {
                ErrorProviderInput.SetError(Txt_Password, "Password field is empty!");
                return;
            }

            var LoginUser = UserRepos.GetUserByUsername(login_username);
            if (LoginUser != null)
            {
                if (login_username.Equals(LoginUser.userName) &&  Txt_Password.Text.Equals(LoginUser.userPassword)) 
                {
                    CurrentlyLoggedUser.GetInstance().CurrentUserAccount = LoginUser;
                    MessageBox.Show("Login successful!\nWelcome, " + login_username, "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Txt_Username.Enabled = false;
                    Txt_Password.Enabled = false;
                    Checkbox_ShowPass.Enabled = false;
                    Btn_Login.Enabled = false;
                    LinkLabel_Register.Enabled = false;

                    Timer_Loading.Start();
                }
                else
                {
                    MessageBox.Show("Login failed! Credentials not found!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Login failed! Credentials not found!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Loading_Tick(object sender, EventArgs e)
        {
            var LoginUser = UserRepos.GetUserByUsername(login_username);
            int timer = 200;

            if (LoginUser.roleId != 1)
            {
                timer = 1;
            }

            if (ProgressBar_Loading.Value < timer)
            {
                ProgressBar_Loading.Value++;
                Label_Loading.Text = (ProgressBar_Loading.Value / 2) + "%";
            }
            else 
            {
                Timer_Loading.Stop();
                ProgressBar_Loading.Value = 0;

                OpenAccountDashboard(LoginUser);
            }
        }

        private void OpenAccountDashboard(UserAccount LoginUser) 
        {
            switch ((Roles)LoginUser.roleId)
            {
                case Roles.Guest:
                    new Form_Dashboard_Guest().Show();
                    this.Hide();
                    break;
                case Roles.Staff:
                    new Form_Dashboard_Staff().Show();
                    this.Hide();
                    break;
                case Roles.Admin:
                    new Form_Dashboard_Admin().Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Cannot login! User has no appropriate role!", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
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

        private void Txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {
                Txt_Password.Focus();
            }
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (String.IsNullOrEmpty(Txt_Username.Text))
                {
                    Txt_Username.Focus();
                }
                else 
                {
                    Btn_Login_Click(sender, e);
                }
            } 
        }

        private void LinkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsExiting = false;

            Form_Register FormRegister = new Form_Register();
            FormRegister.Show();
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("d");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsExiting)
            {
                Application.Exit();
            }
            else 
            {
                IsExiting = true;
            }
        }
    }
}
