using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    [DataContract]
    public class Booking
    {
        [DataMember]
        public int Id { get; set; }                     // For EF to make this promary key
        [DataMember]
        public string TicketNumber { get; set; }        // The ticket number if booking is issued
        [DataMember]
        public string SeatNumber { get; set; }          // Seat number, the user chooses
        [DataMember]
        public float TotalFare { get; set; }            // Total Fare paid by the user
        [DataMember]
        public DateTime BoardingTime { get; set; }      // boarding time
        [DataMember]
        public DateTime DepartureTime { get; set; }     // Same as flight departure to be printed on ticket
        
        [DataMember]
        public User User { get; set; }                  // User        
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public Flight Flight { get; set; }              // Flight
        [DataMember]
        public int FlightId { get; set; }
    }
}
