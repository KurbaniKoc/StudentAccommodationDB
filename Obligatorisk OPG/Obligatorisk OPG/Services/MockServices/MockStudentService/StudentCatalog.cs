using Obligatorisk_OPG.Model;

namespace Obligatorisk_OPG.Services.MockServices.MockStudentService
{
    public class StudentCatalog
    {
        static List<Student> students = new List<Student>()
        {
            new Student() { StudentNo = 1, Name = "name", Adress = "USA"},
            new Student() { StudentNo = 2, Name = "Chow-Yun fat", Adress = "HK"},
           new Student() { StudentNo = 3, Name = "Karl Steger", Adress = "Denmark"},
            new Student() { StudentNo = 4, Name = "Jean Reno", Adress = "France"},
            new Student() { StudentNo = 5, Name = "Julia", Adress = "USA"},
            new Student() { StudentNo = 6, Name = "Marc Duret", Adress = "France"}
        };
        public static List<Student> GetMockStudents()
        {
            return students;
        }
    }
}

