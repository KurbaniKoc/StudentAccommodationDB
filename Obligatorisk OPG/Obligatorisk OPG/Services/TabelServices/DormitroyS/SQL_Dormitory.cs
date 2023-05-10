using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.ViewModels;

namespace Obligatorisk_OPG.Services.TabelServices.DormitroyS

{
    public class SQL_Dormitory
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAccommodation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
        public static List<Room_Student> GetRoomsAndStudents(int did)
        {
            List<Room_Student> ListRoomStudent = new List<Room_Student>();
            string query = "select Leasing.Dormitory_Number, Leasing.Student_No, Leasing.Room_No, Student.Name" +
                " From Leasing" +
                " join Dormitory" +
                " on Leasing.Dormitory_Number = Dormitory.Dormitory_No" +
                " join Student" +
                " on Leasing.Student_No = Student.Student_No" +
                " Where @did = Leasing.Dormitory_Number"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@did", did);
                    using (SqlDataReader reader = command.ExecuteReader())
                        
                    {
                        while (reader.Read())
                        {
                            Room_Student room_Student = new Room_Student();
                            room_Student.StudentNo = Convert.ToInt32(reader[0]);
                            room_Student.RoomNo = Convert.ToInt32(reader[1]);
                            room_Student.DormitoryNo = Convert.ToInt32(reader[2]);
                            room_Student.StudentName = Convert.ToString(reader[3]);
                            
                            ListRoomStudent.Add(room_Student);
                        }
                    }
                }
            }
            return ListRoomStudent;
        }

        public static int GetDormitoryNoByRoomNo(int roomNo)
        {
            int dormitoryNo = 0;
            string query = "select Dormitory_No from Room where Room_No = @Room_No";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Room_No", roomNo);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dormitoryNo = Convert.ToInt32(reader[0]);
                    }
                }
            }
            return dormitoryNo;
        }
    }
}
