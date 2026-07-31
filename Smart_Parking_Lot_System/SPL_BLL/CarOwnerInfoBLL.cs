using Smart_Parking_Lot_System.Entities;
using Smart_Parking_Lot_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.SPL_BLL
{
    public class CarOwnerInfoBLL
    {

        //CarOwnerInfo carOwnerInfo = new CarOwnerInfo("nahin", "234523", "nahin@gmail.com", "Dhaka");

        CarOwnerInfoManager carOwnerInfoManager = new CarOwnerInfoManager();


        // add
        public void carOwnerAdd()
        {
            Console.Write("Car Owner Name : ");
            string name = Console.ReadLine();

            Console.Write("Phone : ");
            string phone = Console.ReadLine();

            Console.Write("Email : ");
            string email = Console.ReadLine();

            Console.Write("Address : ");
            string address = Console.ReadLine();

            CarOwnerInfo carOwnerInfo = new CarOwnerInfo(name, phone, email, address);


            carOwnerInfoManager.add(carOwnerInfo);
        }



        // delete

        public void carOwnerDelete()
        {
            Console.Write("Enter Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            CarOwnerInfo carOwnerInfo = new CarOwnerInfo(Id);

            //carOwnerInfoManager.delete(carOwnerInfo.getId());
        }




        // update

        public void carOwnerUpdate()
        {
            Console.Write("Enter Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            //Books books = new Books(Id);

            //bookManager.Delete(books.getId());
        }




        // get all

        public void carOwnerGetAll()
        {
            Console.WriteLine("------ Car Owner List -----");
            //bookManager.GetAll();
        }

    }
}
