﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify
{
    public partial class F_Favorite : Form
    {

        SoundPlayer player = null;
        public string fileName = Data.fileName;


        public F_Favorite()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            F_Create_Playlist f_Create_Playlist = new F_Create_Playlist();
            f_Create_Playlist.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void F_Favorite_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
            label18.Text = Data.simpleString;
            pictureBox7.Image = Data.album_pic;
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

        private void pictureBox7_Click(object sender, EventArgs e)
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
