using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    public class Aircraft
    {
        public int Id { get; set; }                 // For EF to make this promary key
        public string Name { get; set; }            // Name of the aircraft
        public int FusalageWidth { get; set; }      // Number of column seats in the aircraft
        public int TotalSeats { get; set; }         // Total Seats in the Aircraft
        public int BusinessSeats { get; set; }      // Business Seats in the Aircraft
        public int EconomySeats { get; set; }       // Economy Seats in the Aicraft
        public int FirstClassSeats { get; set; }    // First class Seats in the Aircraft
    }
}
