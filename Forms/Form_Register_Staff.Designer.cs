namespace HotelReservationSystem
{
    partial class Form_Register_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Register_Staff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Contact = new System.Windows.Forms.TextBox();
            this.Cbx_Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_BDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Calendar_BDate = new System.Windows.Forms.MonthCalendar();
            this.Txt_LN = new System.Windows.Forms.TextBox();
            this.Txt_FN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.LinkLabel_Login = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.ErrorProv_Txt = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv_Txt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Txt_Email);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Txt_Contact);
            this.panel1.Controls.Add(this.Cbx_Gender);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Txt_BDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Calendar_BDate);
            this.panel1.Controls.Add(this.Txt_LN);
            this.panel1.Controls.Add(this.Txt_FN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Pic_HotelKannoteki);
            this.panel1.Controls.Add(this.Btn_Register);
            this.panel1.Controls.Add(this.Panel_DateTime);
            this.panel1.Controls.Add(this.LinkLabel_Login);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(28, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 555);
            this.panel1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 33);
            this.label7.TabIndex = 56;
            this.label7.Text = "STAFF DETAILS";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.Location = new System.Drawing.Point(181, 382);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(257, 30);
            this.Txt_Email.TabIndex = 55;
            this.Txt_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Email_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 54;
            this.label8.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Contact No.";
            // 
            // Txt_Contact
            // 
            this.Txt_Contact.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contact.Location = new System.Drawing.Point(181, 294);
            this.Txt_Contact.Name = "Txt_Contact";
            this.Txt_Contact.Size = new System.Drawing.Size(257, 30);
            this.Txt_Contact.TabIndex = 52;
            this.Txt_Contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Contact_KeyPress);
            // 
            // Cbx_Gender
            // 
            this.Cbx_Gender.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Cbx_Gender.FormattingEnabled = true;
            this.Cbx_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.Cbx_Gender.Location = new System.Drawing.Point(404, 219);
            this.Cbx_Gender.Name = "Cbx_Gender";
            this.Cbx_Gender.Size = new System.Drawing.Size(140, 31);
            this.Cbx_Gender.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Gender";
            // 
            // Txt_BDate
            // 
            this.Txt_BDate.Enabled = false;
            this.Txt_BDate.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BDate.Location = new System.Drawing.Point(575, 220);
            this.Txt_BDate.Name = "Txt_BDate";
            this.Txt_BDate.Size = new System.Drawing.Size(131, 30);
            this.Txt_BDate.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(570, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Birthdate";
            // 
            // Calendar_BDate
            // 
            this.Calendar_BDate.Location = new System.Drawing.Point(479, 250);
            this.Calendar_BDate.MaxSelectionCount = 1;
            this.Calendar_BDate.Name = "Calendar_BDate";
            this.Calendar_BDate.TabIndex = 47;
            this.Calendar_BDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_BDate_DateChanged);
            // 
            // Txt_LN
            // 
            this.Txt_LN.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_LN.Location = new System.Drawing.Point(206, 220);
            this.Txt_LN.Name = "Txt_LN";
            this.Txt_LN.Size = new System.Drawing.Size(164, 30);
            this.Txt_LN.TabIndex = 46;
            this.Txt_LN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_LN_KeyPress);
            // 
            // Txt_FN
            // 
            this.Txt_FN.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FN.Location = new System.Drawing.Point(33, 220);
            this.Txt_FN.Name = "Txt_FN";
            this.Txt_FN.Size = new System.Drawing.Size(155, 30);
            this.Txt_FN.TabIndex = 45;
            this.Txt_FN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_FN_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "First Name";
            // 
            // Pic_HotelKannoteki
            // 
            this.Pic_HotelKannoteki.Image = global::HotelReservationSystem.Properties.Resources.hoteldbsyslogo;
            this.Pic_HotelKannoteki.Location = new System.Drawing.Point(262, 13);
            this.Pic_HotelKannoteki.Name = "Pic_HotelKannoteki";
            this.Pic_HotelKannoteki.Size = new System.Drawing.Size(240, 120);
            this.Pic_HotelKannoteki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_HotelKannoteki.TabIndex = 16;
            this.Pic_HotelKannoteki.TabStop = false;
            // 
            // Btn_Register
            // 
            this.Btn_Register.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Register.Location = new System.Drawing.Point(288, 450);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(166, 34);
            this.Btn_Register.TabIndex = 17;
            this.Btn_Register.Text = "Create Account";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Panel_DateTime
            // 
            this.Panel_DateTime.BackColor = System.Drawing.Color.LightGreen;
            this.Panel_DateTime.Controls.Add(this.Label_Calendar);
            this.Panel_DateTime.Controls.Add(this.Label_Clock);
            this.Panel_DateTime.Location = new System.Drawing.Point(12, 13);
            this.Panel_DateTime.Name = "Panel_DateTime";
            this.Panel_DateTime.Size = new System.Drawing.Size(244, 70);
            this.Panel_DateTime.TabIndex = 23;
            // 
            // Label_Calendar
            // 
            this.Label_Calendar.AutoSize = true;
            this.Label_Calendar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Calendar.Location = new System.Drawing.Point(3, 9);
            this.Label_Calendar.Name = "Label_Calendar";
            this.Label_Calendar.Size = new System.Drawing.Size(60, 25);
            this.Label_Calendar.TabIndex = 14;
            this.Label_Calendar.Text = "Date:";
            // 
            // Label_Clock
            // 
            this.Label_Clock.AutoSize = true;
            this.Label_Clock.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Clock.Location = new System.Drawing.Point(3, 34);
            this.Label_Clock.Name = "Label_Clock";
            this.Label_Clock.Size = new System.Drawing.Size(61, 25);
            this.Label_Clock.TabIndex = 13;
            this.Label_Clock.Text = "Time:";
            // 
            // LinkLabel_Login
            // 
            this.LinkLabel_Login.AutoSize = true;
            this.LinkLabel_Login.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_Login.Location = new System.Drawing.Point(448, 512);
            this.LinkLabel_Login.Name = "LinkLabel_Login";
            this.LinkLabel_Login.Size = new System.Drawing.Size(77, 25);
            this.LinkLabel_Login.TabIndex = 22;
            this.LinkLabel_Login.TabStop = true;
            this.LinkLabel_Login.Text = "Sign In";
            this.LinkLabel_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Login_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Already had an account?";
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // ErrorProv_Txt
            // 
            this.ErrorProv_Txt.ContainerControl = this;
            // 
            // Form_Register_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Register_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Information Form";
            this.Load += new System.EventHandler(this.Form_Register_Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv_Txt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.LinkLabel LinkLabel_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Contact;
        private System.Windows.Forms.ComboBox Cbx_Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_BDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar Calendar_BDate;
        private System.Windows.Forms.TextBox Txt_LN;
        private System.Windows.Forms.TextBox Txt_FN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.ErrorProvider ErrorProv_Txt;
    }
}