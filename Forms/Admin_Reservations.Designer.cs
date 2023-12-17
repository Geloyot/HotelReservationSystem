namespace HotelReservationSystem.Forms
{
    partial class Admin_Reservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Reservations));
            this.Panel_AcctManage = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.Panel_AcctOptions = new System.Windows.Forms.Panel();
            this.Btn_ViewChecks = new System.Windows.Forms.Button();
            this.Btn_ViewCheckOut = new System.Windows.Forms.Button();
            this.Btn_ViewCheckIn = new System.Windows.Forms.Button();
            this.Btn_ViewRooms = new System.Windows.Forms.Button();
            this.Btn_ViewCount = new System.Windows.Forms.Button();
            this.Btn_ViewFull = new System.Windows.Forms.Button();
            this.Txt_GuestChild = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_GuestAdult = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Guest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_SearchLN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_SearchUsername = new System.Windows.Forms.TextBox();
            this.Label_StayCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Txt_CheckInDate = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_SearchReservation = new System.Windows.Forms.TextBox();
            this.Dgv_Reservations = new System.Windows.Forms.DataGridView();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.Panel_AcctManage.SuspendLayout();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            this.Panel_AcctOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reservations)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_AcctManage
            // 
            this.Panel_AcctManage.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Panel_AcctManage.Controls.Add(this.label5);
            this.Panel_AcctManage.Controls.Add(this.BtnDashboard);
            this.Panel_AcctManage.Controls.Add(this.Btn_LogOut);
            this.Panel_AcctManage.Controls.Add(this.Panel_DateTime);
            this.Panel_AcctManage.Controls.Add(this.Pic_HotelKannoteki);
            this.Panel_AcctManage.Controls.Add(this.Panel_AcctOptions);
            this.Panel_AcctManage.Controls.Add(this.Dgv_Reservations);
            this.Panel_AcctManage.Location = new System.Drawing.Point(45, 18);
            this.Panel_AcctManage.Name = "Panel_AcctManage";
            this.Panel_AcctManage.Size = new System.Drawing.Size(918, 692);
            this.Panel_AcctManage.TabIndex = 2;
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
            // Panel_DateTime
            // 
            this.Panel_DateTime.BackColor = System.Drawing.Color.LightGreen;
            this.Panel_DateTime.Controls.Add(this.Label_Calendar);
            this.Panel_DateTime.Controls.Add(this.Label_Clock);
            this.Panel_DateTime.Location = new System.Drawing.Point(15, 4);
            this.Panel_DateTime.Name = "Panel_DateTime";
            this.Panel_DateTime.Size = new System.Drawing.Size(339, 69);
            this.Panel_DateTime.TabIndex = 15;
            // 
            // Label_Calendar
            // 
            this.Label_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Calendar.AutoSize = true;
            this.Label_Calendar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Calendar.Location = new System.Drawing.Point(4, 8);
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
            // Panel_AcctOptions
            // 
            this.Panel_AcctOptions.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Panel_AcctOptions.Controls.Add(this.Btn_ViewChecks);
            this.Panel_AcctOptions.Controls.Add(this.Btn_ViewCheckOut);
            this.Panel_AcctOptions.Controls.Add(this.Btn_ViewCheckIn);
            this.Panel_AcctOptions.Controls.Add(this.Btn_ViewRooms);
            this.Panel_AcctOptions.Controls.Add(this.Btn_ViewCount);
            this.Panel_AcctOptions.Controls.Add(this.Btn_ViewFull);
            this.Panel_AcctOptions.Controls.Add(this.Txt_GuestChild);
            this.Panel_AcctOptions.Controls.Add(this.label10);
            this.Panel_AcctOptions.Controls.Add(this.Txt_GuestAdult);
            this.Panel_AcctOptions.Controls.Add(this.label9);
            this.Panel_AcctOptions.Controls.Add(this.label7);
            this.Panel_AcctOptions.Controls.Add(this.Txt_Guest);
            this.Panel_AcctOptions.Controls.Add(this.label6);
            this.Panel_AcctOptions.Controls.Add(this.Txt_SearchLN);
            this.Panel_AcctOptions.Controls.Add(this.label4);
            this.Panel_AcctOptions.Controls.Add(this.Txt_SearchUsername);
            this.Panel_AcctOptions.Controls.Add(this.Label_StayCount);
            this.Panel_AcctOptions.Controls.Add(this.label3);
            this.Panel_AcctOptions.Controls.Add(this.label1);
            this.Panel_AcctOptions.Controls.Add(this.label2);
            this.Panel_AcctOptions.Controls.Add(this.textBox1);
            this.Panel_AcctOptions.Controls.Add(this.Txt_CheckInDate);
            this.Panel_AcctOptions.Controls.Add(this.monthCalendar1);
            this.Panel_AcctOptions.Controls.Add(this.label8);
            this.Panel_AcctOptions.Controls.Add(this.Txt_SearchReservation);
            this.Panel_AcctOptions.Location = new System.Drawing.Point(15, 131);
            this.Panel_AcctOptions.Name = "Panel_AcctOptions";
            this.Panel_AcctOptions.Size = new System.Drawing.Size(889, 215);
            this.Panel_AcctOptions.TabIndex = 9;
            // 
            // Btn_ViewChecks
            // 
            this.Btn_ViewChecks.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewChecks.Location = new System.Drawing.Point(501, 166);
            this.Btn_ViewChecks.Name = "Btn_ViewChecks";
            this.Btn_ViewChecks.Size = new System.Drawing.Size(82, 34);
            this.Btn_ViewChecks.TabIndex = 56;
            this.Btn_ViewChecks.Text = "Checks";
            this.Btn_ViewChecks.UseVisualStyleBackColor = true;
            this.Btn_ViewChecks.Click += new System.EventHandler(this.Btn_ViewChecks_Click);
            // 
            // Btn_ViewCheckOut
            // 
            this.Btn_ViewCheckOut.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewCheckOut.Location = new System.Drawing.Point(388, 166);
            this.Btn_ViewCheckOut.Name = "Btn_ViewCheckOut";
            this.Btn_ViewCheckOut.Size = new System.Drawing.Size(107, 34);
            this.Btn_ViewCheckOut.TabIndex = 55;
            this.Btn_ViewCheckOut.Text = "Check-Out";
            this.Btn_ViewCheckOut.UseVisualStyleBackColor = true;
            this.Btn_ViewCheckOut.Click += new System.EventHandler(this.Btn_ViewCheckOut_Click);
            // 
            // Btn_ViewCheckIn
            // 
            this.Btn_ViewCheckIn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewCheckIn.Location = new System.Drawing.Point(288, 166);
            this.Btn_ViewCheckIn.Name = "Btn_ViewCheckIn";
            this.Btn_ViewCheckIn.Size = new System.Drawing.Size(94, 34);
            this.Btn_ViewCheckIn.TabIndex = 54;
            this.Btn_ViewCheckIn.Text = "Check-In";
            this.Btn_ViewCheckIn.UseVisualStyleBackColor = true;
            this.Btn_ViewCheckIn.Click += new System.EventHandler(this.Btn_ViewCheckIn_Click);
            // 
            // Btn_ViewRooms
            // 
            this.Btn_ViewRooms.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewRooms.Location = new System.Drawing.Point(447, 128);
            this.Btn_ViewRooms.Name = "Btn_ViewRooms";
            this.Btn_ViewRooms.Size = new System.Drawing.Size(68, 35);
            this.Btn_ViewRooms.TabIndex = 53;
            this.Btn_ViewRooms.Text = "Rooms";
            this.Btn_ViewRooms.UseVisualStyleBackColor = true;
            this.Btn_ViewRooms.Click += new System.EventHandler(this.Btn_ViewRooms_Click);
            // 
            // Btn_ViewCount
            // 
            this.Btn_ViewCount.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewCount.Location = new System.Drawing.Point(373, 128);
            this.Btn_ViewCount.Name = "Btn_ViewCount";
            this.Btn_ViewCount.Size = new System.Drawing.Size(68, 35);
            this.Btn_ViewCount.TabIndex = 52;
            this.Btn_ViewCount.Text = "Count";
            this.Btn_ViewCount.UseVisualStyleBackColor = true;
            this.Btn_ViewCount.Click += new System.EventHandler(this.Btn_ViewCount_Click);
            // 
            // Btn_ViewFull
            // 
            this.Btn_ViewFull.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewFull.Location = new System.Drawing.Point(288, 130);
            this.Btn_ViewFull.Name = "Btn_ViewFull";
            this.Btn_ViewFull.Size = new System.Drawing.Size(79, 34);
            this.Btn_ViewFull.TabIndex = 23;
            this.Btn_ViewFull.Text = "Default";
            this.Btn_ViewFull.UseVisualStyleBackColor = true;
            this.Btn_ViewFull.Click += new System.EventHandler(this.Btn_ViewFull_Click);
            // 
            // Txt_GuestChild
            // 
            this.Txt_GuestChild.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_GuestChild.Location = new System.Drawing.Point(412, 94);
            this.Txt_GuestChild.Name = "Txt_GuestChild";
            this.Txt_GuestChild.Size = new System.Drawing.Size(51, 30);
            this.Txt_GuestChild.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(414, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 23);
            this.label10.TabIndex = 49;
            this.label10.Text = "Child";
            // 
            // Txt_GuestAdult
            // 
            this.Txt_GuestAdult.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_GuestAdult.Location = new System.Drawing.Point(351, 94);
            this.Txt_GuestAdult.Name = "Txt_GuestAdult";
            this.Txt_GuestAdult.Size = new System.Drawing.Size(51, 30);
            this.Txt_GuestAdult.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(347, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 47;
            this.label9.Text = "Adult";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "Count";
            // 
            // Txt_Guest
            // 
            this.Txt_Guest.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Guest.Location = new System.Drawing.Point(288, 94);
            this.Txt_Guest.Name = "Txt_Guest";
            this.Txt_Guest.Size = new System.Drawing.Size(51, 30);
            this.Txt_Guest.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(633, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "Search by Guest Last Name";
            // 
            // Txt_SearchLN
            // 
            this.Txt_SearchLN.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SearchLN.Location = new System.Drawing.Point(637, 161);
            this.Txt_SearchLN.Name = "Txt_SearchLN";
            this.Txt_SearchLN.Size = new System.Drawing.Size(239, 30);
            this.Txt_SearchLN.TabIndex = 43;
            this.Txt_SearchLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SearchLN_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Search by Username";
            // 
            // Txt_SearchUsername
            // 
            this.Txt_SearchUsername.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SearchUsername.Location = new System.Drawing.Point(637, 97);
            this.Txt_SearchUsername.Name = "Txt_SearchUsername";
            this.Txt_SearchUsername.Size = new System.Drawing.Size(239, 30);
            this.Txt_SearchUsername.TabIndex = 41;
            this.Txt_SearchUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SearchUsername_KeyPress);
            // 
            // Label_StayCount
            // 
            this.Label_StayCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_StayCount.AutoSize = true;
            this.Label_StayCount.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StayCount.Location = new System.Drawing.Point(501, 97);
            this.Label_StayCount.Name = "Label_StayCount";
            this.Label_StayCount.Size = new System.Drawing.Size(90, 25);
            this.Label_StayCount.TabIndex = 40;
            this.Label_StayCount.Text = "LENGTH";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Stay Length: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Check-Out Date";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Check-In Date";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(458, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 30);
            this.textBox1.TabIndex = 36;
            // 
            // Txt_CheckInDate
            // 
            this.Txt_CheckInDate.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CheckInDate.Location = new System.Drawing.Point(286, 35);
            this.Txt_CheckInDate.Name = "Txt_CheckInDate";
            this.Txt_CheckInDate.Size = new System.Drawing.Size(139, 30);
            this.Txt_CheckInDate.TabIndex = 35;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(30, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(633, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Search by Room Occupied";
            // 
            // Txt_SearchReservation
            // 
            this.Txt_SearchReservation.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SearchReservation.Location = new System.Drawing.Point(637, 35);
            this.Txt_SearchReservation.Name = "Txt_SearchReservation";
            this.Txt_SearchReservation.Size = new System.Drawing.Size(239, 30);
            this.Txt_SearchReservation.TabIndex = 32;
            this.Txt_SearchReservation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SearchReservation_KeyPress);
            // 
            // Dgv_Reservations
            // 
            this.Dgv_Reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Reservations.Location = new System.Drawing.Point(15, 352);
            this.Dgv_Reservations.Name = "Dgv_Reservations";
            this.Dgv_Reservations.Size = new System.Drawing.Size(889, 327);
            this.Dgv_Reservations.TabIndex = 0;
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // Admin_Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Panel_AcctManage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Reservations";
            this.Text = "Admin_Reservations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Reservations_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Reservations_Load);
            this.Panel_AcctManage.ResumeLayout(false);
            this.Panel_AcctManage.PerformLayout();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            this.Panel_AcctOptions.ResumeLayout(false);
            this.Panel_AcctOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_AcctManage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.Panel Panel_AcctOptions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Dgv_Reservations;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox Txt_CheckInDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_StayCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_SearchUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_SearchLN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Guest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_GuestAdult;
        private System.Windows.Forms.TextBox Txt_GuestChild;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_ViewFull;
        private System.Windows.Forms.Button Btn_ViewCount;
        private System.Windows.Forms.Button Btn_ViewRooms;
        private System.Windows.Forms.TextBox Txt_SearchReservation;
        private System.Windows.Forms.Button Btn_ViewCheckIn;
        private System.Windows.Forms.Button Btn_ViewCheckOut;
        private System.Windows.Forms.Button Btn_ViewChecks;
    }
}