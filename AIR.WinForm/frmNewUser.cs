using AIR.Entities;
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
        ReservationServiceRef.ReservationServiceClient adminClient;

        public frmNewUser(ReservationServiceRef.ReservationServiceClient adminClient)
        {
            InitializeComponent();
            this.adminClient = adminClient;
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
            Admin newAdmin = new Admin{Name = "", UserName = userName, PasswordHash = userPassword};

            if (!IsServiceAlive())
                return;
            // Make the call to the service
            var res = adminClient.CreateNewAdmin(newAdmin);

            if (res.IsSuccess)
            {
                MessageBox.Show(res.Results["0"]);
            }
            else
                MessageBox.Show(res.ErrorMessages["Error"]);
        }

        private bool IsServiceAlive()
        {
            if (!adminClient.Ping())
            {
                MessageBox.Show("Service is no longer running.!\nPlease start the service in order to continue!", "WCF Service error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
