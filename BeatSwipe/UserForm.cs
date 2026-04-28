using System;
using System.Data;
using System.Diagnostics;
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

            lblUser.Text = "User: " + Program.LoggedUsername;

            LoadSongs();
            LoadMatches();
            ShowSong();
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
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}