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
    public partial class Staff_Payment : Form
    {
        private DBSYSEntities DB = new DBSYSEntities();
        private HotelRepository HotelRepos = new HotelRepository();
        private ReservationInfo Reservation;
        private PaymentInfo ReservationPayment;

        public Staff_Payment(ReservationInfo Reservation)
        {
            InitializeComponent();
            this.Reservation = Reservation;

            ReservationPayment = HotelRepos.GetPaymentInfoByReservationID(Reservation.reserveID);
            Label_ID.Text = ReservationPayment.reserveID.ToString();
            Dgv_Payment.DataSource = DB.PaymentInfo.Where(pay => pay.reserveID == Reservation.reserveID).ToList();
        }
    }
}
