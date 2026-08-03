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
        private int _entryId;
        private double _amount;

        public ExitDateTime(int Id, int entryId, double amount)
        {
            _Id = Id;
            _entryId = entryId;
            _amount = amount;
        }


        public ExitDateTime( int entryId, double amount)
        {
            _entryId = entryId;
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

        public int getEntryId()
        {
            return _entryId;
        }


        public double getAmount()
        {
            return _amount;
        }
    }
}
