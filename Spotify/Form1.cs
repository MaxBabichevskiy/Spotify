using Microsoft.VisualBasic.ApplicationServices;
using System.Media;

namespace Spotify
{
    public partial class Form1 : Form
    {
        //SoundPlayer player = null;

        string fileName = string.Empty;

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // player = new SoundPlayer();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //player.SoundLocation = fileName;
                // player.Play();

            }
            catch (Exception ex)
            {
                //MessageBox.Show($"{ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog()
            //{
            //    Filter = "WAV|*.wav",
            //    Multiselect = false,
            //    ValidateNames = true
            //};

            //if (ofd.ShowDialog() == DialogResult.OK) { fileName = ofd.FileName; }

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

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
    }
}