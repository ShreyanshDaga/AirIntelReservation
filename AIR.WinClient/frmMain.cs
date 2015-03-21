using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIR.WinClient
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            InitWCFService();
            int iWidth = 10;
            int iBusinessSeats = 10, iFirstSeats = 5, iEconomySeats = 40;

            string[] seatMap = new string[96];

            // Print Columns
            for(int i = 0;i<iWidth;i++)
            {
                char c = Convert.ToChar((65 + i));

                seatMap[0] += (" " + c.ToString() + " ");
                if(i == 0)
                    seatMap[1] += ("--- FIRST CLASS ---");

                for(int j = 2;j<7;j++)
                {
                    seatMap[j] += (" " + "O" + " ");
                }
                if (i == 0)
                    seatMap[7] += ("--- BUSINESS CLASS ---");
                for(int j = 8;j<18;j++)
                {
                    seatMap[j] += (" " + "X" + " ");
                }
                if (i == 0)
                    seatMap[18] += ("--- ECONOMY CLASS ---");
                for (int j = 19; j < 95; j++)
                {
                    seatMap[j] += (" " + "X" + " ");
                }
            }


            txtbxSeatMap.Lines = seatMap;
            lblAircraftType.Text += " Airbus A380";


            //rtxtbxSeatMap.SelectionStart = rtxtbxSeatMap.TextLength;
            //rtxtbxSeatMap.SelectionLength = 0;

            //rtxtbxSeatMap.SelectionColor = Color.Brown;
            //rtxtbxSeatMap.AppendText("Hello");
            //rtxtbxSeatMap.SelectionColor = rtxtbxSeatMap.ForeColor;

            //rtxtbxSeatMap.SelectionStart = rtxtbxSeatMap.TextLength;
            //rtxtbxSeatMap.SelectionLength = 0;

            //rtxtbxSeatMap.SelectionColor = Color.Blue;
            //rtxtbxSeatMap.AppendText("World");
            //rtxtbxSeatMap.SelectionColor = rtxtbxSeatMap.ForeColor;

            grpbxFlightDetails.Enabled = false;
        }

        private void InitWCFService()
        {
            BasicHttpBinding httpBinding = new BasicHttpBinding();

        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            grpbxFlightDetails.Enabled = true;
        }


    }
}
