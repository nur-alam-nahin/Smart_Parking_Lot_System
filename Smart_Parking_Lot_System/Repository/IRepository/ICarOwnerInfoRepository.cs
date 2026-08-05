using Smart_Parking_Lot_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.Repository.IRepository
{
    public interface ICarOwnerInfoRepository
    {
        void add(CarOwnerInfo carOwnerInfo);
        void update(int Id);
        void delete(int Id);
        List<CarOwnerInfo> getAll();
    }
}
