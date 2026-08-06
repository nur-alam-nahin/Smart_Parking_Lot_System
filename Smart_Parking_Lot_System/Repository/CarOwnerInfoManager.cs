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

        public void delete(int Id)
        {
            CarOwnerInfo carOwnerInfo = new CarOwnerInfo(Id); 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"exec sp_carOwnerDeleteInfo @Id;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Id", carOwnerInfo.getName());
               

                connection.Open();

                int n = cmd.ExecuteNonQuery();

                if (n > 0)
                {
                    Console.WriteLine("successful");
                }
                connection.Close();
            }
        }



        public List<CarOwnerInfo> getAll()
        {
            List<CarOwnerInfo> datalist = new List<CarOwnerInfo>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"select * from CarOwnerInfoGetAll";

                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    string CarOwnerName = Convert.ToString(reader["CarOwnerName"]);
                    string Phone = Convert.ToString(reader["phone"]);
                    string Email = Convert.ToString(reader["Email"]);
                    string CarOwnerAddress = Convert.ToString(reader["CarOwnerAddress"]);

                    CarOwnerInfo carOwnerInfo = new CarOwnerInfo(Id, CarOwnerName, Phone, Email, CarOwnerAddress);

                    datalist.Add(carOwnerInfo);
                    Console.WriteLine($"{carOwnerInfo.getId()} {carOwnerInfo.getName()} {carOwnerInfo.getPhone()} {carOwnerInfo.getEmail()} {carOwnerInfo.getAddress()}");
                }
            }

            return datalist;
        }




        public void update(int Id)
        {



            Console.Write("Name = ");
            string name = Console.ReadLine();

            Console.Write("Phone = ");
            string phone = Console.ReadLine();

            Console.Write("Email = ");
            string email = Console.ReadLine();

            Console.Write("Address = ");
            string address = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"exec sp_carOwnerUpdate @Id, @CarOwnerName, @phone, @Email, @CarOwnerAddress;";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("Id", Id);
                cmd.Parameters.AddWithValue("CarOwnerName", name);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("CarOwnerAddress", address);

                connection.Open();

                int n = cmd.ExecuteNonQuery();

                if(n > 0)
                {
                    Console.WriteLine("successful");
                }

                connection.Close();
            }
        }
    }
}
