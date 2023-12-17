namespace HotelReservationSystem
{
    partial class Staff_Reservations
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
            this.Dgv_Reservations = new System.Windows.Forms.DataGridView();
            this.Panel_AcctOptions = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.Txt_RoomTitle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_GuestName = new System.Windows.Forms.TextBox();
            this.Btn_ConfirmCheckOut = new System.Windows.Forms.Button();
            this.Btn_ConfirmCheckIn = new System.Windows.Forms.Button();
            this.Label_GuestCheckOutDate = new System.Windows.Forms.Label();
            this.Label_GuestCheckInDate = new System.Windows.Forms.Label();
            this.Label_CheckOutStatus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Label_CheckInStatus = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_GuestChild = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_GuestAdult = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Guest = new System.Windows.Forms.TextBox();
            this.Label_StayCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_CheckOutDate = new System.Windows.Forms.TextBox();
            this.Txt_CheckInDate = new System.Windows.Forms.TextBox();
            this.Calendar_CheckInOut = new System.Windows.Forms.MonthCalendar();
            this.Txt_SearchReservation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_SearchUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_SearchLN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_ViewFull = new System.Windows.Forms.Button();
            this.Btn_ViewCount = new System.Windows.Forms.Button();
            this.Btn_ViewRooms = new System.Windows.Forms.Button();
            this.Btn_ViewCheckIn = new System.Windows.Forms.Button();
            this.Btn_ViewCheckOut = new System.Windows.Forms.Button();
            this.Btn_ViewChecks = new System.Windows.Forms.Button();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Panel_AcctManage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.EP_Input = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_PaymentView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reservations)).BeginInit();
            this.Panel_AcctOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            this.Panel_DateTime.SuspendLayout();
            this.Panel_AcctManage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Reservations
            // 
            this.Dgv_Reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Reservations.Location = new System.Drawing.Point(15, 439);
            this.Dgv_Reservations.Name = "Dgv_Reservations";
            this.Dgv_Reservations.Size = new System.Drawing.Size(937, 240);
            this.Dgv_Reservations.TabIndex = 0;
            this.Dgv_Reservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Reservations_CellClick);
            // 
            // Panel_AcctOptions
            // 
            this.Panel_AcctOptions.BackColor = System.Drawing.Color.LightBlue;
            this.Panel_AcctOptions.Controls.Add(this.Btn_PaymentView);
            this.Panel_AcctOptions.Controls.Add(this.label15);
            this.Panel_AcctOptions.Controls.Add(this.Txt_RoomTitle);
            this.Panel_AcctOptions.Controls.Add(this.label13);
            this.Panel_AcctOptions.Controls.Add(this.Txt_Username);
            this.Panel_AcctOptions.Controls.Add(this.label12);
            this.Panel_AcctOptions.Controls.Add(this.Txt_GuestName);
            this.Panel_AcctOptions.Controls.Add(this.Btn_ConfirmCheckOut);
            this.Panel_AcctOptions.Controls.Add(this.Btn_ConfirmCheckIn);
            this.Panel_AcctOptions.Controls.Add(this.Label_GuestCheckOutDate);
            this.Panel_AcctOptions.Controls.Add(this.Label_GuestCheckInDate);
            this.Panel_AcctOptions.Controls.Add(this.Label_CheckOutStatus);
            this.Panel_AcctOptions.Controls.Add(this.label14);
            this.Panel_AcctOptions.Controls.Add(this.Label_CheckInStatus);
            this.Panel_AcctOptions.Controls.Add(this.label11);
            this.Panel_AcctOptions.Controls.Add(this.Txt_GuestChild);
            this.Panel_AcctOptions.Controls.Add(this.label10);
            this.Panel_AcctOptions.Controls.Add(this.Txt_GuestAdult);
            this.Panel_AcctOptions.Controls.Add(this.label9);
            this.Panel_AcctOptions.Controls.Add(this.label7);
            this.Panel_AcctOptions.Controls.Add(this.Txt_Guest);
            this.Panel_AcctOptions.Controls.Add(this.Label_StayCount);
            this.Panel_AcctOptions.Controls.Add(this.label3);
            this.Panel_AcctOptions.Controls.Add(this.label1);
            this.Panel_AcctOptions.Controls.Add(this.label2);
            this.Panel_AcctOptions.Controls.Add(this.Txt_CheckOutDate);
            this.Panel_AcctOptions.Controls.Add(this.Txt_CheckInDate);
            this.Panel_AcctOptions.Controls.Add(this.Calendar_CheckInOut);
            this.Panel_AcctOptions.Location = new System.Drawing.Point(15, 131);
            this.Panel_AcctOptions.Name = "Panel_AcctOptions";
            this.Panel_AcctOptions.Size = new System.Drawing.Size(659, 302);
            this.Panel_AcctOptions.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(460, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 23);
            this.label15.TabIndex = 69;
            this.label15.Text = "Room Occupied";
            // 
            // Txt_RoomTitle
            // 
            this.Txt_RoomTitle.Enabled = false;
            this.Txt_RoomTitle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RoomTitle.Location = new System.Drawing.Point(463, 90);
            this.Txt_RoomTitle.Name = "Txt_RoomTitle";
            this.Txt_RoomTitle.Size = new System.Drawing.Size(160, 27);
            this.Txt_RoomTitle.TabIndex = 68;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(265, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 23);
            this.label13.TabIndex = 67;
            this.label13.Text = "Username";
            // 
            // Txt_Username
            // 
            this.Txt_Username.Enabled = false;
            this.Txt_Username.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Username.Location = new System.Drawing.Point(268, 144);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(177, 27);
            this.Txt_Username.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(265, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 23);
            this.label12.TabIndex = 65;
            this.label12.Text = "Guest Name";
            // 
            // Txt_GuestName
            // 
            this.Txt_GuestName.Enabled = false;
            this.Txt_GuestName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_GuestName.Location = new System.Drawing.Point(268, 90);
            this.Txt_GuestName.Name = "Txt_GuestName";
            this.Txt_GuestName.Size = new System.Drawing.Size(177, 27);
            this.Txt_GuestName.TabIndex = 64;
            // 
            // Btn_ConfirmCheckOut
            // 
            this.Btn_ConfirmCheckOut.Enabled = false;
            this.Btn_ConfirmCheckOut.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConfirmCheckOut.Location = new System.Drawing.Point(403, 255);
            this.Btn_ConfirmCheckOut.Name = "Btn_ConfirmCheckOut";
            this.Btn_ConfirmCheckOut.Size = new System.Drawing.Size(235, 34);
            this.Btn_ConfirmCheckOut.TabIndex = 63;
            this.Btn_ConfirmCheckOut.Text = "CONFIRM CHECK-OUT";
            this.Btn_ConfirmCheckOut.UseVisualStyleBackColor = true;
            this.Btn_ConfirmCheckOut.Click += new System.EventHandler(this.Btn_ConfirmCheckOut_Click);
            // 
            // Btn_ConfirmCheckIn
            // 
            this.Btn_ConfirmCheckIn.Enabled = false;
            this.Btn_ConfirmCheckIn.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConfirmCheckIn.Location = new System.Drawing.Point(179, 255);
            this.Btn_ConfirmCheckIn.Name = "Btn_ConfirmCheckIn";
            this.Btn_ConfirmCheckIn.Size = new System.Drawing.Size(216, 34);
            this.Btn_ConfirmCheckIn.TabIndex = 17;
            this.Btn_ConfirmCheckIn.Text = "CONFIRM CHECK-IN";
            this.Btn_ConfirmCheckIn.UseVisualStyleBackColor = true;
            this.Btn_ConfirmCheckIn.Click += new System.EventHandler(this.Btn_ConfirmCheckIn_Click);
            // 
            // Label_GuestCheckOutDate
            // 
            this.Label_GuestCheckOutDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_GuestCheckOutDate.AutoSize = true;
            this.Label_GuestCheckOutDate.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GuestCheckOutDate.Location = new System.Drawing.Point(399, 230);
            this.Label_GuestCheckOutDate.Name = "Label_GuestCheckOutDate";
            this.Label_GuestCheckOutDate.Size = new System.Drawing.Size(182, 25);
            this.Label_GuestCheckOutDate.TabIndex = 62;
            this.Label_GuestCheckOutDate.Text = "CHECK-OUT DATE";
            this.Label_GuestCheckOutDate.Visible = false;
            // 
            // Label_GuestCheckInDate
            // 
            this.Label_GuestCheckInDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_GuestCheckInDate.AutoSize = true;
            this.Label_GuestCheckInDate.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GuestCheckInDate.Location = new System.Drawing.Point(175, 230);
            this.Label_GuestCheckInDate.Name = "Label_GuestCheckInDate";
            this.Label_GuestCheckInDate.Size = new System.Drawing.Size(165, 25);
            this.Label_GuestCheckInDate.TabIndex = 61;
            this.Label_GuestCheckInDate.Text = "CHECK-IN DATE";
            this.Label_GuestCheckInDate.Visible = false;
            // 
            // Label_CheckOutStatus
            // 
            this.Label_CheckOutStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_CheckOutStatus.AutoSize = true;
            this.Label_CheckOutStatus.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CheckOutStatus.Location = new System.Drawing.Point(399, 205);
            this.Label_CheckOutStatus.Name = "Label_CheckOutStatus";
            this.Label_CheckOutStatus.Size = new System.Drawing.Size(205, 25);
            this.Label_CheckOutStatus.TabIndex = 60;
            this.Label_CheckOutStatus.Text = "CHECK-OUT STATUS";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(401, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 23);
            this.label14.TabIndex = 59;
            this.label14.Text = "Has Checked Out?";
            // 
            // Label_CheckInStatus
            // 
            this.Label_CheckInStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_CheckInStatus.AutoSize = true;
            this.Label_CheckInStatus.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CheckInStatus.Location = new System.Drawing.Point(175, 205);
            this.Label_CheckInStatus.Name = "Label_CheckInStatus";
            this.Label_CheckInStatus.Size = new System.Drawing.Size(188, 25);
            this.Label_CheckInStatus.TabIndex = 58;
            this.Label_CheckInStatus.Text = "CHECK-IN STATUS";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(176, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 23);
            this.label11.TabIndex = 57;
            this.label11.Text = "Has Checked In?";
            // 
            // Txt_GuestChild
            // 
            this.Txt_GuestChild.Enabled = false;
            this.Txt_GuestChild.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_GuestChild.Location = new System.Drawing.Point(389, 32);
            this.Txt_GuestChild.Name = "Txt_GuestChild";
            this.Txt_GuestChild.Size = new System.Drawing.Size(51, 27);
            this.Txt_GuestChild.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 23);
            this.label10.TabIndex = 49;
            this.label10.Text = "Child";
            // 
            // Txt_GuestAdult
            // 
            this.Txt_GuestAdult.Enabled = false;
            this.Txt_GuestAdult.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_GuestAdult.Location = new System.Drawing.Point(328, 32);
            this.Txt_GuestAdult.Name = "Txt_GuestAdult";
            this.Txt_GuestAdult.Size = new System.Drawing.Size(51, 27);
            this.Txt_GuestAdult.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 47;
            this.label9.Text = "Adult";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "Count";
            // 
            // Txt_Guest
            // 
            this.Txt_Guest.Enabled = false;
            this.Txt_Guest.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Guest.Location = new System.Drawing.Point(267, 32);
            this.Txt_Guest.Name = "Txt_Guest";
            this.Txt_Guest.Size = new System.Drawing.Size(51, 27);
            this.Txt_Guest.TabIndex = 45;
            // 
            // Label_StayCount
            // 
            this.Label_StayCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_StayCount.AutoSize = true;
            this.Label_StayCount.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StayCount.Location = new System.Drawing.Point(459, 148);
            this.Label_StayCount.Name = "Label_StayCount";
            this.Label_StayCount.Size = new System.Drawing.Size(90, 25);
            this.Label_StayCount.TabIndex = 40;
            this.Label_StayCount.Text = "LENGTH";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Stay Length: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Check-Out Date";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Check-In Date";
            // 
            // Txt_CheckOutDate
            // 
            this.Txt_CheckOutDate.Enabled = false;
            this.Txt_CheckOutDate.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CheckOutDate.Location = new System.Drawing.Point(19, 262);
            this.Txt_CheckOutDate.Name = "Txt_CheckOutDate";
            this.Txt_CheckOutDate.Size = new System.Drawing.Size(139, 27);
            this.Txt_CheckOutDate.TabIndex = 36;
            // 
            // Txt_CheckInDate
            // 
            this.Txt_CheckInDate.Enabled = false;
            this.Txt_CheckInDate.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CheckInDate.Location = new System.Drawing.Point(19, 203);
            this.Txt_CheckInDate.Name = "Txt_CheckInDate";
            this.Txt_CheckInDate.Size = new System.Drawing.Size(139, 27);
            this.Txt_CheckInDate.TabIndex = 35;
            // 
            // Calendar_CheckInOut
            // 
            this.Calendar_CheckInOut.Enabled = false;
            this.Calendar_CheckInOut.Location = new System.Drawing.Point(19, 9);
            this.Calendar_CheckInOut.Name = "Calendar_CheckInOut";
            this.Calendar_CheckInOut.TabIndex = 34;
            // 
            // Txt_SearchReservation
            // 
            this.Txt_SearchReservation.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SearchReservation.Location = new System.Drawing.Point(20, 35);
            this.Txt_SearchReservation.Name = "Txt_SearchReservation";
            this.Txt_SearchReservation.Size = new System.Drawing.Size(235, 27);
            this.Txt_SearchReservation.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Search by Room Occupied";
            // 
            // Txt_SearchUsername
            // 
            this.Txt_SearchUsername.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SearchUsername.Location = new System.Drawing.Point(20, 89);
            this.Txt_SearchUsername.Name = "Txt_SearchUsername";
            this.Txt_SearchUsername.Size = new System.Drawing.Size(235, 27);
            this.Txt_SearchUsername.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Search by Username";
            // 
            // Txt_SearchLN
            // 
            this.Txt_SearchLN.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SearchLN.Location = new System.Drawing.Point(20, 144);
            this.Txt_SearchLN.Name = "Txt_SearchLN";
            this.Txt_SearchLN.Size = new System.Drawing.Size(235, 27);
            this.Txt_SearchLN.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "Search by Guest Last Name";
            // 
            // Btn_ViewFull
            // 
            this.Btn_ViewFull.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewFull.Location = new System.Drawing.Point(20, 177);
            this.Btn_ViewFull.Name = "Btn_ViewFull";
            this.Btn_ViewFull.Size = new System.Drawing.Size(79, 34);
            this.Btn_ViewFull.TabIndex = 23;
            this.Btn_ViewFull.Text = "Default";
            this.Btn_ViewFull.UseVisualStyleBackColor = true;
            // 
            // Btn_ViewCount
            // 
            this.Btn_ViewCount.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewCount.Location = new System.Drawing.Point(20, 217);
            this.Btn_ViewCount.Name = "Btn_ViewCount";
            this.Btn_ViewCount.Size = new System.Drawing.Size(79, 35);
            this.Btn_ViewCount.TabIndex = 52;
            this.Btn_ViewCount.Text = "Count";
            this.Btn_ViewCount.UseVisualStyleBackColor = true;
            // 
            // Btn_ViewRooms
            // 
            this.Btn_ViewRooms.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewRooms.Location = new System.Drawing.Point(20, 255);
            this.Btn_ViewRooms.Name = "Btn_ViewRooms";
            this.Btn_ViewRooms.Size = new System.Drawing.Size(79, 35);
            this.Btn_ViewRooms.TabIndex = 53;
            this.Btn_ViewRooms.Text = "Rooms";
            this.Btn_ViewRooms.UseVisualStyleBackColor = true;
            // 
            // Btn_ViewCheckIn
            // 
            this.Btn_ViewCheckIn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewCheckIn.Location = new System.Drawing.Point(106, 218);
            this.Btn_ViewCheckIn.Name = "Btn_ViewCheckIn";
            this.Btn_ViewCheckIn.Size = new System.Drawing.Size(107, 34);
            this.Btn_ViewCheckIn.TabIndex = 54;
            this.Btn_ViewCheckIn.Text = "Check-In";
            this.Btn_ViewCheckIn.UseVisualStyleBackColor = true;
            // 
            // Btn_ViewCheckOut
            // 
            this.Btn_ViewCheckOut.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewCheckOut.Location = new System.Drawing.Point(106, 256);
            this.Btn_ViewCheckOut.Name = "Btn_ViewCheckOut";
            this.Btn_ViewCheckOut.Size = new System.Drawing.Size(107, 34);
            this.Btn_ViewCheckOut.TabIndex = 55;
            this.Btn_ViewCheckOut.Text = "Check-Out";
            this.Btn_ViewCheckOut.UseVisualStyleBackColor = true;
            // 
            // Btn_ViewChecks
            // 
            this.Btn_ViewChecks.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewChecks.Location = new System.Drawing.Point(106, 177);
            this.Btn_ViewChecks.Name = "Btn_ViewChecks";
            this.Btn_ViewChecks.Size = new System.Drawing.Size(107, 34);
            this.Btn_ViewChecks.TabIndex = 56;
            this.Btn_ViewChecks.Text = "Checks";
            this.Btn_ViewChecks.UseVisualStyleBackColor = true;
            // 
            // Pic_HotelKannoteki
            // 
            this.Pic_HotelKannoteki.Image = global::HotelReservationSystem.Properties.Resources.hoteldbsyslogo;
            this.Pic_HotelKannoteki.Location = new System.Drawing.Point(366, 4);
            this.Pic_HotelKannoteki.Name = "Pic_HotelKannoteki";
            this.Pic_HotelKannoteki.Size = new System.Drawing.Size(195, 82);
            this.Pic_HotelKannoteki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_HotelKannoteki.TabIndex = 11;
            this.Pic_HotelKannoteki.TabStop = false;
            // 
            // Panel_DateTime
            // 
            this.Panel_DateTime.BackColor = System.Drawing.Color.Cyan;
            this.Panel_DateTime.Controls.Add(this.Label_Calendar);
            this.Panel_DateTime.Controls.Add(this.Label_Clock);
            this.Panel_DateTime.Location = new System.Drawing.Point(15, 4);
            this.Panel_DateTime.Name = "Panel_DateTime";
            this.Panel_DateTime.Size = new System.Drawing.Size(325, 69);
            this.Panel_DateTime.TabIndex = 15;
            // 
            // Label_Calendar
            // 
            this.Label_Calendar.AutoSize = true;
            this.Label_Calendar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Calendar.Location = new System.Drawing.Point(3, 8);
            this.Label_Calendar.Name = "Label_Calendar";
            this.Label_Calendar.Size = new System.Drawing.Size(60, 25);
            this.Label_Calendar.TabIndex = 14;
            this.Label_Calendar.Text = "Date:";
            // 
            // Label_Clock
            // 
            this.Label_Clock.AutoSize = true;
            this.Label_Clock.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Clock.Location = new System.Drawing.Point(3, 33);
            this.Label_Clock.Name = "Label_Clock";
            this.Label_Clock.Size = new System.Drawing.Size(61, 25);
            this.Label_Clock.TabIndex = 13;
            this.Label_Clock.Text = "Time:";
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogOut.Location = new System.Drawing.Point(738, 12);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Size = new System.Drawing.Size(166, 34);
            this.Btn_LogOut.TabIndex = 5;
            this.Btn_LogOut.Text = "LOG OUT";
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.Location = new System.Drawing.Point(738, 52);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(166, 34);
            this.BtnDashboard.TabIndex = 13;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "RESERVATIONS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_AcctManage
            // 
            this.Panel_AcctManage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_AcctManage.Controls.Add(this.panel1);
            this.Panel_AcctManage.Controls.Add(this.label5);
            this.Panel_AcctManage.Controls.Add(this.BtnDashboard);
            this.Panel_AcctManage.Controls.Add(this.Btn_LogOut);
            this.Panel_AcctManage.Controls.Add(this.Panel_DateTime);
            this.Panel_AcctManage.Controls.Add(this.Pic_HotelKannoteki);
            this.Panel_AcctManage.Controls.Add(this.Panel_AcctOptions);
            this.Panel_AcctManage.Controls.Add(this.Dgv_Reservations);
            this.Panel_AcctManage.Location = new System.Drawing.Point(20, 18);
            this.Panel_AcctManage.Name = "Panel_AcctManage";
            this.Panel_AcctManage.Size = new System.Drawing.Size(967, 692);
            this.Panel_AcctManage.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.Txt_SearchReservation);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Txt_SearchUsername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Txt_SearchLN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Btn_ViewFull);
            this.panel1.Controls.Add(this.Btn_ViewCount);
            this.panel1.Controls.Add(this.Btn_ViewRooms);
            this.panel1.Controls.Add(this.Btn_ViewCheckIn);
            this.panel1.Controls.Add(this.Btn_ViewCheckOut);
            this.panel1.Controls.Add(this.Btn_ViewChecks);
            this.panel1.Location = new System.Drawing.Point(680, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 302);
            this.panel1.TabIndex = 4;
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // EP_Input
            // 
            this.EP_Input.ContainerControl = this;
            // 
            // Btn_PaymentView
            // 
            this.Btn_PaymentView.Enabled = false;
            this.Btn_PaymentView.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PaymentView.Location = new System.Drawing.Point(464, 25);
            this.Btn_PaymentView.Name = "Btn_PaymentView";
            this.Btn_PaymentView.Size = new System.Drawing.Size(166, 34);
            this.Btn_PaymentView.TabIndex = 17;
            this.Btn_PaymentView.Text = "VIEW PAYMENT";
            this.Btn_PaymentView.UseVisualStyleBackColor = true;
            this.Btn_PaymentView.Click += new System.EventHandler(this.Btn_PaymentView_Click);
            // 
            // Staff_Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Panel_AcctManage);
            this.Name = "Staff_Reservations";
            this.Text = "Staff_Reservations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Staff_Reservations_FormClosed);
            this.Load += new System.EventHandler(this.Staff_Reservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reservations)).EndInit();
            this.Panel_AcctOptions.ResumeLayout(false);
            this.Panel_AcctOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            this.Panel_AcctManage.ResumeLayout(false);
            this.Panel_AcctManage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Input)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Reservations;
        private System.Windows.Forms.Panel Panel_AcctOptions;
        private System.Windows.Forms.Button Btn_ViewChecks;
        private System.Windows.Forms.Button Btn_ViewCheckOut;
        private System.Windows.Forms.Button Btn_ViewCheckIn;
        private System.Windows.Forms.Button Btn_ViewRooms;
        private System.Windows.Forms.Button Btn_ViewCount;
        private System.Windows.Forms.Button Btn_ViewFull;
        private System.Windows.Forms.TextBox Txt_GuestChild;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_GuestAdult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Guest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_SearchLN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_SearchUsername;
        private System.Windows.Forms.Label Label_StayCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_CheckOutDate;
        private System.Windows.Forms.TextBox Txt_CheckInDate;
        private System.Windows.Forms.MonthCalendar Calendar_CheckInOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_SearchReservation;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Panel_AcctManage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Label_CheckInStatus;
        private System.Windows.Forms.Label Label_CheckOutStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Label_GuestCheckInDate;
        private System.Windows.Forms.Label Label_GuestCheckOutDate;
        private System.Windows.Forms.Button Btn_ConfirmCheckIn;
        private System.Windows.Forms.Button Btn_ConfirmCheckOut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_GuestName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Txt_RoomTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.ErrorProvider EP_Input;
        private System.Windows.Forms.Button Btn_PaymentView;
    }
}