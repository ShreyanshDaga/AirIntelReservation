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
        public event EventHandler OnSignOut;

        Admin loggedinAdmin;
        List<Aircraft> aircraftsInService;
        List<Flight> scheduledFlights;
        frmFlightDetail frmFlightDetail;        

        ReservationServiceRef.ReservationServiceClient adminClient;

        public frmAdmin(ReservationServiceRef.ReservationServiceClient adminClient, Admin loggedInAdmin)
        {
            InitializeComponent();
            this.loggedinAdmin = loggedInAdmin;
            this.adminClient = adminClient;
            
            txtbxAdminUName.Text = this.loggedinAdmin.UserName;
            this.lbluserName.Text += this.loggedinAdmin.UserName;

            this.Cursor = Cursors.Default;
            // List of Flights
            Refresh_Flights();
            // List of aircrafts
            Refresh_Aircrafts();                           
        }

        private void btnAddAircraft_Click(object sender, EventArgs e)
        {
            // Validate the fields
            if (!Validate_AddNewAircraft())
                return;

            int iWidth, iBusinessSeats, iEconSeats, iFirstSeats, iTotal;

            iWidth = Convert.ToInt32(txtbxNewAircraftWidth.Text);
            iBusinessSeats = Convert.ToInt32(txtbxNewAircraftBusinessSeats.Text);
            iEconSeats = Convert.ToInt32(txtbxNewAircraftEconSeats.Text);
            iFirstSeats = Convert.ToInt32(txtbxNewAircraftFirstSeats.Text);
            iTotal = iBusinessSeats + iEconSeats + iFirstSeats;

            var newAircraft = new Aircraft { Name = txtbxNewAircraftName.Text, FusalageWidth = iWidth, BusinessSeats = iBusinessSeats, EconomySeats = iEconSeats, FirstClassSeats=iFirstSeats, TotalSeats = iTotal};

            if (!IsServiceAlive())
                return;
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

            if(txtbxNewAircraftName.Text == "")
            {
                MessageBox.Show("Name can not be empty", "Add New Aircraft Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int iWidth;
            if (!int.TryParse(txtbxNewAircraftWidth.Text, out iWidth) || txtbxNewAircraftWidth.Text == "" || iWidth == 0)
            {
                MessageBox.Show("Width has to be an integer number.", "Add New Aircraft Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(txtbxNewAircraftEconSeats.Text == "" || txtbxNewAircraftBusinessSeats.Text == "" || txtbxNewAircraftFirstSeats.Text == "")
            {
                MessageBox.Show("Seats can not be empty.", "Add New Aircraft Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int iSeats1, iSeats2, iSeats3;
            if (!int.TryParse(txtbxNewAircraftFirstSeats.Text, out iSeats1) || !int.TryParse(txtbxNewAircraftEconSeats.Text, out iSeats2) || !int.TryParse(txtbxNewAircraftBusinessSeats.Text, out iSeats3) || iSeats1 == 0 || iSeats2 == 0 || iSeats3 == 0)
            {
                MessageBox.Show("Number of rows of seats has to be an integer number.", "Add New Aircraft Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }                        

            return true;
        }

        private void btnEditAdminDetails_Click(object sender, EventArgs e)
        {            
            txtbxAdminNewPwd.Enabled = true;
            txtbxAdminUName.Enabled = true;
            txtbxAdminOldPwd.Enabled = true;

            btnSaveDetails.Enabled = true;
            btnEditAdminDetails.Enabled = false;
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            if (!Validate_EditPersonalDetails())
                return;

            // Save Changes here            
            Admin updateAdmin = new Admin { Name = txtbxAdminUName.Text, UserName = txtbxAdminUName.Text, PasswordHash = txtbxAdminNewPwd.Text };

            if (!IsServiceAlive())
                return;
            var res = adminClient.UpdateAdmin(updateAdmin, loggedinAdmin.Id);
            if(res.IsSuccess)
            {
                MessageBox.Show("Admin details updated", "Edit Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error updateing admin details", "Edit Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtbxAdminUName.Enabled = false;
            txtbxAdminOldPwd.Clear();
            txtbxAdminNewPwd.Clear();
            txtbxAdminNewPwd.Enabled = false;
            txtbxAdminOldPwd.Enabled = false;

            btnSaveDetails.Enabled = false;
            btnEditAdminDetails.Enabled = true;
        }

        private bool Validate_EditPersonalDetails()
        {
            if(txtbxAdminUName.Text == "")
            {
                MessageBox.Show("Username can not be empty", "Edit details error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(txtbxAdminNewPwd.Text == "" || txtbxAdminOldPwd.Text == "")
            {
                MessageBox.Show("Passwords can not be empty", "Edit details error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(txtbxAdminOldPwd.Text != loggedinAdmin.PasswordHash)
            {
                MessageBox.Show("Old password does not match", "Edit details error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnAddNewFlight_Click(object sender, EventArgs e)
        {
            // Validate the fields
            if (!Validate_AddNewFlight())
                return;

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

            Flight newFlight = new Flight { Number = flightNumber, Destination = strTo, Source = strFrom, Arrival = dtArr, Departure = dtDep, AircraftId = selectedAircraft.Id, BusinessFare = fBusinessFare, EconomyFare = fEconFare, FirstFare = fFirstFare };

            if (!IsServiceAlive())
                return;
            var res = adminClient.CreateNewFlight(newFlight, loggedinAdmin.Id);

            if (res.IsSuccess)
                MessageBox.Show(res.Results["0"]);
            else
                MessageBox.Show(res.ErrorMessages["Error"]);

            this.btnClearFlight_Click(sender, e);

            Refresh_Flights();
        }

        private bool Validate_AddNewFlight()
        {
            if(txtbxNewFlightNumber.Text == "")
            {
                MessageBox.Show("Flight number can not be empty", "Add New Flight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(txtbxNewFlightFrom.Text == "")
            {
                MessageBox.Show("Flight source can not be empty", "Add New Flight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(txtbxNewFlightTo.Text == "")
            {
                MessageBox.Show("Flight destination can not be empty", "Add New Flight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(dtArr.Value <= dtDep.Value)
            {
                MessageBox.Show("Arrival time can not be before or equal to departure time", "Add New Flight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            float fare;
            if (!float.TryParse(txtbxNewFLightFirstFare.Text,out fare) || !float.TryParse(txtbxNewFlightBusinessFare.Text,out fare) || !float.TryParse(txtbxNewFlightEconFare.Text,out fare) || fare == 0)
            {
                MessageBox.Show("Fare has to be a integer or floating point number", "Add New Flight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
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
            this.Cursor = Cursors.WaitCursor;

            if (!IsServiceAlive())
                return;
            var res = adminClient.AdminLogout(loggedinAdmin.Id);

            if (res.IsSuccess)
                MessageBox.Show(res.Results["0"], "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(res.ErrorMessages["Error"], "Logout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Cursor = Cursors.Default;
            // Trigger the signout event
            this.OnSignOut(this, new EventArgs());
            this.Close();            
        }

        private void Refresh_Aircrafts()
        {
            this.lstvwAircrafts.Items.Clear();

            if (!IsServiceAlive())
                return;
            // Refresh List of Aircrafts            
            this.aircraftsInService = adminClient.GetAllAircrafts();

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

            if (!IsServiceAlive())
                return;
            // Refresh List of flights
            this.scheduledFlights = adminClient.GetAllFlights();

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
}
