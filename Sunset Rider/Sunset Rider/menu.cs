using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Sunset_Rider
{
    public partial class menu : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public menu()
        {
            InitializeComponent();
            player.URL = "menu.wav";
        }


        private void logo_Click(object sender, EventArgs e)
        {
            player.controls.play();
            Application.Exit();
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            player.controls.play();
            this.Hide();
            Form1 gra = new Form1();
            gra.ShowDialog();
        }
    }
}
