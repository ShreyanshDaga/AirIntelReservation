using AIR.DAL.Internal;
using AIR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIR.DAL
{
    public static class API
    {
        public static DBContext Context;            // DbContext object
        public static List<Admin> SignedInAdmins;   // Signed in Adimins
        public static List<User> SignInUsers;       // Signed in Users

        static API()
        {
            // Initialization
            Context = new DBContext("TestConn_Local");            
            SignedInAdmins = new List<Admin>(5);
            SignInUsers = new List<User>(5);
        }
        // For DEBUG
        public static void Init()
        {
            if (!Context.Database.Exists())
            {
                Context.Database.Initialize(true);
            }
        }

        public static List<Admin> GetAdmins()
        {
            return Context.Admins.ToList();
        }
        public static Admin GetLogginAdmin()
        {
            // Only for basic console app
            return SignedInAdmins[0];
        }
        public static bool RegisterNewUser(string userName, string userPassword, bool bAdmin)
        {
            if(bAdmin)
            {
                var Admin = new Admin { Name = userName, PasswordHash = userPassword};
                Context.Admins.Add(Admin);
                Context.SaveChanges();
            }
            else
            {
                var User = new User { UserName = userName, Password = userPassword};
                Context.Users.Add(User);
                Context.SaveChanges();
            }


            return true;
        }
        public static User GetLoggedInUser()
        {
            // Only for basic console app
            return SignInUsers[0];
        }
        public static List<User> GetUsers()
        {
            return Context.Users.ToList();
        }
        public static bool UserRegister(User newUser)
        {
            if(newUser != null)
            {
                Context.Users.Add(newUser);
                return true;
            }

            return false;
        }
        public static bool AdminRegister(Admin newAdmin)
        {
            if (newAdmin != null)
            {
                Context.Admins.Add(newAdmin);
                Context.SaveChanges();
                return true;
            }

            return false;
        }
        public static bool AdminSignIn(string adminName, string adminPassword)
        {
            
            try
            {
                var adminInDB = Context.Admins.Single(a => a.Name == adminName);

                if(adminInDB != null)
                {
                    if (adminPassword == adminInDB.PasswordHash)
                    {
                        SignedInAdmins.Add(adminInDB);
                        return true;
                    }
                    else
                        return false;
                }

                return false;
            }
            catch(Exception ex)
            {
                return false;
            }                        

        }
        public static bool AdminSignOut(int iAdminId)
        {
            foreach (var user in SignedInAdmins)
            {
                if (user.Id == iAdminId)
                {
                    SignedInAdmins.Remove(user);
                    return true;
                }
            }

            return false;
        }
        public static bool UserSignIn(string userName, string userPassword)
        {
            User user = new User();
            SignInUsers.Add(user);
            return true;
        }
        public static bool UserSignOut(int iUserId)
        {
            foreach (var user in SignInUsers)
            {
                if (user.Id == iUserId)
                { 
                    SignInUsers.Remove(user);
                    return true;
                }
            }

            return false;
        }
        private static bool IsUserSignedIn(int iUserId)
        {
            foreach (var admin in SignInUsers)
            {
                if (admin.Id == iUserId)
                    return true;
            }
            return false;
        }
        private static bool IsAdminSignedIn(int iAdminId)
        {
            foreach(var admin in SignedInAdmins)
            {
                if (admin.Id == iAdminId)
                    return true;
            }
            return false;
        }
        public static bool AddNewAircraft(Aircraft newAircraft, int iAdminId)
        {
            if(IsAdminSignedIn(iAdminId))
            {
                try
                {
                    Context.Aircrafts.Add(newAircraft);
                    Context.SaveChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }

            return false;
        }
        public static bool RemoveAircraft(int iAircraftId, int iAdminId)
        {
            // Find the entry for aircraft first
            var aircraft = Context.Aircrafts.Single(a => a.Id == iAircraftId);

            if(aircraft != null)
            {
                Context.Aircrafts.Remove(aircraft);
                Context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }        
        public static List<Flight> GetAllFights()
        {
            try
            {
                var flights = Context.Flights.ToList();
                return flights;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public static Flight GetFlightDetail(int iFlightId)
        {
            try
            {
                var flightDetail = Context.Flights.Single(f => f.Id == iFlightId);
                if (flightDetail != null)
                    return flightDetail;
                else
                    return null;
            }
            catch(Exception ex)
            {
                return null;
            }
        }        
        public static bool AddNewFlight(Flight newFlight, int iAdminId)
        {
            if(IsAdminSignedIn(iAdminId))
            {
                try
                {
                    Context.Flights.Add(newFlight);
                    Context.SaveChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
            return false;
        }        
        public static bool IsFlightFull(int iFlightId)
        {
            return true;
        }
        public static bool IsBusinessFull(int iFlightId)
        {
            return true;
        }
        public static bool IsFirstClassFull(int iFlightId)
        {
            return true;
        }
        public static bool IsEconomyFull(int iFlightId)
        {
            return true;
        }
        public static bool BookSeatInFlight(int iFlightId, int iUserId)
        {
            return true;
        }
        public static bool ChangeSeat(int iBookingId, int iUserId)
        {
            return true;
        }
        public static bool CancelBooking(int iBookingId, int iUserId)
        {
            return true;
        }
        public static List<Booking> GetBookingsForUser(int iUserId)
        {
            var user = Context.Users.Single(u => u.Id == iUserId);

            return user.Bookings.ToList();
        }                                        
        public static List<Aircraft> GetAllAircrafts()
        {
            return Context.Aircrafts.ToList();
        }
        public static bool UpdateAdmin(Admin updateAdmin, int iAdminId)
        {
            var admin = Context.Admins.Single(a => a.Id == iAdminId);

            if(admin != null)
            {
                admin.Name = updateAdmin.Name;
                admin.PasswordHash = updateAdmin.PasswordHash;
                admin.UserName = updateAdmin.UserName;

                Context.Entry(admin).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return true;

            }

            return false;
        }
        public static Admin GetAdminByUserName(string adminUserName)
        {
            return Context.Admins.Single(a => a.UserName == adminUserName);
        }
        public static bool UpdateUserDetails(User updateUser, int iUserId)
        {
            var user = Context.Users.Single(u => u.Id == iUserId);

            if (user != null)
            {
                user.Name = updateUser.Name;
                user.PassportNumber = updateUser.PassportNumber;
                user.Password = updateUser.Password;
                user.Age = updateUser.Age;
                user.EmailAddress = updateUser.EmailAddress;

                Context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();

                return true;
            }

            return false;
        }
        public static User GetUserByName(string userName)
        {
            return Context.Users.Single(u => u.UserName == userName);
        }
        public static Aircraft GetAircraftDetails(int iAircraftId)
        {
            return Context.Aircrafts.Single(a => a.Id == iAircraftId);
        }
        public static bool RemoveFlight(int iFlightId, int iAdminId)
        {
            if (!IsAdminSignedIn(iAdminId))
                return false;

            var flight = Context.Flights.Single(f => f.Id == iFlightId);

            if (flight != null)
            {
                Context.Flights.Remove(flight);
                Context.SaveChanges();

                return true;
            }
            
            return false;
        }
        public static List<Flight> GetFlightBetweenAirports(string strTo, string strFrom)
        {
            var flights = Context.Flights.Where(f => f.Source == strFrom && f.Destination == strTo).ToList();

            return flights;
        }
        public static bool AddNewBooking(Booking newBooking)
        {
            Context.Bookings.Add(newBooking);
            Context.SaveChanges();

            return true;
        }
        public static bool ChangeBooking(Booking booking, int iBookingId)
        {
            var oldBooking = Context.Bookings.Single(b => b.Id == iBookingId);

            if(oldBooking != null)
            {
                oldBooking.SeatNumber = booking.SeatNumber;

                switch(booking.SeatNumber[0])
                {
                    case 'B':
                        oldBooking.TotalFare = oldBooking.Flight.BusinessFare;
                        break;

                    case 'F':
                        oldBooking.TotalFare = oldBooking.Flight.FirstFare;
                        break;

                    case 'E':
                        oldBooking.TotalFare = oldBooking.Flight.EconomyFare;
                        break;
                }

                Context.Entry(oldBooking).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();

                return true;
            }

            return false;
        }       
        public static Booking GetBooking(int iBookingId)
        {
            return Context.Bookings.Single(b => b.Id == iBookingId);
        }
        public static List<Booking> GetBookingsForFlight(int iFlightId)
        {
            var bookings = Context.Bookings.Where(b => b.Flight.Id == iFlightId).ToList();

            return bookings;
        }
    }
}
