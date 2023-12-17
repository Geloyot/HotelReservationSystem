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
    public partial class Admin_Staff : Form
    {
        private DBSYSEntities DB = new DBSYSEntities();
        private UserRepository UserRepos = new UserRepository();
        private UserAccount StaffAccount;
        private StaffInfo StaffPersonalInfo;

        public Admin_Staff(UserAccount StaffAccount)
        {
            InitializeComponent(); 
            this.StaffAccount = StaffAccount;

            StaffPersonalInfo = UserRepos.GetStaffInfoByUserID(StaffAccount.userId);
            Label_ID.Text = StaffPersonalInfo.userId.ToString();
            Dgv_Staff.DataSource = DB.StaffInfo.Where(si => si.userId == StaffAccount.userId).ToList();
        }
    }
}
