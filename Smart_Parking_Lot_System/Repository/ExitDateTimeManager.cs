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
    internal class ExitDateTimeManager : DBHelper, IExitDateTimeRepositroy
    {
        public void add(ExitDateTime exitDateTime)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"insert into tbl_ExitDateTime(VehicleId, EntryId , ExitDate , ExitTime , Amount) values(@VehicleId, @EntryId , @ExitDate , @ExitTime , @Amount)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("VehicleId", exitDateTime.getvehicleId());
                cmd.Parameters.AddWithValue("EntryId", exitDateTime.getEntryId());
                cmd.Parameters.AddWithValue("ExitDate", exitDateTime.getExitDate());
                cmd.Parameters.AddWithValue("ExitTime", exitDateTime.getExitTime());
                cmd.Parameters.AddWithValue("Amount", exitDateTime.getAmount());

                connection.Open();

                int n = cmd.ExecuteNonQuery();

                if (n > 0)
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

        public void getAll(ExitDateTime exitDateTime)
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
