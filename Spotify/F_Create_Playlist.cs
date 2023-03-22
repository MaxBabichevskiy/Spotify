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
using System.IO;


namespace Spotify
{
    public partial class F_Create_Playlist : Form
    {
        SoundPlayer player = null;

        public string fileName = Data.fileName;




        public F_Create_Playlist()
        {
            InitializeComponent();
            if (lstPlayableMedia.Items.Count == 0)
            {
                button7.SendToBack();

            }
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
            F_Media f_Media = new F_Media();
            f_Media.Show();
            this.Close();
        }

        private void F_Create_Playlist_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
            label2.Text = Data.simpleString;

            label18.Text = Data.simpleString;

            pictureBox1.Image = Data.album_pic;

            pictureBox7.Image = Data.album_pic;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                player.SoundLocation = fileName;
                player.Play();



                // timer1.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //if (progressBar1.Value < 100)
            //{
            //    progressBar1.Value += 1;

            //    label13.Text = progressBar1.Value.ToString();
            //}




        }

        private void button14_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            F_Create_Song f_Create_Song = new F_Create_Song();
            f_Create_Song.Show();
            this.Close();
        }




        private List<string> files = new List<string>();
        private List<string> paths = new List<string>();
        private string currentAudio = string.Empty;



        private void button6_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog ofd = new OpenFileDialog
            //{
            //    Title = "Please select an .mp3 to add...",
            //    Filter = "MPEG3 Audio|*.mp3",
            //    FilterIndex = 0,
            //})
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        string file = Path.GetFileName(ofd.FileName);
            //        string path = Path.GetDirectoryName(ofd.FileName);

            //        files.Add(file);
            //        paths.Add(path);

            //        files = files.Distinct().ToList();
            //        if (lstPlayableMedia.Items.Count > 0)
            //        {
            //            lstPlayableMedia.Items.Add(file);
            //            string[] strArray = new string[lstPlayableMedia.Items.Count];
            //            for (int i = 0; i < lstPlayableMedia.Items.Count; i++)
            //            {
            //                string fileName = lstPlayableMedia.Items[i].ToString();
            //                strArray[i] = fileName;
            //            }
            //            strArray = strArray.Distinct().ToArray();

            //            lstPlayableMedia.Items.Clear();
            //            lstPlayableMedia.Items.AddRange(strArray);
            //        }
            //        else
            //        {

            //            lstPlayableMedia.Items.Add(file);
            //        }
            //    }
            //}

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //if (lstPlayableMedia.SelectedIndex < 0 || lstPlayableMedia.SelectedIndex >= lstPlayableMedia.Items.Count)
            //{
            //    MessageBox.Show("Cannot play media because no audio file is selected.", "Audio File Not Selected",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    player.Play();
            //}
        }
    }
}
