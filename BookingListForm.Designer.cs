namespace Fly
{
    partial class BookingListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingListForm));
            this.lbl_results = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.FlightTimesDropDown = new System.Windows.Forms.ComboBox();
            this.lbl_airline = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.groupbox_flight = new System.Windows.Forms.GroupBox();
            this.lbl_avDate = new System.Windows.Forms.Label();
            this.lbl_avAirline = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_seatsAvailable = new System.Windows.Forms.Label();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.lbl_origin = new System.Windows.Forms.Label();
            this.lbl_flightno = new System.Windows.Forms.Label();
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupbox_flight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_results
            // 
            this.lbl_results.AutoSize = true;
            this.lbl_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.lbl_results.Location = new System.Drawing.Point(12, 9);
            this.lbl_results.Name = "lbl_results";
            this.lbl_results.Size = new System.Drawing.Size(264, 29);
            this.lbl_results.TabIndex = 0;
            this.lbl_results.Text = "Here are your results:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_time.Location = new System.Drawing.Point(13, 50);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(105, 20);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "Select a time:";
            // 
            // FlightTimesDropDown
            // 
            this.FlightTimesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlightTimesDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightTimesDropDown.FormattingEnabled = true;
            this.FlightTimesDropDown.Location = new System.Drawing.Point(17, 74);
            this.FlightTimesDropDown.Name = "FlightTimesDropDown";
            this.FlightTimesDropDown.Size = new System.Drawing.Size(169, 26);
            this.FlightTimesDropDown.TabIndex = 2;
            this.FlightTimesDropDown.SelectedIndexChanged += new System.EventHandler(this.dropdown_times_SelectedIndexChanged);
            // 
            // lbl_airline
            // 
            this.lbl_airline.AutoSize = true;
            this.lbl_airline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_airline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_airline.Location = new System.Drawing.Point(272, 50);
            this.lbl_airline.Name = "lbl_airline";
            this.lbl_airline.Size = new System.Drawing.Size(60, 20);
            this.lbl_airline.TabIndex = 3;
            this.lbl_airline.Text = "Airline: ";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_date.Location = new System.Drawing.Point(272, 70);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(48, 20);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "Date:";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_from.Location = new System.Drawing.Point(272, 90);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(54, 20);
            this.lbl_from.TabIndex = 5;
            this.lbl_from.Text = "Origin:";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_to.Location = new System.Drawing.Point(272, 110);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(94, 20);
            this.lbl_to.TabIndex = 6;
            this.lbl_to.Text = "Destination:";
            // 
            // groupbox_flight
            // 
            this.groupbox_flight.Controls.Add(this.lbl_avDate);
            this.groupbox_flight.Controls.Add(this.lbl_avAirline);
            this.groupbox_flight.Controls.Add(this.lbl_price);
            this.groupbox_flight.Controls.Add(this.lbl_seatsAvailable);
            this.groupbox_flight.Controls.Add(this.lbl_destination);
            this.groupbox_flight.Controls.Add(this.lbl_origin);
            this.groupbox_flight.Controls.Add(this.lbl_flightno);
            this.groupbox_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_flight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.groupbox_flight.Location = new System.Drawing.Point(17, 147);
            this.groupbox_flight.Name = "groupbox_flight";
            this.groupbox_flight.Size = new System.Drawing.Size(444, 160);
            this.groupbox_flight.TabIndex = 10;
            this.groupbox_flight.TabStop = false;
            this.groupbox_flight.Text = "Selected Flight";
            // 
            // lbl_avDate
            // 
            this.lbl_avDate.AutoSize = true;
            this.lbl_avDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avDate.Location = new System.Drawing.Point(6, 134);
            this.lbl_avDate.Name = "lbl_avDate";
            this.lbl_avDate.Size = new System.Drawing.Size(43, 18);
            this.lbl_avDate.TabIndex = 6;
            this.lbl_avDate.Text = "Date:";
            // 
            // lbl_avAirline
            // 
            this.lbl_avAirline.AutoSize = true;
            this.lbl_avAirline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avAirline.Location = new System.Drawing.Point(7, 116);
            this.lbl_avAirline.Name = "lbl_avAirline";
            this.lbl_avAirline.Size = new System.Drawing.Size(51, 18);
            this.lbl_avAirline.TabIndex = 5;
            this.lbl_avAirline.Text = "Airline:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(7, 98);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(46, 18);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price:";
            // 
            // lbl_seatsAvailable
            // 
            this.lbl_seatsAvailable.AutoSize = true;
            this.lbl_seatsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seatsAvailable.Location = new System.Drawing.Point(7, 80);
            this.lbl_seatsAvailable.Name = "lbl_seatsAvailable";
            this.lbl_seatsAvailable.Size = new System.Drawing.Size(110, 18);
            this.lbl_seatsAvailable.TabIndex = 3;
            this.lbl_seatsAvailable.Text = "Seats available:";
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destination.Location = new System.Drawing.Point(7, 62);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(122, 18);
            this.lbl_destination.TabIndex = 2;
            this.lbl_destination.Text = "Flight destination:";
            // 
            // lbl_origin
            // 
            this.lbl_origin.AutoSize = true;
            this.lbl_origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_origin.Location = new System.Drawing.Point(7, 44);
            this.lbl_origin.Name = "lbl_origin";
            this.lbl_origin.Size = new System.Drawing.Size(87, 18);
            this.lbl_origin.TabIndex = 1;
            this.lbl_origin.Text = "Flight origin:";
            // 
            // lbl_flightno
            // 
            this.lbl_flightno.AutoSize = true;
            this.lbl_flightno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flightno.Location = new System.Drawing.Point(7, 26);
            this.lbl_flightno.Name = "lbl_flightno";
            this.lbl_flightno.Size = new System.Drawing.Size(65, 18);
            this.lbl_flightno.TabIndex = 0;
            this.lbl_flightno.Text = "Flight ID:";
            // 
            // btn_book
            // 
            this.btn_book.BackColor = System.Drawing.Color.White;
            this.btn_book.FlatAppearance.BorderSize = 0;
            this.btn_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.btn_book.Location = new System.Drawing.Point(17, 313);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(444, 55);
            this.btn_book.TabIndex = 14;
            this.btn_book.Text = "Book selected flight";
            this.btn_book.UseVisualStyleBackColor = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.btn_cancel.Location = new System.Drawing.Point(17, 106);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(169, 35);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Back";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // BookingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 379);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.groupbox_flight);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_airline);
            this.Controls.Add(this.FlightTimesDropDown);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_results);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.listingBookingForm_Load);
            this.groupbox_flight.ResumeLayout(false);
            this.groupbox_flight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_results;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.ComboBox FlightTimesDropDown;
        private System.Windows.Forms.Label lbl_airline;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.GroupBox groupbox_flight;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Label lbl_avDate;
        private System.Windows.Forms.Label lbl_avAirline;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_seatsAvailable;
        private System.Windows.Forms.Label lbl_destination;
        private System.Windows.Forms.Label lbl_origin;
        private System.Windows.Forms.Label lbl_flightno;
        private System.Windows.Forms.Button btn_cancel;
    }
}