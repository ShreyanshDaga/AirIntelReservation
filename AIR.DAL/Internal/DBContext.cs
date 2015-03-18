using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AIR.Entities;

namespace AIR.DAL.Internal
{
    public class DBContext : DbContext
    {
        // Db sets
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        // ctors
        static DBContext()
        {
            // This will fire up only once when a class object is instantiated for the first time, 
            // enabling us to initialise the DB with some seed value

            Database.SetInitializer<DBContext>(new DBInitializer());
        }

        public DBContext(string strConString)
            : base(strConString)
        {
            // Create DB with some connection string

        }
    }
}
