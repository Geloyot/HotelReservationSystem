using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class Form_Dashboard_Admin : Form
    {
        bool IsLoggingOut = false;

        public Form_Dashboard_Admin()
        {
            InitializeComponent();
        }

        private void OpenAcctManageForm()
        {
            Form_AcctManage AccountManagement = new Form_AcctManage();
            AccountManagement.Show();
            this.Dispose();
        }

        private void LogoutAccount()    // Smooth and memory-saving way of transitioning to another window via disposing the current window
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Dispose();
        }

        private void TS_MI_OpenUserEntryForm_Click(object sender, EventArgs e)
        {
            OpenAcctManageForm();
        }

        private void Form_Dashboard_Admin_Load(object sender, EventArgs e)
        {
            ToolStripStatus_CurrentUser.Text = "Current User: " + CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userName;
            Timer_Clock.Start();
        }

        private void LinkLabelAcctManage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenAcctManageForm();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            LogoutAccount();
        }

        private void LinkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsLoggingOut = true;
            LogoutAccount();
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("d");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Form_Dashboard_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsLoggingOut)
            {
                IsLoggingOut = false;
                LogoutAccount();
            }
            else {
                Application.Exit();
            }
        }
    }
}
