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
    public partial class Customer_S2Guest : Form
    {
        private UserRepository UserRepos;
        private HotelRepository HotelRepos;

        public RoomInformation SelectedRoom;
        public ReservationInfo ReservationDetails;
        public GuestInformation GuestDetails;
        public PaymentInfo PaymentDetails;

        private bool IsLoggingOut = false;

        public Customer_S2Guest()
        {
            InitializeComponent();
        }

        private void Customer_S2Guest_Load(object sender, EventArgs e)
        {
            UserRepos = new UserRepository();
            HotelRepos = new HotelRepository();

            ToolStripStatus_CurrentUser.Text = CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userName;
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

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Customer_S1Room step1 = new Customer_S1Room();

            step1.SelectedRoom = SelectedRoom;
            step1.ReservationDetails = ReservationDetails;
            step1.GuestDetails = GuestDetails;
            step1.PaymentDetails = PaymentDetails;

            step1.Show();
            this.Dispose();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            LogOut();
        }

        private void Customer_S2Guest_FormClosed(object sender, FormClosedEventArgs e)
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

        private void Btn_NextStep_Click(object sender, EventArgs e)
        {
            try 
            { 
                string fn = Txt_FN.Text;
                string ln = Txt_LN.Text;
                string gender = Cbx_Gender.Text;
                DateTime bdate = Calendar_BDate.SelectionRange.Start;
                string contact = Txt_Contact.Text;
                string address = Txt_Address.Text;
                string email = Txt_Email.Text;

                EP_Input.Clear();

                if (String.IsNullOrEmpty(Txt_FN.Text))
                {
                    EP_Input.SetError(Txt_FN, "First name must be filled out.");
                    return;
                }
                if (String.IsNullOrEmpty(Txt_LN.Text))
                {
                    EP_Input.SetError(Txt_LN, "Last name must be filled out.");
                    return;
                }
                if (String.IsNullOrEmpty(Cbx_Gender.Text))
                {
                    EP_Input.SetError(Cbx_Gender, "Gender must be selected.");
                    return;
                }
                if (String.IsNullOrEmpty(Txt_BDate.Text))
                {
                    EP_Input.SetError(Txt_BDate, "Birth date must be selected.");
                    return;
                }
                if (String.IsNullOrEmpty(Txt_Contact.Text))
                {
                    EP_Input.SetError(Txt_Contact, "Contact number must be filled out.");
                    return;
                }
                if (String.IsNullOrEmpty(Txt_Address.Text))
                {
                    EP_Input.SetError(Txt_Address, "Current address must be filled out.");
                    return;
                }
                if (String.IsNullOrEmpty(Txt_Email.Text))
                {
                    EP_Input.SetError(Txt_Email, "Email address must be filled out.");
                    return;
                }

                if (GuestDetails == null) 
                {
                    GuestDetails = new GuestInformation();
                }
                GuestDetails.guestFirstName = fn;
                GuestDetails.guestLastName = ln;
                GuestDetails.guestGender = gender;
                GuestDetails.guestBirthDate = bdate;
                GuestDetails.guestContactNo = contact;
                GuestDetails.guestAddress = address;
                GuestDetails.guestEmailAddress = email;
                GuestDetails.guestHasReservation = true;
                GuestDetails.userID = CurrentlyLoggedUser.GetInstance().CurrentUserAccount.userId;
                GuestDetails.roomID = SelectedRoom.roomID;

                Customer_S3Payment payment = new Customer_S3Payment();

                payment.SelectedRoom = SelectedRoom;
                payment.ReservationDetails = ReservationDetails;
                payment.GuestDetails = GuestDetails;
                payment.PaymentDetails = PaymentDetails;

                payment.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occurred! \n\nDESCRIPTION:\n" + ex.InnerException, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calendar_BDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            Txt_BDate.Text = Calendar_BDate.SelectionRange.Start.ToString();
        }
    }
}
