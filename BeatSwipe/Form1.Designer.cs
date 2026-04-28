using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeatSwipe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Panel mainPanel;

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblSlogan;

        private Label lblFeature1Title;
        private Label lblFeature1Text;
        private Label lblFeature2Title;
        private Label lblFeature2Text;
        private Label lblFeature3Title;
        private Label lblFeature3Text;

        private Button btnGetStarted;
        private Button btnLogin;
        private Button btnGuest;
        private Button btnClose;

        private Label lblWelcome;
        private Label lblFooter1;
        private Label lblFooter2;
        private Label lblFooter3;

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblFeature1Title = new System.Windows.Forms.Label();
            this.lblFeature1Text = new System.Windows.Forms.Label();
            this.lblFeature2Title = new System.Windows.Forms.Label();
            this.lblFeature2Text = new System.Windows.Forms.Label();
            this.lblFeature3Title = new System.Windows.Forms.Label();
            this.lblFeature3Text = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.lblFooter1 = new System.Windows.Forms.Label();
            this.lblFooter2 = new System.Windows.Forms.Label();
            this.lblFooter3 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.btnClose);
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Controls.Add(this.lblSubtitle);
            this.mainPanel.Controls.Add(this.lblSlogan);
            this.mainPanel.Controls.Add(this.lblFeature1Title);
            this.mainPanel.Controls.Add(this.lblFeature1Text);
            this.mainPanel.Controls.Add(this.lblFeature2Title);
            this.mainPanel.Controls.Add(this.lblFeature2Text);
            this.mainPanel.Controls.Add(this.lblFeature3Title);
            this.mainPanel.Controls.Add(this.lblFeature3Text);
            this.mainPanel.Controls.Add(this.lblWelcome);
            this.mainPanel.Controls.Add(this.btnGetStarted);
            this.mainPanel.Controls.Add(this.btnLogin);
            this.mainPanel.Controls.Add(this.btnGuest);
            this.mainPanel.Controls.Add(this.lblFooter1);
            this.mainPanel.Controls.Add(this.lblFooter2);
            this.mainPanel.Controls.Add(this.lblFooter3);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1315, 809);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(585, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(190, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1250, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(85, 165);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(520, 80);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "BEATSWIPE";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblSubtitle.Location = new System.Drawing.Point(95, 250);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(500, 40);
            this.lblSubtitle.TabIndex = 5;
            this.lblSubtitle.Text = "CONNECT THROUGH MUSIC";
            // 
            // lblSlogan
            // 
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.lblSlogan.Location = new System.Drawing.Point(95, 320);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(520, 40);
            this.lblSlogan.TabIndex = 6;
            this.lblSlogan.Text = "Swipe. Match. Vibe. Together.";
            // 
            // lblFeature1Title
            // 
            this.lblFeature1Title.BackColor = System.Drawing.Color.Transparent;
            this.lblFeature1Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFeature1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.lblFeature1Title.Location = new System.Drawing.Point(95, 395);
            this.lblFeature1Title.Name = "lblFeature1Title";
            this.lblFeature1Title.Size = new System.Drawing.Size(350, 30);
            this.lblFeature1Title.TabIndex = 7;
            this.lblFeature1Title.Text = "♪  FIND YOUR VIBE";
            // 
            // lblFeature1Text
            // 
            this.lblFeature1Text.BackColor = System.Drawing.Color.Transparent;
            this.lblFeature1Text.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFeature1Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.lblFeature1Text.Location = new System.Drawing.Point(130, 430);
            this.lblFeature1Text.Name = "lblFeature1Text";
            this.lblFeature1Text.Size = new System.Drawing.Size(350, 55);
            this.lblFeature1Text.TabIndex = 8;
            this.lblFeature1Text.Text = "Meet people who share your\nmusic taste and mood.";
            // 
            // lblFeature2Title
            // 
            this.lblFeature2Title.BackColor = System.Drawing.Color.Transparent;
            this.lblFeature2Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFeature2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.lblFeature2Title.Location = new System.Drawing.Point(95, 505);
            this.lblFeature2Title.Name = "lblFeature2Title";
            this.lblFeature2Title.Size = new System.Drawing.Size(350, 30);
            this.lblFeature2Title.TabIndex = 9;
            this.lblFeature2Title.Text = "♥  SWIPE & MATCH";
            // 
            // lblFeature2Text
            // 
            this.lblFeature2Text.BackColor = System.Drawing.Color.Transparent;
            this.lblFeature2Text.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFeature2Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.lblFeature2Text.Location = new System.Drawing.Point(130, 540);
            this.lblFeature2Text.Name = "lblFeature2Text";
            this.lblFeature2Text.Size = new System.Drawing.Size(350, 55);
            this.lblFeature2Text.TabIndex = 10;
            this.lblFeature2Text.Text = "Swipe right to like,\nleft to pass.";
            // 
            // lblFeature3Title
            // 
            this.lblFeature3Title.BackColor = System.Drawing.Color.Transparent;
            this.lblFeature3Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFeature3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.lblFeature3Title.Location = new System.Drawing.Point(95, 610);
            this.lblFeature3Title.Name = "lblFeature3Title";
            this.lblFeature3Title.Size = new System.Drawing.Size(350, 30);
            this.lblFeature3Title.TabIndex = 11;
            this.lblFeature3Title.Text = "☁  CHAT & CONNECT";
            // 
            // lblFeature3Text
            // 
            this.lblFeature3Text.BackColor = System.Drawing.Color.Transparent;
            this.lblFeature3Text.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFeature3Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.lblFeature3Text.Location = new System.Drawing.Point(130, 645);
            this.lblFeature3Text.Name = "lblFeature3Text";
            this.lblFeature3Text.Size = new System.Drawing.Size(350, 55);
            this.lblFeature3Text.TabIndex = 12;
            this.lblFeature3Text.Text = "Chat anonymously,\nshare songs and connect.";
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(690, 460);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(420, 35);
            this.lblWelcome.TabIndex = 13;
            this.lblWelcome.Text = "WELCOME TO BEATSWIPE";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.btnGetStarted.FlatAppearance.BorderSize = 0;
            this.btnGetStarted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.btnGetStarted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStarted.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnGetStarted.ForeColor = System.Drawing.Color.White;
            this.btnGetStarted.Location = new System.Drawing.Point(650, 515);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(300, 69);
            this.btnGetStarted.TabIndex = 14;
            this.btnGetStarted.Text = "GET STARTED   →";
            this.btnGetStarted.UseVisualStyleBackColor = false;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnLogin.Location = new System.Drawing.Point(970, 515);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(285, 69);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "I ALREADY HAVE AN ACCOUNT";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnGuest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.btnGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(10)))));
            this.btnGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.btnGuest.Location = new System.Drawing.Point(760, 610);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(320, 55);
            this.btnGuest.TabIndex = 16;
            this.btnGuest.Text = "CONTINUE AS GUEST";
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // lblFooter1
            // 
            this.lblFooter1.BackColor = System.Drawing.Color.Transparent;
            this.lblFooter1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFooter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblFooter1.Location = new System.Drawing.Point(97, 759);
            this.lblFooter1.Name = "lblFooter1";
            this.lblFooter1.Size = new System.Drawing.Size(200, 25);
            this.lblFooter1.TabIndex = 17;
            this.lblFooter1.Text = "100% FREE";
            // 
            // lblFooter2
            // 
            this.lblFooter2.BackColor = System.Drawing.Color.Transparent;
            this.lblFooter2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFooter2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblFooter2.Location = new System.Drawing.Point(480, 759);
            this.lblFooter2.Name = "lblFooter2";
            this.lblFooter2.Size = new System.Drawing.Size(300, 25);
            this.lblFooter2.TabIndex = 18;
            this.lblFooter2.Text = "NO PERSONAL INFO REQUIRED";
            // 
            // lblFooter3
            // 
            this.lblFooter3.BackColor = System.Drawing.Color.Transparent;
            this.lblFooter3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFooter3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblFooter3.Location = new System.Drawing.Point(935, 759);
            this.lblFooter3.Name = "lblFooter3";
            this.lblFooter3.Size = new System.Drawing.Size(250, 25);
            this.lblFooter3.TabIndex = 19;
            this.lblFooter3.Text = "EVERYONE IS WELCOME";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1315, 809);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeatSwipe";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
    }
}