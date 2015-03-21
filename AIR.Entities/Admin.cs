using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    [DataContract]
    public class Admin
    {
        [DataMember]
        public int Id { get; set; }                 // For EF to make this promary key
        [DataMember]        
        public string Name { get; set; }            // Admin name
        [DataMember]
        public string UserName { get; set; }        // User name
        [DataMember]
        public string PasswordHash { get; set; }    // Password, not storing it directly
    }   
}
