using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;

namespace Obligatorisk_OPG.Services.TabelServices.StudentS
{
    public class ADOStudentService : IStudentService
    {
        public IEnumerable<Student> GetAll()
        {
            return SQL_Student.GetAllStudents();
        }
        public void AddStudent(Student student)
        {
            SQL_Student.AddStudent(student);
        }

        public void DeleteStudent(Student student)
        {
            SQL_Student.DeleteStudent(student);
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

       
        //public IEnumerable<Student> GetStudents()
        //{
        //    return SQL_Student.GetAllStudents();
        //}
    }
}
