using AIR.DAL;
using AIR.DAL.Internal;
using AIR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AIR.WCFService
{    
    public class ReservationService : IReservationService
    {        
        static ReservationService()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
            API.Init();
        }

        #region Custom Service PING        
        public bool Ping()
        {
            return true;
        }
        #endregion

        #region Admin APIs
        public APIResult CreateNewAdmin(Admin newAdmin)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.AdminRegister(newAdmin))
                {
                    apiRes.AddResult("0", "New administrator created.");                    
                }
                else
                {
                    apiRes.AddError("Error", "Unable to create new Administrator.");
                    
                }
                return apiRes;
            }
            catch(Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public APIResult AdminLogin(string adminUserName, string adminPassword)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.AdminSignIn(adminUserName, adminPassword))
                    apiRes.AddResult("0", "Login successful.");
                else
                    apiRes.AddError("Error", "Incorrect username/password for Admin login.");
                
                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public APIResult AdminLogout(int iAdminId)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.AdminSignOut(iAdminId))
                    apiRes.AddResult("0", "Logout successful.");
                else
                    apiRes.AddError("Error", "Unable to logout.");
                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public APIResult UpdateAdmin(Admin updateAdmin, int iAdminId)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.UpdateAdmin(updateAdmin, iAdminId))
                    apiRes.AddResult("0", "Administrator details updated.");
                else
                    apiRes.AddError("Error", "Unable to update administrator details");

                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public Admin GetAdminByUserName(string adminUserName)
        {
            var admin = API.GetAdminByUserName(adminUserName);
            
            return admin;            
        }

        public Admin GetLoggedInAdmin()
        {
            var loggedinAdmin = API.GetLogginAdmin();

            return loggedinAdmin;
        }
        #endregion

        #region User APIs
        public APIResult CreateNewUser(User newUser)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.UserRegister(newUser))
                    apiRes.AddResult("0", "New user created.");
                else
                    apiRes.AddError("Error", "Unable to create new user.");

                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public APIResult UserLogin(string userName, string userPassword)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.UserSignIn(userName, userPassword))
                    apiRes.AddResult("0", "Login successful.");
                else
                    apiRes.AddError("Error", "Incorrect username/password.");

                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public APIResult UserLogout(int iUserId)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.UserSignOut(iUserId))
                    apiRes.AddResult("0", "Logout successful.");
                else
                    apiRes.AddError("Error", "Unable to logout user.");
                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public APIResult UpdateUser(User updateUser, int iUserId)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.UpdateUserDetails(updateUser, iUserId))
                    apiRes.AddResult("0", "User details updated.");
                else
                    apiRes.AddError("Error", "Unable to update user details.");

                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public User GetUserByUserName(string userName)
        {
            var user = API.GetUserByName(userName);

            return user;
        }

        public User GetLoggedInUser()
        {
            // To be looked at again

            return null;
        }
        #endregion

        #region Aircraft APIs
        public APIResult CreateNewAircraft(Aircraft newAircraft, int iAdminId)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.AddNewAircraft(newAircraft, iAdminId))
                    apiRes.AddResult("0", "New aircraft added in service.");
                else
                    apiRes.AddError("Error", "Unable to add new aircraft in service");

                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public APIResult RemoveAircraft(int iAircraftId, int iAdminId)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.RemoveAircraft(iAircraftId, iAircraftId))
                    apiRes.AddResult("0", "Aircraft removed from service.");
                else
                    apiRes.AddError("Error", "Unable to remove aircraft from service");

                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public Aircraft GetAircraftDetails(int iAircraftId)
        {
            var aircraft = API.GetAircraftDetails(iAircraftId);

            return aircraft;
        }

        public List<Aircraft> GetAllAircrafts()
        {
            var allAircrafts = API.GetAllAircrafts();

            return allAircrafts;
        }
        #endregion

        #region Flight APIs
        public APIResult CreateNewFlight(Flight newFlight, int iAdminId)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.AddNewFlight(newFlight, iAdminId))
                    apiRes.AddResult("0", "New flight added and scheduled.");
                else
                    apiRes.AddError("Error", "Unable to add new flight.");

                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public APIResult RemoveFlight(int iFlightId, int iAdminId)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.RemoveFlight(iFlightId, iAdminId))
                    apiRes.AddResult("0", "Flight unscheduled and removed.");
                else
                    apiRes.AddError("Error", "Unable to remove flight.");

                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public Flight GetFlightDetails(int iFlightId)
        {
            var flight = API.GetFlightDetail(iFlightId);

            return flight;
        }

        public List<Flight> GetAllFlights()
        {
            var allFlights = API.GetAllFights();

            return allFlights;
        }

        public List<Flight> GetFlightsBetweenAirports(string strTo, string strFrom)
        {
            var flightsBetweenAirports = API.GetFlightBetweenAirports(strTo, strFrom);

            return flightsBetweenAirports;
        }
        #endregion

        #region Booking APIs
        public APIResult AddNewBooking(Booking newBooking)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.AddNewBooking(newBooking))
                    apiRes.AddResult("0", "New booking added.");
                else
                    apiRes.AddError("Error", "Unable to add new booking");

                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public APIResult ChangeBooking(Booking booking, int iBookingId)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.ChangeBooking(booking, iBookingId))
                    apiRes.AddResult("0", "Booking changed successfully.");
                else
                    apiRes.AddError("Error", "Unable to change booking.");

                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public APIResult CancelBooking(int iBookingId, int iUserId)
        {
            APIResult apiRes = new APIResult();

            try
            {
                if (API.CancelBooking(iBookingId, iUserId))
                    apiRes.AddResult("0", "Booking cancelled.");
                else
                    apiRes.AddError("Error", "Unable to cancel booking.");

                return apiRes;
            }
            catch (Exception ex)
            {
                apiRes.AddError("Error", ex.Message);
                return apiRes;
            }
        }

        public Booking GetBookingDetails(int iBookingId)
        {
            var booking = API.GetBooking(iBookingId);

            return booking;
        }

        public List<Booking> GetAllBookingsForUser(int iUserId)
        {
            var bookingsForUser = API.GetBookingsForUser(iUserId);

            return bookingsForUser;
        }

        public List<Booking> GetAllBookingsForFlight(int iFlightId)
        {
            var bookingsForFlight = API.GetBookingsForFlight(iFlightId);

            return bookingsForFlight;
        }
        #endregion
    }
}
