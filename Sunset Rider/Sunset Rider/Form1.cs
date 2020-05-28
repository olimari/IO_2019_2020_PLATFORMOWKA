using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Sunset_Rider
{
    public partial class Form1 : Form
    {

        static public bool pause = false;
        static public bool close = false;

        bool lewo;
        bool prawo;
        bool jump;
        bool maKlucz;

        int wynik = 0;


        int G = 8; //wysokosc skoku
        int force;


        int predkoscGracza = 10;


        bool gifIsNotLoaded = true; //instrukcja do pomocy obslugi animacji chodzenia
        bool facingRight = false;
        bool facingLeft = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (!pause)
            {
                txtScore.Text = "Wynik: " + wynik;

                if (prawo == true && gracz.Left + (gracz.Width + 60) < this.ClientSize.Width)
                {
                    gracz.Left += predkoscGracza;
                }

                if (lewo == true && gracz.Left > 60)
                {
                    gracz.Left -= predkoscGracza;
                }

                //spadanie jezeli gracz skoczyl

                if (jump == true)
                {
                    gracz.Top -= force;
                    force -= 1;
                }

                if (gracz.Top + gracz.Height >= gracz.Height)
                {
                    gracz.Top -= force;
                    force -= 1;
                    if (prawo == true)
                        gracz.Image = Image.FromFile("ruchwprawo3.png");
                    if (lewo == true)
                        gracz.Image = Image.FromFile("ruchwlewo3.png");
                }
                else
                {
                    gracz.Top += 5;
                }
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "platform")
                    {
                        if (gracz.Bounds.IntersectsWith(x.Bounds)  /* && jump ==false*/)
                        {
                            //G = 8;
                            gracz.Top = x.Top - gracz.Height;
                            //force = 0;
                            jump = false;
                        }

                        x.BringToFront();

                    }

                    if (x is PictureBox && (string)x.Tag == "money")
                    {
                        if (gracz.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            wynik++;
                        }
                    }
                }

                if (gracz.Bounds.IntersectsWith(klucz.Bounds))
                {
                    klucz.Visible = false;
                    maKlucz = true;
                }

                if (gracz.Bounds.IntersectsWith(portal.Bounds) && maKlucz == true)
                {
                    portal.Image = Properties.Resources.portalotwarty;
                    GameTimer.Stop();
                    MessageBox.Show("Brawo! Twoja gra zakończyła się sukcesem!" + Environment.NewLine + "Wcisnij OK, aby zagrac jeszcze raz");
                    //Restart();
                }
                if (gracz.Top + gracz.Height > this.ClientSize.Height)
                {
                    GameTimer.Stop();
                    MessageBox.Show("Porażka! Koniec gry." + Environment.NewLine + "Wcisnij OK, aby zagrac jeszcze raz");
                    //Restart();
                }
                if (close == true)
                {
                    this.Close();
                }
            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                facingLeft = false;
                prawo = true;
                facingRight = true;
                if (gifIsNotLoaded == true)
                {
                    gracz.Image = Image.FromFile("ruchwprawo.gif");
                    gifIsNotLoaded = false;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                facingRight = false;
                lewo = true;
                facingLeft = true;
                if (gifIsNotLoaded == true)
                {
                    gracz.Image = Image.FromFile("ruchwlewo.gif");
                    gifIsNotLoaded = false;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                pauza p = new pauza();
                pause = !pause;

                if (pause == true)
                {
                    p.ShowDialog();
                    //GameTimer.Stop();
                }

                if(pauza.formclose == true)
                {
                    pauza.formclose = false;
                    this.Hide();

                    menu m = new menu();
                    m.ShowDialog();
                }
                if(pauza.formrestart == true)
                {
                    pauza.formrestart = false;
                    Restart();
                }

            }

            if (jump != true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    jump = true;
                    force = G;
                    if (facingRight == true)
                    {
                        gracz.Image = Image.FromFile("ruchwprawo3.png");
                    }

                    if (facingLeft == true)
                    {
                        gracz.Image = Image.FromFile("ruchwlewo3.png");
                    }
                }
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            gifIsNotLoaded = true;
            if (e.KeyCode == Keys.Right)
            {
                prawo = false;
                if (jump != true)
                    gracz.Image = Image.FromFile("ruchwprawo2.gif");
            }
            if (e.KeyCode == Keys.Left)
            {
                lewo = false;
                if (jump != true)
                    gracz.Image = Image.FromFile("ruchwlewo2.gif");
            }
        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void Restart()
        {
            Form1 noweOkno = new Form1();
            noweOkno.Show();
            this.Hide();
        }
    }
}
