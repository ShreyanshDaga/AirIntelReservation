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
    public partial class frmAdmin : Form
    {
        Admin loggedinAdmin;
        List<Aircraft> aircraftsInService;
        List<Flight> scheduledFlights;
        frmFlightDetail frmFlightDetail;
        frmAircraftDetail frmAircraftDetail;
        ReservationServiceRef.ReservationServiceClient adminClient;

        public frmAdmin(ReservationServiceRef.ReservationServiceClient adminClient,Admin loggedInAdmin)
        {
            InitializeComponent();
            this.loggedinAdmin = loggedInAdmin;
            this.adminClient = adminClient;

            txtbxAdminName.Text = loggedInAdmin.Name;
            txtbxAdminUName.Text = loggedInAdmin.Name;
            this.lbluserName.Text += loggedinAdmin.Name;                                                 

            // List of aircrafts
            Refresh_Aircrafts();
            // List of Flights     
            Refresh_Flights();
        }

        private void btnAddAircraft_Click(object sender, EventArgs e)
        {
            if (!Validate_AddNewAircraft())
                return;

            int iWidth, iBusinessSeats, iEconSeats, iFirstSeats, iTotal;

            iWidth = Convert.ToInt32(txtbxNewAircraftWidth.Text);
            iBusinessSeats = Convert.ToInt32(txtbxNewAircraftBusinessSeats.Text);
            iEconSeats = Convert.ToInt32(txtbxNewAircraftEconSeats.Text);
            iFirstSeats = Convert.ToInt32(txtbxNewAircraftFirstSeats.Text);
            iTotal = iBusinessSeats + iEconSeats + iFirstSeats;

            var newAircraft = new Aircraft { Name = txtbxNewAircraftName.Text, FusalageWidth = iWidth, BusinessSeats = iBusinessSeats, EconomySeats = iEconSeats, FirstClassSeats=iFirstSeats, TotalSeats = iTotal};
            
            var res = adminClient.CreateNewAircraft(newAircraft, loggedinAdmin.Id);

            if (res.IsSuccess)
                MessageBox.Show(res.Results["0"]);
            else
                MessageBox.Show(res.ErrorMessages["Error"]);

            btnClear_Click(sender, e);
            Refresh_Aircrafts();
        }        

        private void btnClear_Click(object sender, EventArgs e)
        {            
            txtbxNewAircraftWidth.Clear();
            txtbxNewAircraftName.Clear();
            txtbxNewAircraftFirstSeats.Clear();
            txtbxNewAircraftEconSeats.Clear();
            txtbxNewAircraftBusinessSeats.Clear();
        }

        private bool Validate_AddNewAircraft()
        {
            // Validate all the fields
            return true;
        }

        private void btnEditAdminDetails_Click(object sender, EventArgs e)
        {
            txtbxAdminName.Enabled = true;
            txtbxAdminNewPwd.Enabled = true;
            txtbxAdminUName.Enabled = true;
            txtbxAdminOldPwd.Enabled = true;

            btnSaveDetails.Enabled = true;
            btnEditAdminDetails.Enabled = false;
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            if (!Validate_EditPersonalDetails())
            {
                MessageBox.Show("Validation Error");
                return;
            }

            // Save Changes here

            txtbxAdminName.Enabled = false;
            txtbxAdminUName.Enabled = false;
            txtbxAdminNewPwd.Enabled = false;
            txtbxAdminOldPwd.Enabled = false;

            btnSaveDetails.Enabled = false;
            btnEditAdminDetails.Enabled = true;
        }

        private bool Validate_EditPersonalDetails()
        {
            // Check for validation errors here
            return true;
        }

        private void btnAddNewFlight_Click(object sender, EventArgs e)
        {
            Validate_AddNewFlight();

            float fEconFare, fBusinessFare, fFirstFare;
            DateTime dtDep, dtArr;
            string strTo, strFrom;
            string flightNumber;

            Aircraft selectedAircraft = (Aircraft)this.cmbbxAircraft.SelectedItem;

            flightNumber = txtbxNewFlightNumber.Text;
            strTo = txtbxNewFlightTo.Text;
            strFrom = txtbxNewFlightFrom.Text;

            dtArr = this.dtArr.Value;
            dtDep = this.dtDep.Value;

            fEconFare = (float)Convert.ToDouble(txtbxNewFlightEconFare.Text);
            fBusinessFare = (float)Convert.ToDouble(txtbxNewFlightBusinessFare.Text);
            fFirstFare = (float)Convert.ToDouble(txtbxNewFLightFirstFare.Text);

            Flight newFlight = new Flight { Number = flightNumber, Destination = strTo, Source = strFrom, Arrival = dtArr, Departure = dtDep, Aircraft = selectedAircraft, BusinessFare = fBusinessFare, EconomyFare = fEconFare, FirstFare = fFirstFare };

            //API.AddNewFlight(newFlight, loggedinAdmin.Id);

            var res = adminClient.CreateNewFlight(newFlight, loggedinAdmin.Id);

            if (res.IsSuccess)
                MessageBox.Show(res.Results["0"]);
            else
                MessageBox.Show(res.ErrorMessages["Error"]);

            this.btnClearFlight_Click(sender, e);

            Refresh_Flights();
        }

        private void Validate_AddNewFlight()
        {            
        }

        private void btnClearFlight_Click(object sender, EventArgs e)
        {
            txtbxNewFlightNumber.Clear();
            txtbxNewFlightFrom.Clear();
            txtbxNewFlightTo.Clear();
            txtbxNewFLightFirstFare.Clear();
            txtbxNewFlightEconFare.Clear();
            txtbxNewFlightBusinessFare.Clear();

            dtDep.Value = DateTime.UtcNow;
            dtArr.Value = DateTime.UtcNow;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            var res = adminClient.AdminLogout(loggedinAdmin.Id);

            if (res.IsSuccess)
                MessageBox.Show(res.Results["0"]);
            else
                MessageBox.Show(res.ErrorMessages["Error"]);
            
            this.Close();
        }

        private void Refresh_Aircrafts()
        {
            this.lstvwAircrafts.Items.Clear();
            // Refresh List of Aircrafts
            //aircraftsInService = API.GetAllAircrafts();
            aircraftsInService = adminClient.

            foreach (var aircraft in aircraftsInService)
            {
                string[] row = { aircraft.Name, aircraft.FusalageWidth.ToString(), aircraft.FirstClassSeats.ToString(), aircraft.BusinessSeats.ToString(), aircraft.EconomySeats.ToString(), aircraft.TotalSeats.ToString() };
                var listViewItem = new ListViewItem(row);
                this.lstvwAircrafts.Items.Add(listViewItem);
            }

            this.cmbbxAircraft.DataSource = aircraftsInService;
            this.cmbbxAircraft.DisplayMember = "Name";
            this.cmbbxAircraft.ValueMember = "Id";
        }

        private void Refresh_Flights()
        {
            this.lstvwFlights.Items.Clear();
            // Refresh List of flights
            this.scheduledFlights = API.GetAllFights();
            foreach (var flight in scheduledFlights)
            {
                string[] row = { flight.Number, flight.Source, flight.Destination, flight.Departure.ToString(), flight.Arrival.ToString(), flight.Aircraft.Name };
                var listViewItem = new ListViewItem(row);
                this.lstvwFlights.Items.Add(listViewItem);
            }
        }

        private void lstvwFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstvwFlights.SelectedIndices.Count == 0)
                return;

            var flightIndex = this.lstvwFlights.SelectedIndices[0];

            var flight = scheduledFlights[flightIndex];

            if(frmFlightDetail == null)
            {
                frmFlightDetail = new frmFlightDetail(flight);
                frmFlightDetail.FormClosed += frmFlightDetail_FormClosed;
                frmFlightDetail.MdiParent = this.MdiParent;
                frmFlightDetail.Show();
            }
            else
            {
                frmFlightDetail.Activate();
            }
        }

        void frmFlightDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmFlightDetail = null;
        }

        private void btnRefreshFlights_Click(object sender, EventArgs e)
        {
            Refresh_Flights();
        }

        private void btnRefreshAircrafts_Click(object sender, EventArgs e)
        {
            Refresh_Aircrafts();
        }
    }
}
