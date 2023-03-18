using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify
{
    public partial class F_Search : Form
    {
        public F_Search()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Что хочешь послушать?") { textBox1.Text = ""; }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { textBox1.Text = "Что хочешь послушать?"; }
        }
    }
}
