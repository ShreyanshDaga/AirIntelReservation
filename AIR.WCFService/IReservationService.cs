using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using AIR.Entities;
using AIR.DAL;

namespace AIR.WCFService
{
    [ServiceContract]
    public interface IReservationService
    {
        #region Misc
        [OperationContract]
        bool Ping();
        [OperationContract]
        string InitService();
        #endregion

        #region AdminAPIs
        [OperationContract]
        APIResult CreateNewAdmin(Admin newAdmin);
        [OperationContract]
        APIResult AdminLogin(string adminUserName, string adminPassword);
        [OperationContract]
        APIResult AdminLogout(int iAdminId);        
        [OperationContract]
        APIResult UpdateAdmin(Admin updateAdmin, int iAdminId);
        [OperationContract]
        Admin GetAdminByUserName(string adminUserName);
        [OperationContract]
        Admin GetLoggedInAdmin();
        #endregion

        #region User APIs
        [OperationContract]
        APIResult CreateNewUser(User newUser);
        [OperationContract]
        APIResult UserLogin(string userName, string userPassword);
        [OperationContract]
        APIResult UserLogout(int iUserId);
        [OperationContract]
        APIResult UpdateUser(User updateUser, int iUserId);
        [OperationContract]
        int GetUserIdByEmailAddress(string userEmail);
        [OperationContract]
        User GetLoggedInUser();
        #endregion

        #region Aircraft APIs
        [OperationContract]
        APIResult CreateNewAircraft(Aircraft newAircraft, int iAdminId);
        [OperationContract]
        APIResult RemoveAircraft(int iAircraftId, int iAdminId);
        [OperationContract]
        Aircraft GetAircraftDetails(int iAircraft);
        [OperationContract]
        List<Aircraft> GetAllAircrafts();
        #endregion

        #region Flight APIs
        [OperationContract]
        APIResult CreateNewFlight(Flight newFlight, int iAdminId);
        [OperationContract]
        APIResult RemoveFlight(int iFlightId, int iAdminId);
        [OperationContract]
        Flight GetFlightDetails(int iFlightId);
        [OperationContract]
        List<Flight> GetAllFlights();
        [OperationContract]
        List<Flight> GetFlightsBetweenAirports(string strTo, string strFrom);
        #endregion

        #region Booking APIs
        [OperationContract]
        APIResult AddNewBooking(Booking newBooking);
        [OperationContract]
        APIResult ChangeBooking(Booking booking, int iBookingId);
        [OperationContract]
        APIResult CancelBooking(int iBookingId, int iUserId);
        [OperationContract]
        Booking GetBookingDetails(int iBookingId);
        [OperationContract]
        List<Booking> GetAllBookingsForUser(int iUserId);
        [OperationContract]
        List<string> GetAllSeatsForFlight(int iFlightId);
        [OperationContract]
        bool IsSeatAvailable(string seatNumber, int iFlightId);
        #endregion

        #region Reports APIs
        // To be implemented later
        #endregion
    }
}
