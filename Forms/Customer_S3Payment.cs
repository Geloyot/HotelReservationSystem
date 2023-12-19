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

namespace HotelReservationSystem
{
    public partial class Customer_S3Payment : Form
    {
        private UserRepository UserRepos;
        private HotelRepository HotelRepos;

        public RoomInformation SelectedRoom;
        public ReservationInfo ReservationDetails;
        public GuestInformation GuestDetails;
        public PaymentInfo PaymentDetails;

        private bool IsLoggingOut = false;

        public Customer_S3Payment()
        {
            InitializeComponent();
        }

        private void Calendar_ExpiryDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            Txt_ExpiryDate.Text = Calendar_ExpiryDate.SelectionRange.End.ToString("MMM dd, yyyy");
        }

        private void Customer_S3Payment_Load(object sender, EventArgs e)
        {
            UserRepos = new UserRepository();
            HotelRepos = new HotelRepository();

            decimal amount = SelectedRoom.roomPrice * ((decimal)ReservationDetails.reserveStayLength / 2);
            Txt_Amount.Text = amount.ToString();
            ToolStatusStrip_CurrentUser.Text = CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userName;
            Timer_Clock.Start();
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
            Label_Calendar.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            LogOut();
        }

        private void Customer_S3Payment_FormClosed(object sender, FormClosedEventArgs e)
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

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Customer_S2Guest step2 = new Customer_S2Guest();

            step2.SelectedRoom = SelectedRoom;
            step2.ReservationDetails = ReservationDetails;
            step2.GuestDetails = GuestDetails;
            step2.PaymentDetails = PaymentDetails;

            step2.Show();
            this.Dispose();
        }

        private void Btn_NextStep_Click(object sender, EventArgs e)
        {
            try 
            { 
                string cardtype = Cbx_CardType.Text;
                string cardnum = Txt_CardNumber.Text;
                decimal amount = Convert.ToDecimal(Txt_Amount.Text);
                int cardcvv = Convert.ToInt32(Txt_SecurityCode.Text);
                DateTime cardexpire = Calendar_ExpiryDate.SelectionRange.Start;
                string cardowner = Txt_CardOwnerName.Text;
                EP_Input.Clear();

                if (String.IsNullOrEmpty(Cbx_CardType.Text))
                {
                    EP_Input.SetError(Cbx_CardType, "Select a payment mode first.");
                    return;
                }
                if (String.IsNullOrEmpty(Txt_CardNumber.Text))
                {
                    EP_Input.SetError(Txt_CardNumber, "Fill out your payment mode's number.");
                    return;
                }
                if (String.IsNullOrEmpty(Txt_SecurityCode.Text))
                {
                    EP_Input.SetError(Txt_SecurityCode, "Fill out your card's CVV (Card Verification Value) or security code.");
                    return;
                }
                if (String.IsNullOrEmpty(Txt_ExpiryDate.Text))
                {
                    EP_Input.SetError(Txt_ExpiryDate, "Enter your payment mode's expiration date.");
                    return;
                }
                if (String.IsNullOrEmpty(Txt_CardOwnerName.Text))
                {
                    EP_Input.SetError(Txt_CardOwnerName, "Fill out the name of your card's owner.");
                    return;
                }

                if (PaymentDetails == null) 
                {
                    PaymentDetails = new PaymentInfo();
                }

                PaymentDetails.paymentType = cardtype;
                PaymentDetails.cardNumber = cardnum;
                PaymentDetails.paymentAmount = amount;
                PaymentDetails.cardSecurityCode = cardcvv;
                PaymentDetails.cardExpiryDate = cardexpire;
                PaymentDetails.cardOwnerName = cardowner;
                PaymentDetails.userId = CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userId;
                PaymentDetails.reserveID = ReservationDetails.guestID;

                //Guest record first, so that other records can connect using guestID.
                DBSYSEntities DB = new DBSYSEntities();
                DB.SP_AddGuest_Booking(GuestDetails.guestFirstName, 
                    GuestDetails.guestLastName,
                    GuestDetails.guestGender, 
                    GuestDetails.guestBirthDate, 
                    GuestDetails.guestContactNo,
                    GuestDetails.guestAddress, 
                    GuestDetails.guestEmailAddress, 
                    GuestDetails.userID,
                    SelectedRoom.roomID);

                int RecentGuestID = UserRepos.GetGuestLatestID();

                //Create reservation second, so that payment can connect to reservation id
                DB.SP_AddReservation_Booking(ReservationDetails.reserveCheckInDate, 
                    ReservationDetails.reserveCheckOutDate,
                    ReservationDetails.reserveStayLength,
                    ReservationDetails.reserveGuestAdultCount,
                    ReservationDetails.reserveGuestChildCount,
                    ReservationDetails.reserveGuestCount,
                    CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userId,
                    SelectedRoom.roomID,
                    RecentGuestID);

                int RecentReservationID = HotelRepos.GetReservationLatestID();

                DB.SP_AddPayment_Booking(CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userId,
                    RecentReservationID,
                    RecentGuestID,
                    cardtype,
                    cardnum,
                    amount,
                    cardcvv,
                    cardexpire,
                    cardowner);

                DB.SP_UpdateRoom_GuestCount(SelectedRoom.roomID, ReservationDetails.reserveGuestCount);
                DB.SP_UpdateRoom_GuestID(SelectedRoom.roomID, RecentGuestID);

                Customer_S4Transaction receipt = new Customer_S4Transaction(RecentReservationID, amount);
                receipt.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occurred! \n\nDESCRIPTION:\n" + ex.ToString(), "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
