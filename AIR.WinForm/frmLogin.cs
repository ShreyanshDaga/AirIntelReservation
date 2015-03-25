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
        ReservationServiceRef.ReservationServiceClient adminClient;
        frmNewUser formNewUser;

        public frmLogin(ReservationServiceRef.ReservationServiceClient adminClient)
        {
            InitializeComponent();
            this.txtbxUserName.GotFocus += txtbxUserName_GotFocus;
            this.txtbxUserPassword.GotFocus += txtbxUserPassword_GotFocus;
            this.txtbxUserName.Leave += txtbxUserName_Leave;
            this.txtbxUserPassword.Leave += txtbxUserPassword_Leave;

            this.adminClient = adminClient;
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
            this.formNewUser = new frmNewUser(this.adminClient);

            this.formNewUser.FormClosed += formNewUser_FormClosed;
            this.formNewUser.MdiParent = this.MdiParent;
            this.formNewUser.Show();
        }

        void formNewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.formNewUser = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string userName, userPassword;

            lblLoginErrorMessage.Text = "Signing in...";
            lblLoginErrorMessage.ForeColor = Color.Black;


            userName = txtbxUserName.Text;
            userPassword = txtbxUserPassword.Text;

            if (!IsServiceAlive())
                return;
            // Call the service            
            var res = adminClient.AdminLogin(userName, userPassword);

            this.Cursor = Cursors.Default;

            if(!res.IsSuccess)
            {
                lblLoginErrorMessage.Text = "Error: Incorrect username/password!";                    
                lblLoginErrorMessage.ForeColor = Color.Red;
            }

            if (!IsServiceAlive())
                return;
            var currentAdmin = adminClient.GetAdminByUserName(userName);
            frmAdmin admin = new frmAdmin(adminClient, currentAdmin);
            admin.MdiParent = this.MdiParent;
            admin.Show();
            this.Close();                        
        }

        private bool IsServiceAlive()
        {
            if(!adminClient.Ping())
            {
                MessageBox.Show("Service is no longer running.!\nPlease start the service in order to continue!", "WCF Service error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
