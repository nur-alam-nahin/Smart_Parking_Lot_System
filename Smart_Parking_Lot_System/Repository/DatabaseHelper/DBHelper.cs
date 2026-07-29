using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.Repository.DatabaseHelper
{
    abstract class DBHelper
    {
        protected string connectionString = "Server=.;database=SmartParkingDB;integrated security=true;";
    }
}
