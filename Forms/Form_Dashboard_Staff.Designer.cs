namespace HotelReservationSystem.Forms
{
    partial class Form_Dashboard_Staff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Rooms = new System.Windows.Forms.Button();
            this.Btn_Reservations = new System.Windows.Forms.Button();
            this.Btn_Guests = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_GuestCount = new System.Windows.Forms.Label();
            this.Dgv_GuestsSmall = new System.Windows.Forms.DataGridView();
            this.Btn_GoToGuests = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Panel_Reservation = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_CheckOutCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_CheckInCount = new System.Windows.Forms.Label();
            this.Btn_GoToReservations = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Label_ReservationCount = new System.Windows.Forms.Label();
            this.Label_Reservation = new System.Windows.Forms.Label();
            this.Panel_Availability = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Label_RoomUsedCount = new System.Windows.Forms.Label();
            this.Btn_GoToRooms = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_RoomAvailCount = new System.Windows.Forms.Label();
            this.Label_Availability = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatus_CurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GuestsSmall)).BeginInit();
            this.Panel_Reservation.SuspendLayout();
            this.Panel_Availability.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.Panel_DateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Btn_Rooms);
            this.panel1.Controls.Add(this.Btn_Reservations);
            this.panel1.Controls.Add(this.Btn_Guests);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Panel_Reservation);
            this.panel1.Controls.Add(this.Panel_Availability);
            this.panel1.Location = new System.Drawing.Point(22, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 454);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Rooms
            // 
            this.Btn_Rooms.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rooms.Location = new System.Drawing.Point(420, 13);
            this.Btn_Rooms.Name = "Btn_Rooms";
            this.Btn_Rooms.Size = new System.Drawing.Size(131, 49);
            this.Btn_Rooms.TabIndex = 29;
            this.Btn_Rooms.Text = "ROOMS";
            this.Btn_Rooms.UseVisualStyleBackColor = true;
            this.Btn_Rooms.Click += new System.EventHandler(this.Btn_Rooms_Click);
            // 
            // Btn_Reservations
            // 
            this.Btn_Reservations.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reservations.Location = new System.Drawing.Point(162, 13);
            this.Btn_Reservations.Name = "Btn_Reservations";
            this.Btn_Reservations.Size = new System.Drawing.Size(252, 49);
            this.Btn_Reservations.TabIndex = 28;
            this.Btn_Reservations.Text = "RESERVATIONS";
            this.Btn_Reservations.UseVisualStyleBackColor = true;
            this.Btn_Reservations.Click += new System.EventHandler(this.Btn_Reservations_Click);
            // 
            // Btn_Guests
            // 
            this.Btn_Guests.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guests.Location = new System.Drawing.Point(14, 13);
            this.Btn_Guests.Name = "Btn_Guests";
            this.Btn_Guests.Size = new System.Drawing.Size(142, 49);
            this.Btn_Guests.TabIndex = 24;
            this.Btn_Guests.Text = "GUESTS";
            this.Btn_Guests.UseVisualStyleBackColor = true;
            this.Btn_Guests.Click += new System.EventHandler(this.Btn_Guests_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Label_GuestCount);
            this.panel2.Controls.Add(this.Dgv_GuestsSmall);
            this.panel2.Controls.Add(this.Btn_GoToGuests);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(560, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 425);
            this.panel2.TabIndex = 27;
            // 
            // Label_GuestCount
            // 
            this.Label_GuestCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_GuestCount.AutoSize = true;
            this.Label_GuestCount.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GuestCount.Location = new System.Drawing.Point(3, 357);
            this.Label_GuestCount.Name = "Label_GuestCount";
            this.Label_GuestCount.Size = new System.Drawing.Size(229, 25);
            this.Label_GuestCount.TabIndex = 29;
            this.Label_GuestCount.Text = "No. of Current Guests: ";
            // 
            // Dgv_GuestsSmall
            // 
            this.Dgv_GuestsSmall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_GuestsSmall.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_GuestsSmall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_GuestsSmall.Location = new System.Drawing.Point(9, 48);
            this.Dgv_GuestsSmall.Name = "Dgv_GuestsSmall";
            this.Dgv_GuestsSmall.Size = new System.Drawing.Size(249, 306);
            this.Dgv_GuestsSmall.TabIndex = 25;
            // 
            // Btn_GoToGuests
            // 
            this.Btn_GoToGuests.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GoToGuests.Location = new System.Drawing.Point(8, 386);
            this.Btn_GoToGuests.Name = "Btn_GoToGuests";
            this.Btn_GoToGuests.Size = new System.Drawing.Size(255, 32);
            this.Btn_GoToGuests.TabIndex = 24;
            this.Btn_GoToGuests.Text = "Go to Guests";
            this.Btn_GoToGuests.UseVisualStyleBackColor = true;
            this.Btn_GoToGuests.Click += new System.EventHandler(this.Btn_GoToGuests_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Recently Visiting Guests";
            // 
            // Panel_Reservation
            // 
            this.Panel_Reservation.BackColor = System.Drawing.Color.White;
            this.Panel_Reservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Reservation.Controls.Add(this.label4);
            this.Panel_Reservation.Controls.Add(this.Label_CheckOutCount);
            this.Panel_Reservation.Controls.Add(this.label2);
            this.Panel_Reservation.Controls.Add(this.Label_CheckInCount);
            this.Panel_Reservation.Controls.Add(this.Btn_GoToReservations);
            this.Panel_Reservation.Controls.Add(this.label5);
            this.Panel_Reservation.Controls.Add(this.Label_ReservationCount);
            this.Panel_Reservation.Controls.Add(this.Label_Reservation);
            this.Panel_Reservation.Location = new System.Drawing.Point(14, 267);
            this.Panel_Reservation.Name = "Panel_Reservation";
            this.Panel_Reservation.Size = new System.Drawing.Size(537, 171);
            this.Panel_Reservation.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Checked Out";
            // 
            // Label_CheckOutCount
            // 
            this.Label_CheckOutCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_CheckOutCount.AutoSize = true;
            this.Label_CheckOutCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CheckOutCount.Location = new System.Drawing.Point(397, 46);
            this.Label_CheckOutCount.Name = "Label_CheckOutCount";
            this.Label_CheckOutCount.Size = new System.Drawing.Size(34, 39);
            this.Label_CheckOutCount.TabIndex = 24;
            this.Label_CheckOutCount.Text = "2";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Checked In";
            // 
            // Label_CheckInCount
            // 
            this.Label_CheckInCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_CheckInCount.AutoSize = true;
            this.Label_CheckInCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CheckInCount.Location = new System.Drawing.Point(244, 46);
            this.Label_CheckInCount.Name = "Label_CheckInCount";
            this.Label_CheckInCount.Size = new System.Drawing.Size(35, 39);
            this.Label_CheckInCount.TabIndex = 22;
            this.Label_CheckInCount.Text = "4";
            // 
            // Btn_GoToReservations
            // 
            this.Btn_GoToReservations.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GoToReservations.Location = new System.Drawing.Point(21, 132);
            this.Btn_GoToReservations.Name = "Btn_GoToReservations";
            this.Btn_GoToReservations.Size = new System.Drawing.Size(495, 32);
            this.Btn_GoToReservations.TabIndex = 21;
            this.Btn_GoToReservations.Text = "Go to Reservations";
            this.Btn_GoToReservations.UseVisualStyleBackColor = true;
            this.Btn_GoToReservations.Click += new System.EventHandler(this.Btn_GoToReservations_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Reservations";
            // 
            // Label_ReservationCount
            // 
            this.Label_ReservationCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_ReservationCount.AutoSize = true;
            this.Label_ReservationCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ReservationCount.Location = new System.Drawing.Point(87, 48);
            this.Label_ReservationCount.Name = "Label_ReservationCount";
            this.Label_ReservationCount.Size = new System.Drawing.Size(35, 39);
            this.Label_ReservationCount.TabIndex = 19;
            this.Label_ReservationCount.Text = "4";
            // 
            // Label_Reservation
            // 
            this.Label_Reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Reservation.AutoSize = true;
            this.Label_Reservation.Font = new System.Drawing.Font("Bahnschrift", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Reservation.Location = new System.Drawing.Point(19, 14);
            this.Label_Reservation.Name = "Label_Reservation";
            this.Label_Reservation.Size = new System.Drawing.Size(136, 25);
            this.Label_Reservation.TabIndex = 18;
            this.Label_Reservation.Text = "Reservations";
            // 
            // Panel_Availability
            // 
            this.Panel_Availability.BackColor = System.Drawing.Color.White;
            this.Panel_Availability.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Availability.Controls.Add(this.label8);
            this.Panel_Availability.Controls.Add(this.Label_RoomUsedCount);
            this.Panel_Availability.Controls.Add(this.Btn_GoToRooms);
            this.Panel_Availability.Controls.Add(this.label1);
            this.Panel_Availability.Controls.Add(this.Label_RoomAvailCount);
            this.Panel_Availability.Controls.Add(this.Label_Availability);
            this.Panel_Availability.Location = new System.Drawing.Point(14, 68);
            this.Panel_Availability.Name = "Panel_Availability";
            this.Panel_Availability.Size = new System.Drawing.Size(537, 171);
            this.Panel_Availability.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "No. of Occupied Rooms";
            // 
            // Label_RoomUsedCount
            // 
            this.Label_RoomUsedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_RoomUsedCount.AutoSize = true;
            this.Label_RoomUsedCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomUsedCount.Location = new System.Drawing.Point(346, 50);
            this.Label_RoomUsedCount.Name = "Label_RoomUsedCount";
            this.Label_RoomUsedCount.Size = new System.Drawing.Size(35, 39);
            this.Label_RoomUsedCount.TabIndex = 22;
            this.Label_RoomUsedCount.Text = "0";
            // 
            // Btn_GoToRooms
            // 
            this.Btn_GoToRooms.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GoToRooms.Location = new System.Drawing.Point(21, 132);
            this.Btn_GoToRooms.Name = "Btn_GoToRooms";
            this.Btn_GoToRooms.Size = new System.Drawing.Size(495, 32);
            this.Btn_GoToRooms.TabIndex = 21;
            this.Btn_GoToRooms.Text = "Go to Rooms";
            this.Btn_GoToRooms.UseVisualStyleBackColor = true;
            this.Btn_GoToRooms.Click += new System.EventHandler(this.Btn_GoToRooms_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "No. of Available Rooms";
            // 
            // Label_RoomAvailCount
            // 
            this.Label_RoomAvailCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_RoomAvailCount.AutoSize = true;
            this.Label_RoomAvailCount.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RoomAvailCount.Location = new System.Drawing.Point(105, 50);
            this.Label_RoomAvailCount.Name = "Label_RoomAvailCount";
            this.Label_RoomAvailCount.Size = new System.Drawing.Size(35, 39);
            this.Label_RoomAvailCount.TabIndex = 19;
            this.Label_RoomAvailCount.Text = "0";
            // 
            // Label_Availability
            // 
            this.Label_Availability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Availability.AutoSize = true;
            this.Label_Availability.Font = new System.Drawing.Font("Bahnschrift", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Availability.Location = new System.Drawing.Point(18, 12);
            this.Label_Availability.Name = "Label_Availability";
            this.Label_Availability.Size = new System.Drawing.Size(114, 25);
            this.Label_Availability.TabIndex = 18;
            this.Label_Availability.Text = "Availability";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::HotelReservationSystem.Properties.Resources.hoteldbsyslogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(273, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 142);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatus_CurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(885, 28);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatus_CurrentUser
            // 
            this.ToolStripStatus_CurrentUser.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatus_CurrentUser.Name = "ToolStripStatus_CurrentUser";
            this.ToolStripStatus_CurrentUser.Size = new System.Drawing.Size(124, 23);
            this.ToolStripStatus_CurrentUser.Text = "Current User:";
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // Panel_DateTime
            // 
            this.Panel_DateTime.BackColor = System.Drawing.Color.Cyan;
            this.Panel_DateTime.Controls.Add(this.Label_Calendar);
            this.Panel_DateTime.Controls.Add(this.Label_Clock);
            this.Panel_DateTime.Location = new System.Drawing.Point(12, 12);
            this.Panel_DateTime.Name = "Panel_DateTime";
            this.Panel_DateTime.Size = new System.Drawing.Size(255, 62);
            this.Panel_DateTime.TabIndex = 30;
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
            // Form_Dashboard_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(885, 658);
            this.Controls.Add(this.Panel_DateTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Dashboard_Staff";
            this.Text = "Form_Dashboard_Staff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Dashboard_Staff_FormClosed);
            this.Load += new System.EventHandler(this.Form_Dashboard_Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GuestsSmall)).EndInit();
            this.Panel_Reservation.ResumeLayout(false);
            this.Panel_Reservation.PerformLayout();
            this.Panel_Availability.ResumeLayout(false);
            this.Panel_Availability.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_Reservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_CheckOutCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_CheckInCount;
        private System.Windows.Forms.Button Btn_GoToReservations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label_ReservationCount;
        private System.Windows.Forms.Label Label_Reservation;
        private System.Windows.Forms.Panel Panel_Availability;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Label_RoomUsedCount;
        private System.Windows.Forms.Button Btn_GoToRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_RoomAvailCount;
        private System.Windows.Forms.Label Label_Availability;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label_GuestCount;
        private System.Windows.Forms.DataGridView Dgv_GuestsSmall;
        private System.Windows.Forms.Button Btn_GoToGuests;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_Guests;
        private System.Windows.Forms.Button Btn_Reservations;
        private System.Windows.Forms.Button Btn_Rooms;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatus_CurrentUser;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Label Label_Clock;
    }
}