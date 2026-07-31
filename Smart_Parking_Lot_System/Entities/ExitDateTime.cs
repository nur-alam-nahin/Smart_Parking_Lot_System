using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.Entities
{
    public class ExitDateTime
    {
        private int _Id;
        private int _vehicleId;
        private int _entryId;
        private string _exitDate;
        private string _exitTime;
        private double _amount;

        public ExitDateTime(int Id, int vehicleId, int entryId, string exitDate, string exitTime, double amount)
        {
            _Id = Id;
            _vehicleId = vehicleId;
            _entryId = entryId;
            _exitDate = exitDate;
            _exitTime = exitTime;
            _amount = amount;
        }


        public ExitDateTime(int vehicleId, int entryId, string exitDate, string exitTime, double amount)
        {
            _vehicleId = vehicleId;
            _entryId = entryId;
            _exitDate = exitDate;
            _exitTime = exitTime;
            _amount = amount;
        }


        public ExitDateTime(int Id)
        {
            _Id = Id;
        }


        public int getId()
        {
            return _Id;
        }

        public int getvehicleId()
        {
            return _vehicleId;
        }

        public int getEntryId()
        {
            return _entryId;
        }


        public string getExitDate()
        {
            return _exitDate;
        }

        public string getExitTime()
        {
            return _exitTime;
        }

        public double getAmount()
        {
            return _amount;
        }
    }
}
