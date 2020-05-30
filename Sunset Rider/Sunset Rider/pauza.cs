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

    public partial class pauza : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        static public bool formclose = false;
        static public bool formrestart = false;
        public pauza()
        {
            InitializeComponent();
            player.URL = "ladowanie.wav";
        }



        private void backtomenu_Click(object sender, EventArgs e)
        {
            player.controls.play();
            Form1.pause = false;
            formclose = true;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player.controls.play();
            Form1.pause = false;
            this.Close();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            player.controls.play();
            Form1.pause = false;
            formrestart = true;
            this.Close();
        }
    }
}
