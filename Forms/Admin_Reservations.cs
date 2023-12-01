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
    public partial class Admin_Reservations : Form
    {
        private HotelRepository HotelRepos;
        private UserRepository UserRepos;

        private bool IsLoggingOut = false;

        public Admin_Reservations()
        {
            InitializeComponent();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Form_Dashboard_Admin admin = new Form_Dashboard_Admin();
            admin.Show();
            this.Dispose();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            this.Dispose();
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Admin_Reservations_Load(object sender, EventArgs e)
        {
            HotelRepos = new HotelRepository();
            UserRepos = new UserRepository();

            Timer_Clock.Start();
            LoadReservationsDB();
        }

        private void LoadReservationsDB() 
        { 
            Dgv_Reservations.DataSource = HotelRepos.GetReservationFullList();
        }

        private void Admin_Reservations_FormClosed(object sender, FormClosedEventArgs e)
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

        private void Btn_ViewFull_Click(object sender, EventArgs e)
        {
            LoadReservationsDB();
        }

        private void Btn_ViewGuests_Click(object sender, EventArgs e)
        {
            try
            {
                Dgv_Reservations.DataSource = HotelRepos.GetReservationGuestList();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("EXCEPTION: \n" + ex.Message , "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ViewCount_Click(object sender, EventArgs e)
        {
            try
            {
                Dgv_Reservations.DataSource = HotelRepos.GetReservationGuestCountList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXCEPTION: \n" + ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ViewRooms_Click(object sender, EventArgs e)
        {
            try
            {
                Dgv_Reservations.DataSource = HotelRepos.GetReservationRoomsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXCEPTION: \n" + ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Btn_ViewCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                Dgv_Reservations.DataSource = HotelRepos.GetReservationCheckInList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXCEPTION: \n" + ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ViewCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                Dgv_Reservations.DataSource = HotelRepos.GetReservationCheckOutList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXCEPTION: \n" + ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ViewChecks_Click(object sender, EventArgs e)
        {
            try
            {
                Dgv_Reservations.DataSource = HotelRepos.GetReservationChecksList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXCEPTION: \n" + ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_SearchReservation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {
                string room = Txt_SearchReservation.Text;
                
                DBSYSEntities DB = new DBSYSEntities();
                Dgv_Reservations.DataSource = DB.SP_SearchReservation_RoomOccupied(room).ToList();
            }
        }

        private void Txt_SearchUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string username = Txt_SearchUsername.Text;

                DBSYSEntities DB = new DBSYSEntities();
                Dgv_Reservations.DataSource = DB.SP_SearchReservation_Username(username).ToList();
            }
        }

        private void Txt_SearchLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string guestname = Txt_SearchUsername.Text;

                DBSYSEntities DB = new DBSYSEntities();
                Dgv_Reservations.DataSource = DB.SP_SearchReservation_GuestLastName(guestname).ToList();
            }
        }
        
    }
}
