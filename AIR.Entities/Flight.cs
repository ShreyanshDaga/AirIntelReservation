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
        public int Id { get; set; }
        public string Number { get; set; }
        public string Destination { get; set; }
        public string Source { get; set; }
        public DateTime FlightDT { get; set; }
        public float BaseFare { get; set; }
        public int Distance { get; set; }

        // Navigational Properties
        public virtual Aircraft Aircraft { get; set; }
    }
}
