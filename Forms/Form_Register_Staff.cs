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
    public partial class Form_Register_Staff : Form
    {
        private UserAccount StaffUserAccount = null;
        private DBSYSEntities DB;

        public void SetStaffUA(UserAccount UA) { StaffUserAccount = UA; }
        public UserAccount GetStaffUA() { return this.StaffUserAccount; }
        public double RngSalary(double min, double max) 
        {
            Random rng = new Random();
            return rng.NextDouble() * (max - min) + min; // NextDouble() gives between 0.00-1.00, hence the long formula.
        }

        public Form_Register_Staff()
        {
            InitializeComponent();

            DB = new DBSYSEntities();
            this.StaffUserAccount = null;
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Form_Register_Staff_Load(object sender, EventArgs e)
        {
            Timer_Clock.Start();
        }

        private void LinkLabel_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void Calendar_BDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            Txt_BDate.Text = Calendar_BDate.SelectionRange.Start.ToString("MMM dd, yyyy");
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_FN.Text))
            {
                ErrorProv_Txt.SetError(Txt_FN, "Write your first name in the form.");
                return;
            }
            if (String.IsNullOrEmpty(Txt_LN.Text))
            {
                ErrorProv_Txt.SetError(Txt_LN, "Write your last name in the form.");
                return;
            }
            if (String.IsNullOrEmpty(Cbx_Gender.Text))
            {
                ErrorProv_Txt.SetError(Cbx_Gender, "Select your gender in the form.");
                return;
            }
            if (String.IsNullOrEmpty(Txt_BDate.Text))
            {
                ErrorProv_Txt.SetError(Txt_BDate, "Write your birthdate in the form.");
                return;
            }
            if (String.IsNullOrEmpty(Txt_Contact.Text))
            {
                ErrorProv_Txt.SetError(Txt_Contact, "Write your contact number in the form.");
                return;
            }
            if (String.IsNullOrEmpty(Txt_Email.Text))
            {
                ErrorProv_Txt.SetError(Txt_Email, "Write your email address in the form.");
                return;
            }

            StaffInfo Staff = new StaffInfo();
            Staff.roleId = GetStaffUA().roleId;
            Staff.userId = GetStaffUA().userId;
            Staff.StaffFirstName = Txt_FN.Text;
            Staff.StaffLastName = Txt_LN.Text;
            Staff.StaffGender = Cbx_Gender.Text;
            Staff.StaffBirthDate = Convert.ToDateTime(Txt_BDate.Text);
            Staff.StaffContactNo = Txt_Contact.Text;
            Staff.StaffEmailAddress = Txt_Email.Text;
            Staff.StaffSalary = Convert.ToDecimal(RngSalary(18300, 27450)); // Convert from double to decimal.
            Staff.StaffStatus = "ACTIVE";

            DB.SP_NewStaff_Register(Staff.StaffFirstName,
                Staff.StaffLastName,
                Staff.StaffGender,
                Staff.StaffBirthDate,
                Staff.StaffContactNo,
                Staff.StaffEmailAddress,
                Staff.StaffSalary,
                Staff.StaffStatus,
                Staff.roleId,
                Staff.userId);
            DB.SP_NewUserAccount_Register(GetStaffUA().userName,
                    GetStaffUA().userPassword,
                    GetStaffUA().userStatus,
                    GetStaffUA().userDateCreated,
                    GetStaffUA().userDateUpdated,
                    GetStaffUA().roleId,
                    GetStaffUA().createdById,
                    GetStaffUA().createdByUser);

            MessageBox.Show("Registration successful!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Dispose();
        }

        private void Txt_FN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Txt_LN.Focus();
            }
        }

        private void Txt_LN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Txt_Contact.Focus();
            }
        }

        private void Txt_Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Txt_Email.Focus();
            }
        }

        private void Txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Btn_Register_Click(sender, e);
            }
        }
    }
}
