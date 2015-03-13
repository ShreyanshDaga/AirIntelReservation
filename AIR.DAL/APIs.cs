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
        public static DBContext Context;

        static API()
        {
            // Initialization
            Context = new DBContext();
        }

        // For User/Admin Management
        public static bool UserRegister(User newUser)
        {
        }
        public static bool AdminRegister(Admin newAdmin)
        {
        }
        public static bool AdminSignIn(Admin admin)
        {
        }
        public static bool AdminSignOut(int iAdminId)
        {
        }
        public static bool UserSignIn(User user)
        {
        }
        public static bool UserSignOut(int iUserId)
        {
        }

        // Aircraft Management
        public static bool AddNewAircraft(Aircraft newAircraft)
        {
        }
        public static bool RemoveAircraft(int iAircraftId)
        {
        }        

        // Flight Management
        public static List<Flight> GetAllFights()
        {

        }
        public static Flight GetFlight(int iFlightId)
        {

        }        
        public static bool AddNewFlight(Flight newFlight)
        {

        }
        public static bool BookSeatInFlight(int iFlightId, int iUserId)
        {

        }

        // Booking Management
    }
}
