using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.Entities
{
    public class EntryDateTime
    {
        private int _Id;
        private int _vehicleId;
        private string _entryDate;
        private string _entryTime;


        public EntryDateTime(int Id, int vehicleId, string entryDate , string entryTime)
        {
            _Id = Id;
            _vehicleId = vehicleId;
            _entryDate = entryDate;
            _entryTime = entryTime;
        }


        public EntryDateTime(int vehicleId, string entryDate, string entryTime)
        {
            _vehicleId = vehicleId;
            _entryDate = entryDate;
            _entryTime = entryTime;
        }


        public EntryDateTime(int Id)
        {
            _Id = Id;
        }

        public int getId()
        {
            return _Id;
        }

        public int getVehicleId()
        {
            return _vehicleId;
        }

        public string getEntryDate()
        {
            return _entryDate;
        }

        public string getEntryTime()
        {
            return _entryTime;
        }
    }
}
