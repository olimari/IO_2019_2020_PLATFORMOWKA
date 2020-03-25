using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGame
{
    public partial class Form1 : Form
    {

        bool left;
        bool right;

        bool jump;
        int G = 20; //wysokosc skoku
        int force;

        bool gifIsNotLoaded = true; //instrukcja do pomocy obslugi animacji chodzenia
        bool facingRight = false;
        bool facingLeft = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //kolizja boczna

            if (character.Right > block.Left && character.Left < block.Right - character.Width / 2 && character.Bottom > block.Top)
            {
                right = false;
            }
            if (character.Left < block.Right && character.Right > block.Left + character.Width / 2 && character.Bottom > block.Top)
            {
                left = false;
            }

            //ruch lewo / prawo
            if (right == true) { character.Left += 5; }
            if (left == true) { character.Left -= 5; }

            //spadanie jezeli gracz skoczyl
            if ( jump==true )
            {
                character.Top -= force;
                force -= 1;
            }

            if(character.Top + character.Height >= screen.Height)
            {
                character.Top = screen.Height - character.Height;
                if (jump == true)
                {
                    if (right == true)
                        character.Image = Image.FromFile("idle.gif");
                    if (left == true)
                        character.Image = Image.FromFile("idle_l.gif");
                }
                jump = false;
            }
            else
            {
                character.Top += 5;
            }


            //Kolizja od gory

            if(character.Left + character.Width - 1 > block.Left && character.Left + character.Width + 5 < block.Left + block.Width + character.Width && character.Top + character.Height >= block.Top && character.Top < block.Top)
            {
                character.Top = screen.Height - block.Height - character.Height;
                force = 0;
                if (jump == true)
                { 
                    if(right==true)
                        character.Image = Image.FromFile("idle.gif");
                    if(left==true)
                        character.Image = Image.FromFile("idle_l.gif");
                }
                jump = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                facingLeft = false;
                right = true;
                facingRight = true;
                if (gifIsNotLoaded == true)
                {
                    character.Image = Image.FromFile("right.gif");
                    gifIsNotLoaded = false;
                }
            }
            if(e.KeyCode == Keys.Left)
            {
                facingRight = false;
                left = true;
                facingLeft = true;
                if (gifIsNotLoaded == true)
                {
                    character.Image = Image.FromFile("left.gif");
                    gifIsNotLoaded = false;
                }
            }
            //zamykanie poprzez esc.
            if (e.KeyCode == Keys.Escape) { this.Close(); }

            //skok
            if (jump!=true)
            {
                if(e.KeyCode == Keys.Up)
                {
                    jump = true;
                    force = G;

                    if(facingRight==true)
                    {
                        character.Image = Image.FromFile("jump.png");
                    }

                    if (facingLeft == true)
                    {
                        character.Image = Image.FromFile("jump_l.png");
                    }  
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            gifIsNotLoaded=true;
            if(e.KeyCode == Keys.Right)
            { 
                right = false;
                if(jump != true )
                    character.Image = Image.FromFile("idle.gif");
            }
            if(e.KeyCode == Keys.Left) 
            { 
                left = false;
                if (jump != true)
                    character.Image = Image.FromFile("idle_l.gif");
            }
        }
    }
}
