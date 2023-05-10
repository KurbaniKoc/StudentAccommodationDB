using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.ViewModels;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace Obligatorisk_OPG.Services.TabelServices.LeasingS
{
    public class SQL_Leasing
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAccommodation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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

        public static List<Leasing_Room> GetLeasingRoom(int lid)
        {
            List<Leasing_Room> ListLeasing_Room = new List<Leasing_Room>();
            string query = "Select * from Leasing where Leasing.Student_No= @lid"; //Ændre
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@lid", lid);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Leasing_Room leasing_Room = new Leasing_Room();
                            leasing_Room.LeasingNo = Convert.ToInt32(reader[0]);
                            leasing_Room.StudentNo = Convert.ToInt32(reader[3]);
                            leasing_Room.RoomNo = Convert.ToInt32(reader[4]);
                            

                            ListLeasing_Room.Add(leasing_Room);
                        }
                    }
                }
            }
            return ListLeasing_Room;
        }

        public static bool LeasingExists(int leasingNo)
        {
            string query = $"SELECT COUNT(*) FROM Leasing WHERE Leasing_No = {leasingNo}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static List<Room> GetAllAvailableRooms()
        {
            List<Room> roomList = new List<Room>();
            string query = "SELECT Room.Room_No, Room.Types, Room.Price FROM Leasing RIGHT JOIN Room \r\nON Leasing.Room_No = Room.Room_No WHERE Leasing.Room_No IS NULL;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room room = new Room();
                        room.RoomNo = Convert.ToInt32(reader[0]);
                        room.Types = Convert.ToString(reader[1]);
                        room.Price = Convert.ToString(reader[2]);
                        roomList.Add(room);
                    }
                }
            }
            return roomList;
        }
    }
}
