namespace HotelReservationSystem
{
    partial class Staff_Guest
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
            this.Panel_AcctManage = new System.Windows.Forms.Panel();
            this.Label_AccountCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.Panel_AcctOptions = new System.Windows.Forms.Panel();
            this.Txt_SearchGuestName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.Txt_Contact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_BDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbx_Gender = new System.Windows.Forms.ComboBox();
            this.Clndr_BDate = new System.Windows.Forms.MonthCalendar();
            this.Txt_LN = new System.Windows.Forms.TextBox();
            this.Txt_FN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_Guests = new System.Windows.Forms.DataGridView();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.EP_Input = new System.Windows.Forms.ErrorProvider(this.components);
            this.Panel_AcctManage.SuspendLayout();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            this.Panel_AcctOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Guests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_AcctManage
            // 
            this.Panel_AcctManage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_AcctManage.Controls.Add(this.Label_AccountCount);
            this.Panel_AcctManage.Controls.Add(this.label5);
            this.Panel_AcctManage.Controls.Add(this.BtnDashboard);
            this.Panel_AcctManage.Controls.Add(this.Btn_LogOut);
            this.Panel_AcctManage.Controls.Add(this.Panel_DateTime);
            this.Panel_AcctManage.Controls.Add(this.Pic_HotelKannoteki);
            this.Panel_AcctManage.Controls.Add(this.Panel_AcctOptions);
            this.Panel_AcctManage.Controls.Add(this.Dgv_Guests);
            this.Panel_AcctManage.Location = new System.Drawing.Point(45, 18);
            this.Panel_AcctManage.Name = "Panel_AcctManage";
            this.Panel_AcctManage.Size = new System.Drawing.Size(918, 692);
            this.Panel_AcctManage.TabIndex = 1;
            // 
            // Label_AccountCount
            // 
            this.Label_AccountCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_AccountCount.AutoSize = true;
            this.Label_AccountCount.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AccountCount.Location = new System.Drawing.Point(36, 126);
            this.Label_AccountCount.Name = "Label_AccountCount";
            this.Label_AccountCount.Size = new System.Drawing.Size(150, 25);
            this.Label_AccountCount.TabIndex = 31;
            this.Label_AccountCount.Text = "No. of Guests: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "GUESTS";
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
            this.Panel_DateTime.BackColor = System.Drawing.Color.Cyan;
            this.Panel_DateTime.Controls.Add(this.Label_Calendar);
            this.Panel_DateTime.Controls.Add(this.Label_Clock);
            this.Panel_DateTime.Location = new System.Drawing.Point(15, 4);
            this.Panel_DateTime.Name = "Panel_DateTime";
            this.Panel_DateTime.Size = new System.Drawing.Size(326, 69);
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
            // Pic_HotelKannoteki
            // 
            this.Pic_HotelKannoteki.Image = global::HotelReservationSystem.Properties.Resources.hoteldbsyslogo;
            this.Pic_HotelKannoteki.Location = new System.Drawing.Point(366, 4);
            this.Pic_HotelKannoteki.Name = "Pic_HotelKannoteki";
            this.Pic_HotelKannoteki.Size = new System.Drawing.Size(189, 91);
            this.Pic_HotelKannoteki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_HotelKannoteki.TabIndex = 11;
            this.Pic_HotelKannoteki.TabStop = false;
            // 
            // Panel_AcctOptions
            // 
            this.Panel_AcctOptions.BackColor = System.Drawing.Color.LightBlue;
            this.Panel_AcctOptions.Controls.Add(this.Txt_SearchGuestName);
            this.Panel_AcctOptions.Controls.Add(this.label9);
            this.Panel_AcctOptions.Controls.Add(this.Btn_Delete);
            this.Panel_AcctOptions.Controls.Add(this.Btn_Update);
            this.Panel_AcctOptions.Controls.Add(this.Txt_Email);
            this.Panel_AcctOptions.Controls.Add(this.Txt_Address);
            this.Panel_AcctOptions.Controls.Add(this.Txt_Contact);
            this.Panel_AcctOptions.Controls.Add(this.label8);
            this.Panel_AcctOptions.Controls.Add(this.label7);
            this.Panel_AcctOptions.Controls.Add(this.label6);
            this.Panel_AcctOptions.Controls.Add(this.Txt_BDate);
            this.Panel_AcctOptions.Controls.Add(this.label4);
            this.Panel_AcctOptions.Controls.Add(this.label3);
            this.Panel_AcctOptions.Controls.Add(this.Cbx_Gender);
            this.Panel_AcctOptions.Controls.Add(this.Clndr_BDate);
            this.Panel_AcctOptions.Controls.Add(this.Txt_LN);
            this.Panel_AcctOptions.Controls.Add(this.Txt_FN);
            this.Panel_AcctOptions.Controls.Add(this.label1);
            this.Panel_AcctOptions.Controls.Add(this.label2);
            this.Panel_AcctOptions.Location = new System.Drawing.Point(15, 154);
            this.Panel_AcctOptions.Name = "Panel_AcctOptions";
            this.Panel_AcctOptions.Size = new System.Drawing.Size(889, 211);
            this.Panel_AcctOptions.TabIndex = 9;
            // 
            // Txt_SearchGuestName
            // 
            this.Txt_SearchGuestName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SearchGuestName.Location = new System.Drawing.Point(733, 136);
            this.Txt_SearchGuestName.Name = "Txt_SearchGuestName";
            this.Txt_SearchGuestName.Size = new System.Drawing.Size(136, 27);
            this.Txt_SearchGuestName.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(729, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Search by Name";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(733, 47);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(136, 34);
            this.Btn_Delete.TabIndex = 20;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(733, 7);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(136, 34);
            this.Btn_Update.TabIndex = 17;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Txt_Email
            // 
            this.Txt_Email.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.Location = new System.Drawing.Point(163, 136);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(163, 27);
            this.Txt_Email.TabIndex = 19;
            // 
            // Txt_Address
            // 
            this.Txt_Address.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Address.Location = new System.Drawing.Point(163, 105);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(163, 27);
            this.Txt_Address.TabIndex = 18;
            // 
            // Txt_Contact
            // 
            this.Txt_Contact.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contact.Location = new System.Drawing.Point(163, 73);
            this.Txt_Contact.Name = "Txt_Contact";
            this.Txt_Contact.Size = new System.Drawing.Size(163, 27);
            this.Txt_Contact.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Home Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contact No.:";
            // 
            // Txt_BDate
            // 
            this.Txt_BDate.Enabled = false;
            this.Txt_BDate.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BDate.Location = new System.Drawing.Point(351, 105);
            this.Txt_BDate.Name = "Txt_BDate";
            this.Txt_BDate.Size = new System.Drawing.Size(121, 27);
            this.Txt_BDate.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Birthdate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gender";
            // 
            // Cbx_Gender
            // 
            this.Cbx_Gender.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.Cbx_Gender.FormattingEnabled = true;
            this.Cbx_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.Cbx_Gender.Location = new System.Drawing.Point(351, 33);
            this.Cbx_Gender.Name = "Cbx_Gender";
            this.Cbx_Gender.Size = new System.Drawing.Size(121, 27);
            this.Cbx_Gender.TabIndex = 10;
            // 
            // Clndr_BDate
            // 
            this.Clndr_BDate.Location = new System.Drawing.Point(484, 7);
            this.Clndr_BDate.MaxSelectionCount = 1;
            this.Clndr_BDate.Name = "Clndr_BDate";
            this.Clndr_BDate.TabIndex = 9;
            this.Clndr_BDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Clndr_BDate_DateChanged);
            // 
            // Txt_LN
            // 
            this.Txt_LN.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_LN.Location = new System.Drawing.Point(184, 33);
            this.Txt_LN.Name = "Txt_LN";
            this.Txt_LN.Size = new System.Drawing.Size(142, 27);
            this.Txt_LN.TabIndex = 8;
            // 
            // Txt_FN
            // 
            this.Txt_FN.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FN.Location = new System.Drawing.Point(26, 33);
            this.Txt_FN.Name = "Txt_FN";
            this.Txt_FN.Size = new System.Drawing.Size(152, 27);
            this.Txt_FN.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name:";
            // 
            // Dgv_Guests
            // 
            this.Dgv_Guests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Guests.Location = new System.Drawing.Point(15, 371);
            this.Dgv_Guests.Name = "Dgv_Guests";
            this.Dgv_Guests.Size = new System.Drawing.Size(889, 308);
            this.Dgv_Guests.TabIndex = 0;
            this.Dgv_Guests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Guests_CellClick);
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // EP_Input
            // 
            this.EP_Input.ContainerControl = this;
            // 
            // Staff_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Panel_AcctManage);
            this.Name = "Staff_Guest";
            this.Text = "Staff_Guest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Staff_Guest_FormClosed);
            this.Load += new System.EventHandler(this.Staff_Guest_Load);
            this.Panel_AcctManage.ResumeLayout(false);
            this.Panel_AcctManage.PerformLayout();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            this.Panel_AcctOptions.ResumeLayout(false);
            this.Panel_AcctOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Guests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Input)).EndInit();
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
        private System.Windows.Forms.TextBox Txt_FN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_Guests;
        private System.Windows.Forms.TextBox Txt_LN;
        private System.Windows.Forms.MonthCalendar Clndr_BDate;
        private System.Windows.Forms.ComboBox Cbx_Gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_BDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Contact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_SearchGuestName;
        private System.Windows.Forms.Label Label_AccountCount;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.ErrorProvider EP_Input;
    }
}