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

            InitWCFService();

            RefreshFlights();

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
        private void InitWCFService()
        {
            try
            {
                this.userClient = new ReservationServiceRef.ReservationServiceClient();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Air Intel Reservation Service is Unavailable!");
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
            iFlightIndex = lstvwFlights.SelectedIndices[0];
            
            if(iFlightIndex > 0)
            {
                this.selectedFlight = scheduledFlights[iFlightIndex];

                grpbxFlightDetails.Enabled = true;

                lblSelFlightNumbe.Text = selectedFlight.Number;
                lblSelFlightFrom.Text = selectedFlight.Source;
                lblSelFlightTo.Text = selectedFlight.Destination;
                lblSelFlightArr.Text = selectedFlight.Arrival.ToString();
                lblSelFlightDep.Text = selectedFlight.Departure.ToString();
                lblAircraftType.Text = selectedFlight.Aircraft.Name;

                iBusinessRows = selectedFlight.Aircraft.BusinessSeats;
                iFirstRows = selectedFlight.Aircraft.FirstClassSeats;
                iEconRows = selectedFlight.Aircraft.EconomySeats;

                iWidth = selectedFlight.Aircraft.FusalageWidth;

                RenderSeatMap();
            }
        }
        private void RenderSeatMap()
        {
            int iTotalRows = iBusinessRows + iFirstRows + iEconRows + 6;

            string[] seatMap = new string[iTotalRows];
            this.seatMap = new bool[iWidth, iTotalRows];

            GetSeatMapFromBookings(selectedFlight.Id);

            // Print Columns
            for (int i = 0; i < iWidth; i++)
            {
                char c = Convert.ToChar((65 + i));

                seatMap[0] += (" " + c.ToString() + " ");
                if (i == 0)
                    seatMap[1] += ("--- FIRST CLASS ---");

                for (int j = 2; j < 2 + iFirstRows; j++)
                {
                    if (this.seatMap[j - 2, i])
                        seatMap[j] += (" " + "O" + " ");
                    else
                        seatMap[j] += (" " + "X" + " ");
                }
                if (i == 0)
                    seatMap[iFirstRows + 2] += ("--- BUSINESS CLASS ---");

                for (int j = iFirstRows + 3; j < iFirstRows + 3 + iBusinessRows; j++)
                {
                    if (this.seatMap[j - 3, i])
                        seatMap[j] += (" " + "O" + " ");
                    else
                        seatMap[j] += (" " + "X" + " ");
                }
                if (i == 0)
                    seatMap[iFirstRows + iBusinessRows + 4] += ("--- ECONOMY CLASS ---");

                for (int j = iFirstRows + iBusinessRows + 4; j < iTotalRows + 4; j++)
                {
                    if (this.seatMap[j - 4, i])
                        seatMap[j] += (" " + "O" + " ");
                    else
                        seatMap[j] += (" " + "X" + " ");
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

                this.seatMap[iR, iC] = false;
            }
        }
        private int GetRowFromSeatNumber(string p)
        {
            return 0;
        }
        private int GetColumnFromSeatNumber(string p)
        {
            return 0;
        }
    }
}
