using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.Entities
{
    public class VahicleInfo
    {
        private string _vahicleType;
        private int _plateNumber;

        public VahicleInfo(string vahicleType, int plateNumber)
        {
            _vahicleType = vahicleType;
            _plateNumber = plateNumber;
        }

        public string getType()
        {
            return _vahicleType;
        }

        public int getPlateNum()
        {
            return _plateNumber;
        }
    }
}
