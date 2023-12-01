using HotelReservationSystem.Appdata;
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
    public partial class Form_Dashboard_Staff : Form
    {
        private UserRepository UserRepos;
        private HotelRepository HotelRepos;

        private bool IsLoggingOut;

        public Form_Dashboard_Staff()
        {
            InitializeComponent();

            UserRepos = new UserRepository();
            HotelRepos = new HotelRepository();

            IsLoggingOut = false;
        }

        private void Btn_Rooms_Click(object sender, EventArgs e)
        {
            Staff_Rooms rooms = new Staff_Rooms();
            rooms.Show();
            this.Dispose();
        }

        private void Btn_Guests_Click(object sender, EventArgs e)
        {
            Staff_Guest guest = new Staff_Guest();
            guest.Show();
            this.Dispose();
        }

        private void Btn_Reservations_Click(object sender, EventArgs e)
        {
            Staff_Reservations reserves = new Staff_Reservations();
            reserves.Show();
            this.Dispose();
        }

        private void Btn_Payments_Click(object sender, EventArgs e)
        {

        }

        private void Btn_GoToRooms_Click(object sender, EventArgs e)
        {
            Btn_Rooms_Click(sender, e);
        }

        private void Btn_GoToReservations_Click(object sender, EventArgs e)
        {
            Btn_Reservations_Click(sender, e);
        }

        private void Btn_GoToGuests_Click(object sender, EventArgs e)
        {
            Btn_Guests_Click(sender, e);
        }

        private void Form_Dashboard_Staff_Load(object sender, EventArgs e)
        {
            ToolStripStatus_CurrentUser.Text = "Current User: " + CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userName;
            Timer_Clock.Start();

            UserRepos = new UserRepository();
            HotelRepos = new HotelRepository();
            LoadGuestsLocation();
            Label_GuestCount.Text = "No. of Accounts: " + UserRepos.GetCurrentMonthGuestCount();
            LoadHotelData();
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void LoadGuestsLocation() 
        {
            Dgv_GuestsSmall.DataSource = UserRepos.GetGuestLocationList();   
        }
        private void LoadHotelData() 
        {
            DBSYSEntities DB = new DBSYSEntities();

            List<ReservationInfo> ReservesList = DB.ReservationInfo.ToList();
            List<GuestInformation> GuestsList = DB.GuestInformation.ToList();
            int checkins = 0;
            int checkouts = 0;

            foreach (ReservationInfo reservation in DB.ReservationInfo.ToList())
            {
                if (reservation.reserveCheckInDate.Value.Month != DateTime.Now.Month)
                {
                    ReservesList.Remove(reservation);
                }
            }
            foreach (GuestInformation guest in DB.GuestInformation.ToList())
            {
                if (guest.guestLastCheckInDate == null || guest.guestLastCheckInDate.Value.Month != DateTime.Now.Month)
                {
                    GuestsList.Remove(guest);
                }
            }
            foreach (ReservationInfo reservation in DB.ReservationInfo.ToList())
            {
                if (reservation.reserveHasCheckedIn.Value)
                {
                    checkins++;
                }
                if (reservation.reserveHasCheckedOut.Value)
                {
                    checkouts++;
                }
            }

            Label_Reservation.Text = "Reservations for " + DateTime.Now.ToString("MMMM");
            Label_ReservationCount.Text = ReservesList.Count.ToString();
            Label_CheckInCount.Text = checkins.ToString();
            Label_CheckOutCount.Text = checkouts.ToString();
            // Label_ReservationCount.Text = HotelRepos.GetReservationFullList().Count.ToString();
            Label_RoomAvailCount.Text = HotelRepos.GetRoomsAvailableList().Count.ToString();
            Label_RoomUsedCount.Text = HotelRepos.GetRoomsOccupiedList().Count.ToString();
        }

        private void Form_Dashboard_Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsLoggingOut)
            {
                Application.Exit();
            }
            else 
            {
                IsLoggingOut = false;

                Form_Login login = new Form_Login();
                login.Show();
                this.Dispose();
            }
        }
    }
}
