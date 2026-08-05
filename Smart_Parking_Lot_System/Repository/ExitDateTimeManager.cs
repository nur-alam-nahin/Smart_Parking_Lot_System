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
                string query = @"insert into tbl_ExitDateTime(EntryId , Amount) values(@EntryId , @Amount)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("EntryId", exitDateTime.getEntryId());
                cmd.Parameters.AddWithValue("Amount", exitDateTime.getAmount());

                connection.Open();

                int n = cmd.ExecuteNonQuery();

              
                connection.Close();
            }
        }


        //TimeSpan result = new TimeSpan();

        //int time =  - ;

       

        public double calculateAmount(int Id)
        {

            EntryDateTimeManager entryDateTimeManager = new EntryDateTimeManager();

            double cost = entryDateTimeManager.getTime(Id).TotalHours;

            //if(entryDateTimeManager.getTime(Id).TotalHours > 1)
            //{

            //    cost = entryDateTimeManager.getTime(Id).TotalHours * 50;
            //}
            //else
            //{
            //    cost = 50;
            //}
            
            return cost;

        }

        public void delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ExitDateTime> getAll()
        {
            throw new NotImplementedException();
        }

        public void update(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
