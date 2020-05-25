using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR
{
    public partial class Form1 : Form
    {
        int wynik=0;
        //int predkosc;
        bool skok;
        int g;
        
        public Form1()
        {
            InitializeComponent();
        }

        void kontrolaSkoku()
        {
            //gracz.Top += predkosc;
            if (skok && g <0)
            { 
                skok = false;
            }
            else if (skok)
            {
               // gracz.Top = predkosc;
                g -= 20;
            }
            else
            {

                //predkosc = 5;
                g = 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                gracz.Image = Properties.Resources.ruchwprawo;
                gracz.Left += 10;
            }
            if (e.KeyCode == Keys.Left)
            { 
                gracz.Left -= 10; 
            }
            if (e.KeyCode == Keys.Space && !skok)
            {
                gracz.Image = Properties.Resources.ruchwprawo3;
                skok = true;
            }

        }
        void kontrolaPieniedzy()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag=="money")
                {
                    money.Top = pictureBox12.Width;
                    Random rnd = new Random();
                    int a;
                    if (x.Left < -900)
                    {
                        //x.Left -= predkosc;
                        a = rnd.Next(1000);
                        x.Location = new Point(a, 200);
                    }
                    else if (gracz.Bounds.IntersectsWith(x.Bounds))
                    {
                        a = rnd.Next(1000);
                        x.Location = new Point(a, 100);
                        wynik += 1;
                        label1.Text = "Wynik: " + wynik;
                    }
                    else
                    {
                        //x.Left -= predkosc;
                    }
                }
            }
        }
        void koniecGry()
        {
            if (gracz.Top + gracz.Height > this.ClientSize.Height)
            {
                label1.Text = "Wynik: " + wynik + "\n\n\n\n\n\n\n Koniec Gry";
                //MessageBox.Show("Porażka! Koniec gry." + Environment.NewLine + "Wcisnij OK, aby zagrac jeszcze raz");
                timer1.Stop();
            }
        }
        private void Restart()
        {
            Form1 noweOkno = new Form1();
            noweOkno.Show();
            this.Hide();
        }
        void kontrolaPlatform()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag=="platform")
                {
                    if (x.Left <-200)
                    {
                        x.Left = 900;
                    }
                    else if (gracz.Bounds.IntersectsWith(x.Bounds))
                    {
                        gracz.Top = x.Top - gracz.Height;
                    }
                    else if (gracz.Bounds.IntersectsWith(Final.Bounds))
                    {
                        gracz.Size = new Size(50, 50);
                        gracz.Top = Final.Top - gracz.Height;
                        //predkosc = 0;
                    }
                    else
                    {
                        //x.Left -= predkosc;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kontrolaSkoku();
            kontrolaPlatform();
            kontrolaPieniedzy();
            koniecGry();
        }
       
    }
}
