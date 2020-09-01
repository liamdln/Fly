namespace Fly
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btnCollectTicket = new System.Windows.Forms.PictureBox();
            this.btnBookTicket = new System.Windows.Forms.PictureBox();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnCollectTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBookTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCollectTicket
            // 
            this.btnCollectTicket.Location = new System.Drawing.Point(331, 149);
            this.btnCollectTicket.Name = "btnCollectTicket";
            this.btnCollectTicket.Size = new System.Drawing.Size(300, 300);
            this.btnCollectTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCollectTicket.TabIndex = 12;
            this.btnCollectTicket.TabStop = false;
            this.btnCollectTicket.Click += new System.EventHandler(this.pb_ticket_collect_Click);
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Location = new System.Drawing.Point(13, 150);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(300, 300);
            this.btnBookTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBookTicket.TabIndex = 11;
            this.btnBookTicket.TabStop = false;
            this.btnBookTicket.Click += new System.EventHandler(this.pb_book_Click);
            // 
            // picboxLogo
            // 
            this.picboxLogo.Location = new System.Drawing.Point(12, 12);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(619, 131);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxLogo.TabIndex = 10;
            this.picboxLogo.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(314, 70);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 460);
            this.ControlBox = false;
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCollectTicket);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.picboxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCollectTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBookTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCollectTicket;
        private System.Windows.Forms.PictureBox btnBookTicket;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Button btnTest;
    }
}

