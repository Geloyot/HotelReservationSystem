namespace HotelReservationSystem
{
    partial class Form_Dashboard_Guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard_Guest));
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.StatusStrip_CurrentUser = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatus_CurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_PreExistingRes = new System.Windows.Forms.Panel();
            this.Label_CheckOut = new System.Windows.Forms.Label();
            this.Label_CheckIn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Btn_Book = new System.Windows.Forms.Button();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.StatusStrip_CurrentUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panel_PreExistingRes.SuspendLayout();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // StatusStrip_CurrentUser
            // 
            this.StatusStrip_CurrentUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatus_CurrentUser});
            this.StatusStrip_CurrentUser.Location = new System.Drawing.Point(0, 486);
            this.StatusStrip_CurrentUser.Name = "StatusStrip_CurrentUser";
            this.StatusStrip_CurrentUser.Size = new System.Drawing.Size(800, 28);
            this.StatusStrip_CurrentUser.TabIndex = 1;
            this.StatusStrip_CurrentUser.Text = "Current User:";
            // 
            // ToolStripStatus_CurrentUser
            // 
            this.ToolStripStatus_CurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripStatus_CurrentUser.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatus_CurrentUser.Name = "ToolStripStatus_CurrentUser";
            this.ToolStripStatus_CurrentUser.Size = new System.Drawing.Size(129, 23);
            this.ToolStripStatus_CurrentUser.Text = "Current User: ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.panel1.Controls.Add(this.Panel_PreExistingRes);
            this.panel1.Controls.Add(this.Btn_LogOut);
            this.panel1.Controls.Add(this.Panel_DateTime);
            this.panel1.Controls.Add(this.Btn_Book);
            this.panel1.Controls.Add(this.Pic_HotelKannoteki);
            this.panel1.Location = new System.Drawing.Point(59, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 399);
            this.panel1.TabIndex = 0;
            // 
            // Panel_PreExistingRes
            // 
            this.Panel_PreExistingRes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_PreExistingRes.Controls.Add(this.Label_CheckOut);
            this.Panel_PreExistingRes.Controls.Add(this.Label_CheckIn);
            this.Panel_PreExistingRes.Controls.Add(this.label3);
            this.Panel_PreExistingRes.Controls.Add(this.label2);
            this.Panel_PreExistingRes.Controls.Add(this.label1);
            this.Panel_PreExistingRes.Location = new System.Drawing.Point(43, 288);
            this.Panel_PreExistingRes.Name = "Panel_PreExistingRes";
            this.Panel_PreExistingRes.Size = new System.Drawing.Size(594, 100);
            this.Panel_PreExistingRes.TabIndex = 17;
            this.Panel_PreExistingRes.Visible = false;
            // 
            // Label_CheckOut
            // 
            this.Label_CheckOut.AutoSize = true;
            this.Label_CheckOut.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CheckOut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Label_CheckOut.Location = new System.Drawing.Point(316, 65);
            this.Label_CheckOut.Name = "Label_CheckOut";
            this.Label_CheckOut.Size = new System.Drawing.Size(102, 23);
            this.Label_CheckOut.TabIndex = 4;
            this.Label_CheckOut.Text = "CHECKOUT";
            // 
            // Label_CheckIn
            // 
            this.Label_CheckIn.AutoSize = true;
            this.Label_CheckIn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CheckIn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Label_CheckIn.Location = new System.Drawing.Point(316, 42);
            this.Label_CheckIn.Name = "Label_CheckIn";
            this.Label_CheckIn.Size = new System.Drawing.Size(88, 23);
            this.Label_CheckIn.TabIndex = 3;
            this.Label_CheckIn.Text = "CHECKIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reservation Check-Out: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reservation Check-In: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Existing Appointment";
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogOut.Location = new System.Drawing.Point(547, 18);
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
            this.Panel_DateTime.Location = new System.Drawing.Point(23, 18);
            this.Panel_DateTime.Name = "Panel_DateTime";
            this.Panel_DateTime.Size = new System.Drawing.Size(128, 69);
            this.Panel_DateTime.TabIndex = 16;
            // 
            // Label_Calendar
            // 
            this.Label_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // Btn_Book
            // 
            this.Btn_Book.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Book.Location = new System.Drawing.Point(223, 237);
            this.Btn_Book.Name = "Btn_Book";
            this.Btn_Book.Size = new System.Drawing.Size(254, 45);
            this.Btn_Book.TabIndex = 13;
            this.Btn_Book.Text = "Make an Appointment!";
            this.Btn_Book.UseVisualStyleBackColor = true;
            this.Btn_Book.Click += new System.EventHandler(this.Btn_Book_Click);
            // 
            // Pic_HotelKannoteki
            // 
            this.Pic_HotelKannoteki.BackColor = System.Drawing.Color.Transparent;
            this.Pic_HotelKannoteki.Image = global::HotelReservationSystem.Properties.Resources.hoteldbsyslogo;
            this.Pic_HotelKannoteki.Location = new System.Drawing.Point(170, 18);
            this.Pic_HotelKannoteki.Name = "Pic_HotelKannoteki";
            this.Pic_HotelKannoteki.Size = new System.Drawing.Size(354, 203);
            this.Pic_HotelKannoteki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_HotelKannoteki.TabIndex = 12;
            this.Pic_HotelKannoteki.TabStop = false;
            // 
            // Form_Dashboard_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.StatusStrip_CurrentUser);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dashboard_Guest";
            this.Text = "Form_Dashboard_Guest";
            this.Load += new System.EventHandler(this.Form_Dashboard_Guest_Load);
            this.StatusStrip_CurrentUser.ResumeLayout(false);
            this.StatusStrip_CurrentUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Panel_PreExistingRes.ResumeLayout(false);
            this.Panel_PreExistingRes.PerformLayout();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Book;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.StatusStrip StatusStrip_CurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatus_CurrentUser;
        private System.Windows.Forms.Panel Panel_PreExistingRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_CheckOut;
        private System.Windows.Forms.Label Label_CheckIn;
    }
}