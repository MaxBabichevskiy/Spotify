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
    public partial class F_Media : Form
    {
        public F_Media()
        {
            InitializeComponent();
        }

        private void плейлистыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            F_Create_Playlist f_Create_Playlist = new F_Create_Playlist();
            f_Create_Playlist.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            F_Favorite f_Favorite = new F_Favorite();
            f_Favorite.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Search f_Search = new F_Search();
            f_Search.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
