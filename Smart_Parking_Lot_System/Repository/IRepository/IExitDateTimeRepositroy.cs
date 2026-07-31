using Smart_Parking_Lot_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.Repository.IRepository
{
    public interface IExitDateTimeRepositroy
    {
        void add(ExitDateTime exitDateTime);
        void update();
        void delete();
        void getAll(ExitDateTime exitDateTime);
    }
}
