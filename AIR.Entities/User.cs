using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    public class User
    {
        // Base Properties
        public int Id { get; set; }                                 // For EF to make this promary key
        public string Name { get; set; }                            // Name of the user
        public string EmailAddress { get; set; }                    // Email Address
        public int Age { get; set; }                                // Age
        public string PassportNumber { get; set; }                  // Passport number
        public string UserName { get; set; }
        public string Password { get; set; }

        // Navigational Properties
        public virtual ICollection<Booking> Bookings { get; set; }  // User's bookings so far
    }
}
