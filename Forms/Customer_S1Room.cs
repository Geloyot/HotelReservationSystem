﻿using System;
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
    public partial class Customer_S1Room : Form
    {
        private UserRepository UserRepos;
        private HotelRepository HotelRepos;

        public RoomInformation SelectedRoom;
        public ReservationInfo ReservationDetails;
        public GuestInformation GuestDetails;
        public PaymentInfo PaymentDetails;

        private bool IsLoggingOut = false;

        public Customer_S1Room()
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

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form_Dashboard_Guest home = new Form_Dashboard_Guest();
            home.Show();
            this.Dispose();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            LogOut();
        }

        private void LoadCbxRoomNames() 
        {
            DBSYSEntities DB = new DBSYSEntities();
            var RoomTitles = DB.RoomInformation.ToList();

            Cbx_RoomTitles.ValueMember = "roomID";
            Cbx_RoomTitles.DisplayMember = "roomTitle";
            Cbx_RoomTitles.DataSource = RoomTitles;
        }

        private void Customer_S1Room_Load(object sender, EventArgs e)
        {
            UserRepos = new UserRepository();
            HotelRepos = new HotelRepository();

            ToolStripStatus_CurrentUser.Text = "Current User: " + CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userName;
            Timer_Clock.Start();

            LoadCbxRoomNames();
        }

        private void Btn_NextStep_Click(object sender, EventArgs e)
        {
            DateTime checkin = Calendar_CheckIn.SelectionRange.Start;
            DateTime checkout = Calendar_CheckIn.SelectionRange.End;
            int staycount = (checkout - checkin).Days;
            int adult = Convert.ToInt32(NumUD_AdultCount.Value);
            int child = Convert.ToInt32(NumUD_ChildCount.Value);

            EP_Input.Clear();

            if (String.IsNullOrEmpty(Cbx_RoomTitles.Text)) 
            {
                EP_Input.SetError(Cbx_RoomTitles, "Select a room first before proceeding!");
                return;
            }
            if (String.IsNullOrEmpty(Txt_CheckOut.Text))
            {

                EP_Input.SetError(Txt_CheckOut, "Select your check-out date before proceeding!");
                return;
            }

            if (ReservationDetails == null) 
            {
                ReservationDetails = new ReservationInfo();
            }
            ReservationDetails.reserveCheckInDate = checkin;
            ReservationDetails.reserveCheckOutDate = checkout;
            ReservationDetails.reserveStayLength = staycount;
            ReservationDetails.roomID = SelectedRoom.roomID;
            ReservationDetails.reserveGuestAdultCount = adult;
            ReservationDetails.reserveGuestChildCount = child;
            ReservationDetails.reserveGuestCount = adult + child;
            ReservationDetails.userId = CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userId;

            Customer_S2Guest guest = new Customer_S2Guest();

            guest.SelectedRoom = SelectedRoom;
            guest.ReservationDetails = ReservationDetails;
            guest.GuestDetails = GuestDetails;
            guest.PaymentDetails = PaymentDetails;

            guest.Show();
            this.Dispose();
        }

        private void Customer_S1Room_FormClosed(object sender, FormClosedEventArgs e)
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

        private void Calendar_CheckIn_DateChanged(object sender, DateRangeEventArgs e)
        {
            Txt_CheckIn.Text = Calendar_CheckIn.SelectionRange.Start.ToString("MMM dd, yyyy");
            Txt_CheckOut.Text = Calendar_CheckIn.SelectionRange.End.ToString("MMM dd, yyyy");
        }

        private void Cbx_RoomTitles_SelectedIndexChanged(object sender, EventArgs e)
        {

            SelectedRoom = HotelRepos.GetRoomByRoomTitle(Cbx_RoomTitles.Text);
            Txt_Type.Text = SelectedRoom.roomType;
            Txt_Price.Text = SelectedRoom.roomPrice.ToString();
            richTxt_RoomDesc.Text = SelectedRoom.roomDesc;

            string ImageFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Images\\" + SelectedRoom.roomImage;
            picBx_RoomImage.Image = new Bitmap(ImageFilePath);
        }
    }
}