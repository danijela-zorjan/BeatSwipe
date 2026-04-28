using System;
using System.Windows.Forms;

namespace BeatSwipe
{
    public partial class UserGuestForm : Form
    {
        public UserGuestForm()
        {
            InitializeComponent();
        }

        // THIS FIXES YOUR ERROR
        private void UserGuestForm_Load(object sender, EventArgs e)
        {
            // runs when form opens
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login clicked");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
        }
    }
}