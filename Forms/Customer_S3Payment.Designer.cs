namespace HotelReservationSystem
{
    partial class Customer_S3Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_S3Payment));
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStatusStrip_CurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Txt_CardNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_SecurityCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbx_CardType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_ExpiryDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Calendar_ExpiryDate = new System.Windows.Forms.MonthCalendar();
            this.Txt_Amount = new System.Windows.Forms.TextBox();
            this.Txt_CardOwnerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picProgress = new System.Windows.Forms.PictureBox();
            this.Btn_NextStep = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.EP_Input = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).BeginInit();
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
            this.ToolStatusStrip_CurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 28);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStatusStrip_CurrentUser
            // 
            this.ToolStatusStrip_CurrentUser.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStatusStrip_CurrentUser.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ToolStatusStrip_CurrentUser.Name = "ToolStatusStrip_CurrentUser";
            this.ToolStatusStrip_CurrentUser.Size = new System.Drawing.Size(124, 23);
            this.ToolStatusStrip_CurrentUser.Text = "Current User:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.panel1.Controls.Add(this.Panel_DateTime);
            this.panel1.Controls.Add(this.Txt_CardNumber);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Txt_SecurityCode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Cbx_CardType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Txt_ExpiryDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Calendar_ExpiryDate);
            this.panel1.Controls.Add(this.Txt_Amount);
            this.panel1.Controls.Add(this.Txt_CardOwnerName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picProgress);
            this.panel1.Controls.Add(this.Btn_NextStep);
            this.panel1.Controls.Add(this.Btn_Back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_LogOut);
            this.panel1.Controls.Add(this.Pic_HotelKannoteki);
            this.panel1.Location = new System.Drawing.Point(24, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 429);
            this.panel1.TabIndex = 3;
            // 
            // Panel_DateTime
            // 
            this.Panel_DateTime.BackColor = System.Drawing.Color.LightGreen;
            this.Panel_DateTime.Controls.Add(this.Label_Calendar);
            this.Panel_DateTime.Controls.Add(this.Label_Clock);
            this.Panel_DateTime.Location = new System.Drawing.Point(3, 3);
            this.Panel_DateTime.Name = "Panel_DateTime";
            this.Panel_DateTime.Size = new System.Drawing.Size(306, 62);
            this.Panel_DateTime.TabIndex = 41;
            // 
            // Label_Calendar
            // 
            this.Label_Calendar.AutoSize = true;
            this.Label_Calendar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Calendar.Location = new System.Drawing.Point(3, 5);
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
            // Txt_CardNumber
            // 
            this.Txt_CardNumber.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CardNumber.Location = new System.Drawing.Point(218, 142);
            this.Txt_CardNumber.Name = "Txt_CardNumber";
            this.Txt_CardNumber.Size = new System.Drawing.Size(180, 30);
            this.Txt_CardNumber.TabIndex = 40;
            this.Txt_CardNumber.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Card Number";
            // 
            // Txt_SecurityCode
            // 
            this.Txt_SecurityCode.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SecurityCode.Location = new System.Drawing.Point(30, 225);
            this.Txt_SecurityCode.Name = "Txt_SecurityCode";
            this.Txt_SecurityCode.Size = new System.Drawing.Size(157, 30);
            this.Txt_SecurityCode.TabIndex = 38;
            this.Txt_SecurityCode.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "C.V.V.";
            // 
            // Cbx_CardType
            // 
            this.Cbx_CardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_CardType.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Cbx_CardType.FormattingEnabled = true;
            this.Cbx_CardType.Items.AddRange(new object[] {
            "VISA",
            "Mastercard"});
            this.Cbx_CardType.Location = new System.Drawing.Point(30, 142);
            this.Cbx_CardType.Name = "Cbx_CardType";
            this.Cbx_CardType.Size = new System.Drawing.Size(157, 31);
            this.Cbx_CardType.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Credit Card";
            // 
            // Txt_ExpiryDate
            // 
            this.Txt_ExpiryDate.Enabled = false;
            this.Txt_ExpiryDate.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ExpiryDate.Location = new System.Drawing.Point(473, 143);
            this.Txt_ExpiryDate.Name = "Txt_ExpiryDate";
            this.Txt_ExpiryDate.Size = new System.Drawing.Size(131, 30);
            this.Txt_ExpiryDate.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Expiration Date";
            // 
            // Calendar_ExpiryDate
            // 
            this.Calendar_ExpiryDate.Location = new System.Drawing.Point(473, 173);
            this.Calendar_ExpiryDate.MaxSelectionCount = 1;
            this.Calendar_ExpiryDate.Name = "Calendar_ExpiryDate";
            this.Calendar_ExpiryDate.TabIndex = 32;
            this.Calendar_ExpiryDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_ExpiryDate_DateChanged);
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.Enabled = false;
            this.Txt_Amount.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Amount.Location = new System.Drawing.Point(218, 225);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Size = new System.Drawing.Size(180, 30);
            this.Txt_Amount.TabIndex = 31;
            // 
            // Txt_CardOwnerName
            // 
            this.Txt_CardOwnerName.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CardOwnerName.Location = new System.Drawing.Point(30, 301);
            this.Txt_CardOwnerName.Name = "Txt_CardOwnerName";
            this.Txt_CardOwnerName.Size = new System.Drawing.Size(368, 30);
            this.Txt_CardOwnerName.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Amount";
            // 
            // picProgress
            // 
            this.picProgress.BackColor = System.Drawing.Color.Transparent;
            this.picProgress.Image = global::HotelReservationSystem.Properties.Resources.step3;
            this.picProgress.Location = new System.Drawing.Point(233, 382);
            this.picProgress.Name = "picProgress";
            this.picProgress.Size = new System.Drawing.Size(295, 44);
            this.picProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProgress.TabIndex = 28;
            this.picProgress.TabStop = false;
            // 
            // Btn_NextStep
            // 
            this.Btn_NextStep.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NextStep.Location = new System.Drawing.Point(245, 347);
            this.Btn_NextStep.Name = "Btn_NextStep";
            this.Btn_NextStep.Size = new System.Drawing.Size(270, 34);
            this.Btn_NextStep.TabIndex = 25;
            this.Btn_NextStep.Text = "COMPLETE RESERVATION";
            this.Btn_NextStep.UseVisualStyleBackColor = true;
            this.Btn_NextStep.Click += new System.EventHandler(this.Btn_NextStep_Click);
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
            this.label2.Location = new System.Drawing.Point(25, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Card Owner Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reservation Payment";
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
            // Customer_S3Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_S3Payment";
            this.Text = "Step 3: Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_S3Payment_FormClosed);
            this.Load += new System.EventHandler(this.Customer_S3Payment_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_ExpiryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar Calendar_ExpiryDate;
        private System.Windows.Forms.TextBox Txt_Amount;
        private System.Windows.Forms.TextBox Txt_CardOwnerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picProgress;
        private System.Windows.Forms.Button Btn_NextStep;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.ComboBox Cbx_CardType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStatusStrip_CurrentUser;
        private System.Windows.Forms.TextBox Txt_SecurityCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_CardNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider EP_Input;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Label Label_Clock;
    }
}