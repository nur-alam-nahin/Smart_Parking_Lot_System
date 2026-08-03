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
    internal class CarOwnerInfoManager : DBHelper, ICarOwnerInfoRepository
    {
        public void add(CarOwnerInfo carOwnerInfo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"exec sp_carOwner @CarOwnerName , @phone , @Email, @CarOwnerAddress;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("CarOwnerName", carOwnerInfo.getName());
                cmd.Parameters.AddWithValue("phone", carOwnerInfo.getPhone());
                cmd.Parameters.AddWithValue("Email", carOwnerInfo.getEmail());
                cmd.Parameters.AddWithValue("CarOwnerAddress", carOwnerInfo.getAddress());

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

        public List<CarOwnerInfo> getAll()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
