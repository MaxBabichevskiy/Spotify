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
    public partial class F_Create_Song : Form
    {
        Point lastPoint;
        OpenFileDialog ofd = new OpenFileDialog();
        string fileName = string.Empty;

        public F_Create_Song()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Добавить название") { textBox1.Text = ""; }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { textBox1.Text = "Добавить название"; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gray;
        }

        private void F_Create_Song_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void F_Create_Song_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files(*.BMP,*.JPG;*.PNG) |*.BMP, *.JPG,*.PNG| All files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try { pictureBox1.Image = Data.album_pic = new Bitmap(ofd.FileName); }
                catch { MessageBox.Show("Невозможно открыть выбраный файл"); }
                label3.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_Create_Playlist f_Create_Playlist = new F_Create_Playlist();

            Data.fileName = fileName;


            if (textBox1.Text == "Добавить название") { Data.simpleString = "Мой плейлист"; }
            else { Data.simpleString = textBox1.Text; }
            f_Create_Playlist.Show();
            this.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "WAV|*.wav",
                Multiselect = false,
                ValidateNames = true
            };

            if (ofd.ShowDialog() == DialogResult.OK) { fileName = ofd.FileName; }
        }

        private void F_Create_Song_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            
        }
    }
}
