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
                string query = @"exec sp_ExitDateTime @EntryId , @Amount";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("EntryId", exitDateTime.getEntryId());
                cmd.Parameters.AddWithValue("Amount", exitDateTime.getAmount());

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


        //TimeSpan result = new TimeSpan();

        //int time =  - ;

       

        public double calculateAmount(int Id)
        {

            EntryDateTimeManager entryDateTimeManager = new EntryDateTimeManager();

            double cost = entryDateTimeManager.getTime(Id).TotalHours;

            if (entryDateTimeManager.getTime(Id).TotalHours > 1)
            {

                cost = entryDateTimeManager.getTime(Id).TotalHours * 50;
            }
            else
            {
                cost = 50;
            }

            return cost;

        }

        public void delete(int Id)
        {
            throw new NotImplementedException();
        }


       
        public List<ExitDateTime> getAll()
        {
            List<ExitDateTime> datalist = new List<ExitDateTime>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"select * from ExitDateTimeGetAll";

                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    int Id = Convert.ToInt32(reader["Id"]);
                    int entryId = Convert.ToInt32(reader["EntryId"]);
                    double amount = Convert.ToDouble(reader["Amount"]);

                    ExitDateTime exitDateTime = new ExitDateTime(Id, entryId, amount);

                    datalist.Add(exitDateTime);

                    Console.WriteLine($"{exitDateTime.getId()} {exitDateTime.getEntryId()} {exitDateTime.getAmount()}");
                }
            }

            return datalist;
        }

        public void update(int Id)
        {
            throw new NotImplementedException();
        }


        // full view 
        public List<DataFullView> fullView()
        {
            List<DataFullView> datalist = new List<DataFullView>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"exec sp_fullView ;";
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    DataFullView dataFullView = new DataFullView();

                    dataFullView.ParkingSlot = reader["ParkingSlot"] != DBNull.Value ? Convert.ToInt32(reader["ParkingSlot"]) : 0;
                    dataFullView.CarOwnerName = reader["CarOwnerName"] != DBNull.Value ? Convert.ToString(reader["CarOwnerName"]) : "Unknown";
                    dataFullView.Phone = reader["phone"] != DBNull.Value ? Convert.ToString(reader["phone"]) : "N/A";
                    dataFullView.VehicleType = reader["VechicleType"] != DBNull.Value ? Convert.ToString(reader["VechicleType"]) : "Unknown";
                    dataFullView.PlateNumber = reader["PlateNumber"] != DBNull.Value ? Convert.ToString(reader["PlateNumber"]) : "N/A";
                    dataFullView.EntryDateandTime = reader["EntryDateandTime"] != DBNull.Value ? Convert.ToDateTime(reader["EntryDateandTime"]) : DateTime.MinValue;
                    dataFullView.ExitDateandTime = reader["ExitDateandTime"] != DBNull.Value ? Convert.ToDateTime(reader["ExitDateandTime"]) : DateTime.MinValue;
                    dataFullView.ParkingSlot = reader["ParkingSlot"] != DBNull.Value ? Convert.ToInt32(reader["ParkingSlot"]) : 0;
                    dataFullView.Amount = reader["Amount"] != DBNull.Value ? Convert.ToDouble(reader["Amount"]) : 0.0;


                    datalist.Add(dataFullView);

                    Console.WriteLine();
                    Console.WriteLine($" ID: {dataFullView.Id}\n Owner: {dataFullView.CarOwnerName}\n Phone: {dataFullView.Phone}\n Type: {dataFullView.VehicleType}\n Plate: {dataFullView.PlateNumber}\n Entry: {dataFullView.EntryDateandTime}\n Exit: {dataFullView.ExitDateandTime}\n Slot: {dataFullView.ParkingSlot}\n Amount: {dataFullView.Amount}");
                    Console.WriteLine();
                }
            }

            return datalist;
        }



        // selected view 
        public List<DataFullView> selectView(int id)
        {
            List<DataFullView> datalist = new List<DataFullView>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"exec sp_selectView @Id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("Id", id);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DataFullView dataFullView = new DataFullView();

                    dataFullView.ParkingSlot = reader["ParkingSlot"] != DBNull.Value ? Convert.ToInt32(reader["ParkingSlot"]) : 0;
                    dataFullView.CarOwnerName = reader["CarOwnerName"] != DBNull.Value ? Convert.ToString(reader["CarOwnerName"]) : "Unknown";
                    dataFullView.Phone = reader["phone"] != DBNull.Value ? Convert.ToString(reader["phone"]) : "N/A";
                    dataFullView.VehicleType = reader["VechicleType"] != DBNull.Value ? Convert.ToString(reader["VechicleType"]) : "Unknown";
                    dataFullView.PlateNumber = reader["PlateNumber"] != DBNull.Value ? Convert.ToString(reader["PlateNumber"]) : "N/A";
                    dataFullView.EntryDateandTime = reader["EntryDateandTime"] != DBNull.Value ? Convert.ToDateTime(reader["EntryDateandTime"]) : DateTime.MinValue;
                    dataFullView.ExitDateandTime = reader["ExitDateandTime"] != DBNull.Value ? Convert.ToDateTime(reader["ExitDateandTime"]) : DateTime.MinValue;
                    dataFullView.ParkingSlot = reader["ParkingSlot"] != DBNull.Value ? Convert.ToInt32(reader["ParkingSlot"]) : 0;
                    dataFullView.Amount = reader["Amount"] != DBNull.Value ? Convert.ToDouble(reader["Amount"]) : 0.0;


                    datalist.Add(dataFullView);
                    Console.WriteLine();
                    Console.WriteLine($" ID: {dataFullView.Id}\n Owner: {dataFullView.CarOwnerName}\n Phone: {dataFullView.Phone}\n Type: {dataFullView.VehicleType}\n Plate: {dataFullView.PlateNumber}\n Entry: {dataFullView.EntryDateandTime}\n Exit: {dataFullView.ExitDateandTime}\n Slot: {dataFullView.ParkingSlot}\n Amount: {dataFullView.Amount}");
                    Console.WriteLine();
                }
            }

            return datalist;
        }






    }
}
