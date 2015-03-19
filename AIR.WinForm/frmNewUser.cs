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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Check for user name, and password confirmation
            if (txtbxUserName.Text == "" || txtbxUserPassConf.Text == "" || txtbxUserPassword.Text == "")
            {
                MessageBox.Show("Please enter all the fields to register new user");
                return;
            }

            string userName, userPassword;
            userName = txtbxUserName.Text;
            userPassword = txtbxUserPassword.Text;

            // Create User/Admin here
            bool bAdmin;

            if(rdbtnAdmin.Checked)
                bAdmin = true;
            else 
                bAdmin = false;

            var bres = API.RegisterNewUser(userName, userPassword, bAdmin);

            if (bres)
            {
                MessageBox.Show("New User registered.!");
            }
            else
                MessageBox.Show("New user not registered");
        }
    }
}
