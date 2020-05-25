using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunset_Rider
{
    public partial class Form1 : Form
    {
        bool lewo;
        bool prawo;
        bool skok; 
        bool maKlucz;

        int wynik = 0;
        int force = 8;
        int predkoscSkoku = 10;

        //int predkoscTla = 8;
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
            txtScore.Text = "Wynik: " + wynik;
            gracz.Top += predkoscSkoku;

            if (prawo == true && gracz.Left + (gracz.Width+60)<this.ClientSize.Width)
            {
                gracz.Left += predkoscGracza;
            }

            if (lewo == true && gracz.Left > 60)
            {
                gracz.Left -= predkoscGracza;
            }

            /*if (prawo == true && tlo.Left > -1290)
            {
                tlo.Left -= predkoscTla;
                MoveGameElements("tyl");
            }
            if (lewo == true && tlo.Left < 0)
            {
                tlo.Left += predkoscTla;
                MoveGameElements("przod");
            }*/

            if (skok == true)
            {
                predkoscSkoku = -12;
                force -= 1;
            }
            else
            {
                predkoscSkoku = 12;
            }
            if (skok == true && force < 0)
            {
                skok = false;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (gracz.Bounds.IntersectsWith(x.Bounds) && skok ==false)
                    {
                        force = 8;
                        gracz.Top = x.Top - gracz.Height;
                        predkoscSkoku = 0;
                    }

                    x.BringToFront();

                }

                if ( x is PictureBox && (string)x.Tag == "money")
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

            if (gracz.Bounds.IntersectsWith(portal.Bounds) && maKlucz ==true)
            {
                portal.Image = Properties.Resources.portalotwarty;
                GameTimer.Stop();
                MessageBox.Show("Brawo! Twoja gra zakończyła się sukcesem!" + Environment.NewLine + "Wcisnij OK, aby zagrac jeszcze raz");
                Restart();
            }
            if (gracz.Top + gracz.Height >this.ClientSize.Height)
            {
                GameTimer.Stop();
                MessageBox.Show("Porażka! Koniec gry." + Environment.NewLine + "Wcisnij OK, aby zagrac jeszcze raz");
                Restart();
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

            if (skok == false && e.KeyCode == Keys.Space)
            {
                skok = true;
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

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            gifIsNotLoaded = true;
            if (e.KeyCode == Keys.Right)
            {
                prawo = false;
                if (skok != true)
                    gracz.Image = Image.FromFile("ruchwprawo2.gif");
            }
            if (e.KeyCode == Keys.Left)
            {
                lewo = false;
                if (skok != true)
                    gracz.Image = Image.FromFile("ruchwlewo2.gif");
            }
            if (skok == true)
            {
                skok = false;
            }
        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void Restart()
        {
            Form1 noweOkno = new Form1();
            noweOkno.Show();
            this.Hide();
        }
        /*
        private void MoveGameElements(string kierunek)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "portal" || x is PictureBox && (string)x.Tag == "klucz" || x is PictureBox && (string)x.Tag == "money" || x is PictureBox && (string)x.Tag == "platform")
                {
                    if (kierunek == "tyl")
                    {
                        x.Left -= predkoscTla;
                    }
                    if (kierunek == "przod")
                    {
                        x.Left += predkoscTla;
                    }
                }
            }
        }*/
    }
}
