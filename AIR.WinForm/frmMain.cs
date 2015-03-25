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
        //frmNewUser newuserForm;
        //frmAdmin adminPanel;
        ReservationServiceRef.ReservationServiceClient adminClient;
        bool bRunning = false;

       
        public frmMain()
        {
            InitializeComponent();
            if (!InitWCF())
                return;
            
            loginForm = new frmLogin(adminClient);
            loginForm.FormClosed += loginForm_FormClosed;
            loginForm.MdiParent = this;
            loginForm.Show();
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

            this.Cursor = Cursors.Default;
            loginForm = new frmLogin(adminClient);
            loginForm.FormClosed += loginForm_FormClosed;
            loginForm.MdiParent = this;
            loginForm.Show();
        }
    }
}
