namespace HotelReservationSystem
{
    partial class Staff_Rooms
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
            this.Label_RoomCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.Panel_AcctOptions = new System.Windows.Forms.Panel();
            this.Btn_RoomsTypes = new System.Windows.Forms.Button();
            this.Btn_RoomsPrices = new System.Windows.Forms.Button();
            this.Btn_RoomsOccupied = new System.Windows.Forms.Button();
            this.Btn_RoomsAvailable = new System.Windows.Forms.Button();
            this.Btn_RoomsFull = new System.Windows.Forms.Button();
            this.Txt_ImgFileName = new System.Windows.Forms.TextBox();
            this.Btn_AddRoom = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_BrowseImage = new System.Windows.Forms.Button();
            this.Pbx_RoomImg = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_RType = new System.Windows.Forms.TextBox();
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
            this.EP_Input = new System.Windows.Forms.ErrorProvider(this.components);
            this.Panel_AcctManage.SuspendLayout();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            this.Panel_AcctOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_RoomImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_AcctManage
            // 
            this.Panel_AcctManage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Panel_AcctManage.Controls.Add(this.Label_RoomCount);
            this.Panel_AcctManage.Controls.Add(this.label5);
            this.Panel_AcctManage.Controls.Add(this.BtnDashboard);
            this.Panel_AcctManage.Controls.Add(this.Btn_LogOut);
            this.Panel_AcctManage.Controls.Add(this.Panel_DateTime);
            this.Panel_AcctManage.Controls.Add(this.Pic_HotelKannoteki);
            this.Panel_AcctManage.Controls.Add(this.Panel_AcctOptions);
            this.Panel_AcctManage.Controls.Add(this.Dgv_Rooms);
            this.Panel_AcctManage.Location = new System.Drawing.Point(26, 18);
            this.Panel_AcctManage.Name = "Panel_AcctManage";
            this.Panel_AcctManage.Size = new System.Drawing.Size(1005, 692);
            this.Panel_AcctManage.TabIndex = 2;
            // 
            // Label_RoomCount
            // 
            this.Label_RoomCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_RoomCount.AutoSize = true;
            this.Label_RoomCount.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomCount.Location = new System.Drawing.Point(123, 126);
            this.Label_RoomCount.Name = "Label_RoomCount";
            this.Label_RoomCount.Size = new System.Drawing.Size(143, 25);
            this.Label_RoomCount.TabIndex = 31;
            this.Label_RoomCount.Text = "No. of Rooms:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "HOTEL ROOMS";
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.Location = new System.Drawing.Point(823, 52);
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
            this.Btn_LogOut.Location = new System.Drawing.Point(823, 12);
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
            this.Panel_DateTime.Location = new System.Drawing.Point(15, 17);
            this.Panel_DateTime.Name = "Panel_DateTime";
            this.Panel_DateTime.Size = new System.Drawing.Size(328, 69);
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
            this.Pic_HotelKannoteki.Size = new System.Drawing.Size(293, 91);
            this.Pic_HotelKannoteki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_HotelKannoteki.TabIndex = 11;
            this.Pic_HotelKannoteki.TabStop = false;
            // 
            // Panel_AcctOptions
            // 
            this.Panel_AcctOptions.BackColor = System.Drawing.Color.LightBlue;
            this.Panel_AcctOptions.Controls.Add(this.Btn_RoomsTypes);
            this.Panel_AcctOptions.Controls.Add(this.Btn_RoomsPrices);
            this.Panel_AcctOptions.Controls.Add(this.Btn_RoomsOccupied);
            this.Panel_AcctOptions.Controls.Add(this.Btn_RoomsAvailable);
            this.Panel_AcctOptions.Controls.Add(this.Btn_RoomsFull);
            this.Panel_AcctOptions.Controls.Add(this.Txt_ImgFileName);
            this.Panel_AcctOptions.Controls.Add(this.Btn_AddRoom);
            this.Panel_AcctOptions.Controls.Add(this.Btn_Update);
            this.Panel_AcctOptions.Controls.Add(this.Btn_Delete);
            this.Panel_AcctOptions.Controls.Add(this.Btn_BrowseImage);
            this.Panel_AcctOptions.Controls.Add(this.Pbx_RoomImg);
            this.Panel_AcctOptions.Controls.Add(this.label8);
            this.Panel_AcctOptions.Controls.Add(this.Txt_RType);
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
            this.Panel_AcctOptions.Location = new System.Drawing.Point(15, 154);
            this.Panel_AcctOptions.Name = "Panel_AcctOptions";
            this.Panel_AcctOptions.Size = new System.Drawing.Size(974, 290);
            this.Panel_AcctOptions.TabIndex = 9;
            // 
            // Btn_RoomsTypes
            // 
            this.Btn_RoomsTypes.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RoomsTypes.Location = new System.Drawing.Point(792, 141);
            this.Btn_RoomsTypes.Name = "Btn_RoomsTypes";
            this.Btn_RoomsTypes.Size = new System.Drawing.Size(165, 31);
            this.Btn_RoomsTypes.TabIndex = 53;
            this.Btn_RoomsTypes.Text = "Types";
            this.Btn_RoomsTypes.UseVisualStyleBackColor = true;
            this.Btn_RoomsTypes.Click += new System.EventHandler(this.Btn_RoomsTypes_Click);
            // 
            // Btn_RoomsPrices
            // 
            this.Btn_RoomsPrices.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RoomsPrices.Location = new System.Drawing.Point(792, 104);
            this.Btn_RoomsPrices.Name = "Btn_RoomsPrices";
            this.Btn_RoomsPrices.Size = new System.Drawing.Size(165, 31);
            this.Btn_RoomsPrices.TabIndex = 52;
            this.Btn_RoomsPrices.Text = "Prices";
            this.Btn_RoomsPrices.UseVisualStyleBackColor = true;
            this.Btn_RoomsPrices.Click += new System.EventHandler(this.Btn_RoomsPrices_Click);
            // 
            // Btn_RoomsOccupied
            // 
            this.Btn_RoomsOccupied.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RoomsOccupied.Location = new System.Drawing.Point(792, 178);
            this.Btn_RoomsOccupied.Name = "Btn_RoomsOccupied";
            this.Btn_RoomsOccupied.Size = new System.Drawing.Size(165, 31);
            this.Btn_RoomsOccupied.TabIndex = 51;
            this.Btn_RoomsOccupied.Text = "Occupied";
            this.Btn_RoomsOccupied.UseVisualStyleBackColor = true;
            this.Btn_RoomsOccupied.Click += new System.EventHandler(this.Btn_RoomsOccupied_Click);
            // 
            // Btn_RoomsAvailable
            // 
            this.Btn_RoomsAvailable.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RoomsAvailable.Location = new System.Drawing.Point(792, 215);
            this.Btn_RoomsAvailable.Name = "Btn_RoomsAvailable";
            this.Btn_RoomsAvailable.Size = new System.Drawing.Size(165, 31);
            this.Btn_RoomsAvailable.TabIndex = 50;
            this.Btn_RoomsAvailable.Text = "Available";
            this.Btn_RoomsAvailable.UseVisualStyleBackColor = true;
            this.Btn_RoomsAvailable.Click += new System.EventHandler(this.Btn_RoomsAvailable_Click);
            // 
            // Btn_RoomsFull
            // 
            this.Btn_RoomsFull.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RoomsFull.Location = new System.Drawing.Point(792, 67);
            this.Btn_RoomsFull.Name = "Btn_RoomsFull";
            this.Btn_RoomsFull.Size = new System.Drawing.Size(165, 31);
            this.Btn_RoomsFull.TabIndex = 49;
            this.Btn_RoomsFull.Text = "Default";
            this.Btn_RoomsFull.UseVisualStyleBackColor = true;
            this.Btn_RoomsFull.Click += new System.EventHandler(this.Btn_RoomsFull_Click);
            // 
            // Txt_ImgFileName
            // 
            this.Txt_ImgFileName.Enabled = false;
            this.Txt_ImgFileName.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ImgFileName.Location = new System.Drawing.Point(454, 252);
            this.Txt_ImgFileName.Name = "Txt_ImgFileName";
            this.Txt_ImgFileName.Size = new System.Drawing.Size(503, 30);
            this.Txt_ImgFileName.TabIndex = 46;
            // 
            // Btn_AddRoom
            // 
            this.Btn_AddRoom.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_AddRoom.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddRoom.Location = new System.Drawing.Point(596, 104);
            this.Btn_AddRoom.Name = "Btn_AddRoom";
            this.Btn_AddRoom.Size = new System.Drawing.Size(183, 44);
            this.Btn_AddRoom.TabIndex = 43;
            this.Btn_AddRoom.Text = "Add Room";
            this.Btn_AddRoom.UseVisualStyleBackColor = false;
            this.Btn_AddRoom.Click += new System.EventHandler(this.Btn_AddRoom_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_Update.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(596, 154);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(183, 44);
            this.Btn_Update.TabIndex = 44;
            this.Btn_Update.Text = "Update Room";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_Delete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(596, 204);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(183, 44);
            this.Btn_Delete.TabIndex = 45;
            this.Btn_Delete.Text = "Remove Room";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_BrowseImage
            // 
            this.Btn_BrowseImage.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BrowseImage.Location = new System.Drawing.Point(367, 250);
            this.Btn_BrowseImage.Name = "Btn_BrowseImage";
            this.Btn_BrowseImage.Size = new System.Drawing.Size(86, 33);
            this.Btn_BrowseImage.TabIndex = 32;
            this.Btn_BrowseImage.Text = "Browse";
            this.Btn_BrowseImage.UseVisualStyleBackColor = true;
            this.Btn_BrowseImage.Click += new System.EventHandler(this.Btn_BrowseImage_Click);
            // 
            // Pbx_RoomImg
            // 
            this.Pbx_RoomImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pbx_RoomImg.Location = new System.Drawing.Point(367, 104);
            this.Pbx_RoomImg.Name = "Pbx_RoomImg";
            this.Pbx_RoomImg.Size = new System.Drawing.Size(209, 144);
            this.Pbx_RoomImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_RoomImg.TabIndex = 41;
            this.Pbx_RoomImg.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 23);
            this.label8.TabIndex = 40;
            this.label8.Text = "Room Image";
            // 
            // Txt_RType
            // 
            this.Txt_RType.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RType.Location = new System.Drawing.Point(244, 45);
            this.Txt_RType.Name = "Txt_RType";
            this.Txt_RType.Size = new System.Drawing.Size(151, 30);
            this.Txt_RType.TabIndex = 39;
            // 
            // Label_GuestCount
            // 
            this.Label_GuestCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_GuestCount.AutoSize = true;
            this.Label_GuestCount.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GuestCount.Location = new System.Drawing.Point(716, 48);
            this.Label_GuestCount.Name = "Label_GuestCount";
            this.Label_GuestCount.Size = new System.Drawing.Size(20, 23);
            this.Label_GuestCount.TabIndex = 38;
            this.Label_GuestCount.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(716, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "No. of Guests";
            // 
            // Label_RoomStatus
            // 
            this.Label_RoomStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_RoomStatus.AutoSize = true;
            this.Label_RoomStatus.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomStatus.Location = new System.Drawing.Point(592, 48);
            this.Label_RoomStatus.Name = "Label_RoomStatus";
            this.Label_RoomStatus.Size = new System.Drawing.Size(42, 23);
            this.Label_RoomStatus.TabIndex = 36;
            this.Label_RoomStatus.Text = "N/A";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Room Status";
            // 
            // richTxt_RDesc
            // 
            this.richTxt_RDesc.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxt_RDesc.Location = new System.Drawing.Point(24, 104);
            this.richTxt_RDesc.Name = "richTxt_RDesc";
            this.richTxt_RDesc.Size = new System.Drawing.Size(316, 179);
            this.richTxt_RDesc.TabIndex = 34;
            this.richTxt_RDesc.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Room Description";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Room Price";
            // 
            // Txt_RPrice
            // 
            this.Txt_RPrice.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RPrice.Location = new System.Drawing.Point(425, 45);
            this.Txt_RPrice.Name = "Txt_RPrice";
            this.Txt_RPrice.Size = new System.Drawing.Size(151, 30);
            this.Txt_RPrice.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Room Title";
            // 
            // Txt_RTitle
            // 
            this.Txt_RTitle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RTitle.Location = new System.Drawing.Point(24, 45);
            this.Txt_RTitle.Name = "Txt_RTitle";
            this.Txt_RTitle.Size = new System.Drawing.Size(200, 30);
            this.Txt_RTitle.TabIndex = 27;
            // 
            // Dgv_Rooms
            // 
            this.Dgv_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Rooms.Location = new System.Drawing.Point(15, 450);
            this.Dgv_Rooms.Name = "Dgv_Rooms";
            this.Dgv_Rooms.Size = new System.Drawing.Size(974, 229);
            this.Dgv_Rooms.TabIndex = 0;
            this.Dgv_Rooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Rooms_CellClick);
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // EP_Input
            // 
            this.EP_Input.ContainerControl = this;
            // 
            // Staff_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(1056, 729);
            this.Controls.Add(this.Panel_AcctManage);
            this.Name = "Staff_Rooms";
            this.Text = "Staff_Rooms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Staff_Rooms_FormClosed);
            this.Load += new System.EventHandler(this.Staff_Rooms_Load);
            this.Panel_AcctManage.ResumeLayout(false);
            this.Panel_AcctManage.PerformLayout();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            this.Panel_AcctOptions.ResumeLayout(false);
            this.Panel_AcctOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_RoomImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Input)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_AcctManage;
        private System.Windows.Forms.Label Label_RoomCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.Panel Panel_AcctOptions;
        private System.Windows.Forms.DataGridView Dgv_Rooms;
        private System.Windows.Forms.Label Label_GuestCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label_RoomStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTxt_RDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_RPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_RTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox Pbx_RoomImg;
        private System.Windows.Forms.Button Btn_BrowseImage;
        private System.Windows.Forms.Button Btn_AddRoom;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox Txt_ImgFileName;
        private System.Windows.Forms.Button Btn_RoomsTypes;
        private System.Windows.Forms.Button Btn_RoomsPrices;
        private System.Windows.Forms.Button Btn_RoomsOccupied;
        private System.Windows.Forms.Button Btn_RoomsAvailable;
        private System.Windows.Forms.Button Btn_RoomsFull;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.ErrorProvider EP_Input;
        private System.Windows.Forms.TextBox Txt_RType;
    }
}