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
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ReservationService : IReservationService
    {                
        #region Misc      
        public bool Ping()
        {
            // Simple method to check if service is still running or not
            return true;
        }
        public string InitService()
        {
            try
            {
                API.Init();
                return "Success";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
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
            try
            {
                var admin = API.GetAdminByUserName(adminUserName);
                return admin;
            }
            catch(Exception ex)
            {
                return null;
            }            
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

        public int GetUserIdByEmailAddress(string userEmail)
        {
            var id = API.GetUserIdByEmail(userEmail);

            return id;
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
                    apiRes.AddError("Error","This seat is already assigned.!");

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

        public List<string> GetAllSeatsForFlight(int iFlightId)
        {
            var bookingsForFlight = API.GetBookingsForFlight(iFlightId);

            List<string> seats = new List<string>();

            foreach(var booking in bookingsForFlight)
            {
                seats.Add(booking.SeatNumber);
            }

            return seats;
        }

        public bool IsSeatAvailable(string seatNumber, int iFlightId)
        {
            var bookings = API.GetBookingsForFlight(iFlightId);

            if(bookings != null)
            {
                foreach(var booking in bookings)
                {
                    if (booking.SeatNumber == seatNumber)
                        return false;
                }

                return true;
            }

            return false;
        }
        #endregion
    }
}
