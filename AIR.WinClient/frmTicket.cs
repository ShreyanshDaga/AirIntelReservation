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

namespace AIR.WinClient
{
    public partial class frmTicket : Form
    {
        public frmTicket(Booking booking, User user)
        {
            InitializeComponent();

            // Fill up all the labels to show booking reservation data to user
            lblName.Text += user.Name;
            lblSeat.Text += booking.SeatNumber;
            lblTicket.Text += booking.TicketNumber;
            lblFrom.Text += booking.Flight.Source;
            lblTo.Text += booking.Flight.Destination;
            lblFlight.Text += booking.Flight.Number;
            lblDepartire.Text += booking.DepartureTime.ToString();
            lblBoarding.Text += booking.BoardingTime.ToString();            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close this window 
            this.Close();
        }
    }
}
