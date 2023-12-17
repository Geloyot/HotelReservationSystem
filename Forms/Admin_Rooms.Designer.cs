namespace HotelReservationSystem
{
    partial class Admin_Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Rooms));
            this.Panel_AcctManage = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.Panel_AcctOptions = new System.Windows.Forms.Panel();
            this.Txt_RType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_SearchRoom = new System.Windows.Forms.TextBox();
            this.Btn_RoomsTypes = new System.Windows.Forms.Button();
            this.Btn_RoomsPrices = new System.Windows.Forms.Button();
            this.Btn_RoomsOccupied = new System.Windows.Forms.Button();
            this.Btn_RoomsAvailable = new System.Windows.Forms.Button();
            this.Btn_RoomsFull = new System.Windows.Forms.Button();
            this.Label_GuestCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label_RoomStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTxt_RDesc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_RPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_RTitle = new System.Windows.Forms.TextBox();
            this.Dgv_Rooms = new System.Windows.Forms.DataGridView();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.Panel_AcctManage.SuspendLayout();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            this.Panel_AcctOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Rooms)).BeginInit();
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
            this.Panel_AcctManage.Controls.Add(this.Dgv_Rooms);
            this.Panel_AcctManage.Location = new System.Drawing.Point(45, 18);
            this.Panel_AcctManage.Name = "Panel_AcctManage";
            this.Panel_AcctManage.Size = new System.Drawing.Size(918, 692);
            this.Panel_AcctManage.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "HOTEL ROOMS";
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
            this.Panel_DateTime.Size = new System.Drawing.Size(334, 69);
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
            this.Panel_AcctOptions.Controls.Add(this.Txt_RType);
            this.Panel_AcctOptions.Controls.Add(this.label8);
            this.Panel_AcctOptions.Controls.Add(this.Txt_SearchRoom);
            this.Panel_AcctOptions.Controls.Add(this.Btn_RoomsTypes);
            this.Panel_AcctOptions.Controls.Add(this.Btn_RoomsPrices);
            this.Panel_AcctOptions.Controls.Add(this.Btn_RoomsOccupied);
            this.Panel_AcctOptions.Controls.Add(this.Btn_RoomsAvailable);
            this.Panel_AcctOptions.Controls.Add(this.Btn_RoomsFull);
            this.Panel_AcctOptions.Controls.Add(this.Label_GuestCount);
            this.Panel_AcctOptions.Controls.Add(this.label7);
            this.Panel_AcctOptions.Controls.Add(this.Label_RoomStatus);
            this.Panel_AcctOptions.Controls.Add(this.label6);
            this.Panel_AcctOptions.Controls.Add(this.richTxt_RDesc);
            this.Panel_AcctOptions.Controls.Add(this.label4);
            this.Panel_AcctOptions.Controls.Add(this.label3);
            this.Panel_AcctOptions.Controls.Add(this.Txt_RPrice);
            this.Panel_AcctOptions.Controls.Add(this.label2);
            this.Panel_AcctOptions.Controls.Add(this.label1);
            this.Panel_AcctOptions.Controls.Add(this.Txt_RTitle);
            this.Panel_AcctOptions.Location = new System.Drawing.Point(15, 131);
            this.Panel_AcctOptions.Name = "Panel_AcctOptions";
            this.Panel_AcctOptions.Size = new System.Drawing.Size(889, 215);
            this.Panel_AcctOptions.TabIndex = 9;
            // 
            // Txt_RType
            // 
            this.Txt_RType.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RType.Location = new System.Drawing.Point(238, 37);
            this.Txt_RType.Name = "Txt_RType";
            this.Txt_RType.Size = new System.Drawing.Size(151, 30);
            this.Txt_RType.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Search by Room Title";
            // 
            // Txt_SearchRoom
            // 
            this.Txt_SearchRoom.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SearchRoom.Location = new System.Drawing.Point(590, 97);
            this.Txt_SearchRoom.Name = "Txt_SearchRoom";
            this.Txt_SearchRoom.Size = new System.Drawing.Size(286, 30);
            this.Txt_SearchRoom.TabIndex = 32;
            this.Txt_SearchRoom.TextChanged += new System.EventHandler(this.Txt_SearchRoom_TextChanged);
            // 
            // Btn_RoomsTypes
            // 
            this.Btn_RoomsTypes.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RoomsTypes.Location = new System.Drawing.Point(689, 170);
            this.Btn_RoomsTypes.Name = "Btn_RoomsTypes";
            this.Btn_RoomsTypes.Size = new System.Drawing.Size(93, 31);
            this.Btn_RoomsTypes.TabIndex = 31;
            this.Btn_RoomsTypes.Text = "Types";
            this.Btn_RoomsTypes.UseVisualStyleBackColor = true;
            // 
            // Btn_RoomsPrices
            // 
            this.Btn_RoomsPrices.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RoomsPrices.Location = new System.Drawing.Point(689, 133);
            this.Btn_RoomsPrices.Name = "Btn_RoomsPrices";
            this.Btn_RoomsPrices.Size = new System.Drawing.Size(93, 31);
            this.Btn_RoomsPrices.TabIndex = 30;
            this.Btn_RoomsPrices.Text = "Prices";
            this.Btn_RoomsPrices.UseVisualStyleBackColor = true;
            // 
            // Btn_RoomsOccupied
            // 
            this.Btn_RoomsOccupied.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RoomsOccupied.Location = new System.Drawing.Point(590, 170);
            this.Btn_RoomsOccupied.Name = "Btn_RoomsOccupied";
            this.Btn_RoomsOccupied.Size = new System.Drawing.Size(93, 31);
            this.Btn_RoomsOccupied.TabIndex = 29;
            this.Btn_RoomsOccupied.Text = "Occupied";
            this.Btn_RoomsOccupied.UseVisualStyleBackColor = true;
            // 
            // Btn_RoomsAvailable
            // 
            this.Btn_RoomsAvailable.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RoomsAvailable.Location = new System.Drawing.Point(590, 133);
            this.Btn_RoomsAvailable.Name = "Btn_RoomsAvailable";
            this.Btn_RoomsAvailable.Size = new System.Drawing.Size(93, 31);
            this.Btn_RoomsAvailable.TabIndex = 28;
            this.Btn_RoomsAvailable.Text = "Available";
            this.Btn_RoomsAvailable.UseVisualStyleBackColor = true;
            // 
            // Btn_RoomsFull
            // 
            this.Btn_RoomsFull.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RoomsFull.Location = new System.Drawing.Point(792, 151);
            this.Btn_RoomsFull.Name = "Btn_RoomsFull";
            this.Btn_RoomsFull.Size = new System.Drawing.Size(84, 31);
            this.Btn_RoomsFull.TabIndex = 27;
            this.Btn_RoomsFull.Text = "Default";
            this.Btn_RoomsFull.UseVisualStyleBackColor = true;
            // 
            // Label_GuestCount
            // 
            this.Label_GuestCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_GuestCount.AutoSize = true;
            this.Label_GuestCount.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GuestCount.Location = new System.Drawing.Point(734, 40);
            this.Label_GuestCount.Name = "Label_GuestCount";
            this.Label_GuestCount.Size = new System.Drawing.Size(122, 23);
            this.Label_GuestCount.TabIndex = 26;
            this.Label_GuestCount.Text = "No. of Guests";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(734, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "No. of Guests";
            // 
            // Label_RoomStatus
            // 
            this.Label_RoomStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_RoomStatus.AutoSize = true;
            this.Label_RoomStatus.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomStatus.Location = new System.Drawing.Point(586, 40);
            this.Label_RoomStatus.Name = "Label_RoomStatus";
            this.Label_RoomStatus.Size = new System.Drawing.Size(118, 23);
            this.Label_RoomStatus.TabIndex = 24;
            this.Label_RoomStatus.Text = "Room Status";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(586, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Room Status";
            // 
            // richTxt_RDesc
            // 
            this.richTxt_RDesc.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxt_RDesc.Location = new System.Drawing.Point(18, 96);
            this.richTxt_RDesc.Name = "richTxt_RDesc";
            this.richTxt_RDesc.Size = new System.Drawing.Size(552, 107);
            this.richTxt_RDesc.TabIndex = 22;
            this.richTxt_RDesc.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Room Description";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Room Price";
            // 
            // Txt_RPrice
            // 
            this.Txt_RPrice.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RPrice.Location = new System.Drawing.Point(419, 37);
            this.Txt_RPrice.Name = "Txt_RPrice";
            this.Txt_RPrice.Size = new System.Drawing.Size(151, 30);
            this.Txt_RPrice.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Room Title";
            // 
            // Txt_RTitle
            // 
            this.Txt_RTitle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RTitle.Location = new System.Drawing.Point(18, 37);
            this.Txt_RTitle.Name = "Txt_RTitle";
            this.Txt_RTitle.Size = new System.Drawing.Size(200, 30);
            this.Txt_RTitle.TabIndex = 0;
            // 
            // Dgv_Rooms
            // 
            this.Dgv_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Rooms.Location = new System.Drawing.Point(15, 352);
            this.Dgv_Rooms.Name = "Dgv_Rooms";
            this.Dgv_Rooms.Size = new System.Drawing.Size(889, 327);
            this.Dgv_Rooms.TabIndex = 0;
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // Admin_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Panel_AcctManage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Rooms";
            this.Text = "Room Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Rooms_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Rooms_Load);
            this.Panel_AcctManage.ResumeLayout(false);
            this.Panel_AcctManage.PerformLayout();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            this.Panel_AcctOptions.ResumeLayout(false);
            this.Panel_AcctOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Rooms)).EndInit();
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
        private System.Windows.Forms.DataGridView Dgv_Rooms;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.TextBox Txt_RTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_RPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTxt_RDesc;
        private System.Windows.Forms.Label Label_RoomStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Label_GuestCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_RoomsFull;
        private System.Windows.Forms.Button Btn_RoomsAvailable;
        private System.Windows.Forms.Button Btn_RoomsOccupied;
        private System.Windows.Forms.Button Btn_RoomsPrices;
        private System.Windows.Forms.Button Btn_RoomsTypes;
        private System.Windows.Forms.TextBox Txt_SearchRoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_RType;
    }
}