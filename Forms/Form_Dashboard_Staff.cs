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
        public Form_Dashboard_Staff()
        {
            InitializeComponent();
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

        }

        private void Btn_GoToGuests_Click(object sender, EventArgs e)
        {
            Btn_Guests_Click(sender, e);
        }
    }
}
