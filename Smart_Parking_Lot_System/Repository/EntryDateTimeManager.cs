using Smart_Parking_Lot_System.Entities;
using Smart_Parking_Lot_System.Repository.DatabaseHelper;
using Smart_Parking_Lot_System.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.Repository
{
    internal class EntryDateTimeManager : DBHelper, IEntryDateTimeRepository
    {

        // data insert 
        public void add(EntryDateTime entryDateTime)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"exec sp_EntryDateTime @VehicleId , @OwnerId , @ParkingSlot;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("VehicleId", entryDateTime.getVehicleId());
                cmd.Parameters.AddWithValue("OwnerId", entryDateTime.getownerId());
                //cmd.Parameters.AddWithValue("EntryDateTime", entryDateTime.getEntryDateAndTime());
                cmd.Parameters.AddWithValue("ParkingSlot", entryDateTime.getparkingSlot());


                try
                {
                    connection.Open();
                    int n = cmd.ExecuteNonQuery();

                    if (n > 0)
                    {
                        Console.WriteLine("Successful");
                    }

                    connection.Close();
                }
                catch (SqlException)
                {
                    Console.WriteLine("try again");

                }
            }
        }

        public void delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<EntryDateTime> getAll()
        {
            List<EntryDateTime> datalist = new List<EntryDateTime>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"select * from EntryDateTimeGetAll";

                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    int vehicleId = Convert.ToInt32(reader["VehicleId"]);
                    int OwnerId = Convert.ToInt32(reader["OwnerId"]);
                    DateTime entryDateandTime = Convert.ToDateTime(reader["EntryDateandTime"]);
                    DateTime exitDateandTime = reader["ExitDateandTime"] != DBNull.Value ? Convert.ToDateTime(reader["ExitDateandTime"]) : DateTime.Now;
                    int parkingSlot = Convert.ToInt32(reader["ParkingSlot"]);


                    EntryDateTime entryDateTime = new EntryDateTime(Id, vehicleId, OwnerId, entryDateandTime , exitDateandTime , parkingSlot);
                    datalist.Add(entryDateTime);

                    Console.WriteLine($"{entryDateTime.getId()} {entryDateTime.getVehicleId()} {entryDateTime.getownerId()} {entryDateTime.getEntryDateAndTime()} {entryDateTime.getexitDateAndTime()} {entryDateTime.getparkingSlot()}");
                }
            }

            return datalist;
        }




        public void update(int Id)
        {

            Console.Write("Vehicle Id = ");
            int vehicleId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Owner id = ");
            int OwnerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entry Date and Time = ");
            DateTime entryDateandTime = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Exit Date and Time = ");
            DateTime exitDateandTime = Convert.ToDateTime(Console.ReadLine());

            Console.Write("ParkingSlot = ");
            int parkingSlot = Convert.ToInt32(Console.ReadLine());




            Console.Write("PlateNumber = ");
            string number = Console.ReadLine();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"exec sp_EntryDateTimeUpdate @VehicleId , @OwnerId , @EntryDateandTime , @ExitDateandTime , @ParkingSlot;";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Id", Id);
                cmd.Parameters.AddWithValue("VehicleId", vehicleId);
                cmd.Parameters.AddWithValue("OwnerId", OwnerId);
                cmd.Parameters.AddWithValue("EntryDateandTime", entryDateandTime);
                cmd.Parameters.AddWithValue("ExitDateandTime", exitDateandTime);
                cmd.Parameters.AddWithValue("ParkingSlot", parkingSlot);




                try
                {
                    connection.Open();
                    int n = cmd.ExecuteNonQuery();

                    if (n > 0)
                    {
                        Console.WriteLine("Successful");
                    }

                    connection.Close();
                }
                catch (SqlException)
                {
                    Console.WriteLine("try again");

                }

            }
        }





        public int parkingSoltCheck()
        {
            //List<EntryDateTime> slotCheck = new List<EntryDateTime>();

            int count = 1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from tbl_EntryDateTime";

                SqlCommand cmd = new SqlCommand(query,connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();


               
                while(reader.Read())
                {
                    int slot = Convert.ToInt32(reader["ParkingSlot"]);

                    if(slot != count)
                    {
                        count = slot;
                    }
                    
                  
                    count++;
                }


            }

            return count;
        }


        public void exitTimeUp(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"update tbl_EntryDateTime set ExitDateandTime = GETDate() where Id = @Id";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("Id", Id);

                connection.Open();

                cmd.ExecuteNonQuery();

                connection.Close();
             

            }
        }


        public TimeSpan getTime(int Id)
        {

            
            TimeSpan result = new TimeSpan();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"select EntryDateandTime , ExitDateandTime from  tbl_EntryDateTime  where Id = @Id";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("Id", Id);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    DateTime entry = Convert.ToDateTime(reader["EntryDateandTime"]);
                    DateTime exit = Convert.ToDateTime(reader["ExitDateandTime"]);

                    EntryDateTime entryDateTime = new EntryDateTime(entry, exit);
                    result = exit - entry;
                }


            }

            return result;
        }

    }
}
