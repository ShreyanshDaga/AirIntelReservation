using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string SeatNumber { get; set; }
        public float TotalFare { get; set; }
        public DateTime BoardingTime { get; set; }
        public DateTime DepartureTime { get; set; }

        public virtual User User { get; set; }
    }
}
