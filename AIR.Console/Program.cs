using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AIR.Entities;
using AIR.WCFService;
using System.ServiceModel;

namespace AIR.Console
{
    class Program
    {
        public static Admin loggedInAdmin;
        public static User loggedInUser;
        public static ServiceHost svcAirIntelReservation;

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());

            System.Console.WriteLine(" --x Air Intel Reservation service x-- ");
            System.Console.WriteLine("\n Press any key to start the service.!");

            System.Console.ReadKey();

            try
            {
                svcAirIntelReservation = new ServiceHost(typeof(ReservationService));
                svcAirIntelReservation.Open();

                System.Console.WriteLine(" Service Started");
                System.Console.WriteLine(" Air Intel Reservation service is now running..");                
            }
            catch(Exception ex)
            {
                svcAirIntelReservation = null;
                System.Console.WriteLine("** Error starting service **");
                System.Console.WriteLine("   Error Message: " + ex.Message);
                System.Console.WriteLine("\nPress any key to continue.!");
                System.Console.ReadKey();
            }

            if(svcAirIntelReservation != null)
            {
                System.Console.WriteLine("\n Press any key to stop the service.!");
                System.Console.ReadKey();
            }
            //Basic_Console();
        }

        //public static int Basic_Console()
        //{
        //    // Main Menu for User/Admin
        //    int iCh = 1;
        //    while(iCh != 0)
        //    {
        //        iCh = PrintMainMenu();
        //        switch(iCh)
        //        {
        //            case 0:
        //                System.Console.WriteLine("Exiting System");
        //            return 0;                    

        //            case 1:
        //                // Admin Login
        //                AdminLogin();
        //            break;

        //            case 2:
        //                // User Login
        //                UserLogin();
        //            break;                                        
                    
        //            default:
        //                System.Console.WriteLine("Error: Invalid Choice !");
        //            break;
        //        }
        //    }

        //    return 0;
        //}
                             
        //private static int PrintMainMenu()
        //{
        //    System.Console.WriteLine("\n Select Login Type: ");
        //    System.Console.WriteLine("1. System Administrator");
        //    System.Console.WriteLine("2. User");
        //    System.Console.WriteLine("\nEnter Choice");

        //    int iCh = Convert.ToInt32(System.Console.ReadLine());

        //    return iCh;
        //}
        //private static void AdminLogin()
        //{
        //    int iCh = 1;

        //    while (iCh != 0)
        //    {
        //        iCh = PrintAdminLoginMenu();
        //        switch (iCh)
        //        {
        //            case 0:
        //                return;
                    
        //            case 1:
        //                string adminName, adminPassword;
        //                System.Console.WriteLine("** Admin Login **");
        //                System.Console.WriteLine("Enter Admin Name: ");
        //                adminName = System.Console.ReadLine();
        //                System.Console.WriteLine("Enter Admin Passeord: ");
        //                adminPassword = System.Console.ReadLine();

        //                if(!API.AdminSignIn(adminName, adminPassword))
        //                {
        //                    System.Console.WriteLine("Error: Unable to Login. Incorrect Username and Password");
        //                    break;
        //                }
        //                loggedInAdmin = API.GetLogginAdmin();
        //                Admin_Functionality();
                        
        //            break;

        //            case 2:
        //                // Register New Admin
        //                // Loggin Admin
        //            break;
        //        }
        //    }
        //}
        
        //private static void UserLogin()
        //{
        //    int iCh = 1;

        //    while (iCh != 0)
        //    {
        //        iCh = PrintUserLoginMenu();
        //        switch (iCh)
        //        {

        //        }
        //    }
        //}
        //private static int PrintAdminLoginMenu()
        //{
        //    System.Console.WriteLine("Admin Login");
        //    System.Console.WriteLine("1. Existing Admin ");
        //    System.Console.WriteLine("2. New Admin");

        //    return Convert.ToInt32(System.Console.ReadLine());
        //}
        //private static int PrintUserLoginMenu()
        //{
        //    System.Console.WriteLine("User Login");
        //    System.Console.WriteLine("1. Existing User ");
        //    System.Console.WriteLine("2. New User");

        //    return Convert.ToInt32(System.Console.ReadLine());
        //}
        //private static void Admin_Functionality()
        //{
        //    int iCh = 1;

        //    while(iCh != 0)
        //    {
        //        iCh = PrintAdminFunctionMenu();
        //        switch(iCh)
        //        {
        //            case 0:
        //                //Return
        //                return;                        

        //            case 1:
        //                // View All Flights
        //                var Flights = API.GetAllFights();
        //                int i = 0;
        //                foreach(var flight in Flights)
        //                {
        //                    System.Console.WriteLine("Flight # " + i);
        //                    System.Console.WriteLine(flight.Number + ", " + flight.Source + " to " + flight.Destination);
        //                    System.Console.WriteLine("--------------------------------------------------------------------------------");
        //                    i++;
        //                }
        //                break;
        //            case 2:
        //                // View Flight Details

        //                break;
        //            case 3:
        //                //Add New Flight
        //                System.Console.WriteLine("Add new Flight:");
        //                Flight newFlight = new Flight();
        //                System.Console.WriteLine();
        //                break;

        //            case 4:
        //                // Edit Exsiting Flight
        //                break;

        //            case 5:
        //                // Add New Aircraft
        //                break;

        //            case 6:
        //                // Remove Aircraft
        //                break;

        //            case 7:
        //                // Manage Admin
        //                break;
        //        }
        //    }
        //}

        //private static int PrintAdminFunctionMenu()
        //{
        //    System.Console.WriteLine("Admin Function Menu");
        //    System.Console.WriteLine("1. View All Flights");
        //    System.Console.WriteLine("2. View Single Flight Details");
        //    System.Console.WriteLine("3. Add New Flight");
        //    System.Console.WriteLine("4. Edit Flight");
        //    System.Console.WriteLine("5. Add new Aircraft into Service");
        //    System.Console.WriteLine("6. Remove Aircraft from Service");
        //    System.Console.WriteLine("7. Manage Profile");
        //    System.Console.WriteLine("0. Back");

        //    return Convert.ToInt32(System.Console.ReadLine());
        //}        
    }
}
