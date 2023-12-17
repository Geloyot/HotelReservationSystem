namespace HotelReservationSystem
{
    partial class Customer_S2Guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_S2Guest));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatus_CurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Contact = new System.Windows.Forms.TextBox();
            this.Cbx_Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_BDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Calendar_BDate = new System.Windows.Forms.MonthCalendar();
            this.Txt_LN = new System.Windows.Forms.TextBox();
            this.Txt_FN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picProgress = new System.Windows.Forms.PictureBox();
            this.Btn_NextStep = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.EP_Input = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).BeginInit();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatus_CurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 28);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatus_CurrentUser
            // 
            this.ToolStripStatus_CurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripStatus_CurrentUser.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatus_CurrentUser.Name = "ToolStripStatus_CurrentUser";
            this.ToolStripStatus_CurrentUser.Size = new System.Drawing.Size(129, 23);
            this.ToolStripStatus_CurrentUser.Text = "Current User: ";
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.panel1.Controls.Add(this.Txt_Email);
            this.panel1.Controls.Add(this.Txt_Address);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Txt_Contact);
            this.panel1.Controls.Add(this.Cbx_Gender);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Txt_BDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Calendar_BDate);
            this.panel1.Controls.Add(this.Txt_LN);
            this.panel1.Controls.Add(this.Txt_FN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picProgress);
            this.panel1.Controls.Add(this.Btn_NextStep);
            this.panel1.Controls.Add(this.Btn_Back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_LogOut);
            this.panel1.Controls.Add(this.Panel_DateTime);
            this.panel1.Controls.Add(this.Pic_HotelKannoteki);
            this.panel1.Location = new System.Drawing.Point(23, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 456);
            this.panel1.TabIndex = 2;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.Location = new System.Drawing.Point(175, 305);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(257, 30);
            this.Txt_Email.TabIndex = 42;
            // 
            // Txt_Address
            // 
            this.Txt_Address.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Address.Location = new System.Drawing.Point(175, 260);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(257, 30);
            this.Txt_Address.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Contact No.";
            // 
            // Txt_Contact
            // 
            this.Txt_Contact.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contact.Location = new System.Drawing.Point(175, 217);
            this.Txt_Contact.Name = "Txt_Contact";
            this.Txt_Contact.Size = new System.Drawing.Size(257, 30);
            this.Txt_Contact.TabIndex = 37;
            // 
            // Cbx_Gender
            // 
            this.Cbx_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Gender.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Cbx_Gender.FormattingEnabled = true;
            this.Cbx_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.Cbx_Gender.Location = new System.Drawing.Point(398, 142);
            this.Cbx_Gender.Name = "Cbx_Gender";
            this.Cbx_Gender.Size = new System.Drawing.Size(140, 31);
            this.Cbx_Gender.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Gender";
            // 
            // Txt_BDate
            // 
            this.Txt_BDate.Enabled = false;
            this.Txt_BDate.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BDate.Location = new System.Drawing.Point(569, 143);
            this.Txt_BDate.Name = "Txt_BDate";
            this.Txt_BDate.Size = new System.Drawing.Size(131, 30);
            this.Txt_BDate.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Birthdate";
            // 
            // Calendar_BDate
            // 
            this.Calendar_BDate.Location = new System.Drawing.Point(473, 173);
            this.Calendar_BDate.MaxSelectionCount = 1;
            this.Calendar_BDate.Name = "Calendar_BDate";
            this.Calendar_BDate.TabIndex = 32;
            this.Calendar_BDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_BDate_DateChanged);
            // 
            // Txt_LN
            // 
            this.Txt_LN.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_LN.Location = new System.Drawing.Point(200, 143);
            this.Txt_LN.Name = "Txt_LN";
            this.Txt_LN.Size = new System.Drawing.Size(164, 30);
            this.Txt_LN.TabIndex = 31;
            // 
            // Txt_FN
            // 
            this.Txt_FN.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FN.Location = new System.Drawing.Point(27, 143);
            this.Txt_FN.Name = "Txt_FN";
            this.Txt_FN.Size = new System.Drawing.Size(155, 30);
            this.Txt_FN.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Last Name";
            // 
            // picProgress
            // 
            this.picProgress.BackColor = System.Drawing.Color.Transparent;
            this.picProgress.Image = global::HotelReservationSystem.Properties.Resources.step2;
            this.picProgress.Location = new System.Drawing.Point(234, 393);
            this.picProgress.Name = "picProgress";
            this.picProgress.Size = new System.Drawing.Size(295, 44);
            this.picProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProgress.TabIndex = 28;
            this.picProgress.TabStop = false;
            // 
            // Btn_NextStep
            // 
            this.Btn_NextStep.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NextStep.Location = new System.Drawing.Point(246, 358);
            this.Btn_NextStep.Name = "Btn_NextStep";
            this.Btn_NextStep.Size = new System.Drawing.Size(270, 34);
            this.Btn_NextStep.TabIndex = 25;
            this.Btn_NextStep.Text = "PROCEED TO PAYMENT";
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
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Guest Details";
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
            this.Panel_DateTime.Size = new System.Drawing.Size(306, 62);
            this.Panel_DateTime.TabIndex = 16;
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
            // Customer_S2Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(804, 521);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_S2Guest";
            this.Text = "Step 2: Guest Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_S2Guest_FormClosed);
            this.Load += new System.EventHandler(this.Customer_S2Guest_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).EndInit();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picProgress;
        private System.Windows.Forms.Button Btn_NextStep;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatus_CurrentUser;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_LN;
        private System.Windows.Forms.TextBox Txt_FN;
        private System.Windows.Forms.MonthCalendar Calendar_BDate;
        private System.Windows.Forms.ComboBox Cbx_Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_BDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.ErrorProvider EP_Input;
    }
}