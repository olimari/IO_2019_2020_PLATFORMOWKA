namespace Sunset_Rider
{
    partial class pauza
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
            this.backtomenu = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.restart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backtomenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).BeginInit();
            this.SuspendLayout();
            // 
            // backtomenu
            // 
            this.backtomenu.BackColor = System.Drawing.Color.Transparent;
            this.backtomenu.Image = global::Sunset_Rider.Properties.Resources.home;
            this.backtomenu.Location = new System.Drawing.Point(61, 188);
            this.backtomenu.Name = "backtomenu";
            this.backtomenu.Size = new System.Drawing.Size(100, 100);
            this.backtomenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backtomenu.TabIndex = 0;
            this.backtomenu.TabStop = false;
            this.backtomenu.Click += new System.EventHandler(this.backtomenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Sunset_Rider.Properties.Resources.resume;
            this.pictureBox2.Location = new System.Drawing.Point(167, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Transparent;
            this.restart.Image = global::Sunset_Rider.Properties.Resources.restart;
            this.restart.Location = new System.Drawing.Point(273, 188);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(100, 100);
            this.restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restart.TabIndex = 3;
            this.restart.TabStop = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // pauza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sunset_Rider.Properties.Resources.pausescreen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(435, 437);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.backtomenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pauza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pause";
            ((System.ComponentModel.ISupportInitialize)(this.backtomenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backtomenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox restart;
    }
}