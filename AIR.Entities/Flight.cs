using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    [DataContract]
    public class Flight
    {        
        // Base Properties
        [DataMember]
        public int Id { get; set; }                     // For EF to make this promary key
        [DataMember]
        public string Number { get; set; }              // Flight number
        [DataMember]
        public string Destination { get; set; }         // Flight destination
        [DataMember]
        public string Source { get; set; }              // Flight source
        [DataMember]
        public DateTime Departure { get; set; }          // Departure Date Time
        [DataMember]
        public DateTime Arrival { get; set; }            // Arrival Date Time
        [DataMember]
        public float EconomyFare { get; set; }           // Base Fare 
        [DataMember]
        public float BusinessFare { get; set; }          // Business Fare 
        [DataMember]
        public float FirstFare { get; set; }             // Firstclass Fare         

        // Navigational Properties
        [DataMember]
        public virtual Aircraft Aircraft { get; set; }  // Aicraft used by the flight
    }
}
