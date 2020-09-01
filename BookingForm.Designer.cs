namespace Fly
{
    partial class BookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.lbl_book = new System.Windows.Forms.Label();
            this.dropdown_destination = new System.Windows.Forms.ComboBox();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.lbl_origin = new System.Windows.Forms.Label();
            this.dropdown_origin = new System.Windows.Forms.ComboBox();
            this.lbl_ast = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.flightDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_book
            // 
            this.lbl_book.AutoSize = true;
            this.lbl_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.lbl_book.Location = new System.Drawing.Point(9, 9);
            this.lbl_book.Name = "lbl_book";
            this.lbl_book.Size = new System.Drawing.Size(236, 42);
            this.lbl_book.TabIndex = 0;
            this.lbl_book.Text = "Book a flight";
            // 
            // dropdown_destination
            // 
            this.dropdown_destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_destination.FormattingEnabled = true;
            this.dropdown_destination.Location = new System.Drawing.Point(12, 156);
            this.dropdown_destination.Name = "dropdown_destination";
            this.dropdown_destination.Size = new System.Drawing.Size(226, 28);
            this.dropdown_destination.TabIndex = 1;
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_destination.Location = new System.Drawing.Point(8, 129);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(169, 24);
            this.lbl_destination.TabIndex = 2;
            this.lbl_destination.Text = "*Select destination:";
            // 
            // lbl_origin
            // 
            this.lbl_origin.AutoSize = true;
            this.lbl_origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_origin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_origin.Location = new System.Drawing.Point(8, 71);
            this.lbl_origin.Name = "lbl_origin";
            this.lbl_origin.Size = new System.Drawing.Size(126, 24);
            this.lbl_origin.TabIndex = 3;
            this.lbl_origin.Text = "*Select origin:";
            // 
            // dropdown_origin
            // 
            this.dropdown_origin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_origin.FormattingEnabled = true;
            this.dropdown_origin.Location = new System.Drawing.Point(12, 98);
            this.dropdown_origin.Name = "dropdown_origin";
            this.dropdown_origin.Size = new System.Drawing.Size(226, 28);
            this.dropdown_origin.TabIndex = 4;
            // 
            // lbl_ast
            // 
            this.lbl_ast.AutoSize = true;
            this.lbl_ast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_ast.Location = new System.Drawing.Point(5, 255);
            this.lbl_ast.Name = "lbl_ast";
            this.lbl_ast.Size = new System.Drawing.Size(66, 13);
            this.lbl_ast.TabIndex = 5;
            this.lbl_ast.Text = "* = Required";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.btn_search.Location = new System.Drawing.Point(244, 129);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 55);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.btn_cancel.Location = new System.Drawing.Point(244, 190);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 55);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_date.Location = new System.Drawing.Point(8, 187);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(60, 24);
            this.lbl_date.TabIndex = 12;
            this.lbl_date.Text = "*Date:";
            // 
            // flightDate
            // 
            this.flightDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightDate.Location = new System.Drawing.Point(12, 215);
            this.flightDate.Name = "flightDate";
            this.flightDate.Size = new System.Drawing.Size(222, 26);
            this.flightDate.TabIndex = 13;
            // 
            // form_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 281);
            this.ControlBox = false;
            this.Controls.Add(this.flightDate);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_ast);
            this.Controls.Add(this.dropdown_origin);
            this.Controls.Add(this.lbl_origin);
            this.Controls.Add(this.lbl_destination);
            this.Controls.Add(this.dropdown_destination);
            this.Controls.Add(this.lbl_book);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form_book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_book;
        private System.Windows.Forms.ComboBox dropdown_destination;
        private System.Windows.Forms.Label lbl_destination;
        private System.Windows.Forms.Label lbl_origin;
        private System.Windows.Forms.ComboBox dropdown_origin;
        private System.Windows.Forms.Label lbl_ast;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker flightDate;
    }
}