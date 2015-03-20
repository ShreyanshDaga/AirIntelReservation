using AIR.DAL;
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

        public frmAdmin(Admin loggedInAdmin)
        {
            InitializeComponent();
            this.loggedinAdmin = loggedInAdmin;

            txtbxAdminName.Text = loggedInAdmin.Name;
            txtbxAdminUName.Text = loggedInAdmin.Name;
            this.lbluserName.Text += loggedinAdmin.Name;
                          
            // Init Aircrafts here
            aircraftsInService = API.GetAllAircrafts();

            this.cmbbxAircraft.DataSource = aircraftsInService;
            this.cmbbxAircraft.DisplayMember = "Name";
            this.cmbbxAircraft.ValueMember = "Id";

            // List of aircrafts
            foreach(var aircraft in aircraftsInService)
            {
                string[] row = { aircraft.Name, aircraft.FusalageWidth.ToString(), aircraft.FirstClassSeats.ToString(), aircraft.BusinessSeats.ToString(), aircraft.EconomySeats.ToString(), aircraft.TotalSeats.ToString() };
                var listViewItem = new ListViewItem(row);
                this.lstvwAircrafts.Items.Add(listViewItem);
            }

            // List of Flights
            this.scheduledFlights = API.GetAllFights();
            foreach (var flight in scheduledFlights)
            {
                string[] row = { flight.Number, flight.Source, flight.Destination, flight.Departure.ToString(), flight.Arrival.ToString(), flight.Aircraft.Name };
                var listViewItem = new ListViewItem(row);
                this.lstvwFlights.Items.Add(listViewItem);
            }
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

            API.AddNewAircraft(newAircraft, loggedinAdmin.Id);

            MessageBox.Show("Aircraft added successfully");

            btnClear_Click(sender, e);
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

            API.AddNewFlight(newFlight, loggedinAdmin.Id);

            MessageBox.Show("New Flight Added Succesfully");

            this.btnClearFlight_Click(sender, e);
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
            API.AdminSignOut(loggedinAdmin.Id);
            MessageBox.Show("You have logged out successfully");
            this.Close();
        }

        private void Refresh_Aircrafts()
        {

        }
        private void Refresh_Flights()
        {

        }

        private void lstvwFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
