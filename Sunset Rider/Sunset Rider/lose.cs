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
    public partial class lose : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public lose()
        {
            InitializeComponent();
            player.URL = "fail.wav";
        }

        private void menu_Click(object sender, EventArgs e)
        {
            player.controls.play();
            Form1.pause = false;
            pauza.formclose = true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player.controls.play();
            Form1.pause = false;
            pauza.formrestart = true;
            this.Close();
        }
    }
}
