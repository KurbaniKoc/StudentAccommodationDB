using Obligatorisk_OPG.Model;
using System.Data.SqlClient;


namespace Obligatorisk_OPG.Services.TabelServices.LeasingS
{
    public class SQL_Leasing
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAccommodation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //public static void AddLeasing(Leasing leasing)
        //{
        //    string query = $"INSERT into Leasing(LeasingNo, DateFrom, DateTo, StudentNo, RoomNo, DormitoryNumber) Values(@Leasing_No, @Date_From, @Date_to, @Student_No, @Room_No, @Dormitory_Number)";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@Leasing_No", leasing.LeasingNo);
        //            command.Parameters.AddWithValue("@Date_From", leasing.DateFrom);
        //            command.Parameters.AddWithValue("@Date_To", leasing.DateTo);
        //            command.Parameters.AddWithValue("@Student_No", leasing)

        //            int affectedRows = command.ExecuteNonQuery();
        //        }
        //    }
        //}
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
                        room.Price = Convert.ToInt32(reader[2]);
                        roomList.Add(room);
                    }
                }
            }
            return roomList;
        }

        //public static void DeleteLeasing(Leasing leasing)
        //{
        //    string query = $" DELETE from Leasing where LeasingNO=@Leasing_No";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@Leasing_No", leasing.LeasingNo);
        //            int affectedRows = command.ExecuteNonQuery();
        //        }
        //    }
        //}

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
                        leasing.StudentNo = Convert.ToInt32(reader[3]);
                        leasing.RoomNo = Convert.ToInt32(reader[4]);
                        leasing.DormitoryNumber = Convert.ToInt32(reader[5]);

                        listLeasing.Add(leasing);
                    }
                    return listLeasing;
                }
            }
        }


        public static Room GetRoomByNumber(int roomNo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM Room WHERE Room_No = {roomNo}";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Room room = new Room();
                            room.RoomNo = Convert.ToInt32(reader[0]);
                            room.Types = Convert.ToString(reader[1]);
                            room.Price = Convert.ToInt32(reader[2]);
                            return room;
                        }
                        else
                        {
                            return null; // Room not found
                        }
                    }
                }
            }
        }


            //public static void UpdateLeasing(Leasing leasing)
            //{
            //    string query = $"UPDATE Leasing SET DateFrom=@Date_From, DateTo=@Date_to, StudentNo=@Student_No, RoomNo=@Room_No, DormitoryNumber=@Dormitory_Number WHERE LeasingNo=@Leasing_No";
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();
            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            command.Parameters.AddWithValue("@Date_From", leasing.DateFrom);
            //            command.Parameters.AddWithValue("@Date_To", leasing.DateTo);
            //            command.Parameters.AddWithValue("@Student_No", leasing.StudentNo);
            //            command.Parameters.AddWithValue("@Room_No", leasing.RoomNo);
            //            command.Parameters.AddWithValue("@Dormitory_Number", leasing.DormitoryNumber);
            //            command.Parameters.AddWithValue("@Leasing_No", leasing.LeasingNo);

            //            int affectedRows = command.ExecuteNonQuery();
            //        }
            //    }
            //}

            //public static void UpdateRoom(Room room)
            //{
            //    string query = $"UPDATE Room SET Types=@Types, Price=@Price WHERE Room_No=@Room_No";
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();
            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            command.Parameters.AddWithValue("@Types", room.Types);
            //            command.Parameters.AddWithValue("@Price", room.Price);
            //            command.Parameters.AddWithValue("@Room_No", room.RoomNo);

            //            int affectedRows = command.ExecuteNonQuery();
            //        }
            //    }
            //}



        }
    }



