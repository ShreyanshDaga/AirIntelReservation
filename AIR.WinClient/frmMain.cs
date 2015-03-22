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

        public frmMain()
        {
            InitializeComponent();
                                   
            grpbxFlightDetails.Enabled = false;
        }
        private void RefreshFlights()
        {
            this.lstvwFlights.Items.Clear();

            //scheduledFlights.Clear();
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
            RefreshFlights();
        }
        private void lstvwFlights_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstvwFlights.SelectedIndices.Count == 0)
                return;

            iFlightIndex = lstvwFlights.SelectedIndices[0];
                        
            this.selectedFlight = scheduledFlights[iFlightIndex];

            grpbxFlightDetails.Enabled = true;

            lblSelFlightNumbe.Text = selectedFlight.Number;
            lblSelFlightFrom.Text = selectedFlight.Source;
            lblSelFlightTo.Text = selectedFlight.Destination;
            lblSelFlightArr.Text = selectedFlight.Arrival.ToString();
            lblSelFlightDep.Text = selectedFlight.Departure.ToString();
            lblAircraftType.Text = selectedFlight.Aircraft.Name;

            txtbxTotalFare.Text = selectedFlight.EconomyFare.ToString();

            iBusinessRows = selectedFlight.Aircraft.BusinessSeats;
            iFirstRows = selectedFlight.Aircraft.FirstClassSeats;
            iEconRows = selectedFlight.Aircraft.EconomySeats;

            iWidth = selectedFlight.Aircraft.FusalageWidth;

            RenderSeatMap();            
        }
        private void RenderSeatMap()
        {
            int iTotalRows = iBusinessRows + iFirstRows + iEconRows + 6;

            string[] seatMap = new string[iTotalRows + 5];
            this.seatMap = new bool[iTotalRows, iWidth];

            GetSeatMapFromBookings(selectedFlight.Id);

            // Print Columns according to class
            for (int i = 0; i < iWidth; i++)
            {
                char c = Convert.ToChar((65 + i));

                if(i != 0)
                    seatMap[0] += (" " + c.ToString() + " ");
                if (i == 0)
                {
                    seatMap[0] += ("   " + c.ToString() + " ");
                    seatMap[1] += ("--- FIRST CLASS ---");
                }
                    
                for (int j = 2; j < 2 + iFirstRows; j++)
                {
                    if (i == 0)
                    {
                        if(j < 10)
                            seatMap[j] += " " + (j - 1).ToString() + " ";
                        else
                            seatMap[j] += (j - 1).ToString() + " ";
                    }
                        
                    if (this.seatMap[j - 2, i])
                        seatMap[j] += (" " + "X" + " ");
                    else
                        seatMap[j] += (" " + "O" + " ");
                }


                if (i == 0)
                    seatMap[iFirstRows + 2] += ("--- BUSINESS CLASS ---");

                for (int j = iFirstRows + 3; j < iFirstRows + 3 + iBusinessRows; j++)
                {
                    if (i == 0)
                    {
                        if(j < 10)
                            seatMap[j] += " " + (iFirstRows + j - 2).ToString() + " ";
                        else
                            seatMap[j] += (iFirstRows + j - 2).ToString() + " ";
                    }
                        
                    if (this.seatMap[j - 3, i])
                        seatMap[j] += (" " + "X" + " ");
                    else
                        seatMap[j] += (" " + "O" + " ");
                }
                if (i == 0)
                    seatMap[iFirstRows + iBusinessRows + 3] += ("--- ECONOMY CLASS ---");

                for (int j = iFirstRows + iBusinessRows + 4; j < iTotalRows; j++)
                {
                    if (i == 0)
                    {
                        if(j < 10)
                            seatMap[j] += " " + (iFirstRows + iBusinessRows + j - 3).ToString() + " ";
                        else
                            seatMap[j] += (iFirstRows + iBusinessRows + j - 3).ToString() + " ";
                    }
                        
                    if (this.seatMap[j - 4, i])
                        seatMap[j] += (" " + "X" + " ");
                    else
                        seatMap[j] += (" " + "O" + " ");
                }
            }

            txtbxSeatMap.Lines = seatMap;
        }
        private void GetSeatMapFromBookings(int iFlightId)
        {
            // Get all the bookings for this flight
            var bookings = userClient.GetAllBookingsForFlight(iFlightId);
            
            foreach(var booking in bookings)
            {
                int iR = GetRowFromSeatNumber(booking.SeatNumber);
                int iC = GetColumnFromSeatNumber(booking.SeatNumber);

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
            GenerateUserBooking();
        }
        private void GenerateUserBooking()
        {
            ValidateUserBooking();
            float fare;
            string seatNumber = txtbxRow.Text + txtbxCol.Text;
            string ticketNumber = "XYZ";

            fare = (float)Convert.ToDouble(txtbxTotalFare.Text);

            var user = new User { Name = txtbxUserName.Text, EmailAddress = txtbxUserEmail.Text, Age = Convert.ToInt32(txtbxUserAge.Text), PassportNumber = txtbxUserPassport.Text };            

            Booking booking = new Booking { FlightId = selectedFlight.Id, TotalFare = fare, SeatNumber = seatNumber, TicketNumber = ticketNumber, DepartureTime = selectedFlight.Departure, BoardingTime = selectedFlight.Departure.AddMinutes(-30.00), User = user };

            var res = userClient.AddNewBooking(booking);

            if(res.IsSuccess)
            {
                MessageBox.Show("Your booking is confirmed.!");
            }
            else
            {
                MessageBox.Show(res.ErrorMessages["Error"]);
            }
        }
        private void ValidateUserBooking()
        {
            
        }
        private void btnCheckAvail_Click(object sender, EventArgs e)
        {
            string seatSelected = txtbxRow.Text + txtbxCol.Text;

            if (userClient.IsSeatAvailable(seatSelected, selectedFlight.Id))
                MessageBox.Show("Seat is still available!");
            else
            {
                MessageBox.Show("We are sorry the seat was booked by some one else and is no longer available.!\nPlease select a different seat.");
                RenderSeatMap();
            }                
        }
        private void rdbtnBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtnBusiness.Checked)            
                txtbxTotalFare.Text = selectedFlight.BusinessFare.ToString();            
        }
        private void rdbtnFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnFirst.Checked)
                txtbxTotalFare.Text = selectedFlight.FirstFare.ToString();            
        }
        private void rdbtnEcon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnEcon.Checked)
                txtbxTotalFare.Text = selectedFlight.EconomyFare.ToString();            
        }
        private void btnRefreshSeatMap_Click(object sender, EventArgs e)
        {
            // Re render the SeatMap
            RenderSeatMap();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Init WCF Service
            if (!InitWCFService())
            {                
                return;
            }                

            // Refresh Flights
            RefreshFlights(); 

            // Form is ready
        }
    }
}
