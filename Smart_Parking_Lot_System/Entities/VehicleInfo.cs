using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.Entities
{
    public class VehicleInfo
    {
        private int _Id;
        private int _CarOwnerId;
        private string _vahicleType;
        private string _plateNumber;

        public VehicleInfo(int Id , int CarOwnerId , string vahicleType, string plateNumber)
        {
            _Id = Id;
            _CarOwnerId = CarOwnerId;
            _vahicleType = vahicleType;
            _plateNumber = plateNumber;
        }


        public VehicleInfo(int CarOwnerId , string vahicleType, string plateNumber)
        {
            _CarOwnerId = CarOwnerId;
            _vahicleType = vahicleType;
            _plateNumber = plateNumber;
        }


        public VehicleInfo(int Id)
        {
            _Id = Id;
        }


        public int getId()
        {
            return _Id;
        }

        public int getCarOwnerId()
        {
            return _CarOwnerId;
        }
        public string getType()
        {
            return _vahicleType;
        }

        public string getPlateNum()
        {
            return _plateNumber;
        }
    }
}
