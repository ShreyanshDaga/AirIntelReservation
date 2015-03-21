using AIR.DAL;
using AIR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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

        //public string AdminLogin(string adminUserName, string adminPassword)
        //{
        //    if (API.AdminSignIn(adminUserName, adminPassword))
        //        return "User Logged In";
        //    else
        //        return "Incorrect username/password";
        //}
        //public string CreateNewAdmin(Admin newAdmin)
        //{            
        //    if (API.AdminRegister(newAdmin))
        //        return "Succesful";
        //    else
        //        return "Fail";
        //}
        //public Admin GetAdminByUserName(int iId)
        //{
        //    var admins = API.GetAdmins();

        //    if (admins != null)
        //    {
        //        foreach (var admin in admins)
        //        {
        //            if (admin.Id == iId)
        //                return admin;
        //        }
        //        return null;
        //    }
        //    else
        //        return null;
        //}        

        #region Admin APIs
        public APIResult CreateNewAdmin(Admin newAdmin)
        {
            APIResult apiRes = new APIResult();

            try
            {
                
                return apiRes;
            }
            catch(Exception ex)
            {

                return apiRes;
            }
        }

        public APIResult AdminLogin(string adminUserName, string adminPassword)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public APIResult AdminLogout(int iAdminId)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public APIResult UpdateAdmin(Admin updateAdmin, int iAdminId)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public Admin GetAdminByUserName(string adminUserName)
        {            
        }

        public Admin GetLoggedInAdmin()
        {            
           
        }
        #endregion

        #region User APIs
        public APIResult CreateNewUser(User newUser)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public APIResult UserLogin(string userName, string userPassword)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public APIResult UserLogout(string iUserId)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public APIResult UpdateUser(User updateUser, int iUserId)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public User GetUserByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public User GetLoggedInUser()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Aircraft APIs
        public APIResult CreateNewAircraft(Aircraft newAircraft)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public APIResult RemoveAircraft(int iAircraftId)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public Aircraft GetAircraftDetails(int iAircraft)
        {
            throw new NotImplementedException();
        }

        public List<Aircraft> GetAllAircrafts()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Flight APIs
        public APIResult CreateNewFlight(Flight newFlight)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public APIResult RemoveFLight(int iFlightId)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public Flight GetFlightDetails(int iFlightId)
        {
            throw new NotImplementedException();
        }

        public List<Flight> GetAllFlights()
        {
            throw new NotImplementedException();
        }

        public List<Flight> GetFlightsBetweenAirports(string strTo, string strFrom)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Booking APIs
        public APIResult AddNewBooking(Booking newBooking)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public APIResult ChangeBooking(Booking booking, int iBookingId)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public APIResult CancelBooking(int iBookingId, int iUserId)
        {
            APIResult apiRes = new APIResult();

            try
            {

                return apiRes;
            }
            catch (Exception ex)
            {

                return apiRes;
            }
        }

        public Booking GetBookingDetails(int iBookingId)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetAllBookingsForUser(int iUserId)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetAllBookingsForFlight(int iFlightId)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
