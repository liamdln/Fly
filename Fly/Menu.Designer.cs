namespace Fly
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pb_ticket_collect = new System.Windows.Forms.PictureBox();
            this.pb_book = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ticket_collect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_ticket_collect
            // 
            this.pb_ticket_collect.Location = new System.Drawing.Point(331, 149);
            this.pb_ticket_collect.Name = "pb_ticket_collect";
            this.pb_ticket_collect.Size = new System.Drawing.Size(300, 300);
            this.pb_ticket_collect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_ticket_collect.TabIndex = 12;
            this.pb_ticket_collect.TabStop = false;
            this.pb_ticket_collect.Click += new System.EventHandler(this.pb_ticket_collect_Click);
            // 
            // pb_book
            // 
            this.pb_book.Location = new System.Drawing.Point(13, 150);
            this.pb_book.Name = "pb_book";
            this.pb_book.Size = new System.Drawing.Size(300, 300);
            this.pb_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_book.TabIndex = 11;
            this.pb_book.TabStop = false;
            this.pb_book.Click += new System.EventHandler(this.pb_book_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Location = new System.Drawing.Point(12, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(619, 131);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_logo.TabIndex = 10;
            this.pb_logo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 460);
            this.ControlBox = false;
            this.Controls.Add(this.pb_ticket_collect);
            this.Controls.Add(this.pb_book);
            this.Controls.Add(this.pb_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ticket_collect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_ticket_collect;
        private System.Windows.Forms.PictureBox pb_book;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}

