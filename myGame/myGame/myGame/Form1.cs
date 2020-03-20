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


            if (right == true) { character.Left += 5; }
            if (left == true) { character.Left -= 5; }

            if( jump==true )
            {
                //spadanie jezeli gracz skoczyl
                character.Top -= force;
                force -= 1;
            }

            if(character.Top + character.Height >= screen.Height)
            {
                character.Top = screen.Height - character.Height;
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
                jump = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = true; }
            if(e.KeyCode == Keys.Left) { left = true; }
            if(e.KeyCode == Keys.Escape) { this.Close(); } //zamykanie poprzez esc.

            if(jump!=true)
            {
                if(e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = G;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = false; }
            if(e.KeyCode == Keys.Left) { left = false; }
        }
    }
}
