using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AIR.Entities;

namespace AIR.DAL.Internal
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            this.Seed_TestAdmins(context);
            this.Seed_TestAircrafts(context);
            this.Seed_TestFlights(context);
            this.Seed_TestUsers(context);
            this.Seed_TestBookings(context);

            base.Seed(context);
        }

        private void Seed_TestAdmins(DBContext context)
        {
            // Seeding Test Admins
            var admin1 = new Admin { Name = "eMusk", PasswordHash = "MuskToMars" };
            var admin2 = new Admin { Name = "gMoore", PasswordHash = "IntelInside" };

            context.Admins.Add(admin1);
            context.Admins.Add(admin2);

            context.SaveChanges();
        }

        private void Seed_TestAircrafts(DBContext context)
        {
            // Seeding Test Aircrafts
            var a380 = new Aircraft { Name = "A380", FusalageWidth = 10, TotalSeats = 600, BusinessSeats = 100, FirstClassSeats = 200, EconomySeats = 300 };
            var b747 = new Aircraft { Name = "B747", FusalageWidth = 10, TotalSeats = 600, BusinessSeats = 100, FirstClassSeats = 200, EconomySeats = 300 };
            var b777 = new Aircraft { Name = "B777", FusalageWidth = 9, TotalSeats = 600, BusinessSeats = 100, FirstClassSeats = 200, EconomySeats = 300 };
            var a330 = new Aircraft { Name = "A330", FusalageWidth = 6, TotalSeats = 600, BusinessSeats = 100, FirstClassSeats = 200, EconomySeats = 300 };

            context.Aircrafts.Add(a380);
            context.Aircrafts.Add(b747);
            context.Aircrafts.Add(b777);
            context.Aircrafts.Add(a330);

            context.SaveChanges();
        }

        private void Seed_TestFlights(DBContext context)
        {
            // Seeding Test FLights
            //var flight1 = new Flight { Number="IT2034", FlightDT = DateTime.Now, Aircraft = };
            //var flight2 = new Flight { };
            //var flight3 = new Flight { };
            //var flight4 = new Flight { };

            //context.Flights.Add(flight1);
            //context.Flights.Add(flight2);
            //context.Flights.Add(flight3);
            //context.Flights.Add(flight4);

            //context.SaveChanges();     
        }

        private void Seed_TestUsers(DBContext context)
        {
            // Seed Test users
            var user1 = new User { Name = "Jane Doe", EmailAddress = "janed@example.com", Age = 35, PassportNumber = "A545645" };
            var user2 = new User { Name = "John Doe", EmailAddress = "johnd@example.com", Age = 42, PassportNumber = "K548754" };

            context.Users.Add(user1);
            context.Users.Add(user2);

            context.SaveChanges();
        }

        private void Seed_TestBookings(DBContext context)
        {
            
        }
    }
}
