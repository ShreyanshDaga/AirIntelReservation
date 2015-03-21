﻿using System;
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
        [OperationContract]
        string AdminLogin(string adminUserName, string adminPassword);
        [OperationContract]
        string CreateNewAdmin(Admin newAdmin);
        [OperationContract]
        Admin GetAdminByUserName(int iId);
    }
}
