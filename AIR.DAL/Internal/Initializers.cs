using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AIR.DAL.Internal
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            this.Seed_TestAdmins();
            this.Seed_TestAircrafts();
            this.Seed_TestFlights();
            this.Seed_TestUsers();
            this.Seed_TestBookings();

            base.Seed(context);
        }

        private void Seed_TestAdmins()
        {
        }

        private void Seed_TestAircrafts()
        {
        }

        private void Seed_TestFlights()
        {
        }

        private void Seed_TestUsers()
        {
        }

        private void Seed_TestBookings()
        {
        }
    }
}
