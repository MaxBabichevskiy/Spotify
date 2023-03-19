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
    public partial class F_Create_Playlist : Form
    {
        public F_Create_Playlist()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            F_Create_Song f_Create_Song = new F_Create_Song();
            f_Create_Song.Show();
        }
    }
}
