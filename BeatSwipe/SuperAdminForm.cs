using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeatSwipe
{
    public partial class SuperAdminForm : Form
    {
        private Button btnUpdateSong;
        private Button btnDeleteUser;
        private Button btnShowSwipes;
        private Button btnShowUserLikes;
        private Button btnShowPlaylists;
        private Button btnShowUploads;

        public SuperAdminForm()
        {
            InitializeComponent();

            CreateExtraAdminButtons();

            LoadUsers();
            LoadSongs();
            LoadSwipes();

            dgvSongs.CellClick += dgvSongs_CellClick;
        }

        private void CreateExtraAdminButtons()
        {
            btnUpdateSong = new Button();
            btnUpdateSong.Text = "UPDATE SONG";
            btnUpdateSong.Location = new System.Drawing.Point(600, 510);
            btnUpdateSong.Size = new System.Drawing.Size(220, 45);
            btnUpdateSong.BackColor = System.Drawing.Color.FromArgb(255, 95, 20);
            btnUpdateSong.ForeColor = System.Drawing.Color.White;
            btnUpdateSong.FlatStyle = FlatStyle.Flat;
            btnUpdateSong.FlatAppearance.BorderSize = 0;
            btnUpdateSong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnUpdateSong.Click += btnUpdateSong_Click;
            this.Controls.Add(btnUpdateSong);

            btnDeleteUser = new Button();
            btnDeleteUser.Text = "DELETE SELECTED USER";
            btnDeleteUser.Location = new System.Drawing.Point(270, 290);
            btnDeleteUser.Size = new System.Drawing.Size(220, 40);
            btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            btnDeleteUser.ForeColor = System.Drawing.Color.White;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnDeleteUser.Click += btnDeleteUser_Click;
            this.Controls.Add(btnDeleteUser);

            btnShowSwipes = CreateSmallButton("SONG SWIPES", 860, 630);
            btnShowSwipes.Click += (s, e) => LoadSwipes();

            btnShowUserLikes = CreateSmallButton("USER LIKES", 970, 630);
            btnShowUserLikes.Click += (s, e) => LoadUserLikes();

            btnShowPlaylists = CreateSmallButton("PLAYLISTS", 1080, 630);
            btnShowPlaylists.Click += (s, e) => LoadPlaylists();

            btnShowUploads = CreateSmallButton("UPLOADS", 1190, 630);
            btnShowUploads.Click += (s, e) => LoadUploads();

            this.Controls.Add(btnShowSwipes);
            this.Controls.Add(btnShowUserLikes);
            this.Controls.Add(btnShowPlaylists);
            this.Controls.Add(btnShowUploads);
        }

        private Button CreateSmallButton(string text, int x, int y)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(100, 35);
            btn.BackColor = System.Drawing.Color.OrangeRed;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            return btn;
        }

        private void LoadUsers()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        id,
                        username,
                        role,
                        favorite_genre,
                        created_at
                    FROM users
                    ORDER BY id ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUsers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Users load error: " + ex.Message);
                }
            }
        }

        private void LoadSongs()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        id,
                        title,
                        artist,
                        genre,
                        music_url,
                        created_at
                    FROM songs
                    ORDER BY id ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSongs.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Songs load error: " + ex.Message);
                }
            }
        }

        private void LoadSwipes()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        sw.id,
                        u.username,
                        s.title,
                        s.genre,
                        sw.action,
                        sw.created_at
                    FROM song_swipes sw
                    INNER JOIN users u ON sw.user_id = u.id
                    INNER JOIN songs s ON sw.song_id = s.id
                    ORDER BY sw.created_at DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSwipes.DataSource = dt;
                    lblSwipesTitle.Text = "Swipe Activity";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Swipes load error: " + ex.Message);
                }
            }
        }

        private void LoadUserLikes()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        ul.id,
                        u1.username AS user_who_liked,
                        u2.username AS liked_user,
                        ul.created_at
                    FROM user_likes ul
                    INNER JOIN users u1 ON ul.user_id = u1.id
                    INNER JOIN users u2 ON ul.liked_user_id = u2.id
                    ORDER BY ul.created_at DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSwipes.DataSource = dt;
                    lblSwipesTitle.Text = "User Likes";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User likes load error: " + ex.Message);
                }
            }
        }

        private void LoadPlaylists()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        p.id,
                        u.username,
                        p.name,
                        p.description,
                        p.created_at
                    FROM playlists p
                    INNER JOIN users u ON p.user_id = u.id
                    ORDER BY p.created_at DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSwipes.DataSource = dt;
                    lblSwipesTitle.Text = "Playlists";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Playlists load error: " + ex.Message);
                }
            }
        }

        private void LoadUploads()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        t.id,
                        u.username,
                        p.name AS playlist,
                        t.title,
                        t.artist,
                        t.genre,
                        t.file_path,
                        t.created_at
                    FROM uploaded_tracks t
                    INNER JOIN users u ON t.user_id = u.id
                    LEFT JOIN playlists p ON t.playlist_id = p.id
                    ORDER BY t.created_at DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSwipes.DataSource = dt;
                    lblSwipesTitle.Text = "Uploaded Tracks";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Uploads load error: " + ex.Message);
                }
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.");
                return;
            }

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    INSERT INTO songs 
                    (title, artist, genre, music_url)
                    VALUES 
                    (@title, @artist, @genre, @url)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@artist", txtArtist.Text.Trim());
                    cmd.Parameters.AddWithValue("@genre", txtGenre.Text.Trim());
                    cmd.Parameters.AddWithValue("@url", txtUrl.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Song added.");
                    ClearSongInputs();
                    LoadSongs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add song error: " + ex.Message);
                }
            }
        }

        private void btnUpdateSong_Click(object sender, EventArgs e)
        {
            if (dgvSongs.CurrentRow == null)
            {
                MessageBox.Show("Select a song first.");
                return;
            }

            int songId = Convert.ToInt32(dgvSongs.CurrentRow.Cells["id"].Value);

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    UPDATE songs
                    SET title=@title,
                        artist=@artist,
                        genre=@genre,
                        music_url=@url
                    WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", songId);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@artist", txtArtist.Text.Trim());
                    cmd.Parameters.AddWithValue("@genre", txtGenre.Text.Trim());
                    cmd.Parameters.AddWithValue("@url", txtUrl.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Song updated.");
                    ClearSongInputs();
                    LoadSongs();
                    LoadSwipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update song error: " + ex.Message);
                }
            }
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            if (dgvSongs.CurrentRow == null)
            {
                MessageBox.Show("Select a song first.");
                return;
            }

            int songId = Convert.ToInt32(dgvSongs.CurrentRow.Cells["id"].Value);

            DialogResult result = MessageBox.Show(
                "Delete selected song?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM songs WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", songId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Song deleted.");
                    ClearSongInputs();
                    LoadSongs();
                    LoadSwipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete song error: " + ex.Message);
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Select user first.");
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["id"].Value);
            string role = dgvUsers.CurrentRow.Cells["role"].Value.ToString();

            if (role == "superadmin")
            {
                MessageBox.Show("You cannot delete super admin.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Delete selected user and all their data?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM users WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User deleted.");
                    LoadUsers();
                    LoadSongs();
                    LoadSwipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete user error: " + ex.Message);
                }
            }
        }

        private void dgvSongs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSongs.Rows[e.RowIndex];

            txtTitle.Text = row.Cells["title"].Value?.ToString();
            txtArtist.Text = row.Cells["artist"].Value?.ToString();
            txtGenre.Text = row.Cells["genre"].Value?.ToString();
            txtUrl.Text = row.Cells["music_url"].Value?.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
            LoadSongs();
            LoadSwipes();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void ClearSongInputs()
        {
            txtTitle.Clear();
            txtArtist.Clear();
            txtGenre.Clear();
            txtUrl.Clear();
        }
    }
}