namespace BeatSwipe
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Panel pnlPlaylists;

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblSongTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblMatchesTitle;
        private System.Windows.Forms.Label lblUsersTitle;
        private System.Windows.Forms.Label lblUserMatchesTitle;
        private System.Windows.Forms.Label lblPlaylistTitle;
        private System.Windows.Forms.Label lblMyTracksTitle;

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnMatches;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLikeUser;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.Button btnUploadMp3;
        private System.Windows.Forms.Button btnPlayUploadedTrack;

        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvUserMatches;
        private System.Windows.Forms.DataGridView dgvMyTracks;

        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.TextBox txtPlaylistDescription;
        private System.Windows.Forms.TextBox txtTrackTitle;
        private System.Windows.Forms.TextBox txtTrackArtist;
        private System.Windows.Forms.TextBox txtTrackGenre;

        private System.Windows.Forms.ComboBox cmbPlaylists;

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

            this.lblMatchesTitle = new System.Windows.Forms.Label();
            this.dgvMatches = new System.Windows.Forms.DataGridView();

            this.pnlUsers = new System.Windows.Forms.Panel();
            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnLikeUser = new System.Windows.Forms.Button();
            this.lblUserMatchesTitle = new System.Windows.Forms.Label();
            this.dgvUserMatches = new System.Windows.Forms.DataGridView();

            this.pnlPlaylists = new System.Windows.Forms.Panel();
            this.lblPlaylistTitle = new System.Windows.Forms.Label();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.txtPlaylistDescription = new System.Windows.Forms.TextBox();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.cmbPlaylists = new System.Windows.Forms.ComboBox();
            this.txtTrackTitle = new System.Windows.Forms.TextBox();
            this.txtTrackArtist = new System.Windows.Forms.TextBox();
            this.txtTrackGenre = new System.Windows.Forms.TextBox();
            this.btnUploadMp3 = new System.Windows.Forms.Button();
            this.btnPlayUploadedTrack = new System.Windows.Forms.Button();
            this.lblMyTracksTitle = new System.Windows.Forms.Label();
            this.dgvMyTracks = new System.Windows.Forms.DataGridView();

            this.pnlSidebar.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            this.pnlPlaylists.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTracks)).BeginInit();

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(1350, 760);
            this.BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeatSwipe - User";

            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(230, 760);
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

            this.btnMatches.Text = "REFRESH";
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
            this.pnlCard.Location = new System.Drawing.Point(270, 45);
            this.pnlCard.Size = new System.Drawing.Size(430, 360);

            this.lblIcon.Text = "♪";
            this.lblIcon.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Bold);
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIcon.Location = new System.Drawing.Point(0, 10);
            this.lblIcon.Size = new System.Drawing.Size(430, 100);

            this.lblSongTitle.Text = "Song title";
            this.lblSongTitle.ForeColor = System.Drawing.Color.White;
            this.lblSongTitle.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblSongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSongTitle.Location = new System.Drawing.Point(20, 125);
            this.lblSongTitle.Size = new System.Drawing.Size(390, 55);

            this.lblArtist.Text = "Artist";
            this.lblArtist.ForeColor = System.Drawing.Color.Gray;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArtist.Location = new System.Drawing.Point(20, 185);
            this.lblArtist.Size = new System.Drawing.Size(390, 35);

            this.lblGenre.Text = "Genre";
            this.lblGenre.ForeColor = System.Drawing.Color.Orange;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGenre.Location = new System.Drawing.Point(20, 225);
            this.lblGenre.Size = new System.Drawing.Size(390, 35);

            this.btnPlay.Text = "PLAY";
            this.btnPlay.Location = new System.Drawing.Point(125, 285);
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
            this.btnPass.Location = new System.Drawing.Point(295, 430);
            this.btnPass.Size = new System.Drawing.Size(170, 55);
            this.btnPass.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnPass.ForeColor = System.Drawing.Color.White;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.FlatAppearance.BorderSize = 0;
            this.btnPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);

            this.btnLike.Text = "LIKE";
            this.btnLike.Location = new System.Drawing.Point(505, 430);
            this.btnLike.Size = new System.Drawing.Size(170, 55);
            this.btnLike.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLike.ForeColor = System.Drawing.Color.White;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.FlatAppearance.BorderSize = 0;
            this.btnLike.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);

            this.lblMatchesTitle.Text = "Song Matches";
            this.lblMatchesTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMatchesTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMatchesTitle.Location = new System.Drawing.Point(730, 20);
            this.lblMatchesTitle.Size = new System.Drawing.Size(250, 30);
            this.lblMatchesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.dgvMatches.Location = new System.Drawing.Point(730, 55);
            this.dgvMatches.Size = new System.Drawing.Size(250, 430);
            this.dgvMatches.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dgvMatches.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvMatches.ForeColor = System.Drawing.Color.White;
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.pnlUsers.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.pnlUsers.Location = new System.Drawing.Point(1010, 20);
            this.pnlUsers.Size = new System.Drawing.Size(310, 465);

            this.lblUsersTitle.Text = "Users";
            this.lblUsersTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblUsersTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsersTitle.Location = new System.Drawing.Point(10, 10);
            this.lblUsersTitle.Size = new System.Drawing.Size(290, 30);
            this.lblUsersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.dgvUsers.Location = new System.Drawing.Point(15, 50);
            this.dgvUsers.Size = new System.Drawing.Size(280, 150);
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(12, 12, 12);
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvUsers.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.btnLikeUser.Text = "LIKE USER";
            this.btnLikeUser.Location = new System.Drawing.Point(65, 215);
            this.btnLikeUser.Size = new System.Drawing.Size(180, 40);
            this.btnLikeUser.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLikeUser.ForeColor = System.Drawing.Color.White;
            this.btnLikeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLikeUser.FlatAppearance.BorderSize = 0;
            this.btnLikeUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLikeUser.Click += new System.EventHandler(this.btnLikeUser_Click);

            this.lblUserMatchesTitle.Text = "Mutual Matches";
            this.lblUserMatchesTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblUserMatchesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserMatchesTitle.Location = new System.Drawing.Point(10, 270);
            this.lblUserMatchesTitle.Size = new System.Drawing.Size(290, 30);
            this.lblUserMatchesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.dgvUserMatches.Location = new System.Drawing.Point(15, 305);
            this.dgvUserMatches.Size = new System.Drawing.Size(280, 140);
            this.dgvUserMatches.BackgroundColor = System.Drawing.Color.FromArgb(12, 12, 12);
            this.dgvUserMatches.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvUserMatches.ForeColor = System.Drawing.Color.White;
            this.dgvUserMatches.ReadOnly = true;
            this.dgvUserMatches.AllowUserToAddRows = false;
            this.dgvUserMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserMatches.RowHeadersVisible = false;
            this.dgvUserMatches.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.pnlUsers.Controls.Add(this.lblUsersTitle);
            this.pnlUsers.Controls.Add(this.dgvUsers);
            this.pnlUsers.Controls.Add(this.btnLikeUser);
            this.pnlUsers.Controls.Add(this.lblUserMatchesTitle);
            this.pnlUsers.Controls.Add(this.dgvUserMatches);

            this.pnlPlaylists.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.pnlPlaylists.Location = new System.Drawing.Point(270, 515);
            this.pnlPlaylists.Size = new System.Drawing.Size(1050, 220);

            this.lblPlaylistTitle.Text = "Playlists & Upload MP3";
            this.lblPlaylistTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPlaylistTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPlaylistTitle.Location = new System.Drawing.Point(15, 10);
            this.lblPlaylistTitle.Size = new System.Drawing.Size(300, 30);

            this.txtPlaylistName.Location = new System.Drawing.Point(20, 50);
            this.txtPlaylistName.Size = new System.Drawing.Size(180, 27);
            //this.txtPlaylistName.PlaceholderText = "Playlist name";

            this.txtPlaylistDescription.Location = new System.Drawing.Point(210, 50);
            this.txtPlaylistDescription.Size = new System.Drawing.Size(220, 27);
            //this.txtPlaylistDescription.PlaceholderText = "Description";

            this.btnCreatePlaylist.Text = "CREATE";
            this.btnCreatePlaylist.Location = new System.Drawing.Point(445, 48);
            this.btnCreatePlaylist.Size = new System.Drawing.Size(110, 32);
            this.btnCreatePlaylist.BackColor = System.Drawing.Color.FromArgb(255, 95, 20);
            this.btnCreatePlaylist.ForeColor = System.Drawing.Color.White;
            this.btnCreatePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePlaylist.FlatAppearance.BorderSize = 0;
            this.btnCreatePlaylist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);

            this.cmbPlaylists.Location = new System.Drawing.Point(20, 95);
            this.cmbPlaylists.Size = new System.Drawing.Size(180, 28);
            this.cmbPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.txtTrackTitle.Location = new System.Drawing.Point(210, 95);
            this.txtTrackTitle.Size = new System.Drawing.Size(150, 27);
            //this.txtTrackTitle.PlaceholderText = "Track title";

            this.txtTrackArtist.Location = new System.Drawing.Point(370, 95);
            this.txtTrackArtist.Size = new System.Drawing.Size(150, 27);
            //this.txtTrackArtist.PlaceholderText = "Artist";

            this.txtTrackGenre.Location = new System.Drawing.Point(530, 95);
            this.txtTrackGenre.Size = new System.Drawing.Size(130, 27);
            //this.txtTrackGenre.PlaceholderText = "Genre";

            this.btnUploadMp3.Text = "UPLOAD MP3";
            this.btnUploadMp3.Location = new System.Drawing.Point(675, 92);
            this.btnUploadMp3.Size = new System.Drawing.Size(130, 32);
            this.btnUploadMp3.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUploadMp3.ForeColor = System.Drawing.Color.White;
            this.btnUploadMp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadMp3.FlatAppearance.BorderSize = 0;
            this.btnUploadMp3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadMp3.Click += new System.EventHandler(this.btnUploadMp3_Click);

            this.btnPlayUploadedTrack.Text = "PLAY SELECTED";
            this.btnPlayUploadedTrack.Location = new System.Drawing.Point(815, 92);
            this.btnPlayUploadedTrack.Size = new System.Drawing.Size(140, 32);
            this.btnPlayUploadedTrack.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnPlayUploadedTrack.ForeColor = System.Drawing.Color.White;
            this.btnPlayUploadedTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayUploadedTrack.FlatAppearance.BorderSize = 0;
            this.btnPlayUploadedTrack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPlayUploadedTrack.Click += new System.EventHandler(this.btnPlayUploadedTrack_Click);

            this.lblMyTracksTitle.Text = "My uploaded tracks";
            this.lblMyTracksTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblMyTracksTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMyTracksTitle.Location = new System.Drawing.Point(20, 135);
            this.lblMyTracksTitle.Size = new System.Drawing.Size(250, 25);

            this.dgvMyTracks.Location = new System.Drawing.Point(20, 160);
            this.dgvMyTracks.Size = new System.Drawing.Size(1010, 50);
            this.dgvMyTracks.BackgroundColor = System.Drawing.Color.FromArgb(12, 12, 12);
            this.dgvMyTracks.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvMyTracks.ForeColor = System.Drawing.Color.White;
            this.dgvMyTracks.ReadOnly = true;
            this.dgvMyTracks.AllowUserToAddRows = false;
            this.dgvMyTracks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyTracks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyTracks.RowHeadersVisible = false;
            this.dgvMyTracks.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.pnlPlaylists.Controls.Add(this.lblPlaylistTitle);
            this.pnlPlaylists.Controls.Add(this.txtPlaylistName);
            this.pnlPlaylists.Controls.Add(this.txtPlaylistDescription);
            this.pnlPlaylists.Controls.Add(this.btnCreatePlaylist);
            this.pnlPlaylists.Controls.Add(this.cmbPlaylists);
            this.pnlPlaylists.Controls.Add(this.txtTrackTitle);
            this.pnlPlaylists.Controls.Add(this.txtTrackArtist);
            this.pnlPlaylists.Controls.Add(this.txtTrackGenre);
            this.pnlPlaylists.Controls.Add(this.btnUploadMp3);
            this.pnlPlaylists.Controls.Add(this.btnPlayUploadedTrack);
            this.pnlPlaylists.Controls.Add(this.lblMyTracksTitle);
            this.pnlPlaylists.Controls.Add(this.dgvMyTracks);

            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.lblMatchesTitle);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.pnlPlaylists);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlUsers.ResumeLayout(false);
            this.pnlPlaylists.ResumeLayout(false);
            this.pnlPlaylists.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTracks)).EndInit();

            this.ResumeLayout(false);
        }
    }
}