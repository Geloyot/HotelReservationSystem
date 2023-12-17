namespace HotelReservationSystem
{
    partial class Customer_S1Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_S1Room));
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatus_CurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumUD_ChildCount = new System.Windows.Forms.NumericUpDown();
            this.NumUD_AdultCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_CheckOut = new System.Windows.Forms.TextBox();
            this.Txt_CheckIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calendar_CheckIn = new System.Windows.Forms.MonthCalendar();
            this.picProgress = new System.Windows.Forms.PictureBox();
            this.Txt_Price = new System.Windows.Forms.TextBox();
            this.Txt_Type = new System.Windows.Forms.TextBox();
            this.Btn_NextStep = new System.Windows.Forms.Button();
            this.richTxt_RoomDesc = new System.Windows.Forms.RichTextBox();
            this.Label_RoomPrice = new System.Windows.Forms.Label();
            this.Label_RoomType = new System.Windows.Forms.Label();
            this.picBx_RoomImage = new System.Windows.Forms.PictureBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbx_RoomTitles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.EP_Input = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_ChildCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_AdultCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_RoomImage)).BeginInit();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatus_CurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 28);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatus_CurrentUser
            // 
            this.ToolStripStatus_CurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripStatus_CurrentUser.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatus_CurrentUser.Name = "ToolStripStatus_CurrentUser";
            this.ToolStripStatus_CurrentUser.Size = new System.Drawing.Size(124, 23);
            this.ToolStripStatus_CurrentUser.Text = "Current User:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.NumUD_ChildCount);
            this.panel1.Controls.Add(this.NumUD_AdultCount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Txt_CheckOut);
            this.panel1.Controls.Add(this.Txt_CheckIn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Calendar_CheckIn);
            this.panel1.Controls.Add(this.picProgress);
            this.panel1.Controls.Add(this.Txt_Price);
            this.panel1.Controls.Add(this.Txt_Type);
            this.panel1.Controls.Add(this.Btn_NextStep);
            this.panel1.Controls.Add(this.richTxt_RoomDesc);
            this.panel1.Controls.Add(this.Label_RoomPrice);
            this.panel1.Controls.Add(this.Label_RoomType);
            this.panel1.Controls.Add(this.picBx_RoomImage);
            this.panel1.Controls.Add(this.Btn_Back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Cbx_RoomTitles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_LogOut);
            this.panel1.Controls.Add(this.Panel_DateTime);
            this.panel1.Controls.Add(this.Pic_HotelKannoteki);
            this.panel1.Location = new System.Drawing.Point(21, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 523);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(185, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "No. of Children";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "No. of Adults";
            // 
            // NumUD_ChildCount
            // 
            this.NumUD_ChildCount.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUD_ChildCount.Location = new System.Drawing.Point(190, 392);
            this.NumUD_ChildCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumUD_ChildCount.Name = "NumUD_ChildCount";
            this.NumUD_ChildCount.Size = new System.Drawing.Size(83, 33);
            this.NumUD_ChildCount.TabIndex = 38;
            // 
            // NumUD_AdultCount
            // 
            this.NumUD_AdultCount.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUD_AdultCount.Location = new System.Drawing.Point(41, 392);
            this.NumUD_AdultCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumUD_AdultCount.Name = "NumUD_AdultCount";
            this.NumUD_AdultCount.Size = new System.Drawing.Size(83, 33);
            this.NumUD_AdultCount.TabIndex = 37;
            this.NumUD_AdultCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Preview:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(602, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Check Out:";
            // 
            // Txt_CheckOut
            // 
            this.Txt_CheckOut.Enabled = false;
            this.Txt_CheckOut.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.Txt_CheckOut.Location = new System.Drawing.Point(607, 394);
            this.Txt_CheckOut.Name = "Txt_CheckOut";
            this.Txt_CheckOut.Size = new System.Drawing.Size(133, 27);
            this.Txt_CheckOut.TabIndex = 34;
            // 
            // Txt_CheckIn
            // 
            this.Txt_CheckIn.Enabled = false;
            this.Txt_CheckIn.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.Txt_CheckIn.Location = new System.Drawing.Point(446, 394);
            this.Txt_CheckIn.Name = "Txt_CheckIn";
            this.Txt_CheckIn.Size = new System.Drawing.Size(133, 27);
            this.Txt_CheckIn.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Check In:";
            // 
            // Calendar_CheckIn
            // 
            this.Calendar_CheckIn.Location = new System.Drawing.Point(480, 200);
            this.Calendar_CheckIn.MaxSelectionCount = 14;
            this.Calendar_CheckIn.Name = "Calendar_CheckIn";
            this.Calendar_CheckIn.TabIndex = 29;
            this.Calendar_CheckIn.TitleBackColor = System.Drawing.Color.GreenYellow;
            this.Calendar_CheckIn.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_CheckIn_DateChanged);
            // 
            // picProgress
            // 
            this.picProgress.BackColor = System.Drawing.Color.Transparent;
            this.picProgress.Image = global::HotelReservationSystem.Properties.Resources.step1;
            this.picProgress.Location = new System.Drawing.Point(232, 473);
            this.picProgress.Name = "picProgress";
            this.picProgress.Size = new System.Drawing.Size(295, 44);
            this.picProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProgress.TabIndex = 28;
            this.picProgress.TabStop = false;
            // 
            // Txt_Price
            // 
            this.Txt_Price.Enabled = false;
            this.Txt_Price.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.Txt_Price.Location = new System.Drawing.Point(534, 143);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.Size = new System.Drawing.Size(173, 27);
            this.Txt_Price.TabIndex = 27;
            // 
            // Txt_Type
            // 
            this.Txt_Type.Enabled = false;
            this.Txt_Type.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.Txt_Type.Location = new System.Drawing.Point(355, 143);
            this.Txt_Type.Name = "Txt_Type";
            this.Txt_Type.Size = new System.Drawing.Size(173, 27);
            this.Txt_Type.TabIndex = 26;
            // 
            // Btn_NextStep
            // 
            this.Btn_NextStep.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NextStep.Location = new System.Drawing.Point(220, 438);
            this.Btn_NextStep.Name = "Btn_NextStep";
            this.Btn_NextStep.Size = new System.Drawing.Size(319, 34);
            this.Btn_NextStep.TabIndex = 25;
            this.Btn_NextStep.Text = "PROCEED TO GUEST DETAILS";
            this.Btn_NextStep.UseVisualStyleBackColor = true;
            this.Btn_NextStep.Click += new System.EventHandler(this.Btn_NextStep_Click);
            // 
            // richTxt_RoomDesc
            // 
            this.richTxt_RoomDesc.Enabled = false;
            this.richTxt_RoomDesc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxt_RoomDesc.Location = new System.Drawing.Point(248, 200);
            this.richTxt_RoomDesc.Name = "richTxt_RoomDesc";
            this.richTxt_RoomDesc.Size = new System.Drawing.Size(226, 162);
            this.richTxt_RoomDesc.TabIndex = 24;
            this.richTxt_RoomDesc.Text = "";
            // 
            // Label_RoomPrice
            // 
            this.Label_RoomPrice.AutoSize = true;
            this.Label_RoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.Label_RoomPrice.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomPrice.Location = new System.Drawing.Point(529, 115);
            this.Label_RoomPrice.Name = "Label_RoomPrice";
            this.Label_RoomPrice.Size = new System.Drawing.Size(124, 25);
            this.Label_RoomPrice.TabIndex = 23;
            this.Label_RoomPrice.Text = "Room Price:";
            // 
            // Label_RoomType
            // 
            this.Label_RoomType.AutoSize = true;
            this.Label_RoomType.BackColor = System.Drawing.Color.Transparent;
            this.Label_RoomType.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomType.Location = new System.Drawing.Point(349, 115);
            this.Label_RoomType.Name = "Label_RoomType";
            this.Label_RoomType.Size = new System.Drawing.Size(118, 25);
            this.Label_RoomType.TabIndex = 22;
            this.Label_RoomType.Text = "Room Type:";
            // 
            // picBx_RoomImage
            // 
            this.picBx_RoomImage.Location = new System.Drawing.Point(28, 200);
            this.picBx_RoomImage.Name = "picBx_RoomImage";
            this.picBx_RoomImage.Size = new System.Drawing.Size(214, 162);
            this.picBx_RoomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBx_RoomImage.TabIndex = 21;
            this.picBx_RoomImage.TabStop = false;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(516, 15);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(95, 34);
            this.Btn_Back.TabIndex = 20;
            this.Btn_Back.Text = "BACK";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Room:";
            // 
            // Cbx_RoomTitles
            // 
            this.Cbx_RoomTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_RoomTitles.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_RoomTitles.FormattingEnabled = true;
            this.Cbx_RoomTitles.Location = new System.Drawing.Point(27, 143);
            this.Cbx_RoomTitles.Name = "Cbx_RoomTitles";
            this.Cbx_RoomTitles.Size = new System.Drawing.Size(310, 27);
            this.Cbx_RoomTitles.TabIndex = 18;
            this.Cbx_RoomTitles.SelectedIndexChanged += new System.EventHandler(this.Cbx_RoomTitles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Room";
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogOut.Location = new System.Drawing.Point(624, 15);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Size = new System.Drawing.Size(116, 34);
            this.Btn_LogOut.TabIndex = 15;
            this.Btn_LogOut.Text = "LOG OUT";
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // Panel_DateTime
            // 
            this.Panel_DateTime.BackColor = System.Drawing.Color.LightGreen;
            this.Panel_DateTime.Controls.Add(this.Label_Calendar);
            this.Panel_DateTime.Controls.Add(this.Label_Clock);
            this.Panel_DateTime.Location = new System.Drawing.Point(3, 3);
            this.Panel_DateTime.Name = "Panel_DateTime";
            this.Panel_DateTime.Size = new System.Drawing.Size(304, 62);
            this.Panel_DateTime.TabIndex = 16;
            // 
            // Label_Calendar
            // 
            this.Label_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Calendar.AutoSize = true;
            this.Label_Calendar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Calendar.Location = new System.Drawing.Point(4, 5);
            this.Label_Calendar.Name = "Label_Calendar";
            this.Label_Calendar.Size = new System.Drawing.Size(60, 25);
            this.Label_Calendar.TabIndex = 14;
            this.Label_Calendar.Text = "Date:";
            // 
            // Label_Clock
            // 
            this.Label_Clock.AutoSize = true;
            this.Label_Clock.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Clock.Location = new System.Drawing.Point(3, 30);
            this.Label_Clock.Name = "Label_Clock";
            this.Label_Clock.Size = new System.Drawing.Size(61, 25);
            this.Label_Clock.TabIndex = 13;
            this.Label_Clock.Text = "Time:";
            // 
            // Pic_HotelKannoteki
            // 
            this.Pic_HotelKannoteki.BackColor = System.Drawing.Color.Transparent;
            this.Pic_HotelKannoteki.Image = global::HotelReservationSystem.Properties.Resources.hoteldbsyslogo;
            this.Pic_HotelKannoteki.Location = new System.Drawing.Point(327, 3);
            this.Pic_HotelKannoteki.Name = "Pic_HotelKannoteki";
            this.Pic_HotelKannoteki.Size = new System.Drawing.Size(115, 62);
            this.Pic_HotelKannoteki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_HotelKannoteki.TabIndex = 12;
            this.Pic_HotelKannoteki.TabStop = false;
            // 
            // EP_Input
            // 
            this.EP_Input.ContainerControl = this;
            // 
            // Customer_S1Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(804, 591);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_S1Room";
            this.Text = "Step 1: Room Selection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_S1Room_FormClosed);
            this.Load += new System.EventHandler(this.Customer_S1Room_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_ChildCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_AdultCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_RoomImage)).EndInit();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatus_CurrentUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbx_RoomTitles;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.PictureBox picBx_RoomImage;
        private System.Windows.Forms.Label Label_RoomType;
        private System.Windows.Forms.Label Label_RoomPrice;
        private System.Windows.Forms.RichTextBox richTxt_RoomDesc;
        private System.Windows.Forms.Button Btn_NextStep;
        private System.Windows.Forms.TextBox Txt_Type;
        private System.Windows.Forms.TextBox Txt_Price;
        private System.Windows.Forms.PictureBox picProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar Calendar_CheckIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_CheckOut;
        private System.Windows.Forms.TextBox Txt_CheckIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumUD_AdultCount;
        private System.Windows.Forms.NumericUpDown NumUD_ChildCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider EP_Input;
    }
}