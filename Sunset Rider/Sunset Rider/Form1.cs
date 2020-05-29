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
using WMPLib;

namespace Sunset_Rider
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer moneyy = new WindowsMediaPlayer();
        WindowsMediaPlayer key = new WindowsMediaPlayer();
        WindowsMediaPlayer winner = new WindowsMediaPlayer();

        static public bool pause = false;
        static public bool close = false;

        bool lewo = false;
        bool prawo = false;
        bool jump = false;
        bool maKlucz;

        int wynik = 0;


        int G = 8; //wysokosc skoku
        int force;


        int predkoscGracza = 10;


        bool gifIsNotLoaded = true; //instrukcja do pomocy obslugi animacji chodzenia

        public Form1()
        {
            InitializeComponent();
            
            player.URL = "thegroove.mp3";
            moneyy.URL = "hajs.wav";
            key.URL = "klucz.wav";
            winner.URL = "win.wav";
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            player.controls.play();
            
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
                    if (prawo == true && gifIsNotLoaded)
                        gracz.Image = Image.FromFile("ruchwprawo.gif");
                    if (lewo == true && gifIsNotLoaded)
                        gracz.Image = Image.FromFile("ruchwlewo.gif");
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
                            force = 0;

                            if (jump)
                            {
                                gracz.Image = Image.FromFile("ruchwprawo.gif");
                            }
                            jump = false;
                            
                        }

                        x.BringToFront();

                    }

                    if (x is PictureBox && (string)x.Tag == "money")
                    {
                        if (gracz.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            moneyy.controls.play();
                            
                            x.Visible = false;
                            wynik++;
                        }
                    }
                }

                if (gracz.Bounds.IntersectsWith(klucz.Bounds))
                {
                    key.controls.play();
                     
                    klucz.Visible = false;
                    maKlucz = true;
                    portal.Image = Properties.Resources.portalotwarty;
                }

                if (gracz.Bounds.IntersectsWith(portal.Bounds) && maKlucz == true) //gracz wygrywa
                {
                    winner.controls.play();
                    player.controls.stop();
                    
                    GameTimer.Stop();
                    win wygrana = new win();
                    wygrana.ShowDialog();

                    if (pauza.formclose == true)
                    {
                        pauza.formclose = false;
                        this.Hide();

                        menu m = new menu();
                        m.ShowDialog();
                    }

                    if (pauza.formrestart == true)
                    {
                        pauza.formrestart = false;
                        Restart();
                    }
                }


                if (gracz.Top + gracz.Height > this.ClientSize.Height) // gracz przegrywa
                {
                    player.controls.stop();
                    GameTimer.Stop();
                    lose przegrana = new lose();
                    przegrana.ShowDialog();

                    if (pauza.formclose == true)
                    {
                        pauza.formclose = false;
                        this.Hide();

                        menu m = new menu();
                        m.ShowDialog();
                    }

                    if (pauza.formrestart == true)
                    {
                        pauza.formrestart = false;
                        Restart();
                    }
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
                prawo = true;
                if (gifIsNotLoaded == true)
                {
                    gracz.Image = Image.FromFile("ruchwprawo.gif");
                    gifIsNotLoaded = false;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                lewo = true;
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
                    if (prawo == true)
                    {
                        gracz.Image = Image.FromFile("ruchwprawo3.png");
                    }

                    if (lewo == true)
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
