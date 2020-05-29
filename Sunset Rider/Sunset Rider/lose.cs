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
    public partial class lose : Form
    {
        public lose()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form1.pause = false;
            pauza.formclose = true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.pause = false;
            pauza.formrestart = true;
            this.Close();
        }
    }
}
