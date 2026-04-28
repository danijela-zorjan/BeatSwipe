using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BeatSwipe
{
    partial class UserGuestForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel sidebar;
        private Panel card;

        private Label lblLogo;
        private Label lblGuest;

        private Label lblTitle;
        private Label lblArtist;
        private Label lblGenre;

        private Button btnLike;
        private Button btnPass;
        private Button btnPlay;
        private Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidebar = new Panel();
            this.card = new Panel();

            this.lblLogo = new Label();
            this.lblGuest = new Label();

            this.lblTitle = new Label();
            this.lblArtist = new Label();
            this.lblGenre = new Label();

            this.btnLike = new Button();
            this.btnPass = new Button();
            this.btnPlay = new Button();
            this.btnLogin = new Button();

            this.SuspendLayout();

            // FORM
            this.ClientSize = new Size(1000, 600);
            this.BackColor = Color.Black;
            this.Text = "BeatSwipe - Guest";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(this.UserGuestForm_Load);

            // SIDEBAR
            sidebar.BackColor = Color.FromArgb(18, 18, 18);
            sidebar.Location = new Point(0, 0);
            sidebar.Size = new Size(220, 600);

            // LOGO
            lblLogo.Text = "BeatSwipe";
            lblLogo.ForeColor = Color.OrangeRed;
            lblLogo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblLogo.Location = new Point(20, 30);
            lblLogo.Size = new Size(200, 40);

            // GUEST
            lblGuest.Text = "GUEST MODE";
            lblGuest.ForeColor = Color.Gray;
            lblGuest.Location = new Point(20, 80);

            // LOGIN
            btnLogin.Text = "LOGIN";
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(20, 500);
            btnLogin.Size = new Size(180, 40);
            btnLogin.Click += new EventHandler(this.btnLogin_Click);

            sidebar.Controls.Add(lblLogo);
            sidebar.Controls.Add(lblGuest);
            sidebar.Controls.Add(btnLogin);

            // CARD
            card.BackColor = Color.FromArgb(25, 25, 25);
            card.Location = new Point(320, 80);
            card.Size = new Size(500, 350);

            // TITLE
            lblTitle.Text = "Song Title";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Dock = DockStyle.Top;

            // ARTIST
            lblArtist.Text = "Artist";
            lblArtist.ForeColor = Color.Gray;
            lblArtist.TextAlign = ContentAlignment.MiddleCenter;
            lblArtist.Dock = DockStyle.Top;

            // GENRE
            lblGenre.Text = "Genre";
            lblGenre.ForeColor = Color.Orange;
            lblGenre.TextAlign = ContentAlignment.MiddleCenter;
            lblGenre.Dock = DockStyle.Top;

            // PLAY
            btnPlay.Text = "PLAY";
            btnPlay.BackColor = Color.OrangeRed;
            btnPlay.ForeColor = Color.White;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Location = new Point(180, 240);
            btnPlay.Size = new Size(140, 40);
            btnPlay.Click += new EventHandler(this.btnPlay_Click);

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblArtist);
            card.Controls.Add(lblGenre);
            card.Controls.Add(btnPlay);

            // LIKE
            btnLike.Text = "LIKE";
            btnLike.BackColor = Color.Green;
            btnLike.ForeColor = Color.White;
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.Location = new Point(400, 470);
            btnLike.Size = new Size(140, 50);
            btnLike.Click += new EventHandler(this.btnLike_Click);

            // PASS
            btnPass.Text = "PASS";
            btnPass.BackColor = Color.DarkRed;
            btnPass.ForeColor = Color.White;
            btnPass.FlatStyle = FlatStyle.Flat;
            btnPass.Location = new Point(600, 470);
            btnPass.Size = new Size(140, 50);
            btnPass.Click += new EventHandler(this.btnPass_Click);

            // ADD TO FORM
            this.Controls.Add(sidebar);
            this.Controls.Add(card);
            this.Controls.Add(btnLike);
            this.Controls.Add(btnPass);

            this.ResumeLayout(false);
        }
    }
}