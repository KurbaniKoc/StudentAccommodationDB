using Obligatorisk_OPG.Model;
using System.Data.SqlClient;

namespace Obligatorisk_OPG.Services.TabelServices.RoomS
{
    public class SQL_Room
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = StudentAccommodationDB;";
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
                        room.Price = Convert.ToInt32(reader[2]);
                        roomList.Add(room);
                    }
                }
            }
            return roomList;
        }
    }
}
