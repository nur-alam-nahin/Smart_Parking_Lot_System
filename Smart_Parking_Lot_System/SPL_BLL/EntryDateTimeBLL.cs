using Smart_Parking_Lot_System.Entities;
using Smart_Parking_Lot_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.SPL_BLL
{
    class EntryDateTimeBLL
    {


        EntryDateTimeManager entryDateTimeManager = new EntryDateTimeManager();

        // add
        public void EntryDateTimeAdd()
        {
            Console.Write("Vechicle Id : ");
            int vechicleId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Car Owner Id : ");
            int ownerId = Convert.ToInt32(Console.ReadLine());

            if(entryDateTimeManager.parkingSoltCheck() < 20)
            {
                for(int i = 0; i < 20; i++)
                {
                    if(entryDateTimeManager.parkingSoltCheck() != i)
                    {

                        EntryDateTime entryDateTime = new EntryDateTime(vechicleId, ownerId, entryDateTimeManager.parkingSoltCheck());
                        entryDateTimeManager.add(entryDateTime);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Parking Slot is Full");
            }


          
        }





        // delete

        public void EntryDateTimeDelete()
        {
            Console.Write("Enter Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            CarOwnerInfo carOwnerInfo = new CarOwnerInfo(Id);

            //carOwnerInfoManager.delete(carOwnerInfo.getId());
        }




        // update

        public void EntryDateTimeUpdate()
        {
            Console.Write("Enter Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            //Books books = new Books(Id);

            entryDateTimeManager.update(Id);
        }




        // get all

        public void EntryDateTimeGetAll()
        {
            Console.WriteLine("------ Entry List -----");
            entryDateTimeManager.getAll();
        }
    }
}
