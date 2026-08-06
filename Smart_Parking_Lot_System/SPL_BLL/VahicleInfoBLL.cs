using Smart_Parking_Lot_System.Entities;
using Smart_Parking_Lot_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.SPL_BLL
{
    class VahicleInfoBLL
    {

        VehicleInfoManager vahicleInfoManager = new VehicleInfoManager();


        // add
        public void vahicleAdd()
        {
            Console.Write("Car Owner Id : ");
            int ownerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vechicle Type : ");
            string type = Console.ReadLine();

            Console.Write("Plate Number : ");
            string number = Console.ReadLine();

        
            if(type == "Car" || type == "Bike" || type == "Picup")
            {
                //if(vahicleInfoManager.check(number) == 0)
                //{

                    VehicleInfo vahicleInfo = new VehicleInfo(ownerId, type, number);


                    vahicleInfoManager.add(vahicleInfo);
                //}
                //else
                //{
                //    Console.WriteLine("this car already Here");
                //}
            }
           

        }



        // delete

        public void vahicleDelete()
        {
            Console.Write("Enter Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            CarOwnerInfo carOwnerInfo = new CarOwnerInfo(Id);

            //carOwnerInfoManager.delete(carOwnerInfo.getId());
        }




        // update

        public void vahicleUpdate()
        {
            Console.Write("Enter Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            VehicleInfo vahicleInfo = new VehicleInfo(Id);

            vahicleInfoManager.update(vahicleInfo.getId());
        }




        // get all

        public void vahicleGetAll()
        {
            Console.WriteLine("------ Vahicle List -----");
            vahicleInfoManager.getAll();
        }
    }
}
