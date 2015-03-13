using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    public class Booking
    {
        public int Id { get; set; }                     // For EF to make this promary key
        public string TicketNumber { get; set; }        // The ticket number if booking is issued
        public string SeatNumber { get; set; }          // Seat number, the user chooses
        public float TotalFare { get; set; }            // Total Fare paid by the user
        public DateTime BoardingTime { get; set; }      // boarding time
        public DateTime DepartureTime { get; set; }     // Same as flight departure to be printed on ticket

        public virtual User User { get; set; }          // user
    }
}
