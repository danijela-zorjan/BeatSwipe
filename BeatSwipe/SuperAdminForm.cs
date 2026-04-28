using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeatSwipe
{
    public partial class SuperAdminForm : Form
    {
        public SuperAdminForm()
        {
            InitializeComponent();
            LoadUsers();
            LoadSongs();
            LoadSwipes();
        }

        private void LoadUsers()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, username, role, favorite_genre, created_at FROM users";

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

                    string query = "SELECT id, title, artist, genre, music_url FROM songs";

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
                    JOIN users u ON sw.user_id = u.id
                    JOIN songs s ON sw.song_id = s.id
                    ORDER BY sw.created_at DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSwipes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Swipes load error: " + ex.Message);
                }
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
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

        private void btnDeleteSong_Click(object sender, EventArgs e)
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

                    string deleteSwipes = "DELETE FROM song_swipes WHERE song_id=@id";
                    MySqlCommand cmd1 = new MySqlCommand(deleteSwipes, conn);
                    cmd1.Parameters.AddWithValue("@id", songId);
                    cmd1.ExecuteNonQuery();

                    string deleteSong = "DELETE FROM songs WHERE id=@id";
                    MySqlCommand cmd2 = new MySqlCommand(deleteSong, conn);
                    cmd2.Parameters.AddWithValue("@id", songId);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Song deleted.");
                    LoadSongs();
                    LoadSwipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete song error: " + ex.Message);
                }
            }
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