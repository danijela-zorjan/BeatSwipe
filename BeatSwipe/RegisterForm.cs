using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BeatSwipe
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Fill all fields!");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                // check if user exists
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username=@u";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@u", username);

                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (exists > 0)
                {
                    MessageBox.Show("Username already exists!");
                    return;
                }

                // insert user
                string insertQuery = "INSERT INTO users(username, password) VALUES(@u, @p)";
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account created successfully!");

                LoginForm f = new LoginForm();
                f.Show();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }
    }
}