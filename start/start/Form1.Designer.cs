namespace start
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screen = new System.Windows.Forms.Panel();
            this.Baza = new System.Windows.Forms.Panel();
            this.rywal = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.finish = new System.Windows.Forms.PictureBox();
            this.przeszkoda = new System.Windows.Forms.PictureBox();
            this.zdobycz = new System.Windows.Forms.PictureBox();
            this.gracz = new System.Windows.Forms.PictureBox();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rywal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdobycz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.RosyBrown;
            this.screen.Controls.Add(this.rywal);
            this.screen.Controls.Add(this.pictureBox1);
            this.screen.Controls.Add(this.finish);
            this.screen.Controls.Add(this.przeszkoda);
            this.screen.Controls.Add(this.zdobycz);
            this.screen.Controls.Add(this.gracz);
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(982, 438);
            this.screen.TabIndex = 0;
            // 
            // Baza
            // 
            this.Baza.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Baza.Location = new System.Drawing.Point(0, 435);
            this.Baza.Name = "Baza";
            this.Baza.Size = new System.Drawing.Size(982, 71);
            this.Baza.TabIndex = 1;
            // 
            // rywal
            // 
            this.rywal.Image = global::start.Properties.Resources.zlo;
            this.rywal.Location = new System.Drawing.Point(596, 359);
            this.rywal.Name = "rywal";
            this.rywal.Size = new System.Drawing.Size(84, 76);
            this.rywal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rywal.TabIndex = 5;
            this.rywal.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::start.Properties.Resources.przeszkoda;
            this.pictureBox1.Location = new System.Drawing.Point(837, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // finish
            // 
            this.finish.Image = global::start.Properties.Resources.meta;
            this.finish.Location = new System.Drawing.Point(800, 72);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(182, 85);
            this.finish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finish.TabIndex = 3;
            this.finish.TabStop = false;
            // 
            // przeszkoda
            // 
            this.przeszkoda.Image = global::start.Properties.Resources.przeszkoda;
            this.przeszkoda.Location = new System.Drawing.Point(285, 283);
            this.przeszkoda.Name = "przeszkoda";
            this.przeszkoda.Size = new System.Drawing.Size(100, 155);
            this.przeszkoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.przeszkoda.TabIndex = 2;
            this.przeszkoda.TabStop = false;
            // 
            // zdobycz
            // 
            this.zdobycz.Image = global::start.Properties.Resources.pieniadz;
            this.zdobycz.Location = new System.Drawing.Point(444, 370);
            this.zdobycz.Name = "zdobycz";
            this.zdobycz.Size = new System.Drawing.Size(80, 40);
            this.zdobycz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zdobycz.TabIndex = 1;
            this.zdobycz.TabStop = false;
            // 
            // gracz
            // 
            this.gracz.Image = ((System.Drawing.Image)(resources.GetObject("gracz.Image")));
            this.gracz.Location = new System.Drawing.Point(0, 376);
            this.gracz.Name = "gracz";
            this.gracz.Size = new System.Drawing.Size(67, 62);
            this.gracz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gracz.TabIndex = 0;
            this.gracz.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.Baza);
            this.Controls.Add(this.screen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rywal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdobycz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox gracz;
        private System.Windows.Forms.Panel Baza;
        private System.Windows.Forms.PictureBox przeszkoda;
        private System.Windows.Forms.PictureBox zdobycz;
        private System.Windows.Forms.PictureBox rywal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox finish;
    }
}

