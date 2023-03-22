using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify
{
    public partial class F_Search : Form
    {
        SoundPlayer player = null;
        public string fileName = Data.fileName;

        public F_Search()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Что хочешь послушать?") { textBox1.Text = ""; }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { textBox1.Text = "Что хочешь послушать?"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_Media f_Media = new F_Media();
            f_Media.Show();
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void F_Search_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
            label18.Text = Data.simpleString;
            pictureBox27.Image = Data.album_pic;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player.SoundLocation = fileName;
            player.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            F_Create_Playlist f_Create_Playlist = new F_Create_Playlist();
            f_Create_Playlist.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            F_Create_Song f_Create_Song = new F_Create_Song();
            f_Create_Song.Show();
            this.Close();
        }
    }
}
