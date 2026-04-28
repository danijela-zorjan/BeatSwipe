using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BeatSwipe
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // USERNAME
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        // PASSWORD
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.PasswordChar = '\0';
            }
        }

        // CONFIRM PASSWORD
        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "Confirm Password")
            {
                txtConfirm.Text = "";
                txtConfirm.ForeColor = Color.Black;
                txtConfirm.PasswordChar = '*';
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                txtConfirm.Text = "Confirm Password";
                txtConfirm.ForeColor = Color.Gray;
                txtConfirm.PasswordChar = '\0';
            }
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