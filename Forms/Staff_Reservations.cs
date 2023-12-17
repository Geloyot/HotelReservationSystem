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

namespace HotelReservationSystem
{
    public partial class Staff_Reservations : Form
    {
        private UserRepository UserRepos;
        private HotelRepository HotelRepos;
        private DBSYSEntities DB;

        private bool IsLoggingOut;
        private int SelectedReservationID;
        private ReservationInfo SelectedReservation;

        public Staff_Reservations()
        {
            UserRepos = null;
            HotelRepos = null;
            DB = null;

            IsLoggingOut = false;
            SelectedReservationID = 0;
            SelectedReservation = null;

            InitializeComponent();
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
            Label_Calendar.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            this.Close();
        }

        private void Staff_Reservations_Load(object sender, EventArgs e)
        {
            DB = new DBSYSEntities();
            UserRepos = new UserRepository();
            HotelRepos = new HotelRepository();

            LoadReservationsDB();
            Timer_Clock.Start();
        }

        private void LoadReservationsDB()
        {
            Dgv_Reservations.DataSource = HotelRepos.GetReservationFullList();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Form_Dashboard_Staff staff = new Form_Dashboard_Staff();
            staff.Show();
            this.Dispose();
        }

        private void Staff_Reservations_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsLoggingOut)
            {
                Application.Exit();
            }
            else
            {
                Form_Login login = new Form_Login();
                login.Show();
                this.Dispose();
            }
        }

        private void Dgv_Reservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedReservationID = Convert.ToInt32(Dgv_Reservations.Rows[e.RowIndex].Cells[0].Value);
                SelectedReservation = HotelRepos.GetReservationByID(SelectedReservationID);

                Txt_CheckInDate.Text = SelectedReservation.reserveCheckInDate.Value.ToString("MMMM dd, yyyy");
                Txt_CheckOutDate.Text = SelectedReservation.reserveCheckOutDate.Value.ToString("MMMM dd, yyyy");
                Txt_Guest.Text = SelectedReservation.reserveGuestCount.ToString();
                Txt_GuestAdult.Text = SelectedReservation.reserveGuestAdultCount.ToString();
                Txt_GuestChild.Text = SelectedReservation.reserveGuestChildCount.ToString();
                Txt_GuestName.Text = UserRepos.GetGuestNameByGuestID(SelectedReservation.guestID);
                Txt_RoomTitle.Text = HotelRepos.GetRoomTitleByRoomID(SelectedReservation.roomID);
                Txt_Username.Text = UserRepos.GetUsernameByUserID(SelectedReservation.userId);
                Calendar_CheckInOut.SelectionRange.End = SelectedReservation.reserveCheckOutDate.Value;
                Calendar_CheckInOut.SelectionRange.Start = SelectedReservation.reserveCheckInDate.Value;
                Label_StayCount.Text = SelectedReservation.reserveStayLength.ToString();
                Label_CheckInStatus.Text = Convert.ToBoolean(SelectedReservation.reserveHasCheckedIn).ToString();
                Label_CheckOutStatus.Text = Convert.ToBoolean(SelectedReservation.reserveHasCheckedOut).ToString();

                if (!SelectedReservation.reserveHasCheckedIn.Value)
                {
                    Btn_ConfirmCheckIn.Enabled = true;
                    Label_CheckInStatus.ForeColor = System.Drawing.Color.Red;
                    Label_GuestCheckInDate.Visible = false;
                }
                else 
                {
                    Btn_ConfirmCheckIn.Enabled = false;
                    Label_CheckInStatus.ForeColor = System.Drawing.Color.DarkGreen;
                    Label_GuestCheckInDate.Text = SelectedReservation.reserveGuestCheckInDate.Value.ToString("MMMM dd, yyyy");
                    Label_GuestCheckInDate.Visible = true;
                }
                if (!SelectedReservation.reserveHasCheckedOut.Value)
                {
                    Btn_ConfirmCheckOut.Enabled = true;
                    Label_CheckOutStatus.ForeColor = System.Drawing.Color.Red;
                    Label_GuestCheckOutDate.Visible = false;
                }
                else 
                {
                    Btn_ConfirmCheckOut.Enabled = false;
                    Label_CheckOutStatus.ForeColor = System.Drawing.Color.DarkGreen;
                    Label_GuestCheckOutDate.Text = SelectedReservation.reserveGuestCheckOutDate.Value.ToString("MMMM dd, yyyy");
                    Label_GuestCheckOutDate.Visible = true;
                }

                if (SelectedReservation.PaymentInfo != null) 
                {
                    Btn_PaymentView.Enabled = true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("EXCEPTION: \n" + ex.Message, "Cell Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ConfirmCheckIn_Click(object sender, EventArgs e)
        {
            try 
            {
                DialogResult response = MessageBox.Show("Are you sure you want to confirm guest's check-in status?\nThis action cannot be undone.", "Confirm Check-In", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (response == DialogResult.Yes) 
                {
                    DB = new DBSYSEntities();
                    DB.SP_UpdateReservation_CheckInGuest(SelectedReservationID, DateTime.Now);
                    DB.SP_UpdateGuest_CheckInDate(SelectedReservation.guestID, DateTime.Now);

                    MessageBox.Show(UserRepos.GetGuestNameByGuestID(SelectedReservation.guestID) + " has checked-in.", "Guest Check-in", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SelectedReservationID = 0;
                    SelectedReservation = null;
                    ClearDisplays();
                    LoadReservationsDB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXCEPTION: \n" + ex.Message, "Check In Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ConfirmCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult response = MessageBox.Show("Are you sure you want to confirm guest's check-out status?\nThis action cannot be undone.", "Confirm Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (response == DialogResult.Yes)
                {
                    DB = new DBSYSEntities();
                    DB.SP_UpdateReservation_CheckOutGuest(SelectedReservation.reserveID, DateTime.Now);
                    DB.SP_UpdateGuest_CheckOutDate(SelectedReservation.guestID, DateTime.Now);
                    DB.SP_UpdateRoom_EmptyRoom(SelectedReservation.roomID);

                    MessageBox.Show(UserRepos.GetGuestNameByGuestID(SelectedReservation.guestID) + " has checked-out.", "Guest Check-out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SelectedReservationID = 0;
                    SelectedReservation = null;
                    ClearDisplays();
                    LoadReservationsDB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXCEPTION: \n" + ex.Message, "Check Out Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearDisplays() 
        {
            Txt_CheckInDate.Clear();
            Txt_CheckOutDate.Clear();
            Txt_Guest.Clear();
            Txt_GuestAdult.Clear();
            Txt_GuestChild.Clear();
            Txt_GuestName.Clear();
            Txt_RoomTitle.Clear();
            Txt_Username.Clear();
            Label_StayCount.Text = "";
            Label_CheckInStatus.Text = "";
            Label_CheckOutStatus.Text = "";
            Label_GuestCheckInDate.Visible = false;
            Label_GuestCheckOutDate.Visible = false;
            Btn_ConfirmCheckIn.Enabled = false;
            Btn_ConfirmCheckOut.Enabled = false;
            Btn_PaymentView.Enabled = false;
        }

        private void Btn_PaymentView_Click(object sender, EventArgs e)
        {
            Staff_Payment payment = new Staff_Payment(SelectedReservation);
            payment.ShowDialog();
        }
    }
}
