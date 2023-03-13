using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Obligatorisk_OPG.Model;

namespace Obligatorisk_OPG.Services.TabelServices.DormitroyS

{
    public class SQL_Dormitory
    {
        static string connectionString =@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = StudentAccommodationDB";
        public static List<Dormitory> GetAllDormitories()
        {
            List<Dormitory> dormitoryList = new List<Dormitory>();
            string query = "select * from Dormitory";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dormitory dormitory = new Dormitory();
                        dormitory.Dormitory_No = Convert.ToInt32(reader[0]);
                        dormitory.Name = Convert.ToString(reader[1]);
                        dormitory.Address = Convert.ToString(reader[2]);
                        dormitoryList.Add(dormitory);
                    }
                }
            }
            return dormitoryList;
        }
    }
}
