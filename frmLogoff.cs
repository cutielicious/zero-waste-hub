using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group20_Project
{
    public partial class frmLogIn : Form
    {
        ErrorProvider errorProvider1 = new();
        const string  OWNERPASSWORD = "password";
        const string OWNERUSERNAME = "username";
        const string ASSISTANTPASSWORD = "password1";
        const string ASSISTANTUSERNAME = "username1";

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Please enter username!");

            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Please enter password!");
            }
            else
            {
                if(txtUsername.Text == OWNERUSERNAME && txtPassword.Text == OWNERPASSWORD)
                {
                    Session.UserRole = "Owner";
                    Session.UserName = txtUsername.Text;
                    MessageBox.Show("Welcome Owner!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmHomepage Homepage = new frmHomepage();
                    Homepage.Show();
                    this.Hide();
                }
                else if (txtUsername.Text == ASSISTANTUSERNAME && txtPassword.Text == ASSISTANTPASSWORD)
                {
                    Session.UserRole = "Assistant";
                    Session.UserName = txtUsername.Text;
                    MessageBox.Show("Welcome Assistant!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmHomepage Homepage = new frmHomepage();
                    Homepage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }           
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txtUsername.Text)))
            {
                errorProvider1.SetError(txtUsername, "");

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }


    }
}
