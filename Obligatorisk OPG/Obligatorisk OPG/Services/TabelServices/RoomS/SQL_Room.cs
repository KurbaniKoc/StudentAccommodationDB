using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.ViewModels;
using System.Data.SqlClient;

namespace Obligatorisk_OPG.Services.TabelServices.RoomS
{
    public class SQL_Room
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAccommodation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static List<Room> GetAllRooms()
        {
            List<Room> roomList = new List<Room>();
            string query = "select * from Room";
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
                        room.DormitoryNo = Convert.ToInt32(reader[3]);
                        roomList.Add(room);
                    }
                }
            }
            return roomList;
        }

        public static List<Room_Dormitory> GetRoomDormitory(int rid)
        {
            List<Room_Dormitory> ListRoom_Dormitory = new List<Room_Dormitory>();
            string query = "Select * from Room where Room.Dormitory_No = @rid";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@rid", rid);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room_Dormitory room_Dormitory = new Room_Dormitory();
                            room_Dormitory.RoomNo = Convert.ToInt32(reader[0]);
                            room_Dormitory.Types = Convert.ToString(reader[1]);
                            room_Dormitory.Price = Convert.ToString(reader[2]);
                            room_Dormitory.DormitoryNo = Convert.ToInt32(reader[3]);
                            
                            ListRoom_Dormitory.Add(room_Dormitory);
                        }
                    }
                }
            }
            return ListRoom_Dormitory;
        }
    }
}
