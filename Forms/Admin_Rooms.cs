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
    public partial class Admin_Rooms : Form
    {
        private bool IsLoggingOut = false;
        private HotelRepository HotelRepos;

        public Admin_Rooms()
        {
            InitializeComponent();
        }

        private void LogOut() 
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Dispose();
        }

        private void Admin_Rooms_Load(object sender, EventArgs e)
        {
            HotelRepos = new HotelRepository();
            Dgv_Rooms.DataSource = HotelRepos.GetRoomsFullList();

            Timer_Clock.Start();
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

        private void Admin_Rooms_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsLoggingOut)
            {
                IsLoggingOut = false;
                LogOut();
            }
            else
            {
                Application.Exit();
            }
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Form_Dashboard_Admin admin = new Form_Dashboard_Admin();
            admin.Show();
            this.Dispose();
        }

        private void Txt_SearchRoom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
