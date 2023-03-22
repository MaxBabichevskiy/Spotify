namespace Spotify
{
    partial class F_Create_Song
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Create_Song));
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 30);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 5;
            label4.Text = "Изменение сведений";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(148, 148, 148);
            label1.Location = new Point(371, 32);
            label1.Name = "label1";
            label1.Size = new Size(17, 18);
            label1.TabIndex = 6;
            label1.Text = "X";
            label1.Click += label1_Click;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(23, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(62, 62, 62);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.ForeColor = Color.FromArgb(148, 148, 148);
            textBox1.Location = new Point(182, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 16);
            textBox1.TabIndex = 8;
            textBox1.Text = "Добавить название";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(279, 225);
            button1.Name = "button1";
            button1.Size = new Size(109, 36);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 62, 62);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(182, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 101);
            panel1.TabIndex = 11;
            panel1.Click += panel1_Click;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(148, 148, 148);
            label2.Location = new Point(30, 31);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 0;
            label2.Text = "Нажмите или перетащите\r\n        сюда файл WAV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(40, 40, 40);
            label3.ForeColor = Color.FromArgb(148, 148, 148);
            label3.Location = new Point(42, 165);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 12;
            label3.Text = "Выбрать обложку";
            // 
            // F_Create_Song
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(407, 287);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_Create_Song";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_Create_Song";
            Load += F_Create_Song_Load;
            MouseDown += F_Create_Song_MouseDown;
            MouseMove += F_Create_Song_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label3;
    }
}