using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    [DataContract]
    public class User
    {
        // Base Properties
        [DataMember]
        public int Id { get; set; }                                 // For EF to make this promary key
        [DataMember]
        public string Name { get; set; }                            // Name of the user
        [DataMember]
        public string EmailAddress { get; set; }                    // Email Address
        [DataMember]
        public int Age { get; set; }                                // Age
        [DataMember]
        public string PassportNumber { get; set; }                  // Passport number
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }

        // Navigational Properties
        [DataMember]
        public virtual ICollection<Booking> Bookings { get; set; }  // User's bookings so far
    }
}
