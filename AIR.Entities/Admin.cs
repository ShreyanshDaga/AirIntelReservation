using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    public class Admin
    {
        public int Id { get; set; }                 // For EF to make this promary key
        public string Name { get; set; }            // Admin name
        public string PasswordHash { get; set; }    // Password, not storing it directly
    }   
}
