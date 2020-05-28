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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }


        private void logo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 gra = new Form1();
            gra.ShowDialog();
        }
    }
}
