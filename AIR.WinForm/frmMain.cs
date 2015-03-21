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
        frmNewUser newuserForm;
        frmAdmin adminPanel;
        ReservationServiceRef.ReservationServiceClient adminClient;

       
        public frmMain()
        {
            InitializeComponent();
            InitWCF();            
            
            loginForm = new frmLogin(adminClient);
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        private void InitWCF()
        {
            try
            {
                this.adminClient = new ReservationServiceRef.ReservationServiceClient();                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Air Inter Reservation Server is unavailable!");
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
