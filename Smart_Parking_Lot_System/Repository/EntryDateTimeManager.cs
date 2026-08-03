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
        public void add(EntryDateTime entryDateTime)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"insert into tbl_EntryDateTime(VehicleId, OwnerId , ParkingSlot) values(@VehicleId, @OwnerId , @ParkingSlot)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("VehicleId", entryDateTime.getVehicleId());
                cmd.Parameters.AddWithValue("OwnerId", entryDateTime.getownerId());
                //cmd.Parameters.AddWithValue("EntryDateTime", entryDateTime.getEntryDateAndTime());
                cmd.Parameters.AddWithValue("ParkingSlot", entryDateTime.getparkingSlot());

                connection.Open();

                int n = cmd.ExecuteNonQuery();

                if(n > 0)
                {
                    Console.WriteLine("successful");
                }
                connection.Close();
            }
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public List<EntryDateTime> getAll()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
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
