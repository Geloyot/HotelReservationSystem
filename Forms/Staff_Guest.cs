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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelReservationSystem
{
    public partial class Staff_Guest : Form
    {
        private UserRepository UserRepos;
        private HotelRepository HotelRepos;
        private GuestInformation SelectedGuest;
        private int? SelectedGuestID = null;
        private bool IsLoggingOut = false;

        public Staff_Guest()
        {
            InitializeComponent();
        }

        private void Staff_Guest_Load(object sender, EventArgs e)
        {
            Timer_Clock.Start();
            UserRepos = new UserRepository();
            HotelRepos = new HotelRepository();
            LoadGuestDB();
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void LoadGuestDB() 
        {
            Dgv_Guests.DataSource = UserRepos.GetGuestFullList();
            Label_AccountCount.Text = "No. of Guests: " + UserRepos.GetGuestFullList().Count;
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;

            Form_Login login = new Form_Login();
            login.Show();
            this.Dispose();
        }

        private void Dgv_Guests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EP_Input.Clear();

                SelectedGuestID = Convert.ToInt32(Dgv_Guests.Rows[e.RowIndex].Cells[0].Value);
                SelectedGuest = UserRepos.GetGuestByGuestID(SelectedGuestID);

                Txt_FN.Text = SelectedGuest.guestFirstName;
                Txt_LN.Text = SelectedGuest.guestLastName;
                Cbx_Gender.Text = SelectedGuest.guestGender;
                Clndr_BDate.SelectionStart = Convert.ToDateTime(SelectedGuest.guestBirthDate.Value);
                Clndr_BDate.SelectionEnd = Convert.ToDateTime(SelectedGuest.guestBirthDate.Value);
                Txt_Contact.Text = SelectedGuest.guestContactNo;
                Txt_Address.Text = SelectedGuest.guestAddress;
                Txt_Email.Text = SelectedGuest.guestEmailAddress;
                Txt_BDate.Text = SelectedGuest.guestBirthDate.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cell Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Form_Dashboard_Staff staff = new Form_Dashboard_Staff();
            staff.Show();
            this.Dispose();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = Txt_FN.Text;
                string lname = Txt_LN.Text;
                string gender = Cbx_Gender.Text;
                string bdate = Txt_BDate.Text;
                string contact = Txt_Contact.Text;
                string address = Txt_Address.Text;
                string email = Txt_Email.Text;

                EP_Input.Clear();

                // GUARDED CLAUSES TECHNIQUE
                if (String.IsNullOrEmpty(fname)) 
                {
                    EP_Input.SetError(Txt_FN, "Empty first name input!");
                    return;
                }
                if (String.IsNullOrEmpty(lname)) 
                {
                    EP_Input.SetError(Txt_LN, "Empty last name input!");
                    return;
                }
                if (String.IsNullOrEmpty(gender))
                {
                    EP_Input.SetError(Txt_FN, "No gender selected!");
                    return;
                }
                if (String.IsNullOrEmpty(bdate))
                {
                    EP_Input.SetError(Txt_LN, "Empty birthdate selection!");
                    return;
                }
                if (String.IsNullOrEmpty(contact))
                {
                    EP_Input.SetError(Txt_FN, "Empty contact input!");
                    return;
                }
                if (String.IsNullOrEmpty(address))
                {
                    EP_Input.SetError(Txt_LN, "Empty address input!");
                    return;
                }
                if (String.IsNullOrEmpty(email))
                {
                    EP_Input.SetError(Txt_LN, "Empty email input!");
                    return;
                }

                DBSYSEntities DB = new DBSYSEntities();
                DB.SP_UpdateGuest(SelectedGuestID, fname, lname, gender, Convert.ToDateTime(bdate), contact, address, email);

                MessageBox.Show(lname + " is successfully updated!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGuestDB();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error! \n"+ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clndr_BDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            Txt_BDate.Text = Clndr_BDate.SelectionRange.Start.ToString();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try 
            {
                DialogResult Action = MessageBox.Show("Are you sure you want to remove this guest from the list?\nThis action cannot be undone.", "Remove Guest", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (Action == DialogResult.Yes)
                {
                    EP_Input.Clear();

                    string lname = Txt_LN.Text;

                    DBSYSEntities DB = new DBSYSEntities();
                    DB.SP_DeleteGuest(SelectedGuestID);

                    MessageBox.Show(lname + " is successfully removed!", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SelectedGuestID = null;
                    LoadGuestDB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! \n" + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Staff_Guest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsLoggingOut)
            {
                Application.Exit();
            }
        }
    }
}
