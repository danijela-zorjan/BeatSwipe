using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeatSwipe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            cmbGenre.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, username, role FROM users WHERE username=@username AND password=@password";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Program.LoggedUserId = Convert.ToInt32(reader["id"]);
                        Program.LoggedUsername = reader["username"].ToString();
                        Program.LoggedRole = reader["role"].ToString();

                        if (Program.LoggedRole == "superadmin")
                        {
                            SuperAdminForm admin = new SuperAdminForm();
                            admin.Show();
                        }
                        else
                        {
                            UserForm user = new UserForm();
                            user.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login error: " + ex.Message);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    INSERT INTO users 
                    (username, password, role, favorite_genre) 
                    VALUES 
                    (@username, @password, 'user', @genre)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@genre", cmbGenre.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User registered.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Register error: " + ex.Message);
                }
            }
        }
    }
}