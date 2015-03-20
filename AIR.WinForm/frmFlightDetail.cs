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
    public partial class frmFlightDetail : Form
    {
        public frmFlightDetail(Flight flightDetails)
        {
            InitializeComponent();
            lblFlightNumber.Text = flightDetails.Number;
            lblFlightFrom.Text = flightDetails.Source;
            lblFlightTo.Text = flightDetails.Destination;
            lblFlightDep.Text = flightDetails.Departure.ToString();
            lblFlightArr.Text = flightDetails.Arrival.ToString();
            lblAircraftType.Text = flightDetails.Aircraft.Name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }
}
