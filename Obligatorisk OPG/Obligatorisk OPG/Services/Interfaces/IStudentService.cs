using Obligatorisk_OPG.Model;

namespace Obligatorisk_OPG.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable <Student> GetAllStudents();
        void AddStudent(Student student);
        //IEnumerable<Student> GetStudentsByAdress(string adress);
    }
}

