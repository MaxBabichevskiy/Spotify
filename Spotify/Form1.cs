using Microsoft.VisualBasic.ApplicationServices;
using System.Media;
using System.Numerics;

namespace Spotify
{
    public partial class Form1 : Form
    {
        SoundPlayer player = null;
        public string fileName = Data.fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
            label18.Text = Data.simpleString;
            pictureBox11.Image = Data.album_pic;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Search f_Search = new F_Search();
            f_Search.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_Media f_Media = new F_Media();
            f_Media.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F_Create_Playlist f_Create_Playlist = new F_Create_Playlist();
            f_Create_Playlist.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            F_Favorite f_Favorite = new F_Favorite();
            f_Favorite.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            player.SoundLocation = fileName;
            player.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            F_Create_Playlist f_Create_Playlist = new F_Create_Playlist();
            f_Create_Playlist.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
          
        }
    }
}