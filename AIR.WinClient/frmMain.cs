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

using AIR.Entities;

namespace AIR.WinClient
{
    public partial class frmMain : Form
    {
        ReservationServiceRef.ReservationServiceClient userClient;
        List<Flight> scheduledFlights;
        Flight selectedFlight;
        int iFlightIndex;
        int iBusinessRows, iFirstRows, iEconRows, iWidth;
        bool[,] seatMap;
        frmTicket frmTicket;
        List<int> seatRows = new List<int>();
        List<string> seatCols = new List<string>();

        public frmMain()
        {
            InitializeComponent();
                                   
            grpbxFlightDetails.Enabled = false;
        }
        private void RefreshFlights()
        {
            this.lstvwFlights.Items.Clear();

            if (!IsServiceAlive())
                return;
            scheduledFlights = userClient.GetAllFlights();

            if (scheduledFlights == null)
                return;

            // Refresh List of flights            
            foreach (var flight in scheduledFlights)
            {
                string[] row = { flight.Number, flight.Source, flight.Destination, flight.Departure.ToString(), flight.Arrival.ToString(), flight.Aircraft.Name };
                var listViewItem = new ListViewItem(row);
                this.lstvwFlights.Items.Add(listViewItem);
            }
        }
        private bool InitWCFService()
        {
            try
            {
                this.userClient = new ReservationServiceRef.ReservationServiceClient();
                if (!userClient.Ping())
                {
                    MessageBox.Show("Air Intel Reservation Service is Unavailable!");
                    return false;
                }

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Air Intel Reservation Service is Unavailable!");
                return false;
            }
                        
        }
        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            grpbxFlightDetails.Enabled = true;
        }
        private void btnRefreshFlights_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            RefreshFlights();
            this.Cursor = Cursors.Default;
        }
        private void lstvwFlights_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstvwFlights.SelectedIndices.Count == 0)
                return;

            iFlightIndex = lstvwFlights.SelectedIndices[0];
                        
            this.selectedFlight = scheduledFlights[iFlightIndex];                        

            grpbxFlightDetails.Enabled = true;

            this.lblSelFlightNumbe.Text = selectedFlight.Number;
            this.lblSelFlightFrom.Text = selectedFlight.Source;
            this.lblSelFlightTo.Text = selectedFlight.Destination;
            this.lblSelFlightArr.Text = selectedFlight.Arrival.ToString();
            this.lblSelFlightDep.Text = selectedFlight.Departure.ToString();
            this.lblAircraftType.Text = selectedFlight.Aircraft.Name;

            this.txtbxTotalFare.Text = selectedFlight.EconomyFare.ToString();

            this.iBusinessRows = selectedFlight.Aircraft.BusinessSeats;
            this.iFirstRows = selectedFlight.Aircraft.FirstClassSeats;
            this.iEconRows = selectedFlight.Aircraft.EconomySeats;

            this.iWidth = selectedFlight.Aircraft.FusalageWidth;

            for (int i = 0; i < iWidth;i++)
            {
                char c = Convert.ToChar(i + 65);
                this.seatCols.Add(c.ToString());
            }

            for (int j = iBusinessRows + iFirstRows; j < iBusinessRows + iEconRows + iFirstRows; j++)
            {
                this.seatRows.Add(j + 1);
            }

            this.cmbbxCols.DataSource = this.seatCols;
            this.cmbbxRows.DataSource = this.seatRows;

            RenderSeatMap();            
        }
        private void RenderSeatMap()
        {
            int iTotalRows = iBusinessRows + iFirstRows + iEconRows + 6;

            string[] seatMapStrings = new string[iTotalRows + 5];
            this.seatMap = new bool[iTotalRows, iWidth];

            this.GetSeatMapFromBookings(selectedFlight.Id);

            // Print Columns according to class
            for (int i = 0; i < iWidth; i++)
            {
                char c = Convert.ToChar((65 + i));

                if(i != 0)
                    seatMapStrings[0] += (" " + c.ToString() + " ");
                if (i == 0)
                {
                    seatMapStrings[0] += ("   " + c.ToString() + " ");
                    seatMapStrings[1] += ("--- FIRST CLASS ---");
                }
                    
                for (int j = 2; j < iFirstRows + 2; j++)
                {
                    if (i == 0)
                    {
                        if((j-1) < 10)
                            seatMapStrings[j] += " " + (j - 1).ToString();
                        else
                            seatMapStrings[j] += (j - 1).ToString();
                    }
                        
                    if (this.seatMap[j - 1, i])
                        seatMapStrings[j] += (" " + "X" + " ");
                    else
                        seatMapStrings[j] += (" " + "O" + " ");
                }


                if (i == 0)
                    seatMapStrings[iFirstRows + 2] += ("--- BUSINESS CLASS ---");

                for (int j = iFirstRows + 3; j < iFirstRows + iBusinessRows + 3; j++)
                {
                    if (i == 0)
                    {
                        if((j-2) < 10)
                            seatMapStrings[j] += " " + (j - 2).ToString();
                        else
                            seatMapStrings[j] += (j - 2).ToString();
                    }
                        
                    if (this.seatMap[j - 2, i])
                        seatMapStrings[j] += (" " + "X" + " ");
                    else
                        seatMapStrings[j] += (" " + "O" + " ");
                }

                if (i == 0)
                    seatMapStrings[iFirstRows + iBusinessRows + 3] += ("--- ECONOMY CLASS ---");

                for (int j = iFirstRows + iBusinessRows + 4; j < iFirstRows + iBusinessRows + iEconRows + 4; j++)
                {
                    if (i == 0)
                    {
                        if ((j-3) < 10)
                            seatMapStrings[j] += " " + (j - 3).ToString();
                        else
                            seatMapStrings[j] += (j - 3).ToString();
                    }
                        
                    if (this.seatMap[j - 3, i])
                        seatMapStrings[j] += (" " + "X" + " ");
                    else
                        seatMapStrings[j] += (" " + "O" + " ");
                }
            }

            this.txtbxSeatMap.Lines = seatMapStrings;
        }
        private void GetSeatMapFromBookings(int iFlightId)
        {
            if (!IsServiceAlive())
                return;
            // Get seats from service for the selected flight
            var seats = userClient.GetAllSeatsForFlight(iFlightId);
            
            foreach(var seat in seats)
            {
                int iR = GetRowFromSeatNumber(seat);
                int iC = GetColumnFromSeatNumber(seat);

                this.seatMap[iR, iC] = true;
            }
        }
        private int GetRowFromSeatNumber(string seat)
        {
            int iRow = 0;

            if(seat.Length == 3)
                iRow = Convert.ToInt32(seat.Substring(0, 2));
            else
                iRow = Convert.ToInt32(seat.Substring(0, 1));

            return iRow;
        }
        private int GetColumnFromSeatNumber(string seat)
        {
            char cCol;

            cCol = Convert.ToChar(seat[seat.Length - 1]);

            return (int)(cCol - 65);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.GenerateUserBooking();
            this.Cursor = Cursors.Default;                                  
        }
        private void GenerateUserBooking()
        {
            if (!ValidateUserBooking())
                return;

            float fare;
            string seatNumber = cmbbxRows.Text + cmbbxCols.Text;
            string ticketNumber = "TCK" + seatNumber + "OE";

            fare = (float)Convert.ToDouble(txtbxTotalFare.Text);

            var user = new User { Name = txtbxUserName.Text, EmailAddress = txtbxUserEmail.Text, Age = Convert.ToInt32(txtbxUserAge.Text), PassportNumber = txtbxUserPassport.Text };

            if (!IsServiceAlive())
                return;
            var userRes = userClient.CreateNewUser(user);
            if (!userRes.IsSuccess)
            {
                MessageBox.Show("Error submitting user information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!IsServiceAlive())
                return;
            int Id = userClient.GetUserIdByEmailAddress(user.EmailAddress);

            Booking booking = new Booking { FlightId = selectedFlight.Id, TotalFare = fare, SeatNumber = seatNumber, TicketNumber = ticketNumber, DepartureTime = selectedFlight.Departure, BoardingTime = selectedFlight.Departure.AddMinutes(-30.00), UserId =  Id};

            if (!IsServiceAlive())
                return;
            var res = userClient.AddNewBooking(booking);

            if(res.IsSuccess)
            {
                // New ticket form
                MessageBox.Show("Your booking is confirmed.!", "New Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbxTotalFare.Clear();
                txtbxUserAge.Clear();
                txtbxUserEmail.Clear();
                txtbxUserName.Clear();
                txtbxUserPassport.Clear();  

                booking.Flight = this.selectedFlight;
                this.frmTicket = new frmTicket(booking, user);
                this.frmTicket.FormClosed += frmTicket_FormClosed;
                frmTicket.Show();
                RenderSeatMap();
            }
            else
            {
                MessageBox.Show(res.ErrorMessages["Error"], "New Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbbxRows.Focus();
            }
        }
        private void frmTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.frmTicket = null;
        }
        private bool ValidateUserBooking()
        {
            if (this.txtbxUserName.Text == "")
            {
                MessageBox.Show("User Name field can not be empty!","Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (this.txtbxUserPassport.Text == "")
            {
                MessageBox.Show("Passport field can not be empty!", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (this.txtbxUserEmail.Text == "")
            {
                MessageBox.Show("Email field can not be empty!", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                

            int iAge;
            if (!int.TryParse(this.txtbxUserAge.Text, out iAge) || iAge == 0)
            {
                MessageBox.Show("Age should be a integer number greater than 0!", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }                                

            return true;
        }
        private void btnCheckAvail_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string seatSelected = cmbbxRows.Text + cmbbxCols.Text;

            if (!this.IsServiceAlive())
                return;

            if (this.userClient.IsSeatAvailable(seatSelected, selectedFlight.Id))
                MessageBox.Show("Seat is still available!", "Seat Availabilty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("We are sorry the seat was booked by some one else and is no longer available.!\nPlease select a different seat.", "Seat Availabilty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.RenderSeatMap();
            }
            this.Cursor = Cursors.Default;
        }
        private void rdbtnBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbtnBusiness.Checked)
            {
                this.txtbxTotalFare.Text = selectedFlight.BusinessFare.ToString();
                this.seatRows = new List<int>();
                for (int j = iFirstRows; j < iFirstRows + iBusinessRows; j++)
                {
                    this.seatRows.Add(j + 1);
                }

                this.cmbbxRows.DataSource = this.seatRows;                
            }
                
        }
        private void rdbtnFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbtnFirst.Checked)
            {
                this.txtbxTotalFare.Text = selectedFlight.FirstFare.ToString();
                this.seatRows = new List<int>();
                for (int j = 0; j < iFirstRows; j++)
                {
                    this.seatRows.Add(j + 1);
                }

                this.cmbbxRows.DataSource = this.seatRows;                
            }
                
        }
        private void rdbtnEcon_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbtnEcon.Checked)
            {
                this.txtbxTotalFare.Text = selectedFlight.EconomyFare.ToString();
                this.seatRows = new List<int>();
                for (int j = iBusinessRows + iFirstRows; j < iBusinessRows + iFirstRows + iEconRows; j++)
                {
                    this.seatRows.Add(j + 1);
                }

                this.cmbbxRows.DataSource = this.seatRows;
                //this.cmbbxRows.Invalidate();
            }
                
        }
        private void btnRefreshSeatMap_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            // Re render the SeatMap
            this.RenderSeatMap();
            this.Cursor = Cursors.Default;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Init WCF Service
            if (!this.InitWCFService())
            {                
                return;
            }                

            // Refresh Flights
            this.RefreshFlights(); 

            // Form is ready
        }
        private bool IsServiceAlive()
        {
            try
            {
                if (!this.userClient.Ping())
                {
                    MessageBox.Show("WCF Service is no longer running.!\nPlease start the service in order to continue!", "WCF Service error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch(Exception ex)
            {
                // Incase service goes down before the ping is tested
                MessageBox.Show("WCF Service is no longer running.!\nPlease start the service in order to continue!", "WCF Service error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
