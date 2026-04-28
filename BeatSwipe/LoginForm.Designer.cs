namespace BeatSwipe
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(430, 560);
            this.BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "BeatSwipe - Login";

            this.lblLogo.Text = "BeatSwipe";
            this.lblLogo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Location = new System.Drawing.Point(0, 35);
            this.lblLogo.Size = new System.Drawing.Size(430, 60);

            this.lblSub.Text = "Swipe music. Match people.";
            this.lblSub.ForeColor = System.Drawing.Color.Gray;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSub.Location = new System.Drawing.Point(0, 95);
            this.lblSub.Size = new System.Drawing.Size(430, 30);

            this.lblUsername.Text = "Username";
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.Location = new System.Drawing.Point(70, 145);
            this.lblUsername.Size = new System.Drawing.Size(280, 22);

            this.txtUsername.Location = new System.Drawing.Point(70, 170);
            this.txtUsername.Size = new System.Drawing.Size(280, 29);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblPassword.Text = "Password";
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Location = new System.Drawing.Point(70, 215);
            this.lblPassword.Size = new System.Drawing.Size(280, 22);

            this.txtPassword.Location = new System.Drawing.Point(70, 240);
            this.txtPassword.Size = new System.Drawing.Size(280, 29);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.PasswordChar = '*';

            this.lblGenre.Text = "Favorite genre";
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGenre.Location = new System.Drawing.Point(70, 285);
            this.lblGenre.Size = new System.Drawing.Size(280, 22);

            this.cmbGenre.Location = new System.Drawing.Point(70, 310);
            this.cmbGenre.Size = new System.Drawing.Size(280, 29);
            this.cmbGenre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGenre.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.cmbGenre.ForeColor = System.Drawing.Color.White;
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.Items.AddRange(new object[]
            {
                "Techno",
                "House",
                "Hip-Hop",
                "Pop",
                "Rock",
                "Trap",
                "Drum and Bass"
            });

            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Location = new System.Drawing.Point(70, 380);
            this.btnLogin.Size = new System.Drawing.Size(280, 45);
            this.btnLogin.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.btnRegister.Text = "REGISTER USER";
            this.btnRegister.Location = new System.Drawing.Point(70, 440);
            this.btnRegister.Size = new System.Drawing.Size(280, 45);
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}