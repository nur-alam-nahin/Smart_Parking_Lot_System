using Smart_Parking_Lot_System.Entities;
using Smart_Parking_Lot_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.SPL_BLL
{
    class ExitDateTimeBLL
    {
        ExitDateTimeManager exitDateTimeManager = new ExitDateTimeManager();
        EntryDateTimeManager entryDateTimeManager = new EntryDateTimeManager();

        // add
        public void exitDateAdd()
        {
            Console.Write("Entry Id : ");
            int entryId = Convert.ToInt32(Console.ReadLine());

            entryDateTimeManager.exitTimeUp(entryId);

            double amount = exitDateTimeManager.calculateAmount(entryId);

            //Console.WriteLine("total hr = " + amount);

            ExitDateTime exitDateTime = new ExitDateTime(entryId, amount);

            exitDateTimeManager.add(exitDateTime);


        }



        //public void exitDateGetAll()
        //{
        //    Console.WriteLine("------ Vahicle List -----");
        //    exitDateTimeManager.getAll();
        //}



            // all info
        public void allList()
        {
            exitDateTimeManager.fullView();
        }



        // selected info
        public void selectView()
        {
            Console.Write("Enter Id = ");
            int enterId = Convert.ToInt32(Console.ReadLine());
            exitDateTimeManager.selectView(enterId);
        }


        public void deleteParking()
        {
            Console.Write("Enter Id = ");
            int enterId = Convert.ToInt32(Console.ReadLine());
            exitDateTimeManager.delete(enterId);
        }

    }
}
