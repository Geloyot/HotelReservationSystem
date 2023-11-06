namespace HotelReservationSystem.Forms
{
    partial class Form_Dashboard_Admin
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatus_CurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_MI_OpenUserEntryForm = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LinkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.LinkLabelAcctManage = new System.Windows.Forms.LinkLabel();
            this.LinkLabelDashboard = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatus_CurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(968, 28);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatus_CurrentUser
            // 
            this.ToolStripStatus_CurrentUser.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatus_CurrentUser.Name = "ToolStripStatus_CurrentUser";
            this.ToolStripStatus_CurrentUser.Size = new System.Drawing.Size(129, 23);
            this.ToolStripStatus_CurrentUser.Text = "Current User: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_MI_OpenUserEntryForm});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // TS_MI_OpenUserEntryForm
            // 
            this.TS_MI_OpenUserEntryForm.Name = "TS_MI_OpenUserEntryForm";
            this.TS_MI_OpenUserEntryForm.Size = new System.Drawing.Size(190, 22);
            this.TS_MI_OpenUserEntryForm.Text = "Open User Entry Form";
            this.TS_MI_OpenUserEntryForm.Click += new System.EventHandler(this.TS_MI_OpenUserEntryForm_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.Label_Clock);
            this.panel1.Controls.Add(this.Label_Calendar);
            this.panel1.Controls.Add(this.LinkLabelLogout);
            this.panel1.Controls.Add(this.LinkLabelAcctManage);
            this.panel1.Controls.Add(this.LinkLabelDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 60);
            this.panel1.TabIndex = 2;
            // 
            // LinkLabelLogout
            // 
            this.LinkLabelLogout.AutoSize = true;
            this.LinkLabelLogout.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelLogout.LinkColor = System.Drawing.Color.Black;
            this.LinkLabelLogout.Location = new System.Drawing.Point(881, 33);
            this.LinkLabelLogout.Name = "LinkLabelLogout";
            this.LinkLabelLogout.Size = new System.Drawing.Size(75, 25);
            this.LinkLabelLogout.TabIndex = 6;
            this.LinkLabelLogout.TabStop = true;
            this.LinkLabelLogout.Text = "Log Out";
            this.LinkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLogout_LinkClicked);
            // 
            // LinkLabelAcctManage
            // 
            this.LinkLabelAcctManage.AutoSize = true;
            this.LinkLabelAcctManage.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelAcctManage.LinkColor = System.Drawing.Color.Black;
            this.LinkLabelAcctManage.Location = new System.Drawing.Point(285, 33);
            this.LinkLabelAcctManage.Name = "LinkLabelAcctManage";
            this.LinkLabelAcctManage.Size = new System.Drawing.Size(188, 25);
            this.LinkLabelAcctManage.TabIndex = 5;
            this.LinkLabelAcctManage.TabStop = true;
            this.LinkLabelAcctManage.Text = "Account Management";
            this.LinkLabelAcctManage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAcctManage_LinkClicked);
            // 
            // LinkLabelDashboard
            // 
            this.LinkLabelDashboard.AutoSize = true;
            this.LinkLabelDashboard.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelDashboard.LinkColor = System.Drawing.Color.Black;
            this.LinkLabelDashboard.Location = new System.Drawing.Point(146, 33);
            this.LinkLabelDashboard.Name = "LinkLabelDashboard";
            this.LinkLabelDashboard.Size = new System.Drawing.Size(113, 25);
            this.LinkLabelDashboard.TabIndex = 4;
            this.LinkLabelDashboard.TabStop = true;
            this.LinkLabelDashboard.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::HotelReservationSystem.Properties.Resources.hoteldbsyslogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 60);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Label_Calendar
            // 
            this.Label_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Calendar.AutoSize = true;
            this.Label_Calendar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Calendar.Location = new System.Drawing.Point(720, 1);
            this.Label_Calendar.Name = "Label_Calendar";
            this.Label_Calendar.Size = new System.Drawing.Size(60, 25);
            this.Label_Calendar.TabIndex = 14;
            this.Label_Calendar.Text = "Date:";
            // 
            // Label_Clock
            // 
            this.Label_Clock.AutoSize = true;
            this.Label_Clock.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Clock.Location = new System.Drawing.Point(826, 1);
            this.Label_Clock.Name = "Label_Clock";
            this.Label_Clock.Size = new System.Drawing.Size(61, 25);
            this.Label_Clock.TabIndex = 13;
            this.Label_Clock.Text = "Time:";
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // Form_Dashboard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Dashboard_Admin";
            this.Text = "Administrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Dashboard_Admin_FormClosed);
            this.Load += new System.EventHandler(this.Form_Dashboard_Admin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatus_CurrentUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_MI_OpenUserEntryForm;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LinkLabelDashboard;
        private System.Windows.Forms.LinkLabel LinkLabelAcctManage;
        private System.Windows.Forms.LinkLabel LinkLabelLogout;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Timer Timer_Clock;
    }
}