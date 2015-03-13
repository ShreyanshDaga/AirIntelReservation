using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    public class Flight
    {
        // Base Properties
        public int Id { get; set; }                     // For EF to make this promary key
        public string Number { get; set; }              // Flight number
        public string Destination { get; set; }         // Flight destination
        public string Source { get; set; }              // Flight source
        public DateTime FlightDT { get; set; }          // Departure Date Time
        public float BaseFare { get; set; }             // Base Fare 
        public int Distance { get; set; }               // Flight's distance

        // Navigational Properties
        public virtual Aircraft Aircraft { get; set; }  // Aicraft used by the flight
    }
}
