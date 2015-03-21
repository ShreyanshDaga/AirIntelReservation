using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AIR.DAL;

namespace AIR.WinForm
{
    public partial class frmMain : Form
    {
        frmLogin loginForm;
        frmNewUser newuserForm;
        frmAdmin adminPanel;

       
        public frmMain()
        {
            InitializeComponent();

            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());

            API.Init();

            loginForm = new frmLogin();
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
