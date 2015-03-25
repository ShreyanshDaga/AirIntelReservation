using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    [DataContract]
    public class Aircraft
    {
        [DataMember]
        public int Id { get; set; }                 // For EF to make this promary key
        [DataMember]
        public string Name { get; set; }            // Name of the aircraft
        [DataMember]
        public int FusalageWidth { get; set; }      // Number of column seats in the aircraft
        [DataMember]
        public int TotalSeats { get; set; }         // Total Seats in the Aircraft
        [DataMember]
        public int BusinessSeats { get; set; }      // Business Seats in the Aircraft
        [DataMember]
        public int EconomySeats { get; set; }       // Economy Seats in the Aicraft
        [DataMember]
        public int FirstClassSeats { get; set; }    // First class Seats in the Aircraft
    }
}
