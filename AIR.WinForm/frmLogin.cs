using AIR.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIR.WinForm
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
            this.txtbxUserName.GotFocus += txtbxUserName_GotFocus;
            this.txtbxUserPassword.GotFocus += txtbxUserPassword_GotFocus;
            this.txtbxUserName.Leave += txtbxUserName_Leave;
            this.txtbxUserPassword.Leave += txtbxUserPassword_Leave;
        }

        void txtbxUserPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtbxUserPassword.Text == "")
                this.txtbxUserPassword.Text = "password";
        }

        void txtbxUserName_Leave(object sender, EventArgs e)
        {
            if (this.txtbxUserName.Text == "")
                this.txtbxUserName.Text = "username";
        }

        void txtbxUserPassword_GotFocus(object sender, EventArgs e)
        {
            this.txtbxUserPassword.Text = "";
        }

        void txtbxUserName_GotFocus(object sender, EventArgs e)
        {
            this.txtbxUserName.Text = "";
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            frmNewUser formNewUser = new frmNewUser();

            formNewUser.MdiParent = this.MdiParent;            
            formNewUser.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName, userPassword;

            lblLoginErrorMessage.Text = "Signing in...";
            lblLoginErrorMessage.ForeColor = Color.Black;


            userName = txtbxUserName.Text;
            userPassword = txtbxUserPassword.Text;

            if (rdbtnAdmin.Checked)
            {
                if(!API.AdminSignIn(userName, userPassword))
                {
                    lblLoginErrorMessage.Text = "Error: Incorrect username/password!";                    
                    lblLoginErrorMessage.ForeColor = Color.Red;
                }
            }

            if (rdbtnUser.Checked)
            {
                if (!API.UserSignIn(userName, userPassword))
                {
                    lblLoginErrorMessage.Text = "Error: Incorrect username/password!";
                    lblLoginErrorMessage.ForeColor = Color.Red;
                }
            }
        }
    }
}
