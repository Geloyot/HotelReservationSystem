using HotelReservationSystem.Appdata;
using HotelReservationSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class Staff_Rooms : Form
    {
        private UserRepository UserRepos;
        private HotelRepository HotelRepos;
        private RoomInformation SelectedRoom;

        private bool IsLoggingOut = false;
        private int SelectedRoomID;
        private string ImgFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Images";

        public Staff_Rooms()
        {
            InitializeComponent();
            if (!Directory.Exists(ImgFilePath)) 
            { 
                Directory.CreateDirectory(ImgFilePath);
            }
        }

        public void LoadRoomsDB() 
        {
            Dgv_Rooms.DataSource = HotelRepos.GetRoomsFullList();
            Label_RoomCount.Text = "No. of Rooms: " + HotelRepos.GetRoomsFullList().Count;
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Label_Calendar.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            Label_Clock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Staff_Rooms_Load(object sender, EventArgs e)
        {
            UserRepos = new UserRepository();
            HotelRepos = new HotelRepository();

            LoadRoomsDB();
            Timer_Clock.Start();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            this.Close();
        }

        private void Staff_Rooms_FormClosed(object sender, FormClosedEventArgs e)
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

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            Form_Dashboard_Staff staff = new Form_Dashboard_Staff();
            staff.Show();
            this.Dispose();
        }

        private void Btn_BrowseImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Ofd_RoomImg = new OpenFileDialog();
                if (Ofd_RoomImg.ShowDialog() == DialogResult.OK)
                {
                    string RoomImage = Ofd_RoomImg.FileName;

                    Txt_ImgFileName.Text = RoomImage;
                    Pbx_RoomImg.Image = new Bitmap(RoomImage);
                } 
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_RoomsFull_Click(object sender, EventArgs e)
        {
            Dgv_Rooms.DataSource = HotelRepos.GetRoomsFullList();
        }
        private void Btn_RoomsPrices_Click(object sender, EventArgs e)
        {
            Dgv_Rooms.DataSource = HotelRepos.GetRoomsPricesList();
        }
        private void Btn_RoomsTypes_Click(object sender, EventArgs e)
        {
            Dgv_Rooms.DataSource = HotelRepos.GetRoomsTypesList();
        }
        private void Btn_RoomsOccupied_Click(object sender, EventArgs e)
        {
            Dgv_Rooms.DataSource = HotelRepos.GetRoomsOccupiedList();
        }
        private void Btn_RoomsAvailable_Click(object sender, EventArgs e)
        {
            Dgv_Rooms.DataSource = HotelRepos.GetRoomsAvailableList();
        }

        private void Dgv_Rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            { 
                SelectedRoomID = Convert.ToInt32(Dgv_Rooms.Rows[e.RowIndex].Cells[0].Value);
                SelectedRoom = HotelRepos.GetRoomByRoomID(SelectedRoomID);

                string ImageFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Images\\" + SelectedRoom.roomImage;

                Txt_RTitle.Text = SelectedRoom.roomTitle;
                Txt_RType.Text = SelectedRoom.roomType;
                Txt_RPrice.Text = SelectedRoom.roomPrice.ToString();
                richTxt_RDesc.Text = SelectedRoom.roomDesc;
                Txt_ImgFileName.Text = ImageFilePath;
                Pbx_RoomImg.Image = new Bitmap(ImageFilePath);

                if (SelectedRoom.roomGuestCount == 0)
                {
                    Label_RoomStatus.Text = "Available";
                }
                else
                {
                    Label_RoomStatus.Text = "Occupied";
                }
                Label_GuestCount.Text = SelectedRoom.roomGuestCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException, "Cell Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_AddRoom_Click(object sender, EventArgs e)
        {
            try 
            {
                string title = Txt_RTitle.Text;
                string type = Txt_RType.Text;
                decimal price = Convert.ToDecimal(Txt_RPrice.Text);
                string desc = richTxt_RDesc.Text;

                string oldImgFileName = Txt_ImgFileName.Text;
                string[] newImgFileNameSplit = type.Split(' ');
                string newImgFileName = string.Join("_", newImgFileNameSplit) + ".jpg";
                string newImgPath = Path.Combine(ImgFilePath, newImgFileName);

                File.Copy(oldImgFileName, newImgPath);

                EP_Input.Clear();

                if (String.IsNullOrEmpty(title)) 
                {
                    EP_Input.SetError(Txt_RTitle, "Empty Room Title input!");
                    return;
                }
                if (String.IsNullOrEmpty(type))
                {
                    EP_Input.SetError(Txt_RType, "Empty Room Type input!");
                    return;
                }
                if (String.IsNullOrEmpty(price.ToString()))
                {
                    EP_Input.SetError(Txt_RPrice, "Empty Room Price input!");
                    return;
                }

                DBSYSEntities DB = new DBSYSEntities();
                DB.SP_AddRoom(title, type, price, desc, newImgFileName);

                MessageBox.Show(title + " is successfully added!", "Insertion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadRoomsDB();

                SelectedRoomID = 0;
                SelectedRoom = null;
                Txt_RTitle.Clear();
                Txt_RType.Clear();
                Txt_RPrice.Clear();
                richTxt_RDesc.Clear();
                Txt_ImgFileName.Clear();
                Pbx_RoomImg.Image = null;
                Label_RoomStatus.Text = "N/A";
                Label_GuestCount.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.ToString(), "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string title = Txt_RTitle.Text;
                string type = Txt_RType.Text;
                decimal price = Convert.ToDecimal(Txt_RPrice.Text);
                string desc = richTxt_RDesc.Text;

                string oldImgPath = Txt_ImgFileName.Text;
                string[] newImgFileNameSplit = type.Split(' ');
                string newImgFileName = string.Join("_", newImgFileNameSplit) + ".jpg";
                string newImgPath = Path.Combine(ImgFilePath, newImgFileName);

                if (oldImgPath != newImgPath) // NO NEED TO COPY FILE IF IT ALREADY EXISTS WITHIN THE APP
                {
                    File.Copy(oldImgPath, newImgPath, true);    // TRUE VALUE ALLOWS ONE IMAGE TO BE USED BY MULTIPLE ROOMS
                }

                EP_Input.Clear();

                if (String.IsNullOrEmpty(title))
                {
                    EP_Input.SetError(Txt_RTitle, "Empty Room Title input!");
                    return;
                }
                if (String.IsNullOrEmpty(type))
                {
                    EP_Input.SetError(Txt_RType, "Empty Room Type input!");
                    return;
                }
                if (String.IsNullOrEmpty(price.ToString()))
                {
                    EP_Input.SetError(Txt_RPrice, "Empty Room Price input!");
                    return;
                }

                DBSYSEntities DB = new DBSYSEntities();
                DB.SP_UpdateRoom(SelectedRoomID, title, type, price, desc, newImgFileName);

                MessageBox.Show(title + " is successfully updated", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadRoomsDB();

                SelectedRoomID = 0;
                SelectedRoom = null;
                Txt_RTitle.Clear();
                Txt_RType.Clear();
                Txt_RPrice.Clear();
                richTxt_RDesc.Clear();
                Txt_ImgFileName.Clear();
                Pbx_RoomImg.Image = null;
                Label_RoomStatus.Text = "N/A";
                Label_GuestCount.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Action = MessageBox.Show("Are you sure you want to remove this account?\nThis action cannot be undone.", "Remove Account", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (Action == DialogResult.Yes)
                {
                    string title = Txt_RTitle.Text;

                    DBSYSEntities DB = new DBSYSEntities();
                    DB.SP_DeleteRoom(SelectedRoomID);

                    EP_Input.Clear();
                    SelectedRoomID = 0;
                    SelectedRoom = null;
                    Txt_RTitle.Clear();
                    Txt_RType.Clear();
                    Txt_RPrice.Clear();
                    richTxt_RDesc.Clear();
                    Txt_ImgFileName.Clear();
                    Pbx_RoomImg.Image = null;
                    Label_RoomStatus.Text = "N/A";
                    Label_GuestCount.Text = "0";

                    MessageBox.Show(title + " is successfully removed!", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SelectedRoomID = 0;
                    SelectedRoom = null;
                    LoadRoomsDB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! \n" + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
