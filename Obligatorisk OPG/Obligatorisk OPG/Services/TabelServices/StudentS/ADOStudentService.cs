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

        public IEnumerable<Student> GetAllStudents()
        {
            return SQL_Student.GetAllStudents();
        }

        //public IEnumerable<Student> GetStudentsByAdress(string adress)
        //{
        //    return SQL_Student.GetAllStudents();
        //}


        //public IEnumerable<Student> GetStudents()
        //{
        //    return SQL_Student.GetAllStudents();
        //}

        //List<Student> IStudentService.GetAllStudents()
        //{
        //    return SQL_Student.GetAllStudents();
        //}

        //IEnumerable<Student> IStudentService.NameSearch(string name)
        //{
        //    return SQL_Student.GetAllStudents();
        //}
    }
}
