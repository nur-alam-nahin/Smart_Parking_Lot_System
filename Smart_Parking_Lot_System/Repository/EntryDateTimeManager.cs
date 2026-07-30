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
                string query = @"insert into tbl_EntryDateTime(VehicleId, EntryDate , EntryTime) values(@VehicleId, @EntryDate , @EntryTime)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("VehicleId", entryDateTime.getVehicleId());
                cmd.Parameters.AddWithValue("EntryDate", entryDateTime.getEntryDate());
                cmd.Parameters.AddWithValue("EntryTime", entryDateTime.getEntryTime());

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

        public void getAll(VahicleInfo vahicleInfo)
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
