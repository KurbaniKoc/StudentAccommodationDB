﻿using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.ViewModels;
using System.Data.SqlClient;


namespace Obligatorisk_OPG.Services.TabelServices.LeasingS
{
    public class SQL_Leasing
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = StudentAccommodationDB;";
        public static void AddLeasing(Leasing leasing)
        {
            string query = $"INSERT into Leasing(Leasing_No, Date_From, Date_To, Student_No, Room_No, Dormitory_Number) Values(@Leasing_No, @Date_From, @Date_To, @Student_No, @Room_No, @Dormitory_Number)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Leasing_No", leasing.LeasingNo);
                    command.Parameters.AddWithValue("@Date_From", leasing.DateFrom);
                    command.Parameters.AddWithValue("@Date_To", leasing.DateTo);
                    command.Parameters.AddWithValue("@Student_No", leasing.StudentNo);
                    command.Parameters.AddWithValue("@Room_No", leasing.RoomNo);
                    command.Parameters.AddWithValue("@Dormitory_Number", leasing.DormitoryNumber);


                    int affectedRows = command.ExecuteNonQuery();
                }
            }
            
        }
        public static List<Leasing> GetAllLeasings()
        {
            List<Leasing> LeasingList = new List<Leasing>();
            string query = "select * from Leasing";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Leasing leasing = new Leasing();
                        leasing.LeasingNo = Convert.ToInt32(reader[0]);
                        leasing.DateFrom = Convert.ToDateTime(reader[1]);
                        leasing.DateTo = Convert.ToDateTime(reader[2]);
                        leasing.StudentNo = Convert.ToInt32(reader[3]);
                        leasing.RoomNo = Convert.ToInt32(reader[4]);
                        leasing.DormitoryNumber = Convert.ToInt32(reader[5]);
                        LeasingList.Add(leasing);
                    }
                }
            }
            return LeasingList;
        }

        public static List<Leasing> GetLeasingByLeasingNo(int leasingNo)
        {
            List<Leasing> listLeasing = new List<Leasing>();

            string query = $"select * from Leasing WHERE Leasing_No Like '{leasingNo}%' ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Leasing leasing = new Leasing();
                        leasing.LeasingNo = Convert.ToInt32(reader[0]);
                        leasing.DateFrom = Convert.ToDateTime(reader[1]);
                        leasing.DateTo = Convert.ToDateTime(reader[2]);
                        leasing.StudentNo= Convert.ToInt32(reader[3]);
                        leasing.RoomNo= Convert.ToInt32(reader[4]);
                        leasing.DormitoryNumber= Convert.ToInt32(reader[5]);

                        listLeasing.Add(leasing);
                    }
                    return listLeasing;
                }
            }
        }

        public static List<Leasing_Student> GetLeasingStudent(int id)
        {
            List<Leasing_Student> ListLeasing_Student = new List<Leasing_Student>();
            string query = "Select * from Leasing where Leasing.Student_No = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Leasing_Student leasing_Student = new Leasing_Student();
                            leasing_Student.LeasingNo = Convert.ToInt32(reader[0]);
                            leasing_Student.DateFrom = Convert.ToDateTime(reader[1]);
                            leasing_Student.DateTo = Convert.ToDateTime(reader[2]);
                            leasing_Student.StudentNo = Convert.ToInt32(reader[3]);
                            leasing_Student.RoomNo = Convert.ToInt32(reader[4]);
                            leasing_Student.DormitoryNumber = Convert.ToInt32(reader[5]);

                            ListLeasing_Student.Add(leasing_Student);
                        }
                    }
                }
            }
            return ListLeasing_Student;
        }
    }
}
