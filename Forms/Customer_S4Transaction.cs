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
    public partial class Customer_S4Transaction : Form
    {
        public RoomInformation SelectedRoom;
        public ReservationInfo ReservationDetails;
        public GuestInformation GuestDetails;
        public PaymentInfo PaymentDetails;

        public Customer_S4Transaction(int id, decimal amount)
        {
            InitializeComponent();
            Label_ReserveID.Text = id.ToString();
            Label_Amount.Text = amount.ToString("0.00");
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form_Dashboard_Guest guest  = new Form_Dashboard_Guest();
            guest.Show();
            this.Dispose();
        }
    }
}
