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
            this.Seed_TestBookings(context);
            base.Seed(context);
        }

        private void Seed_TestAdmins(DBContext context)
        {
            // Seeding Test Admin
            var admin1 = new Admin { Name = "Elon Musk", UserName = "emusk", PasswordHash = "pwd" };            

            context.Admins.Add(admin1);            

            context.SaveChanges();
        }

        private void Seed_TestAircrafts(DBContext context)
        {
            // Seeding Test Aircrafts
            var a380 = new Aircraft { Name = "Airbus A350", FusalageWidth = 4, TotalSeats = 72, BusinessSeats = 5, FirstClassSeats = 3, EconomySeats = 10 };            

            context.Aircrafts.Add(a380);            

            context.SaveChanges();
        }       

        private void Seed_TestFlights(DBContext context)
        {
            // Seeding test flight

            var a380 = context.Aircrafts.Single(a => a.Name == "Airbus A350");

            var flight1 = new Flight { AircraftId = a380.Id, BusinessFare = 299.59f, EconomyFare = 199.59f, FirstFare = 399.99f, Departure = DateTime.Now, Arrival = DateTime.Now.AddHours(2.5), Number = "EK 317", Destination = "LAX", Source = "EWR" };
            var flight2 = new Flight { AircraftId = a380.Id, BusinessFare = 299.59f, EconomyFare = 199.59f, FirstFare = 399.99f, Departure = DateTime.Now.AddHours(4.0), Arrival = DateTime.Now.AddHours(6.5), Number = "EK 318", Destination = "EWR", Source = "LAX" };

            context.Flights.Add(flight1);
            context.Flights.Add(flight2);

            context.SaveChanges();
        }

        private void Seed_TestBookings(DBContext context)
        {
            var flight1 = context.Flights.Single(f => f.Number == "EK 317");

            var user1 = new User { Name = "John Doe", EmailAddress = "johndoe@example.com", PassportNumber = "KDJB3252", Age = 34 };
            var user2 = new User { Name = "Jane Doe", EmailAddress = "janedoe@example.com", PassportNumber = "KDJB3456", Age = 32 };
            var user3 = new User { Name = "Jack Doe", EmailAddress = "jackdoe@example.com", PassportNumber = "KDJB4657", Age = 12 };

            var bk1 = new Booking { FlightId = flight1.Id, DepartureTime = flight1.Departure, BoardingTime = flight1.Departure.AddHours(0.30), SeatNumber = "1C", TicketNumber = "XYZ", TotalFare = 399.99f, User = user1 };
            var bk2 = new Booking { FlightId = flight1.Id, DepartureTime = flight1.Departure, BoardingTime = flight1.Departure.AddHours(0.30), SeatNumber = "1A", TicketNumber = "ABC", TotalFare = 399.99f, User = user2 };
            var bk3 = new Booking { FlightId = flight1.Id, DepartureTime = flight1.Departure, BoardingTime = flight1.Departure.AddHours(0.30), SeatNumber = "1B", TicketNumber = "DEF", TotalFare = 399.99f, User = user3 };

            context.Bookings.Add(bk1);
            context.Bookings.Add(bk2);
            context.Bookings.Add(bk3);

            context.SaveChanges();
        }
    }
}
