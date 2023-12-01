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

namespace HotelReservationSystem
{
    public partial class Form_Dashboard_Guest : Form
    {
        private HotelRepository HotelRepos;
        private UserRepository UserRepos;
        private bool IsLoggingOut = false;

        public Form_Dashboard_Guest()
        {
            InitializeComponent();
        }

        public void LogOut() 
        {
            if (IsLoggingOut)
            {
                Form_Login login = new Form_Login();
                login.Show();
                this.Dispose();
            }
            else 
            {
                Application.Exit();
            }
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("d");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Form_Dashboard_Guest_Load(object sender, EventArgs e)
        {
            HotelRepos = new HotelRepository();
            UserRepos = new UserRepository();

            ToolStripStatus_CurrentUser.Text = "Current User: " + CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userName;
            Timer_Clock.Start();
            CheckGuestReservation();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            LogOut();
        }

        private void Btn_Book_Click(object sender, EventArgs e)
        {
            Customer_S1Room SelectRoom = new Customer_S1Room();
            SelectRoom.Show();
            this.Dispose();
        }

        private void CheckGuestReservation() 
        {
            try // Try-catch used since getting Guest for 1st time always results in null exception.
            {
                GuestInformation Guest = UserRepos.GetGuestByUserID(CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userId);
                if (Guest == null) 
                {
                    return;
                }
                if (Guest.guestHasReservation.Value) 
                {
                    ReservationInfo CurrentReservation = HotelRepos.GetReservationByGuestID(Guest.guestID);
                    Label_CheckIn.Text = CurrentReservation.reserveCheckInDate.Value.ToString("MMMM dd, yyyy");
                    Label_CheckOut.Text = CurrentReservation.reserveCheckOutDate.Value.ToString("MMMM dd, yyyy");
                    Panel_PreExistingRes.Visible = true;
                }
            }
            catch 
            {

            }
        }
    }
}
