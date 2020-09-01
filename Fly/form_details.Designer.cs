namespace Fly
{
    partial class form_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_details));
            this.lbl_detailsTitle = new System.Windows.Forms.Label();
            this.lbl_ticketID = new System.Windows.Forms.Label();
            this.txtBox_ticketNumber = new System.Windows.Forms.TextBox();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_cardNumber = new System.Windows.Forms.Label();
            this.txtBox_cardNumber = new System.Windows.Forms.TextBox();
            this.txtBox_lastName = new System.Windows.Forms.TextBox();
            this.txtBox_firstName = new System.Windows.Forms.TextBox();
            this.btn_printTicket = new System.Windows.Forms.Button();
            this.btn_saveTicket = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_detailsTitle
            // 
            this.lbl_detailsTitle.AutoSize = true;
            this.lbl_detailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.lbl_detailsTitle.Location = new System.Drawing.Point(8, 9);
            this.lbl_detailsTitle.Name = "lbl_detailsTitle";
            this.lbl_detailsTitle.Size = new System.Drawing.Size(465, 42);
            this.lbl_detailsTitle.TabIndex = 0;
            this.lbl_detailsTitle.Text = "Please enter your details:";
            // 
            // lbl_ticketID
            // 
            this.lbl_ticketID.AutoSize = true;
            this.lbl_ticketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ticketID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_ticketID.Location = new System.Drawing.Point(12, 69);
            this.lbl_ticketID.Name = "lbl_ticketID";
            this.lbl_ticketID.Size = new System.Drawing.Size(76, 20);
            this.lbl_ticketID.TabIndex = 1;
            this.lbl_ticketID.Text = "Ticket ID:";
            // 
            // txtBox_ticketNumber
            // 
            this.txtBox_ticketNumber.Location = new System.Drawing.Point(158, 69);
            this.txtBox_ticketNumber.Name = "txtBox_ticketNumber";
            this.txtBox_ticketNumber.Size = new System.Drawing.Size(306, 20);
            this.txtBox_ticketNumber.TabIndex = 1;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_firstName.Location = new System.Drawing.Point(12, 98);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(90, 20);
            this.lbl_firstName.TabIndex = 3;
            this.lbl_firstName.Text = "First Name:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_lastName.Location = new System.Drawing.Point(12, 124);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(90, 20);
            this.lbl_lastName.TabIndex = 4;
            this.lbl_lastName.Text = "Last Name:";
            // 
            // lbl_cardNumber
            // 
            this.lbl_cardNumber.AutoSize = true;
            this.lbl_cardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cardNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_cardNumber.Location = new System.Drawing.Point(12, 150);
            this.lbl_cardNumber.Name = "lbl_cardNumber";
            this.lbl_cardNumber.Size = new System.Drawing.Size(107, 20);
            this.lbl_cardNumber.TabIndex = 5;
            this.lbl_cardNumber.Text = "Card Number:";
            // 
            // txtBox_cardNumber
            // 
            this.txtBox_cardNumber.Location = new System.Drawing.Point(158, 150);
            this.txtBox_cardNumber.Name = "txtBox_cardNumber";
            this.txtBox_cardNumber.Size = new System.Drawing.Size(306, 20);
            this.txtBox_cardNumber.TabIndex = 4;
            // 
            // txtBox_lastName
            // 
            this.txtBox_lastName.Location = new System.Drawing.Point(158, 124);
            this.txtBox_lastName.Name = "txtBox_lastName";
            this.txtBox_lastName.Size = new System.Drawing.Size(306, 20);
            this.txtBox_lastName.TabIndex = 3;
            // 
            // txtBox_firstName
            // 
            this.txtBox_firstName.Location = new System.Drawing.Point(158, 98);
            this.txtBox_firstName.Name = "txtBox_firstName";
            this.txtBox_firstName.Size = new System.Drawing.Size(306, 20);
            this.txtBox_firstName.TabIndex = 2;
            // 
            // btn_printTicket
            // 
            this.btn_printTicket.BackColor = System.Drawing.Color.White;
            this.btn_printTicket.FlatAppearance.BorderSize = 0;
            this.btn_printTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.btn_printTicket.Location = new System.Drawing.Point(158, 176);
            this.btn_printTicket.Name = "btn_printTicket";
            this.btn_printTicket.Size = new System.Drawing.Size(98, 55);
            this.btn_printTicket.TabIndex = 20;
            this.btn_printTicket.Text = "Print Ticket";
            this.btn_printTicket.UseVisualStyleBackColor = false;
            this.btn_printTicket.Click += new System.EventHandler(this.btn_printTicket_Click);
            // 
            // btn_saveTicket
            // 
            this.btn_saveTicket.BackColor = System.Drawing.Color.White;
            this.btn_saveTicket.FlatAppearance.BorderSize = 0;
            this.btn_saveTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.btn_saveTicket.Location = new System.Drawing.Point(262, 176);
            this.btn_saveTicket.Name = "btn_saveTicket";
            this.btn_saveTicket.Size = new System.Drawing.Size(98, 55);
            this.btn_saveTicket.TabIndex = 21;
            this.btn_saveTicket.Text = "Save Ticket";
            this.btn_saveTicket.UseVisualStyleBackColor = false;
            this.btn_saveTicket.Click += new System.EventHandler(this.btn_saveTicket_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.btn_cancel.Location = new System.Drawing.Point(366, 176);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 55);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // form_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 245);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_saveTicket);
            this.Controls.Add(this.btn_printTicket);
            this.Controls.Add(this.txtBox_firstName);
            this.Controls.Add(this.txtBox_lastName);
            this.Controls.Add(this.txtBox_cardNumber);
            this.Controls.Add(this.lbl_cardNumber);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.txtBox_ticketNumber);
            this.Controls.Add(this.lbl_ticketID);
            this.Controls.Add(this.lbl_detailsTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_details";
            this.Text = "form_details";
            this.Load += new System.EventHandler(this.form_details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_detailsTitle;
        private System.Windows.Forms.Label lbl_ticketID;
        private System.Windows.Forms.TextBox txtBox_ticketNumber;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_cardNumber;
        private System.Windows.Forms.TextBox txtBox_cardNumber;
        private System.Windows.Forms.TextBox txtBox_lastName;
        private System.Windows.Forms.TextBox txtBox_firstName;
        private System.Windows.Forms.Button btn_printTicket;
        private System.Windows.Forms.Button btn_saveTicket;
        private System.Windows.Forms.Button btn_cancel;
    }
}