namespace Fly
{
    partial class CollectTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectTicketForm));
            this.lbl_collect_ticket = new System.Windows.Forms.Label();
            this.lbl_ticketID = new System.Windows.Forms.Label();
            this.txt_ticketID = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.lbl_cardNo = new System.Windows.Forms.Label();
            this.txt_cardNo = new System.Windows.Forms.TextBox();
            this.btn_collect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_collect_ticket
            // 
            this.lbl_collect_ticket.AutoSize = true;
            this.lbl_collect_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_collect_ticket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.lbl_collect_ticket.Location = new System.Drawing.Point(12, 9);
            this.lbl_collect_ticket.Name = "lbl_collect_ticket";
            this.lbl_collect_ticket.Size = new System.Drawing.Size(243, 42);
            this.lbl_collect_ticket.TabIndex = 1;
            this.lbl_collect_ticket.Text = "Collect ticket";
            // 
            // lbl_ticketID
            // 
            this.lbl_ticketID.AutoSize = true;
            this.lbl_ticketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ticketID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_ticketID.Location = new System.Drawing.Point(15, 60);
            this.lbl_ticketID.Name = "lbl_ticketID";
            this.lbl_ticketID.Size = new System.Drawing.Size(87, 24);
            this.lbl_ticketID.TabIndex = 4;
            this.lbl_ticketID.Text = "Ticket ID:";
            // 
            // txt_ticketID
            // 
            this.txt_ticketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ticketID.Location = new System.Drawing.Point(19, 87);
            this.txt_ticketID.Name = "txt_ticketID";
            this.txt_ticketID.Size = new System.Drawing.Size(236, 26);
            this.txt_ticketID.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.btn_cancel.Location = new System.Drawing.Point(568, 231);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 55);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.btn_search.Location = new System.Drawing.Point(261, 87);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(107, 26);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_firstName.Location = new System.Drawing.Point(15, 116);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(106, 24);
            this.lbl_firstName.TabIndex = 13;
            this.lbl_firstName.Text = "First Name:";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.Location = new System.Drawing.Point(19, 143);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(236, 26);
            this.txt_firstName.TabIndex = 2;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_lastName.Location = new System.Drawing.Point(15, 172);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(104, 24);
            this.lbl_lastName.TabIndex = 15;
            this.lbl_lastName.Text = "Last Name:";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastName.Location = new System.Drawing.Point(19, 199);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(236, 26);
            this.txt_lastName.TabIndex = 3;
            // 
            // lbl_cardNo
            // 
            this.lbl_cardNo.AutoSize = true;
            this.lbl_cardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cardNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.lbl_cardNo.Location = new System.Drawing.Point(15, 228);
            this.lbl_cardNo.Name = "lbl_cardNo";
            this.lbl_cardNo.Size = new System.Drawing.Size(129, 24);
            this.lbl_cardNo.TabIndex = 17;
            this.lbl_cardNo.Text = "Card Number:";
            // 
            // txt_cardNo
            // 
            this.txt_cardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cardNo.Location = new System.Drawing.Point(19, 255);
            this.txt_cardNo.Name = "txt_cardNo";
            this.txt_cardNo.Size = new System.Drawing.Size(236, 26);
            this.txt_cardNo.TabIndex = 4;
            // 
            // btn_collect
            // 
            this.btn_collect.BackColor = System.Drawing.Color.White;
            this.btn_collect.FlatAppearance.BorderSize = 0;
            this.btn_collect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_collect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_collect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(223)))));
            this.btn_collect.Location = new System.Drawing.Point(464, 231);
            this.btn_collect.Name = "btn_collect";
            this.btn_collect.Size = new System.Drawing.Size(98, 55);
            this.btn_collect.TabIndex = 19;
            this.btn_collect.Text = "Collect";
            this.btn_collect.UseVisualStyleBackColor = false;
            this.btn_collect.Click += new System.EventHandler(this.btn_collect_Click);
            // 
            // form_collectTicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 298);
            this.ControlBox = false;
            this.Controls.Add(this.btn_collect);
            this.Controls.Add(this.txt_cardNo);
            this.Controls.Add(this.lbl_cardNo);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_ticketID);
            this.Controls.Add(this.lbl_ticketID);
            this.Controls.Add(this.lbl_collect_ticket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_collectTicker";
            this.Load += new System.EventHandler(this.form_collectTicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_collect_ticket;
        private System.Windows.Forms.Label lbl_ticketID;
        private System.Windows.Forms.TextBox txt_ticketID;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label lbl_cardNo;
        private System.Windows.Forms.TextBox txt_cardNo;
        private System.Windows.Forms.Button btn_collect;
    }
}