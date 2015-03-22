using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AIR.Entities;

namespace AIR.DAL.Internal
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            this.Seed_TestAdmins(context);
            this.Seed_TestAircrafts(context);

            base.Seed(context);
        }

        private void Seed_TestAdmins(DBContext context)
        {
            // Seeding Test Admin
            var admin1 = new Admin { Name = "Elon Musk", UserName = "emusk", PasswordHash = "pwd" };            

            context.Admins.Add(admin1);            

            context.SaveChanges();
        }

        private void Seed_TestAircrafts(DBContext context)
        {
            // Seeding Test Aircrafts
            var a380 = new Aircraft { Name = "Airbus A350", FusalageWidth = 10, TotalSeats = 600, BusinessSeats = 10, FirstClassSeats = 5, EconomySeats = 40 };            

            context.Aircrafts.Add(a380);            

            context.SaveChanges();
        }       
    }
}
