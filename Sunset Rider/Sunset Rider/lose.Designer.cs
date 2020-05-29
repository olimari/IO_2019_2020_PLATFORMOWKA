namespace Sunset_Rider
{
    partial class lose
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
            this.menu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Image = global::Sunset_Rider.Properties.Resources.home1;
            this.menu.Location = new System.Drawing.Point(108, 250);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(100, 100);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu.TabIndex = 0;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Sunset_Rider.Properties.Resources.restart1;
            this.pictureBox1.Location = new System.Drawing.Point(266, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sunset_Rider.Properties.Resources.lose;
            this.ClientSize = new System.Drawing.Size(474, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}