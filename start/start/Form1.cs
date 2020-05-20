using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace start
{
    public partial class Form1 : Form
    {

        bool lewo;
        bool prawo;

        bool jump;
        int G = 20; //wysokosc skoku
        int force;

        bool gifIsNotLoaded = true; //instrukcja do pomocy obslugi animacji chodzenia
        bool facingRight = false;
        bool facingLeft = false;

        //moje
        int wynik;
        int predkosc;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //kolizja boczna

            if (gracz.Right > przeszkoda.Left && gracz.Left < przeszkoda.Right - gracz.Width / 2 && gracz.Bottom > przeszkoda.Top)
            {
                prawo = false;
            }
            if (gracz.Left < przeszkoda.Right && gracz.Right > przeszkoda.Left + gracz.Width / 2 && gracz.Bottom > przeszkoda.Top)
            {
                lewo = false;
            }

            //ruch lewo / prawo
            if (prawo == true) { gracz.Left += 5; }
            if (lewo == true) { gracz.Left -= 5; }

            //spadanie jezeli gracz skoczyl
            if (jump == true)
            {
                gracz.Top -= force;
                force -= 1;
            }

            if (gracz.Top + gracz.Height >= screen.Height)
            {
                gracz.Top = screen.Height - gracz.Height;
                if (jump == true)
                {
                    if (prawo == true)
                        gracz.Image = Image.FromFile("idle.gif");
                    if (lewo == true)
                        gracz.Image = Image.FromFile("idle_l.gif");
                }
                jump = false;
            }
            else
            {
                gracz.Top += 5;
            }


            //Kolizja od gory

            if (gracz.Left + gracz.Width - 1 > przeszkoda.Left && gracz.Left + gracz.Width + 5 < przeszkoda.Left + przeszkoda.Width + gracz.Width && gracz.Top + gracz.Height >= przeszkoda.Top && gracz.Top < przeszkoda.Top)
            {
                gracz.Top = screen.Height - przeszkoda.Height - gracz.Height;
                force = 0;
                if (jump == true)
                {
                    if (prawo == true)
                        gracz.Image = Image.FromFile("idle.gif");
                    if (lewo == true)
                        gracz.Image = Image.FromFile("idle_l.gif");
                }
                jump = false;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                facingLeft = false;
                prawo = true;
                facingRight = true;
                if (gifIsNotLoaded == true)
                {
                    gracz.Image = Image.FromFile("postacprawo.gif");
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
                    gracz.Image = Image.FromFile("postaclewo.gif");
                    gifIsNotLoaded = false;
                }
            }
            //zamykanie poprzez esc.
            if (e.KeyCode == Keys.Escape) { this.Close(); }

            //skok
            if (jump != true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    jump = true;
                    force = G;

                    if (facingRight == true)
                    {
                        gracz.Image = Image.FromFile("jump.png");
                    }

                    if (facingLeft == true)
                    {
                        gracz.Image = Image.FromFile("jump_l.png");
                    }
                }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            gifIsNotLoaded = true;
            if (e.KeyCode == Keys.Right)
            {
                prawo = false;
                if (jump != true)
                    gracz.Image = Image.FromFile("idle.gif");
            }
            if (e.KeyCode == Keys.Left)
            {
                lewo = false;
                if (jump != true)
                    gracz.Image = Image.FromFile("idle_l.gif");
            }
        }
    }
}
