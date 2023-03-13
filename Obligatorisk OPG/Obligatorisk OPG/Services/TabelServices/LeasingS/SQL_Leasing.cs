using Obligatorisk_OPG.Model;
using System.Data.SqlClient;


namespace Obligatorisk_OPG.Services.TabelServices.LeasingS
{
    public class SQL_Leasing
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = StudentAccommodationDB;";
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
                        leasing.StudentNo= Convert.ToInt32(reader[3]);
                        leasing.RoomNo= Convert.ToInt32(reader[4]);
                        leasing.DormitoryNumber= Convert.ToInt32(reader[5]);

                        listLeasing.Add(leasing);
                    }
                    return listLeasing;
                }
            }
        }

        //public static List<Actor_Movies> GetAllActorsAndTheirMovies()
        //{
        //    // prepare a list
        //    List<Actor_Movies> listActor_Movies = new List<Actor_Movies>();

        //    // define the sql query
        //    string query = "SELECT Actor.name, Actor.country, Movie.title, Movie.Year  from Movie, Actor WHERE Movie.actorid = Actor.Id";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand(query, connection);
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {

        //            while (reader.Read())
        //            {
        //                Actor_Movies actor_movie = new Actor_Movies();
        //                actor_movie.Name = Convert.ToString(reader[0]);
        //                actor_movie.Country = Convert.ToString(reader[1]);
        //                actor_movie.Title = Convert.ToString(reader[2]);
        //                actor_movie.Year = Convert.ToInt32(reader[3]);

        //                listActor_Movies.Add(actor_movie);
        //            }
        //            return listActor_Movies;
        //        }
        //    }
        //}

        //public static Actor GetActorById(int actorId)
        //{
        //    string query = $"SELECT * From Actor where Id=@aid";
        //    Actor actor = new Actor();
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@aid", actorId);
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read()) // while I am reading row by row
        //            {
        //                actor.Id = Convert.ToInt32(reader["Id"]);
        //                actor.Name = Convert.ToString(reader["Name"]);
        //                actor.Country = Convert.ToString(reader["Country"]);
        //                actor.Birth_year = Convert.ToDateTime(reader["Birth_year"]);
        //                actor.Alive = Convert.ToBoolean(reader["Alive"]);
        //            }
        //        }
        //    }
        //    return actor;
        //}
    }
}
