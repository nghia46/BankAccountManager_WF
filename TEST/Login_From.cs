using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Managerment
{
    public partial class Login_From : Form
    {
        public static bool IsLoginSuccessful { get; private set; }
        UserServices _userservices = new UserServices();

        public Login_From()
        {
            InitializeComponent();
            // Set to no text.
            txtPassword.Text = "";
            // The password character is an asterisk.
            txtPassword.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtPassword.MaxLength = 14;
        }

        private void cbshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            { txtPassword.PasswordChar = '*'; }
        }
        internal void Login()
        {
            List<User> list = _userservices.GetAll().ToList();
            foreach (User user in list)
            {
                if (user.UserName == txtUsername.Text.Trim() && user.Password == txtPassword.Text.Trim())
                {
                    IsLoginSuccessful = true;
                    ManagermentForm form = new ManagermentForm();
                    form.Show();

                    // Close the Login_Form
                    this.Hide();
                    return;
                }
                else
                {
                    IsLoginSuccessful = false;
                }
            }
            // Login failed
            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login_From_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "Administrator";
            txtPassword.Text = "1234";
            Login();
        }
    }
}
