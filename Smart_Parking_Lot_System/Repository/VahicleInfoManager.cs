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
    internal class VahicleInfoManager : DBHelper , IVahicleInfoRipository
    {
        

        public void add(VehicleInfo vahicleInfo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"insert into tbl_Vehicle(CarOwnerId , VechicleType, PlateNumber) values(@CarOwnerId,@VechicleType, @PlateNumber)";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("CarOwnerId", vahicleInfo.getCarOwnerId());
            cmd.Parameters.AddWithValue("VechicleType", vahicleInfo.getType());
            cmd.Parameters.AddWithValue("PlateNumber", vahicleInfo.getPlateNum());
            
            connection.Open();
            int n = cmd.ExecuteNonQuery();

            if (n > 0)
            {
                Console.WriteLine("Successful");
            }
            else
            {
                Console.WriteLine("Error");
            }


            connection.Close();
        }
    }

        public void delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<VehicleInfo> getAll()
        {
            throw new NotImplementedException();
        }

        public void update(int Id)
        {
            throw new NotImplementedException();
        }


    }
}