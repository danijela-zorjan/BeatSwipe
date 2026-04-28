using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BeatSwipe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MakeLabelsTransparent();
            LoadImages();
        }

        private void LoadImages()
        {
            string basePath = Application.StartupPath;

            string headphonesPath = Path.Combine(basePath, "Resources", "headphones.png");
            string logoPath = Path.Combine(basePath, "Resources", "logo.png");

            if (File.Exists(headphonesPath))
            {
                pictureBox1.Image = Image.FromFile(headphonesPath);
            }
            else
            {
                MessageBox.Show("Nije pronađena slika: " + headphonesPath);
            }

            if (File.Exists(logoPath))
            {
                pictureBox2.Image = Image.FromFile(logoPath);
            }
            else
            {
                MessageBox.Show("Nije pronađena slika: " + logoPath);
            }
        }

        private void MakeLabelsTransparent()
        {
            foreach (Control control in mainPanel.Controls)
            {
                if (control is Label label)
                {
                    label.BackColor = Color.Transparent;
                }
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                mainPanel.ClientRectangle,
                Color.FromArgb(8, 10, 20),
                Color.FromArgb(65, 0, 85),
                45f))
            {
                g.FillRectangle(brush, mainPanel.ClientRectangle);
            }
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Otvara se forma za registraciju / unos muzičkog profila.");
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otvara se login forma.");
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nastavljaš kao gost.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}