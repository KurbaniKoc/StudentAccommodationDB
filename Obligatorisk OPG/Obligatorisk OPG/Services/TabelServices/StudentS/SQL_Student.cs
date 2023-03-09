using Obligatorisk_OPG.Model;
using System.Data.SqlClient;

namespace Obligatorisk_OPG.Services.TabelServices.StudentS
{
    public class SQL_Student
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MovieDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static void AddStudent(Student student)
        {
            string query = $"INSERT into Student(StudentNo,Name, Adress) Values(@StudentNo, @Name, @Adress)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", student.StudentNo);
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Country", student.Adress);
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
                        student.StudentNo = Convert.ToInt32(reader[0]);
                        student.Name = Convert.ToString(reader[1]);
                        student.Adress = Convert.ToString(reader[2]);
                        studentList.Add(student);
                    }
                }
            }
            return studentList;
        }
    }
}

    //    public static void DeleteStudent(Student student)
    //    {
    //        string query = $" DELETE from Student where StudentNo=@studentNo";
    //        using (SqlConnection connection = new SqlConnection(connectionString))
    //        {
    //            connection.Open();
    //            using (SqlCommand command = new SqlCommand(query, connection))
    //            {
    //                command.Parameters.AddWithValue("@studentNo", student.StudentNo);
    //                int affectedRows = command.ExecuteNonQuery();
    //            }
    //        }
    //    }

    //    public static List<Student> GetStudentsByName(string name)
    //    {
    //        // prepare a list
    //        List<Student> listStudents = new List<Student>();

    //        // define the sql query
    //        string query = $"select * from Student WHERE Name Like '{name}%' ";

    //        using (SqlConnection connection = new SqlConnection(connectionString))
    //        {
    //            connection.Open();
    //            SqlCommand command = new SqlCommand(query, connection);
    //            //command.Parameters.AddWithValue("@country", country);
    //            using (SqlDataReader reader = command.ExecuteReader())
    //            {

    //                while (reader.Read())
    //                {
    //                    StudentS student = new Student();
    //                    student.StudentNo = Convert.ToInt32(reader[0]);
    //                    student.Name = Convert.ToString(reader[1]);
    //                    student.Adress = Convert.ToString(reader[2]);
    //                    listStudents.Add(student);
    //                }
    //                return listStudents;
    //            }
    //        }
    //    }

    //    public static List<Student> GetAllStudentsAndTheirAdress()
    //    {
    //        // prepare a list
    //        List<Student> listActor_Movies = new List<Student>();

    //        // define the sql query
    //        string query = "SELECT Student.name, Student.adress, Student WHERE Adress.studentNo = Student.StudentNo";

    //        using (SqlConnection connection = new SqlConnection(connectionString))
    //        {
    //            connection.Open();
    //            SqlCommand command = new SqlCommand(query, connection);
    //            using (SqlDataReader reader = command.ExecuteReader())
    //            {

    //                while (reader.Read())
    //                {
    //                    Student student = new Student();
    //                    student.Name = Convert.ToString(reader[0]);
    //                    student.Adress = Convert.ToString(reader[1]);

    //                    listStudents.Add(student);
    //                }
    //                return listStudents;
    //            }
    //        }
    //    }
    //}


