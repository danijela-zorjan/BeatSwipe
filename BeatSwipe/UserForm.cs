using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeatSwipe
{
    public partial class UserForm : Form
    {
        private DataTable songsTable;
        private int currentIndex = 0;
        private int currentSongId = 0;
        private string currentUrl = "";

        public UserForm()
        {
            InitializeComponent();

            SetPlaceholder(txtPlaylistName, "Playlist name");
            SetPlaceholder(txtPlaylistDescription, "Description");
            SetPlaceholder(txtTrackTitle, "Track title");
            SetPlaceholder(txtTrackArtist, "Artist");
            SetPlaceholder(txtTrackGenre, "Genre");

            lblUser.Text = "User: " + Program.LoggedUsername;

            LoadSongs();
            LoadMatches();
            LoadUsers();
            LoadPlaylists();
            LoadMyTracks();

            ShowSong();
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void LoadSongs()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT * FROM songs
                    WHERE id NOT IN 
                    (
                        SELECT song_id FROM song_swipes WHERE user_id=@user_id
                    )
                    ORDER BY id ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", Program.LoggedUserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    songsTable = new DataTable();
                    adapter.Fill(songsTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load songs error: " + ex.Message);
                }
            }
        }

        private void ShowSong()
        {
            if (songsTable == null || songsTable.Rows.Count == 0 || currentIndex >= songsTable.Rows.Count)
            {
                lblSongTitle.Text = "No more songs";
                lblArtist.Text = "Come back later";
                lblGenre.Text = "";
                btnLike.Enabled = false;
                btnPass.Enabled = false;
                btnPlay.Enabled = false;
                return;
            }

            DataRow row = songsTable.Rows[currentIndex];

            currentSongId = Convert.ToInt32(row["id"]);
            currentUrl = row["music_url"].ToString();

            lblSongTitle.Text = row["title"].ToString();
            lblArtist.Text = row["artist"].ToString();
            lblGenre.Text = row["genre"].ToString();

            btnLike.Enabled = true;
            btnPass.Enabled = true;
            btnPlay.Enabled = true;
        }

        private void SwipeSong(string action)
        {
            if (currentSongId == 0) return;

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    INSERT INTO song_swipes 
                    (user_id, song_id, action) 
                    VALUES 
                    (@user_id, @song_id, @action)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", Program.LoggedUserId);
                    cmd.Parameters.AddWithValue("@song_id", currentSongId);
                    cmd.Parameters.AddWithValue("@action", action);

                    cmd.ExecuteNonQuery();

                    currentIndex++;
                    ShowSong();
                    LoadMatches();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Swipe error: " + ex.Message);
                }
            }
        }

        private void LoadMatches()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        u.username AS matched_user,
                        s.genre AS genre,
                        COUNT(*) AS same_likes
                    FROM song_swipes a
                    JOIN song_swipes b ON a.song_id = b.song_id
                    JOIN users u ON b.user_id = u.id
                    JOIN songs s ON a.song_id = s.id
                    WHERE a.user_id=@user_id
                    AND b.user_id != @user_id
                    AND a.action='like'
                    AND b.action='like'
                    GROUP BY u.id, u.username, s.genre
                    ORDER BY same_likes DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", Program.LoggedUserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvMatches.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Matches error: " + ex.Message);
                }
            }
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
                favorite_genre
            FROM users
            WHERE id != @user_id
            AND role = 'user'
            ORDER BY username ASC"
                    ;

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", Program.LoggedUserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUsers.DataSource = dt;

                    if (dgvUsers.Columns.Contains("id"))
                    {
                        dgvUsers.Columns["id"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load users error: " + ex.Message);
                }
            }
        }
        private void LikeSelectedUser()
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Select user first.");
                return;
            }

            int likedUserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["id"].Value);

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    INSERT IGNORE INTO user_likes 
                    (user_id, liked_user_id)
                    VALUES 
                    (@user_id, @liked_user_id)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", Program.LoggedUserId);
                    cmd.Parameters.AddWithValue("@liked_user_id", likedUserId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User liked!");
                    LoadUsers();
                    LoadUserMatches();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Like user error: " + ex.Message);
                }
            }
        }

        private void LoadUserMatches()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT u.username AS mutual_match
                    FROM user_likes a
                    JOIN user_likes b 
                        ON a.user_id = b.liked_user_id 
                        AND a.liked_user_id = b.user_id
                    JOIN users u ON u.id = a.liked_user_id
                    WHERE a.user_id=@user_id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", Program.LoggedUserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUserMatches.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User matches error: " + ex.Message);
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
                    SELECT id, name 
                    FROM playlists 
                    WHERE user_id=@user_id
                    ORDER BY created_at DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", Program.LoggedUserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbPlaylists.DataSource = dt;
                    cmbPlaylists.DisplayMember = "name";
                    cmbPlaylists.ValueMember = "id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load playlists error: " + ex.Message);
                }
            }
        }

        private void CreatePlaylist()
        {
            if (string.IsNullOrWhiteSpace(txtPlaylistName.Text))
            {
                MessageBox.Show("Enter playlist name.");
                return;
            }

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    INSERT INTO playlists 
                    (user_id, name, description)
                    VALUES 
                    (@user_id, @name, @description)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", Program.LoggedUserId);
                    cmd.Parameters.AddWithValue("@name", txtPlaylistName.Text.Trim());
                    cmd.Parameters.AddWithValue("@description", txtPlaylistDescription.Text.Trim());

                    cmd.ExecuteNonQuery();

                    txtPlaylistName.Clear();
                    txtPlaylistDescription.Clear();

                    MessageBox.Show("Playlist created!");
                    LoadPlaylists();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Create playlist error: " + ex.Message);
                }
            }
        }

        private void UploadMp3()
        {
            if (cmbPlaylists.SelectedValue == null)
            {
                MessageBox.Show("Create or select playlist first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTrackTitle.Text))
            {
                MessageBox.Show("Enter track title.");
                return;
            }

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MP3 files (*.mp3)|*.mp3";

            if (dialog.ShowDialog() != DialogResult.OK) return;

            FileInfo fileInfo = new FileInfo(dialog.FileName);

            if (fileInfo.Length > 5 * 1024 * 1024)
            {
                MessageBox.Show("MP3 file is too large. Maximum size is 5MB.");
                return;
            }

            string uploadsFolder = Path.Combine(Application.StartupPath, "uploads");

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            string newFileName = Guid.NewGuid().ToString() + ".mp3";
            string newPath = Path.Combine(uploadsFolder, newFileName);

            File.Copy(dialog.FileName, newPath);

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    INSERT INTO uploaded_tracks
                    (user_id, playlist_id, title, artist, genre, file_path)
                    VALUES
                    (@user_id, @playlist_id, @title, @artist, @genre, @file_path)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", Program.LoggedUserId);
                    cmd.Parameters.AddWithValue("@playlist_id", cmbPlaylists.SelectedValue);
                    cmd.Parameters.AddWithValue("@title", txtTrackTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@artist", txtTrackArtist.Text.Trim());
                    cmd.Parameters.AddWithValue("@genre", txtTrackGenre.Text.Trim());
                    cmd.Parameters.AddWithValue("@file_path", newPath);

                    cmd.ExecuteNonQuery();

                    txtTrackTitle.Clear();
                    txtTrackArtist.Clear();
                    txtTrackGenre.Clear();

                    MessageBox.Show("MP3 uploaded!");
                    LoadMyTracks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Upload MP3 error: " + ex.Message);
                }
            }
        }

        private void LoadMyTracks()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        t.title,
                        t.artist,
                        t.genre,
                        p.name AS playlist,
                        t.file_path
                    FROM uploaded_tracks t
                    LEFT JOIN playlists p ON t.playlist_id = p.id
                    WHERE t.user_id=@user_id
                    ORDER BY t.created_at DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", Program.LoggedUserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvMyTracks.DataSource = dt;

                    if (dgvMyTracks.Columns.Contains("file_path"))
                    {
                        dgvMyTracks.Columns["file_path"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load my tracks error: " + ex.Message);
                }
            }
        }

        private void PlaySelectedUploadedTrack()
        {
            if (dgvMyTracks.CurrentRow == null)
            {
                MessageBox.Show("Select uploaded track first.");
                return;
            }

            string filePath = dgvMyTracks.CurrentRow.Cells["file_path"].Value.ToString();

            if (File.Exists(filePath))
            {
                Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            SwipeSong("like");
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            SwipeSong("pass");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(currentUrl))
            {
                Process.Start(currentUrl);
            }
            else
            {
                MessageBox.Show("No song URL found.");
            }
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            LoadMatches();
            LoadUserMatches();
        }

        private void btnLikeUser_Click(object sender, EventArgs e)
        {
            LikeSelectedUser();
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            CreatePlaylist();
        }

        private void btnUploadMp3_Click(object sender, EventArgs e)
        {
            UploadMp3();
        }

        private void btnPlayUploadedTrack_Click(object sender, EventArgs e)
        {
            PlaySelectedUploadedTrack();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}