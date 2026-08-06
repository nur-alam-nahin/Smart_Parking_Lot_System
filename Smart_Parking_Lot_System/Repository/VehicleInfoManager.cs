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
    internal class VehicleInfoManager : DBHelper , IVahicleInfoRipository
    {
        

        public void add(VehicleInfo vahicleInfo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"exec sp_Vehicle @CarOwnerId , @VechicleType , @PlateNumber;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("CarOwnerId", vahicleInfo.getCarOwnerId());
            cmd.Parameters.AddWithValue("VechicleType", vahicleInfo.getType());
            cmd.Parameters.AddWithValue("PlateNumber", vahicleInfo.getPlateNum());
            
         


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
                catch(SqlException )
                {
                    Console.WriteLine("try again");

                }
            }
        }

        public void delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<VehicleInfo> getAll()
        {
            List<VehicleInfo> datalist = new List<VehicleInfo>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"select * from VehicleGetAll";

                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    int carOwnerId = Convert.ToInt32(reader["CarOwnerId"]);
                    string vechicleType = Convert.ToString(reader["VechicleType"]);
                    string plateNumber = Convert.ToString(reader["PlateNumber"]);

                    VehicleInfo vehicleInfo = new VehicleInfo(Id, carOwnerId, vechicleType, plateNumber);
                    datalist.Add(vehicleInfo);

                    Console.WriteLine($"{vehicleInfo.getId()} {vehicleInfo.getCarOwnerId()} {vehicleInfo.getType()} {vehicleInfo.getPlateNum()}");
                }
            }

            return datalist;
        }

        public void update(int Id)
        {
            

            Console.Write("Owner Id = ");
            int ownerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vehicle Type = ");
            string type = Console.ReadLine();

            Console.Write("PlateNumber = ");
            string number = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"exec sp_carOwnerUpdate @Id  , @CarOwnerId , @VechicleType , @PlateNumber;";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Id", Id);
                cmd.Parameters.AddWithValue("CarOwnerId", ownerId);
                cmd.Parameters.AddWithValue("VechicleType", type);
                cmd.Parameters.AddWithValue("PlateNumber", number);




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


    

    }
}