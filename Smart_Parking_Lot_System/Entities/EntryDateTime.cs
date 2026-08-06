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
        private int _ownerId;
        private DateTime _entryDateAndTime;
        private DateTime _exitDateAndTime;
        private int _parkingSlot;



        public EntryDateTime(int Id, int vehicleId, int ownerId , DateTime entryDateAndTime , DateTime exitDateAndTime , int parkingSlot)
        {
            _Id = Id;
            _vehicleId = vehicleId;
            _ownerId = ownerId;
            _entryDateAndTime = entryDateAndTime;
            _exitDateAndTime = exitDateAndTime;
            _parkingSlot = parkingSlot;
        }


        public EntryDateTime(int vehicleId, int ownerId , int parkingSlot)
        {
            _vehicleId = vehicleId;
            _ownerId = ownerId;
            _parkingSlot = parkingSlot;
        }


        public EntryDateTime(DateTime entryDateAndTime , DateTime exitDateAndTime)
        {
            _entryDateAndTime = entryDateAndTime;
            _exitDateAndTime = exitDateAndTime;
        }





        public EntryDateTime(int Id)
        {
            _Id = Id;
        }



        public EntryDateTime()
        {

        }

        public int getId()
        {
            return _Id;
        }

        public int getVehicleId()
        {
            return _vehicleId;
        }

        public int getownerId()
        {
            return _ownerId;
        }

        public DateTime getEntryDateAndTime()
        {
            return _entryDateAndTime;
        }


        public DateTime getexitDateAndTime()
        {
            return _exitDateAndTime;
        }


        public int getparkingSlot()
        {
            return _parkingSlot;
        }

    }
}
