namespace BeatSwipe
{
    partial class SuperAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Label lblUsersTitle;
        private System.Windows.Forms.Label lblSongsTitle;
        private System.Windows.Forms.Label lblSwipesTitle;
        private System.Windows.Forms.Label lblAddSongTitle;

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.DataGridView dgvSwipes;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblUrl;

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtUrl;

        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnDeleteSong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.lblSongsTitle = new System.Windows.Forms.Label();
            this.lblSwipesTitle = new System.Windows.Forms.Label();
            this.lblAddSongTitle = new System.Windows.Forms.Label();

            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.dgvSwipes = new System.Windows.Forms.DataGridView();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();

            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();

            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();

            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwipes)).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(1250, 740);
            this.BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeatSwipe - Super Admin";

            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(240, 740);
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.pnlSidebar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;

            this.lblLogo.Text = "BeatSwipe";
            this.lblLogo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Location = new System.Drawing.Point(0, 30);
            this.lblLogo.Size = new System.Drawing.Size(240, 60);

            this.lblAdmin.Text = "SUPER ADMIN";
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdmin.Location = new System.Drawing.Point(0, 100);
            this.lblAdmin.Size = new System.Drawing.Size(240, 35);

            this.btnRefresh.Text = "REFRESH DATA";
            this.btnRefresh.Location = new System.Drawing.Point(25, 165);
            this.btnRefresh.Size = new System.Drawing.Size(190, 45);
            this.btnRefresh.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Location = new System.Drawing.Point(25, 220);
            this.btnLogout.Size = new System.Drawing.Size(190, 45);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.lblAdmin);
            this.pnlSidebar.Controls.Add(this.btnRefresh);
            this.pnlSidebar.Controls.Add(this.btnLogout);

            this.lblUsersTitle.Text = "Users";
            this.lblUsersTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblUsersTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblUsersTitle.Location = new System.Drawing.Point(270, 25);
            this.lblUsersTitle.Size = new System.Drawing.Size(300, 35);

            this.dgvUsers.Location = new System.Drawing.Point(270, 65);
            this.dgvUsers.Size = new System.Drawing.Size(430, 220);
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dgvUsers.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.lblSongsTitle.Text = "Songs";
            this.lblSongsTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSongsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSongsTitle.Location = new System.Drawing.Point(730, 25);
            this.lblSongsTitle.Size = new System.Drawing.Size(300, 35);

            this.dgvSongs.Location = new System.Drawing.Point(730, 65);
            this.dgvSongs.Size = new System.Drawing.Size(480, 220);
            this.dgvSongs.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dgvSongs.ForeColor = System.Drawing.Color.White;
            this.dgvSongs.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongs.AllowUserToAddRows = false;
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongs.RowHeadersVisible = false;
            this.dgvSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.lblAddSongTitle.Text = "Add New Song";
            this.lblAddSongTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblAddSongTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAddSongTitle.Location = new System.Drawing.Point(270, 320);
            this.lblAddSongTitle.Size = new System.Drawing.Size(300, 35);

            this.lblTitle.Text = "Title";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(270, 365);
            this.lblTitle.Size = new System.Drawing.Size(280, 22);

            this.txtTitle.Location = new System.Drawing.Point(270, 390);
            this.txtTitle.Size = new System.Drawing.Size(300, 29);
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblArtist.Text = "Artist";
            this.lblArtist.ForeColor = System.Drawing.Color.White;
            this.lblArtist.Location = new System.Drawing.Point(270, 430);
            this.lblArtist.Size = new System.Drawing.Size(280, 22);

            this.txtArtist.Location = new System.Drawing.Point(270, 455);
            this.txtArtist.Size = new System.Drawing.Size(300, 29);
            this.txtArtist.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtArtist.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtArtist.ForeColor = System.Drawing.Color.White;
            this.txtArtist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblGenre.Text = "Genre";
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(270, 495);
            this.lblGenre.Size = new System.Drawing.Size(280, 22);

            this.txtGenre.Location = new System.Drawing.Point(270, 520);
            this.txtGenre.Size = new System.Drawing.Size(300, 29);
            this.txtGenre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGenre.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtGenre.ForeColor = System.Drawing.Color.White;
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblUrl.Text = "Music URL";
            this.lblUrl.ForeColor = System.Drawing.Color.White;
            this.lblUrl.Location = new System.Drawing.Point(270, 560);
            this.lblUrl.Size = new System.Drawing.Size(280, 22);

            this.txtUrl.Location = new System.Drawing.Point(270, 585);
            this.txtUrl.Size = new System.Drawing.Size(300, 29);
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUrl.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtUrl.ForeColor = System.Drawing.Color.White;
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnAddSong.Text = "ADD SONG";
            this.btnAddSong.Location = new System.Drawing.Point(600, 390);
            this.btnAddSong.Size = new System.Drawing.Size(220, 45);
            this.btnAddSong.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddSong.ForeColor = System.Drawing.Color.White;
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.FlatAppearance.BorderSize = 0;
            this.btnAddSong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);

            this.btnDeleteSong.Text = "DELETE SELECTED SONG";
            this.btnDeleteSong.Location = new System.Drawing.Point(600, 450);
            this.btnDeleteSong.Size = new System.Drawing.Size(220, 45);
            this.btnDeleteSong.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnDeleteSong.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSong.FlatAppearance.BorderSize = 0;
            this.btnDeleteSong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);

            this.lblSwipesTitle.Text = "Swipe Activity";
            this.lblSwipesTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSwipesTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSwipesTitle.Location = new System.Drawing.Point(860, 320);
            this.lblSwipesTitle.Size = new System.Drawing.Size(300, 35);

            this.dgvSwipes.Location = new System.Drawing.Point(860, 365);
            this.dgvSwipes.Size = new System.Drawing.Size(350, 250);
            this.dgvSwipes.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dgvSwipes.ForeColor = System.Drawing.Color.White;
            this.dgvSwipes.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvSwipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSwipes.AllowUserToAddRows = false;
            this.dgvSwipes.ReadOnly = true;
            this.dgvSwipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSwipes.RowHeadersVisible = false;
            this.dgvSwipes.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.lblUsersTitle);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.lblSongsTitle);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.lblAddSongTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.lblSwipesTitle);
            this.Controls.Add(this.dgvSwipes);

            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}