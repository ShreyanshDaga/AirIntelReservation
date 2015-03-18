using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AIR.DAL;
using AIR.Entities;

namespace AIR.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());

            API.Init();

            foreach(var admin in API.GetAdmins())
            {
                System.Console.WriteLine("Name: " + admin.Name);
                System.Console.WriteLine("--------------------");
            }

            System.Console.ReadLine();
        }
    }
}
