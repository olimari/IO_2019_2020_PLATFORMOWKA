namespace Sunset_Rider
{
    partial class menu
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.levels = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newgame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newgame)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::Sunset_Rider.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(69, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(345, 185);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // levels
            // 
            this.levels.BackColor = System.Drawing.Color.Transparent;
            this.levels.Image = global::Sunset_Rider.Properties.Resources.levels;
            this.levels.Location = new System.Drawing.Point(249, 239);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(200, 90);
            this.levels.TabIndex = 5;
            this.levels.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Sunset_Rider.Properties.Resources.help;
            this.pictureBox1.Location = new System.Drawing.Point(135, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 90);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // newgame
            // 
            this.newgame.BackColor = System.Drawing.Color.Transparent;
            this.newgame.Image = global::Sunset_Rider.Properties.Resources.newgame1;
            this.newgame.Location = new System.Drawing.Point(43, 239);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(200, 90);
            this.newgame.TabIndex = 8;
            this.newgame.TabStop = false;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Sunset_Rider.Properties.Resources.menubg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunset Rider";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newgame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox levels;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox newgame;
    }
}