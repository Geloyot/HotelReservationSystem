using HotelReservationSystem.Appdata;
using HotelReservationSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HotelReservationSystem
{
    public partial class Form_Dashboard_Admin : Form
    {
        private bool IsLoggingOut = false;
        private UserRepository UserRepos;
        private HotelRepository HotelRepos;

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
        private void OpenRoomsForm() 
        { 
            Admin_Rooms rooms = new Admin_Rooms();
            rooms.Show();
            this.Dispose();
        }
        private void OpenReservationForm() 
        {
            Admin_Reservations reserve = new Admin_Reservations();
            reserve.Show();
            this.Dispose();
        }
        private void LogoutAccount()    // Smooth and memory-saving way of transitioning to another window via disposing the current window
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Dispose();
        }

        private void LoadUserAccountsRoles()
        {
            Dgv_AccountsSmall.DataSource = UserRepos.GetUserAccountRolesList();
        }
        private void LoadUserAccountsActive()
        {
            Dgv_AccountsSmall.DataSource = UserRepos.GetUserAccountActiveList();
        }
        private void LoadUserAccountsInactive()
        {
            Dgv_AccountsSmall.DataSource = UserRepos.GetUserAccountInactiveList();
        }
        private void LoadHotelData() 
        {
            Label_ReservationCount.Text = HotelRepos.GetReservationFullList().Count.ToString();
            Label_RoomAvailCount.Text = HotelRepos.GetRoomsAvailableList().Count.ToString();
            Label_RoomUsedCount.Text = HotelRepos.GetRoomsOccupiedList().Count.ToString();
        }

        private void TS_MI_OpenUserEntryForm_Click(object sender, EventArgs e)
        {
            OpenAcctManageForm();
        }

        private void Form_Dashboard_Admin_Load(object sender, EventArgs e)
        {
            ToolStripStatus_CurrentUser.Text = "Current User: " + CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userName;
            Timer_Clock.Start();

            UserRepos = new UserRepository();
            HotelRepos = new HotelRepository();
            LoadUserAccountsRoles();
            Label_AccountCount.Text = "No. of Accounts: " + UserRepos.GetUserAccountCount();
            LoadHotelData();
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

        private void Btn_Accounts_Click(object sender, EventArgs e)
        {
            OpenAcctManageForm();
        }

        private void Btn_Rooms_Click(object sender, EventArgs e)
        {
            OpenRoomsForm();
        }

        private void Btn_Reservation_Click(object sender, EventArgs e)
        {
            OpenReservationForm();
        }

        private void LinkLabel_Room_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenRoomsForm();
        }

        private void LinkLabel_Reservation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenReservationForm();
        }

        private void LinkLabelAcctManage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenAcctManageForm();
        }

        private void Btn_AcctRoles_Click(object sender, EventArgs e)
        {
            LoadUserAccountsRoles();
        }
        private void Btn_AcctActive_Click(object sender, EventArgs e)
        {
            LoadUserAccountsActive();
        }
        private void Btn_AcctInactive_Click(object sender, EventArgs e)
        {
            LoadUserAccountsInactive();
        }

        private void MenuItem_Accounts_Click(object sender, EventArgs e)
        {
            OpenAcctManageForm();
        }

        private void hotelRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRoomsForm();
        }

        private void guestReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenReservationForm();
        }
    }
}
