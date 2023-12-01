namespace HotelReservationSystem
{
    partial class Admin_AcctManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AcctManage));
            this.Panel_AcctManage = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.Panel_AcctOptions = new System.Windows.Forms.Panel();
            this.Btn_ViewStaff = new System.Windows.Forms.Button();
            this.Label_AccountCount = new System.Windows.Forms.Label();
            this.Btn_ViewFull = new System.Windows.Forms.Button();
            this.Btn_ViewInactive = new System.Windows.Forms.Button();
            this.Btn_ViewActive = new System.Windows.Forms.Button();
            this.Btn_ViewRoles = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_UsernameSearch = new System.Windows.Forms.TextBox();
            this.Label_Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_UserStatus = new System.Windows.Forms.Button();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Checkbox_ShowPass = new System.Windows.Forms.CheckBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Dgv_AcctManage = new System.Windows.Forms.DataGridView();
            this.ErrorProviderInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.Panel_AcctManage.SuspendLayout();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            this.Panel_AcctOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AcctManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderInput)).BeginInit();
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
            this.Panel_AcctManage.Controls.Add(this.Dgv_AcctManage);
            this.Panel_AcctManage.Location = new System.Drawing.Point(47, 12);
            this.Panel_AcctManage.Name = "Panel_AcctManage";
            this.Panel_AcctManage.Size = new System.Drawing.Size(918, 692);
            this.Panel_AcctManage.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "USER ACCOUNTS";
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
            this.Panel_DateTime.Size = new System.Drawing.Size(337, 69);
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
            this.Pic_HotelKannoteki.Size = new System.Drawing.Size(189, 91);
            this.Pic_HotelKannoteki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_HotelKannoteki.TabIndex = 11;
            this.Pic_HotelKannoteki.TabStop = false;
            // 
            // Panel_AcctOptions
            // 
            this.Panel_AcctOptions.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Panel_AcctOptions.Controls.Add(this.Btn_ViewStaff);
            this.Panel_AcctOptions.Controls.Add(this.Label_AccountCount);
            this.Panel_AcctOptions.Controls.Add(this.Btn_ViewFull);
            this.Panel_AcctOptions.Controls.Add(this.Btn_ViewInactive);
            this.Panel_AcctOptions.Controls.Add(this.Btn_ViewActive);
            this.Panel_AcctOptions.Controls.Add(this.Btn_ViewRoles);
            this.Panel_AcctOptions.Controls.Add(this.Btn_Search);
            this.Panel_AcctOptions.Controls.Add(this.label4);
            this.Panel_AcctOptions.Controls.Add(this.Txt_UsernameSearch);
            this.Panel_AcctOptions.Controls.Add(this.Label_Status);
            this.Panel_AcctOptions.Controls.Add(this.label3);
            this.Panel_AcctOptions.Controls.Add(this.Btn_UserStatus);
            this.Panel_AcctOptions.Controls.Add(this.Btn_Register);
            this.Panel_AcctOptions.Controls.Add(this.Btn_Update);
            this.Panel_AcctOptions.Controls.Add(this.Checkbox_ShowPass);
            this.Panel_AcctOptions.Controls.Add(this.Btn_Delete);
            this.Panel_AcctOptions.Controls.Add(this.Txt_Username);
            this.Panel_AcctOptions.Controls.Add(this.label1);
            this.Panel_AcctOptions.Controls.Add(this.label2);
            this.Panel_AcctOptions.Controls.Add(this.Txt_Password);
            this.Panel_AcctOptions.Location = new System.Drawing.Point(15, 154);
            this.Panel_AcctOptions.Name = "Panel_AcctOptions";
            this.Panel_AcctOptions.Size = new System.Drawing.Size(889, 175);
            this.Panel_AcctOptions.TabIndex = 9;
            // 
            // Btn_ViewStaff
            // 
            this.Btn_ViewStaff.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewStaff.Location = new System.Drawing.Point(694, 137);
            this.Btn_ViewStaff.Name = "Btn_ViewStaff";
            this.Btn_ViewStaff.Size = new System.Drawing.Size(178, 32);
            this.Btn_ViewStaff.TabIndex = 31;
            this.Btn_ViewStaff.Text = "View Staff Info";
            this.Btn_ViewStaff.UseVisualStyleBackColor = true;
            this.Btn_ViewStaff.Visible = false;
            this.Btn_ViewStaff.Click += new System.EventHandler(this.Btn_ViewStaff_Click);
            // 
            // Label_AccountCount
            // 
            this.Label_AccountCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_AccountCount.AutoSize = true;
            this.Label_AccountCount.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AccountCount.Location = new System.Drawing.Point(22, 75);
            this.Label_AccountCount.Name = "Label_AccountCount";
            this.Label_AccountCount.Size = new System.Drawing.Size(171, 25);
            this.Label_AccountCount.TabIndex = 30;
            this.Label_AccountCount.Text = "No. of Accounts: ";
            // 
            // Btn_ViewFull
            // 
            this.Btn_ViewFull.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewFull.Location = new System.Drawing.Point(358, 101);
            this.Btn_ViewFull.Name = "Btn_ViewFull";
            this.Btn_ViewFull.Size = new System.Drawing.Size(79, 34);
            this.Btn_ViewFull.TabIndex = 22;
            this.Btn_ViewFull.Text = "Default";
            this.Btn_ViewFull.UseVisualStyleBackColor = true;
            this.Btn_ViewFull.Click += new System.EventHandler(this.Btn_ViewFull_Click);
            // 
            // Btn_ViewInactive
            // 
            this.Btn_ViewInactive.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewInactive.Location = new System.Drawing.Point(593, 101);
            this.Btn_ViewInactive.Name = "Btn_ViewInactive";
            this.Btn_ViewInactive.Size = new System.Drawing.Size(84, 34);
            this.Btn_ViewInactive.TabIndex = 21;
            this.Btn_ViewInactive.Text = "Inactive";
            this.Btn_ViewInactive.UseVisualStyleBackColor = true;
            this.Btn_ViewInactive.Click += new System.EventHandler(this.Btn_ViewInactive_Click);
            // 
            // Btn_ViewActive
            // 
            this.Btn_ViewActive.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewActive.Location = new System.Drawing.Point(517, 101);
            this.Btn_ViewActive.Name = "Btn_ViewActive";
            this.Btn_ViewActive.Size = new System.Drawing.Size(70, 34);
            this.Btn_ViewActive.TabIndex = 20;
            this.Btn_ViewActive.Text = "Active";
            this.Btn_ViewActive.UseVisualStyleBackColor = true;
            this.Btn_ViewActive.Click += new System.EventHandler(this.Btn_ViewActive_Click);
            // 
            // Btn_ViewRoles
            // 
            this.Btn_ViewRoles.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ViewRoles.Location = new System.Drawing.Point(443, 101);
            this.Btn_ViewRoles.Name = "Btn_ViewRoles";
            this.Btn_ViewRoles.Size = new System.Drawing.Size(68, 34);
            this.Btn_ViewRoles.TabIndex = 19;
            this.Btn_ViewRoles.Text = "Roles";
            this.Btn_ViewRoles.UseVisualStyleBackColor = true;
            this.Btn_ViewRoles.Click += new System.EventHandler(this.Btn_ViewRoles_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.Location = new System.Drawing.Point(222, 137);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(99, 34);
            this.Btn_Search.TabIndex = 18;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Search Username:";
            // 
            // Txt_UsernameSearch
            // 
            this.Txt_UsernameSearch.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UsernameSearch.Location = new System.Drawing.Point(27, 138);
            this.Txt_UsernameSearch.Name = "Txt_UsernameSearch";
            this.Txt_UsernameSearch.Size = new System.Drawing.Size(189, 33);
            this.Txt_UsernameSearch.TabIndex = 16;
            this.Txt_UsernameSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UsernameSearch_KeyPress);
            this.Txt_UsernameSearch.Leave += new System.EventHandler(this.Txt_UsernameSearch_Leave);
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status.ForeColor = System.Drawing.Color.DarkGreen;
            this.Label_Status.Location = new System.Drawing.Point(773, 6);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(79, 25);
            this.Label_Status.TabIndex = 15;
            this.Label_Status.Text = "ACTIVE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Status:";
            // 
            // Btn_UserStatus
            // 
            this.Btn_UserStatus.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UserStatus.Location = new System.Drawing.Point(694, 34);
            this.Btn_UserStatus.Name = "Btn_UserStatus";
            this.Btn_UserStatus.Size = new System.Drawing.Size(178, 32);
            this.Btn_UserStatus.TabIndex = 13;
            this.Btn_UserStatus.Text = "Set Status";
            this.Btn_UserStatus.UseVisualStyleBackColor = true;
            this.Btn_UserStatus.Click += new System.EventHandler(this.Btn_UserStatus_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_Register.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Register.Location = new System.Drawing.Point(358, 138);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(100, 34);
            this.Btn_Register.TabIndex = 1;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = false;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_Update.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(470, 138);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(100, 34);
            this.Btn_Update.TabIndex = 2;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Checkbox_ShowPass
            // 
            this.Checkbox_ShowPass.AutoSize = true;
            this.Checkbox_ShowPass.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_ShowPass.Location = new System.Drawing.Point(351, 71);
            this.Checkbox_ShowPass.Name = "Checkbox_ShowPass";
            this.Checkbox_ShowPass.Size = new System.Drawing.Size(161, 29);
            this.Checkbox_ShowPass.TabIndex = 12;
            this.Checkbox_ShowPass.Text = "Show Password";
            this.Checkbox_ShowPass.UseVisualStyleBackColor = true;
            this.Checkbox_ShowPass.CheckedChanged += new System.EventHandler(this.Checkbox_ShowPass_CheckedChanged);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_Delete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(577, 138);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(100, 34);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Txt_Username
            // 
            this.Txt_Username.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Username.Location = new System.Drawing.Point(27, 35);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(291, 33);
            this.Txt_Username.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(352, 35);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(291, 33);
            this.Txt_Password.TabIndex = 8;
            this.Txt_Password.UseSystemPasswordChar = true;
            // 
            // Dgv_AcctManage
            // 
            this.Dgv_AcctManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_AcctManage.Location = new System.Drawing.Point(15, 335);
            this.Dgv_AcctManage.Name = "Dgv_AcctManage";
            this.Dgv_AcctManage.Size = new System.Drawing.Size(889, 344);
            this.Dgv_AcctManage.TabIndex = 0;
            this.Dgv_AcctManage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_AcctManage_CellClick);
            // 
            // ErrorProviderInput
            // 
            this.ErrorProviderInput.ContainerControl = this;
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // Admin_AcctManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Panel_AcctManage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_AcctManage";
            this.Text = "Account Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AcctManage_FormClosed);
            this.Load += new System.EventHandler(this.Form_AcctManage_Load);
            this.Panel_AcctManage.ResumeLayout(false);
            this.Panel_AcctManage.PerformLayout();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            this.Panel_AcctOptions.ResumeLayout(false);
            this.Panel_AcctOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AcctManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_AcctManage;
        private System.Windows.Forms.DataGridView Dgv_AcctManage;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_AcctOptions;
        private System.Windows.Forms.ErrorProvider ErrorProviderInput;
        private System.Windows.Forms.CheckBox Checkbox_ShowPass;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.Button Btn_UserStatus;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_UsernameSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_ViewRoles;
        private System.Windows.Forms.Button Btn_ViewActive;
        private System.Windows.Forms.Button Btn_ViewInactive;
        private System.Windows.Forms.Button Btn_ViewFull;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label_AccountCount;
        private System.Windows.Forms.Button Btn_ViewStaff;
    }
}

