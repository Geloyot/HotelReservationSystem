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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.LinkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.LinkLabelAcctManage = new System.Windows.Forms.LinkLabel();
            this.LinkLabelDashboard = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.LinkLabel_Inquiry = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_Reservation = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_Room = new System.Windows.Forms.LinkLabel();
            this.Panel_Availability = new System.Windows.Forms.Panel();
            this.Label_Availability = new System.Windows.Forms.Label();
            this.Label_RoomCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Inquiry = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_NewInquiryCount = new System.Windows.Forms.Label();
            this.Label_Inquiry = new System.Windows.Forms.Label();
            this.Btn_Rooms = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Inquiries = new System.Windows.Forms.Button();
            this.Panel_Reservation = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Label_Reservation = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Availability.SuspendLayout();
            this.Panel_Inquiry.SuspendLayout();
            this.Panel_Reservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatus_CurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.LinkLabel_Room);
            this.panel1.Controls.Add(this.LinkLabel_Reservation);
            this.panel1.Controls.Add(this.LinkLabelLogout);
            this.panel1.Controls.Add(this.LinkLabel_Inquiry);
            this.panel1.Controls.Add(this.Label_Clock);
            this.panel1.Controls.Add(this.LinkLabelAcctManage);
            this.panel1.Controls.Add(this.Label_Calendar);
            this.panel1.Controls.Add(this.LinkLabelDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 492);
            this.panel1.TabIndex = 2;
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
            // LinkLabelLogout
            // 
            this.LinkLabelLogout.AutoSize = true;
            this.LinkLabelLogout.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelLogout.LinkColor = System.Drawing.Color.Black;
            this.LinkLabelLogout.Location = new System.Drawing.Point(18, 457);
            this.LinkLabelLogout.Name = "LinkLabelLogout";
            this.LinkLabelLogout.Size = new System.Drawing.Size(85, 25);
            this.LinkLabelLogout.TabIndex = 6;
            this.LinkLabelLogout.TabStop = true;
            this.LinkLabelLogout.Text = "Log Out";
            this.LinkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLogout_LinkClicked);
            // 
            // LinkLabelAcctManage
            // 
            this.LinkLabelAcctManage.AutoSize = true;
            this.LinkLabelAcctManage.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelAcctManage.LinkColor = System.Drawing.Color.Black;
            this.LinkLabelAcctManage.Location = new System.Drawing.Point(18, 189);
            this.LinkLabelAcctManage.Name = "LinkLabelAcctManage";
            this.LinkLabelAcctManage.Size = new System.Drawing.Size(86, 25);
            this.LinkLabelAcctManage.TabIndex = 5;
            this.LinkLabelAcctManage.TabStop = true;
            this.LinkLabelAcctManage.Text = "Accounts\r\n";
            this.LinkLabelAcctManage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAcctManage_LinkClicked);
            // 
            // LinkLabelDashboard
            // 
            this.LinkLabelDashboard.AutoSize = true;
            this.LinkLabelDashboard.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelDashboard.LinkColor = System.Drawing.Color.Black;
            this.LinkLabelDashboard.Location = new System.Drawing.Point(3, 149);
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
            // LinkLabel_Inquiry
            // 
            this.LinkLabel_Inquiry.AutoSize = true;
            this.LinkLabel_Inquiry.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_Inquiry.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel_Inquiry.Location = new System.Drawing.Point(20, 231);
            this.LinkLabel_Inquiry.Name = "LinkLabel_Inquiry";
            this.LinkLabel_Inquiry.Size = new System.Drawing.Size(84, 25);
            this.LinkLabel_Inquiry.TabIndex = 15;
            this.LinkLabel_Inquiry.TabStop = true;
            this.LinkLabel_Inquiry.Text = "Inquiries";
            // 
            // LinkLabel_Reservation
            // 
            this.LinkLabel_Reservation.AutoSize = true;
            this.LinkLabel_Reservation.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_Reservation.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel_Reservation.Location = new System.Drawing.Point(2, 269);
            this.LinkLabel_Reservation.Name = "LinkLabel_Reservation";
            this.LinkLabel_Reservation.Size = new System.Drawing.Size(120, 25);
            this.LinkLabel_Reservation.TabIndex = 16;
            this.LinkLabel_Reservation.TabStop = true;
            this.LinkLabel_Reservation.Text = "Reservations";
            // 
            // LinkLabel_Room
            // 
            this.LinkLabel_Room.AutoSize = true;
            this.LinkLabel_Room.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_Room.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel_Room.Location = new System.Drawing.Point(25, 309);
            this.LinkLabel_Room.Name = "LinkLabel_Room";
            this.LinkLabel_Room.Size = new System.Drawing.Size(69, 25);
            this.LinkLabel_Room.TabIndex = 17;
            this.LinkLabel_Room.TabStop = true;
            this.LinkLabel_Room.Text = "Rooms";
            // 
            // Panel_Availability
            // 
            this.Panel_Availability.BackColor = System.Drawing.Color.White;
            this.Panel_Availability.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Availability.Controls.Add(this.Btn_Rooms);
            this.Panel_Availability.Controls.Add(this.label1);
            this.Panel_Availability.Controls.Add(this.Label_RoomCount);
            this.Panel_Availability.Controls.Add(this.Label_Availability);
            this.Panel_Availability.Location = new System.Drawing.Point(146, 29);
            this.Panel_Availability.Name = "Panel_Availability";
            this.Panel_Availability.Size = new System.Drawing.Size(264, 171);
            this.Panel_Availability.TabIndex = 7;
            // 
            // Label_Availability
            // 
            this.Label_Availability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Availability.AutoSize = true;
            this.Label_Availability.Font = new System.Drawing.Font("Bahnschrift", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Availability.Location = new System.Drawing.Point(16, 12);
            this.Label_Availability.Name = "Label_Availability";
            this.Label_Availability.Size = new System.Drawing.Size(114, 25);
            this.Label_Availability.TabIndex = 18;
            this.Label_Availability.Text = "Availability";
            // 
            // Label_RoomCount
            // 
            this.Label_RoomCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_RoomCount.AutoSize = true;
            this.Label_RoomCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomCount.Location = new System.Drawing.Point(105, 47);
            this.Label_RoomCount.Name = "Label_RoomCount";
            this.Label_RoomCount.Size = new System.Drawing.Size(52, 39);
            this.Label_RoomCount.TabIndex = 19;
            this.Label_RoomCount.Text = "20";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "No. of Available Rooms";
            // 
            // Panel_Inquiry
            // 
            this.Panel_Inquiry.BackColor = System.Drawing.Color.White;
            this.Panel_Inquiry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Inquiry.Controls.Add(this.Btn_Inquiries);
            this.Panel_Inquiry.Controls.Add(this.label3);
            this.Panel_Inquiry.Controls.Add(this.label4);
            this.Panel_Inquiry.Controls.Add(this.label2);
            this.Panel_Inquiry.Controls.Add(this.Label_NewInquiryCount);
            this.Panel_Inquiry.Controls.Add(this.Label_Inquiry);
            this.Panel_Inquiry.Location = new System.Drawing.Point(146, 215);
            this.Panel_Inquiry.Name = "Panel_Inquiry";
            this.Panel_Inquiry.Size = new System.Drawing.Size(264, 293);
            this.Panel_Inquiry.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "New Inquiries";
            // 
            // Label_NewInquiryCount
            // 
            this.Label_NewInquiryCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_NewInquiryCount.AutoSize = true;
            this.Label_NewInquiryCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NewInquiryCount.Location = new System.Drawing.Point(105, 47);
            this.Label_NewInquiryCount.Name = "Label_NewInquiryCount";
            this.Label_NewInquiryCount.Size = new System.Drawing.Size(35, 39);
            this.Label_NewInquiryCount.TabIndex = 19;
            this.Label_NewInquiryCount.Text = "0";
            // 
            // Label_Inquiry
            // 
            this.Label_Inquiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Inquiry.AutoSize = true;
            this.Label_Inquiry.Font = new System.Drawing.Font("Bahnschrift", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Inquiry.Location = new System.Drawing.Point(16, 12);
            this.Label_Inquiry.Name = "Label_Inquiry";
            this.Label_Inquiry.Size = new System.Drawing.Size(94, 25);
            this.Label_Inquiry.TabIndex = 18;
            this.Label_Inquiry.Text = "Inquiries";
            // 
            // Btn_Rooms
            // 
            this.Btn_Rooms.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rooms.Location = new System.Drawing.Point(21, 132);
            this.Btn_Rooms.Name = "Btn_Rooms";
            this.Btn_Rooms.Size = new System.Drawing.Size(225, 32);
            this.Btn_Rooms.TabIndex = 21;
            this.Btn_Rooms.Text = "Go to Rooms";
            this.Btn_Rooms.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Addressed Inquiries";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 39);
            this.label4.TabIndex = 21;
            this.label4.Text = "0";
            // 
            // Btn_Inquiries
            // 
            this.Btn_Inquiries.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inquiries.Location = new System.Drawing.Point(21, 245);
            this.Btn_Inquiries.Name = "Btn_Inquiries";
            this.Btn_Inquiries.Size = new System.Drawing.Size(225, 32);
            this.Btn_Inquiries.TabIndex = 22;
            this.Btn_Inquiries.Text = "Go to Inquiries";
            this.Btn_Inquiries.UseVisualStyleBackColor = true;
            // 
            // Panel_Reservation
            // 
            this.Panel_Reservation.BackColor = System.Drawing.Color.White;
            this.Panel_Reservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Reservation.Controls.Add(this.button1);
            this.Panel_Reservation.Controls.Add(this.label5);
            this.Panel_Reservation.Controls.Add(this.label6);
            this.Panel_Reservation.Controls.Add(this.Label_Reservation);
            this.Panel_Reservation.Location = new System.Drawing.Point(448, 29);
            this.Panel_Reservation.Name = "Panel_Reservation";
            this.Panel_Reservation.Size = new System.Drawing.Size(264, 171);
            this.Panel_Reservation.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Go to Rooms";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "No. of Available Rooms";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 39);
            this.label6.TabIndex = 19;
            this.label6.Text = "20";
            // 
            // Label_Reservation
            // 
            this.Label_Reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Reservation.AutoSize = true;
            this.Label_Reservation.Font = new System.Drawing.Font("Bahnschrift", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Reservation.Location = new System.Drawing.Point(16, 12);
            this.Label_Reservation.Name = "Label_Reservation";
            this.Label_Reservation.Size = new System.Drawing.Size(136, 25);
            this.Label_Reservation.TabIndex = 18;
            this.Label_Reservation.Text = "Reservations";
            // 
            // Form_Dashboard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 549);
            this.Controls.Add(this.Panel_Reservation);
            this.Controls.Add(this.Panel_Inquiry);
            this.Controls.Add(this.Panel_Availability);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Availability.ResumeLayout(false);
            this.Panel_Availability.PerformLayout();
            this.Panel_Inquiry.ResumeLayout(false);
            this.Panel_Inquiry.PerformLayout();
            this.Panel_Reservation.ResumeLayout(false);
            this.Panel_Reservation.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LinkLabelDashboard;
        private System.Windows.Forms.LinkLabel LinkLabelAcctManage;
        private System.Windows.Forms.LinkLabel LinkLabelLogout;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.LinkLabel LinkLabel_Room;
        private System.Windows.Forms.LinkLabel LinkLabel_Reservation;
        private System.Windows.Forms.LinkLabel LinkLabel_Inquiry;
        private System.Windows.Forms.Panel Panel_Availability;
        private System.Windows.Forms.Label Label_Availability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_RoomCount;
        private System.Windows.Forms.Panel Panel_Inquiry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_NewInquiryCount;
        private System.Windows.Forms.Label Label_Inquiry;
        private System.Windows.Forms.Button Btn_Rooms;
        private System.Windows.Forms.Button Btn_Inquiries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Panel_Reservation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Label_Reservation;
    }
}