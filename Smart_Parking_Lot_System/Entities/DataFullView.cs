using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.Entities
{
    public class DataFullView
    {
        public int Id { get; set; }

        public string CarOwnerName { get; set; }

        public string Phone { get; set; }

        public string VehicleType { get; set; }

        public string PlateNumber { get; set; }

        public DateTime EntryDateandTime { get; set; }

        public DateTime ExitDateandTime { get; set; }

        public int ParkingSlot { get; set; }

        public double Amount { get; set; }
    }
}
