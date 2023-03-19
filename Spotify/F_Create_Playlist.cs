using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection.Emit;

namespace Spotify
{
    public partial class F_Create_Playlist : Form
    {
        SoundPlayer player = null;

        public string fileName = string.Empty;

       


        public F_Create_Playlist()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            F_Create_Song f_Create_Song = new F_Create_Song();
            f_Create_Song.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Search f_Search = new F_Search();
            f_Search.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_Media f_Media = new F_Media();
            f_Media.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void F_Create_Playlist_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                player.SoundLocation = fileName;
                player.Play();

                timer1.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                label13.Text = progressBar1.Value.ToString();
            }


        }
    }
}
