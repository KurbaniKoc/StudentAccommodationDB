using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;

namespace Obligatorisk_OPG.Services.TabelServices.StudentS
{
    public class StudentService : IStudentService
    {
        //public void AddStudent(Student student)
        //{
        //    SQL_Student.AddStudent(student);
        //}

        //public void DeleteStudent(Student student)
        //{
        //    SQL_Student.DeleteStudent(student);
        //}

        //public Student GetStudentByStudentNo(int studentNo)
        //{
        //    return SQL_Student.GetStudentByStudentNo(studentNo);
        //}

        public IEnumerable<Student> GetStudents()
        {
            return SQL_Student.GetAllStudents();
        }

        //public IEnumerable<Student> GetStudentsByName(string name)
        //{
        //    return SQL_Student.GetStudentsByName(name);
        //}

        //public IEnumerable<Student> GetStudentsByAdress(string adress)
        //{
        //    return SQL_Student.GetAllStudentsByAdress(adress);
        //}
    }
}

