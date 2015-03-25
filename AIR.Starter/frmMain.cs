using AIR.WCFService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIR.Starter
{
    public partial class frmMain : Form
    {
        ServiceHost svcAIRService;
        ReservationService service;

        public frmMain()
        {            
            InitializeComponent();

            txtbxWCFService.Text = "This will start the WCF Service which is hosted in this application itself. The WCF service can be accessed at http://localhost:9999/AirIntelReservationService " + "This is required for the client applications to work. Please start this service first and make sure that the service is running.";
            txtbxClientAdmin.Text = "This will invoke the client instance of the Admin facing interface. This can be used for admin purpose.";
            txtbxClientUser.Text = "This will invoke the client instance of the Consumer facing interface. This can be used for booking tickets.";
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if(this.svcAIRService != null)
            {
                // Stop the service
                this.svcAIRService.Close();
                this.svcAIRService = null;
                this.service = null;
                this.btnStartStop.Text = "Start Service";

                // Service is stopped
                this.lblServiceStatus.Text = "Service is not running.!";
                this.lblServiceStatus.ForeColor = Color.Red;
            }
            else if(this.svcAIRService == null)
            {

                // Start the service
                try
                {
                    this.service = new ReservationService();
                    this.svcAIRService = new ServiceHost(this.service);
                    this.svcAIRService.Open();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unable to start WCF service.\nPlease restart the application with administrator previleges","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                
                // Initiazlies the service
                if(this.service.InitService() != "Success")
                {
                    MessageBox.Show("Error Initializing SQL server database.!\n Kindly make sure SQL server version : (LocalDB)\v11.0 is running, and try again.");
                    return;
                }

                // Service is started
                this.btnStartStop.Text = "Stop Service";                
                this.lblServiceStatus.Text = "Service running.!";
                this.lblServiceStatus.ForeColor = Color.Green;
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Launch admin instance
            Process padminClient = new Process();

            padminClient.StartInfo.FileName = "AIR.WinForm.exe";
            padminClient.Start();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            // Launch consumer instance
            Process puserClient = new Process();

            puserClient.StartInfo.FileName = "AIR.WinClient.exe";
            puserClient.Start();
        }
        
    }
}
