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
        public string CreateNewAdmin(Admin newAdmin)
        {            
            if (API.AdminRegister(newAdmin))
                return "Succesful";
            else
                return "Fail";
        }
        public Admin GetAdminByUserName(int iId)
        {
            var admins = API.GetAdmins();

            if (admins != null)
            {
                foreach (var admin in admins)
                {
                    if (admin.Id == iId)
                        return admin;
                }
                return null;
            }
            else
                return null;
        }
    }
}
