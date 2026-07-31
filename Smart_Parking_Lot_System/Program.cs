using Smart_Parking_Lot_System.Entities;
using Smart_Parking_Lot_System.Repository;
using Smart_Parking_Lot_System.SPL_UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System
{
    class Program
    {
        static void Main(string[] args)
        {




            SPLUI sp_UI = new SPLUI();


            sp_UI.ui();









            //DateTime time = DateTime.Now;


            //string vechicleType = "Car";
            //int plateNumber = 104;
            //string entryTime = time.ToString("h:mm:ss");
            //double rentCost = 500;


            //Console.WriteLine(entryTime);
            //using (SqlConnection connection = new SqlConnection(connnectionString))
            //{
            //    string query = @"insert into tbl_Vehicle(VechicleType,PlateNumber) values(@VechicleType,@PlateNumber)";

            //    SqlCommand cmd = new SqlCommand(query, connection);

            //    cmd.Parameters.AddWithValue("VechicleType", vechicleType);
            //    cmd.Parameters.AddWithValue("PlateNumber", plateNumber);
            //    //cmd.Parameters.AddWithValue("EntryTime", entryTime);
            //    //cmd.Parameters.AddWithValue("RentCost", rentCost);


            //    connection.Open();

            //    int n = cmd.ExecuteNonQuery();

            //    if (n > 0)
            //    {
            //        Console.Write("Successfull");
            //    }
            //    else
            //    {
            //        Console.Write("error");
            //    }


            //    connection.Close();

            //}

            //DateTime dateTime = new DateTime();

            //Console.WriteLine(time.Date);


            //Console.ReadKey();


            //DateTime date1 = DateTime.Now;
            //string datestring = date1.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            //Console.WriteLine(datestring);



            ////Console.WriteLine(twentyFourHourFormat);


            Console.ReadKey();
        }
    }
}
