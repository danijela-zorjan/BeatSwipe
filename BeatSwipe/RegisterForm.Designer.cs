using System.Drawing;

namespace BeatSwipe
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSub;

        private System.Windows.Forms.Panel mainPanel;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();

            this.mainPanel = new System.Windows.Forms.Panel();

            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();

            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.lblTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // FORM
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "BeatSwipe - Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // SIDEBAR
            sidebar.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            sidebar.Location = new System.Drawing.Point(0, 0);
            sidebar.Size = new System.Drawing.Size(250, 600);

            lblLogo.Text = "BeatSwipe";
            lblLogo.ForeColor = System.Drawing.Color.OrangeRed;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblLogo.Location = new System.Drawing.Point(20, 40);
            lblLogo.Size = new System.Drawing.Size(200, 40);

            lblSub.Text = "Create account";
            lblSub.ForeColor = System.Drawing.Color.Gray;
            lblSub.Location = new System.Drawing.Point(20, 90);

            sidebar.Controls.Add(lblLogo);
            sidebar.Controls.Add(lblSub);

            // MAIN PANEL
            mainPanel.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            mainPanel.Location = new System.Drawing.Point(320, 80);
            mainPanel.Size = new System.Drawing.Size(500, 420);

            // TITLE
            lblTitle.Text = "REGISTER";
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(170, 30);
            lblTitle.Size = new System.Drawing.Size(200, 40);

            // USERNAME
            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new System.Drawing.Point(120, 100);
            txtUsername.Size = new System.Drawing.Size(260, 30);

            txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);

            // PASSWORD
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.PasswordChar = '\0';
            txtPassword.Location = new System.Drawing.Point(120, 160);
            txtPassword.Size = new System.Drawing.Size(260, 30);

            txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);

            // CONFIRM
            txtConfirm.Text = "Confirm Password";
            txtConfirm.ForeColor = Color.Gray;
            txtConfirm.PasswordChar = '\0';
            txtConfirm.Location = new System.Drawing.Point(120, 220);
            txtConfirm.Size = new System.Drawing.Size(260, 30);

            txtConfirm.Enter += new System.EventHandler(this.txtConfirm_Enter);
            txtConfirm.Leave += new System.EventHandler(this.txtConfirm_Leave);

            // REGISTER BUTTON
            btnRegister.Text = "REGISTER";
            btnRegister.BackColor = System.Drawing.Color.OrangeRed;
            btnRegister.ForeColor = System.Drawing.Color.White;
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegister.Location = new System.Drawing.Point(160, 290);
            btnRegister.Size = new System.Drawing.Size(180, 40);
            btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // BACK BUTTON
            btnBack.Text = "BACK";
            btnBack.BackColor = System.Drawing.Color.DarkGray;
            btnBack.ForeColor = System.Drawing.Color.Black;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Location = new System.Drawing.Point(160, 340);
            btnBack.Size = new System.Drawing.Size(180, 40);
            btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // ADD CONTROLS
            mainPanel.Controls.Add(lblTitle);
            mainPanel.Controls.Add(txtUsername);
            mainPanel.Controls.Add(txtPassword);
            mainPanel.Controls.Add(txtConfirm);
            mainPanel.Controls.Add(btnRegister);
            mainPanel.Controls.Add(btnBack);

            this.Controls.Add(sidebar);
            this.Controls.Add(mainPanel);

            this.ResumeLayout(false);
        }
    }
}