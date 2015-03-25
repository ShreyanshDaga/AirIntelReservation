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
    public partial class frmMain : Form
    {
        frmLogin loginForm;
        frmAdmin adminPanel;
        ReservationServiceRef.ReservationServiceClient adminClient;
        bool bRunning = false;
       
        public frmMain()
        {
            InitializeComponent();
            if (!InitWCF())
                return;
            
            loginForm = new frmLogin(adminClient);
            loginForm.FormClosed += loginForm_FormClosed;
            loginForm.OnLoginClose += loginForm_OnLoginClose;
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        void loginForm_OnLoginClose(object sender, LoginFormEventArgs e)
        {
            // Get the login result here
            this.adminPanel = e.adminPanel;
            this.adminPanel.OnSignOut += adminPanel_OnSignOut;
            e.adminPanel.Show();
        }

        void adminPanel_OnSignOut(object sender, EventArgs e)
        {            
            this.adminPanel = null;
        }

        void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {            
            this.loginForm = null;
        }

        private bool InitWCF()
        {
            try
            {
                this.adminClient = new ReservationServiceRef.ReservationServiceClient();
                if (!adminClient.Ping())
                {
                    MessageBox.Show("Air Inter Reservation Service is unavailable!\nPlease start the service first and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.bRunning = false;
                    return false;
                }
                else
                {
                    this.bRunning = true;
                    return true;
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Air Inter Reservation Server is unavailable!", "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.bRunning = false;
                return false;
            }            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (!this.bRunning)
            {
                if (!InitWCF())
                {
                    this.Cursor = Cursors.Default;
                    return;
                }                    
            }

            if(this.loginForm != null)
            {
                // if instance is already running
                this.loginForm.Activate();
                this.Cursor = Cursors.Default;
                return;
            }            

            if(this.adminPanel != null)
            {                
                this.adminPanel.Activate();
                this.Cursor = Cursors.Default;
                return;
            }

            // If instance is not running
            this.Cursor = Cursors.Default;
            loginForm = new frmLogin(this.adminClient);
            loginForm.OnLoginClose += loginForm_OnLoginClose;
            loginForm.FormClosed += loginForm_FormClosed;
            loginForm.MdiParent = this;
            loginForm.Show();
        }
        private bool IsServiceAlive()
        {
            try
            {
                if (!this.adminClient.Ping())
                {
                    MessageBox.Show("WCF Service is no longer running.!\nPlease start the service in order to continue!", "WCF Service error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Incase service goes down before the ping is tested
                MessageBox.Show("WCF Service is no longer running.!\nPlease start the service in order to continue!", "WCF Service error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                return false;
            }

            return true;
        }
    }

    public class LoginFormEventArgs : EventArgs
    {
        public frmAdmin adminPanel { get; set; }
        public Admin loggedInAdmin { get; set; }
    }
}
