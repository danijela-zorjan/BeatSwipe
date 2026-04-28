namespace BeatSwipe
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlCard;

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblSongTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblMatchesTitle;

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnMatches;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.DataGridView dgvMatches;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnMatches = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblSongTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.lblMatchesTitle = new System.Windows.Forms.Label();

            this.pnlSidebar.SuspendLayout();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeatSwipe - User";

            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(230, 650);
            this.pnlSidebar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;

            this.lblLogo.Text = "BeatSwipe";
            this.lblLogo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Location = new System.Drawing.Point(0, 30);
            this.lblLogo.Size = new System.Drawing.Size(230, 60);

            this.lblUser.Text = "User:";
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUser.Location = new System.Drawing.Point(25, 115);
            this.lblUser.Size = new System.Drawing.Size(180, 30);

            this.btnMatches.Text = "REFRESH MATCHES";
            this.btnMatches.Location = new System.Drawing.Point(25, 170);
            this.btnMatches.Size = new System.Drawing.Size(180, 45);
            this.btnMatches.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnMatches.ForeColor = System.Drawing.Color.White;
            this.btnMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatches.FlatAppearance.BorderSize = 0;
            this.btnMatches.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMatches.Click += new System.EventHandler(this.btnMatches_Click);

            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Location = new System.Drawing.Point(25, 225);
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.lblUser);
            this.pnlSidebar.Controls.Add(this.btnMatches);
            this.pnlSidebar.Controls.Add(this.btnLogout);

            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Location = new System.Drawing.Point(310, 60);
            this.pnlCard.Size = new System.Drawing.Size(500, 400);

            this.lblIcon.Text = "♪";
            this.lblIcon.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Bold);
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIcon.Location = new System.Drawing.Point(0, 20);
            this.lblIcon.Size = new System.Drawing.Size(500, 110);

            this.lblSongTitle.Text = "Song title";
            this.lblSongTitle.ForeColor = System.Drawing.Color.White;
            this.lblSongTitle.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblSongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSongTitle.Location = new System.Drawing.Point(20, 145);
            this.lblSongTitle.Size = new System.Drawing.Size(460, 60);

            this.lblArtist.Text = "Artist";
            this.lblArtist.ForeColor = System.Drawing.Color.Gray;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArtist.Location = new System.Drawing.Point(20, 210);
            this.lblArtist.Size = new System.Drawing.Size(460, 35);

            this.lblGenre.Text = "Genre";
            this.lblGenre.ForeColor = System.Drawing.Color.Orange;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGenre.Location = new System.Drawing.Point(20, 255);
            this.lblGenre.Size = new System.Drawing.Size(460, 35);

            this.btnPlay.Text = "PLAY";
            this.btnPlay.Location = new System.Drawing.Point(160, 320);
            this.btnPlay.Size = new System.Drawing.Size(180, 45);
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(255, 95, 20);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);

            this.pnlCard.Controls.Add(this.lblIcon);
            this.pnlCard.Controls.Add(this.lblSongTitle);
            this.pnlCard.Controls.Add(this.lblArtist);
            this.pnlCard.Controls.Add(this.lblGenre);
            this.pnlCard.Controls.Add(this.btnPlay);

            this.btnPass.Text = "PASS";
            this.btnPass.Location = new System.Drawing.Point(350, 500);
            this.btnPass.Size = new System.Drawing.Size(180, 55);
            this.btnPass.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnPass.ForeColor = System.Drawing.Color.White;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.FlatAppearance.BorderSize = 0;
            this.btnPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);

            this.btnLike.Text = "LIKE";
            this.btnLike.Location = new System.Drawing.Point(590, 500);
            this.btnLike.Size = new System.Drawing.Size(180, 55);
            this.btnLike.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLike.ForeColor = System.Drawing.Color.White;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.FlatAppearance.BorderSize = 0;
            this.btnLike.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);

            this.lblMatchesTitle.Text = "Matches";
            this.lblMatchesTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMatchesTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblMatchesTitle.Location = new System.Drawing.Point(840, 25);
            this.lblMatchesTitle.Size = new System.Drawing.Size(180, 30);
            this.lblMatchesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.dgvMatches.Location = new System.Drawing.Point(840, 60);
            this.dgvMatches.Size = new System.Drawing.Size(180, 495);
            this.dgvMatches.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dgvMatches.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvMatches.ForeColor = System.Drawing.Color.White;
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.lblMatchesTitle);
            this.Controls.Add(this.dgvMatches);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);
        }
    }
}