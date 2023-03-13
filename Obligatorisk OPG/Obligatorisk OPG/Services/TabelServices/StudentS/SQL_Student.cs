namespace Obligatorisk_OPG.Services.TabelServices.StudentS
{
    public class SQL_Student
    {
<<<<<<< Updated upstream
    }
=======
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAccommodation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static List<Student> listStudents;

        public static void AddStudent(Student student)
        {
            string query = $"INSERT into Student(Id,Name, Adress) Values(@Id, @Name, @Adress)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", student.Student_No);
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Country", student.Address);
                    int affectedRows = command.ExecuteNonQuery();
                }
            }
        }
        public static List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>();
            string query = "select * from Student";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.Student_No = Convert.ToInt32(reader[0]);
                        student.Name = Convert.ToString(reader[1]);
                        student.Address = Convert.ToString(reader[2]);
                        studentList.Add(student);
                    }
                }
            }
            return studentList;
        }
        public static List<Student> GetAllStudentsByAdress(string adress)
        {
            // prepare a list
            List<Student> listActor_Movies = new List<Student>();

            // define the sql query
            string query = "SELECT Student.name, Student.adress, Student WHERE Adress.id = Student.StudentNo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.Name = Convert.ToString(reader[0]);
                        student.Address = Convert.ToString(reader[1]);

                        listStudents.Add(student);
                    }
                    return listStudents;
                }
            }
        }

        public static Student GetStudentById(int studentId)
        {
            string query = $"SELECT * From Student where Id=@aid";
            Student student = new Student();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@aid", studentId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) // while I am reading row by row
                    {
                        student.Student_No = Convert.ToInt32(reader["Id"]);
                        student.Name = Convert.ToString(reader["Name"]);
                        student.Address = Convert.ToString(reader["Adress"]);
                    }
                }
            }
            return student;
        }
    } 
>>>>>>> Stashed changes
}
