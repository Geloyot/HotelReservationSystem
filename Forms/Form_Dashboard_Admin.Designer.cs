namespace HotelReservationSystem.Forms
{
    partial class Form_Dashboard_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatus_CurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_MI_OpenUserEntryForm = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_NavBar = new System.Windows.Forms.Panel();
            this.LinkLabel_Room = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_Reservation = new System.Windows.Forms.LinkLabel();
            this.LinkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.LinkLabelAcctManage = new System.Windows.Forms.LinkLabel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.LinkLabelDashboard = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.Panel_Availability = new System.Windows.Forms.Panel();
            this.Btn_Rooms = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_RoomAvailCount = new System.Windows.Forms.Label();
            this.Label_Availability = new System.Windows.Forms.Label();
            this.Panel_Reservation = new System.Windows.Forms.Panel();
            this.Btn_Reservation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Label_ReservationCount = new System.Windows.Forms.Label();
            this.Label_Reservation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_CheckInCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_CheckOutCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Label_RoomUsedCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_Accounts = new System.Windows.Forms.Button();
            this.Dgv_AccountsSmall = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Panel_NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Availability.SuspendLayout();
            this.Panel_Reservation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AccountsSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatus_CurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(968, 28);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatus_CurrentUser
            // 
            this.ToolStripStatus_CurrentUser.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatus_CurrentUser.Name = "ToolStripStatus_CurrentUser";
            this.ToolStripStatus_CurrentUser.Size = new System.Drawing.Size(129, 23);
            this.ToolStripStatus_CurrentUser.Text = "Current User: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_MI_OpenUserEntryForm});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // TS_MI_OpenUserEntryForm
            // 
            this.TS_MI_OpenUserEntryForm.Name = "TS_MI_OpenUserEntryForm";
            this.TS_MI_OpenUserEntryForm.Size = new System.Drawing.Size(190, 22);
            this.TS_MI_OpenUserEntryForm.Text = "Open User Entry Form";
            this.TS_MI_OpenUserEntryForm.Click += new System.EventHandler(this.TS_MI_OpenUserEntryForm_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Panel_NavBar
            // 
            this.Panel_NavBar.BackColor = System.Drawing.Color.Aquamarine;
            this.Panel_NavBar.Controls.Add(this.LinkLabel_Room);
            this.Panel_NavBar.Controls.Add(this.LinkLabel_Reservation);
            this.Panel_NavBar.Controls.Add(this.LinkLabelLogout);
            this.Panel_NavBar.Controls.Add(this.Label_Clock);
            this.Panel_NavBar.Controls.Add(this.LinkLabelAcctManage);
            this.Panel_NavBar.Controls.Add(this.Label_Calendar);
            this.Panel_NavBar.Controls.Add(this.LinkLabelDashboard);
            this.Panel_NavBar.Controls.Add(this.pictureBox1);
            this.Panel_NavBar.Location = new System.Drawing.Point(0, 26);
            this.Panel_NavBar.Name = "Panel_NavBar";
            this.Panel_NavBar.Size = new System.Drawing.Size(125, 392);
            this.Panel_NavBar.TabIndex = 2;
            // 
            // LinkLabel_Room
            // 
            this.LinkLabel_Room.AutoSize = true;
            this.LinkLabel_Room.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_Room.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel_Room.Location = new System.Drawing.Point(25, 257);
            this.LinkLabel_Room.Name = "LinkLabel_Room";
            this.LinkLabel_Room.Size = new System.Drawing.Size(69, 25);
            this.LinkLabel_Room.TabIndex = 17;
            this.LinkLabel_Room.TabStop = true;
            this.LinkLabel_Room.Text = "Rooms";
            // 
            // LinkLabel_Reservation
            // 
            this.LinkLabel_Reservation.AutoSize = true;
            this.LinkLabel_Reservation.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_Reservation.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel_Reservation.Location = new System.Drawing.Point(2, 217);
            this.LinkLabel_Reservation.Name = "LinkLabel_Reservation";
            this.LinkLabel_Reservation.Size = new System.Drawing.Size(120, 25);
            this.LinkLabel_Reservation.TabIndex = 16;
            this.LinkLabel_Reservation.TabStop = true;
            this.LinkLabel_Reservation.Text = "Reservations";
            // 
            // LinkLabelLogout
            // 
            this.LinkLabelLogout.AutoSize = true;
            this.LinkLabelLogout.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelLogout.LinkColor = System.Drawing.Color.Black;
            this.LinkLabelLogout.Location = new System.Drawing.Point(19, 348);
            this.LinkLabelLogout.Name = "LinkLabelLogout";
            this.LinkLabelLogout.Size = new System.Drawing.Size(85, 25);
            this.LinkLabelLogout.TabIndex = 6;
            this.LinkLabelLogout.TabStop = true;
            this.LinkLabelLogout.Text = "Log Out";
            this.LinkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLogout_LinkClicked);
            // 
            // Label_Clock
            // 
            this.Label_Clock.AutoSize = true;
            this.Label_Clock.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Clock.Location = new System.Drawing.Point(1, 88);
            this.Label_Clock.Name = "Label_Clock";
            this.Label_Clock.Size = new System.Drawing.Size(61, 25);
            this.Label_Clock.TabIndex = 13;
            this.Label_Clock.Text = "Time:";
            // 
            // LinkLabelAcctManage
            // 
            this.LinkLabelAcctManage.AutoSize = true;
            this.LinkLabelAcctManage.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelAcctManage.LinkColor = System.Drawing.Color.Black;
            this.LinkLabelAcctManage.Location = new System.Drawing.Point(18, 177);
            this.LinkLabelAcctManage.Name = "LinkLabelAcctManage";
            this.LinkLabelAcctManage.Size = new System.Drawing.Size(86, 25);
            this.LinkLabelAcctManage.TabIndex = 5;
            this.LinkLabelAcctManage.TabStop = true;
            this.LinkLabelAcctManage.Text = "Accounts\r\n";
            this.LinkLabelAcctManage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAcctManage_LinkClicked);
            // 
            // Label_Calendar
            // 
            this.Label_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Calendar.AutoSize = true;
            this.Label_Calendar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Calendar.Location = new System.Drawing.Point(1, 63);
            this.Label_Calendar.Name = "Label_Calendar";
            this.Label_Calendar.Size = new System.Drawing.Size(60, 25);
            this.Label_Calendar.TabIndex = 14;
            this.Label_Calendar.Text = "Date:";
            // 
            // LinkLabelDashboard
            // 
            this.LinkLabelDashboard.AutoSize = true;
            this.LinkLabelDashboard.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelDashboard.LinkColor = System.Drawing.Color.Black;
            this.LinkLabelDashboard.Location = new System.Drawing.Point(3, 137);
            this.LinkLabelDashboard.Name = "LinkLabelDashboard";
            this.LinkLabelDashboard.Size = new System.Drawing.Size(113, 25);
            this.LinkLabelDashboard.TabIndex = 4;
            this.LinkLabelDashboard.TabStop = true;
            this.LinkLabelDashboard.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::HotelReservationSystem.Properties.Resources.hoteldbsyslogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 60);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // Panel_Availability
            // 
            this.Panel_Availability.BackColor = System.Drawing.Color.White;
            this.Panel_Availability.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Availability.Controls.Add(this.label8);
            this.Panel_Availability.Controls.Add(this.Label_RoomUsedCount);
            this.Panel_Availability.Controls.Add(this.Btn_Rooms);
            this.Panel_Availability.Controls.Add(this.label1);
            this.Panel_Availability.Controls.Add(this.Label_RoomAvailCount);
            this.Panel_Availability.Controls.Add(this.Label_Availability);
            this.Panel_Availability.Location = new System.Drawing.Point(146, 29);
            this.Panel_Availability.Name = "Panel_Availability";
            this.Panel_Availability.Size = new System.Drawing.Size(515, 171);
            this.Panel_Availability.TabIndex = 7;
            // 
            // Btn_Rooms
            // 
            this.Btn_Rooms.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rooms.Location = new System.Drawing.Point(21, 132);
            this.Btn_Rooms.Name = "Btn_Rooms";
            this.Btn_Rooms.Size = new System.Drawing.Size(468, 32);
            this.Btn_Rooms.TabIndex = 21;
            this.Btn_Rooms.Text = "Go to Rooms";
            this.Btn_Rooms.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "No. of Available Rooms";
            // 
            // Label_RoomAvailCount
            // 
            this.Label_RoomAvailCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_RoomAvailCount.AutoSize = true;
            this.Label_RoomAvailCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomAvailCount.Location = new System.Drawing.Point(107, 48);
            this.Label_RoomAvailCount.Name = "Label_RoomAvailCount";
            this.Label_RoomAvailCount.Size = new System.Drawing.Size(46, 39);
            this.Label_RoomAvailCount.TabIndex = 19;
            this.Label_RoomAvailCount.Text = "10";
            // 
            // Label_Availability
            // 
            this.Label_Availability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Availability.AutoSize = true;
            this.Label_Availability.Font = new System.Drawing.Font("Bahnschrift", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Availability.Location = new System.Drawing.Point(20, 10);
            this.Label_Availability.Name = "Label_Availability";
            this.Label_Availability.Size = new System.Drawing.Size(114, 25);
            this.Label_Availability.TabIndex = 18;
            this.Label_Availability.Text = "Availability";
            // 
            // Panel_Reservation
            // 
            this.Panel_Reservation.BackColor = System.Drawing.Color.White;
            this.Panel_Reservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Reservation.Controls.Add(this.label4);
            this.Panel_Reservation.Controls.Add(this.Label_CheckOutCount);
            this.Panel_Reservation.Controls.Add(this.label2);
            this.Panel_Reservation.Controls.Add(this.Label_CheckInCount);
            this.Panel_Reservation.Controls.Add(this.Btn_Reservation);
            this.Panel_Reservation.Controls.Add(this.label5);
            this.Panel_Reservation.Controls.Add(this.Label_ReservationCount);
            this.Panel_Reservation.Controls.Add(this.Label_Reservation);
            this.Panel_Reservation.Location = new System.Drawing.Point(146, 228);
            this.Panel_Reservation.Name = "Panel_Reservation";
            this.Panel_Reservation.Size = new System.Drawing.Size(515, 171);
            this.Panel_Reservation.TabIndex = 22;
            // 
            // Btn_Reservation
            // 
            this.Btn_Reservation.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reservation.Location = new System.Drawing.Point(21, 132);
            this.Btn_Reservation.Name = "Btn_Reservation";
            this.Btn_Reservation.Size = new System.Drawing.Size(468, 32);
            this.Btn_Reservation.TabIndex = 21;
            this.Btn_Reservation.Text = "Go to Reservations";
            this.Btn_Reservation.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Reservations";
            // 
            // Label_ReservationCount
            // 
            this.Label_ReservationCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_ReservationCount.AutoSize = true;
            this.Label_ReservationCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ReservationCount.Location = new System.Drawing.Point(88, 47);
            this.Label_ReservationCount.Name = "Label_ReservationCount";
            this.Label_ReservationCount.Size = new System.Drawing.Size(35, 39);
            this.Label_ReservationCount.TabIndex = 19;
            this.Label_ReservationCount.Text = "4";
            // 
            // Label_Reservation
            // 
            this.Label_Reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Reservation.AutoSize = true;
            this.Label_Reservation.Font = new System.Drawing.Font("Bahnschrift", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Reservation.Location = new System.Drawing.Point(20, 13);
            this.Label_Reservation.Name = "Label_Reservation";
            this.Label_Reservation.Size = new System.Drawing.Size(136, 25);
            this.Label_Reservation.TabIndex = 18;
            this.Label_Reservation.Text = "Reservations";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Checked In";
            // 
            // Label_CheckInCount
            // 
            this.Label_CheckInCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_CheckInCount.AutoSize = true;
            this.Label_CheckInCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CheckInCount.Location = new System.Drawing.Point(245, 45);
            this.Label_CheckInCount.Name = "Label_CheckInCount";
            this.Label_CheckInCount.Size = new System.Drawing.Size(35, 39);
            this.Label_CheckInCount.TabIndex = 22;
            this.Label_CheckInCount.Text = "4";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Checked Out";
            // 
            // Label_CheckOutCount
            // 
            this.Label_CheckOutCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_CheckOutCount.AutoSize = true;
            this.Label_CheckOutCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CheckOutCount.Location = new System.Drawing.Point(398, 45);
            this.Label_CheckOutCount.Name = "Label_CheckOutCount";
            this.Label_CheckOutCount.Size = new System.Drawing.Size(34, 39);
            this.Label_CheckOutCount.TabIndex = 24;
            this.Label_CheckOutCount.Text = "2";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "No. of Occupied Rooms";
            // 
            // Label_RoomUsedCount
            // 
            this.Label_RoomUsedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_RoomUsedCount.AutoSize = true;
            this.Label_RoomUsedCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomUsedCount.Location = new System.Drawing.Point(348, 48);
            this.Label_RoomUsedCount.Name = "Label_RoomUsedCount";
            this.Label_RoomUsedCount.Size = new System.Drawing.Size(46, 39);
            this.Label_RoomUsedCount.TabIndex = 22;
            this.Label_RoomUsedCount.Text = "10";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Dgv_AccountsSmall);
            this.panel1.Controls.Add(this.Btn_Accounts);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(686, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 370);
            this.panel1.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Recently Added Accounts";
            // 
            // Btn_Accounts
            // 
            this.Btn_Accounts.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Accounts.Location = new System.Drawing.Point(8, 331);
            this.Btn_Accounts.Name = "Btn_Accounts";
            this.Btn_Accounts.Size = new System.Drawing.Size(255, 32);
            this.Btn_Accounts.TabIndex = 24;
            this.Btn_Accounts.Text = "Go to Accounts";
            this.Btn_Accounts.UseVisualStyleBackColor = true;
            // 
            // Dgv_AccountsSmall
            // 
            this.Dgv_AccountsSmall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_AccountsSmall.Location = new System.Drawing.Point(9, 49);
            this.Dgv_AccountsSmall.Name = "Dgv_AccountsSmall";
            this.Dgv_AccountsSmall.Size = new System.Drawing.Size(249, 269);
            this.Dgv_AccountsSmall.TabIndex = 25;
            // 
            // Form_Dashboard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Reservation);
            this.Controls.Add(this.Panel_Availability);
            this.Controls.Add(this.Panel_NavBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Dashboard_Admin";
            this.Text = "Administrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Dashboard_Admin_FormClosed);
            this.Load += new System.EventHandler(this.Form_Dashboard_Admin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panel_NavBar.ResumeLayout(false);
            this.Panel_NavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Availability.ResumeLayout(false);
            this.Panel_Availability.PerformLayout();
            this.Panel_Reservation.ResumeLayout(false);
            this.Panel_Reservation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AccountsSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatus_CurrentUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_MI_OpenUserEntryForm;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel Panel_NavBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LinkLabelDashboard;
        private System.Windows.Forms.LinkLabel LinkLabelAcctManage;
        private System.Windows.Forms.LinkLabel LinkLabelLogout;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.LinkLabel LinkLabel_Room;
        private System.Windows.Forms.LinkLabel LinkLabel_Reservation;
        private System.Windows.Forms.Panel Panel_Availability;
        private System.Windows.Forms.Label Label_Availability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_RoomAvailCount;
        private System.Windows.Forms.Button Btn_Rooms;
        private System.Windows.Forms.Panel Panel_Reservation;
        private System.Windows.Forms.Button Btn_Reservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label_ReservationCount;
        private System.Windows.Forms.Label Label_Reservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_CheckOutCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_CheckInCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Label_RoomUsedCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Accounts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Dgv_AccountsSmall;
    }
}