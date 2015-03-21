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

        public string AdminLogin(string adminUserName, string adminPassword)
        {
            if (API.AdminSignIn(adminUserName, adminPassword))
                return "User Logged In";
            else
                return "Incorrect username/password";
        }

        public string CreateNewAdmin(string strName, string strUserName, string strPassword)
        {
            var newDmin = new Admin();

            newDmin.Name = strName;
            newDmin.PasswordHash = strPassword;

            if (API.AdminRegister(newDmin))
                return "Succesful";
            else
                return "Fail";
        }
    }
}
