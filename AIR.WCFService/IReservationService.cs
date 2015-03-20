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
    public interface IReservationService
    {
        string AdminLogin(string adminUserName, string adminPassword);
        string CreateNewAdmin(string strName, string strUserName, string strPassword, );
    }
}
