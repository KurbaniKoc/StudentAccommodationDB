using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;

namespace Obligatorisk_OPG.Services.TabelServices.StudentS
{
    public class ADOStudentService : IStudentService
    {
        public void AddStudent(Student student)
        {
            SQL_Student.AddStudent(student);
        }

        public Student GetStudentById(int id)
        {
            return SQL_Student.GetStudentById(id);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return SQL_Student.GetAllStudents();
        }

        public IEnumerable<Student> GetStudentsByAdress(string adress)
        {
            return SQL_Student.GetAllStudentsByAdress(adress);
        }

        public IEnumerable<Student> GetStudents()
        {
            return SQL_Student.GetAllStudents();
        }
    }
}
