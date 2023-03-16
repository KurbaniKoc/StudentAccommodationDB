using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.TabelServices.StudentS;

namespace Obligatorisk_OPG.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable <Student> GetAllStudents();
        void AddStudent(Student student);
        IEnumerable<Student> GetStudentsByAdress(string adress);
        public Student GetStudentById(int sid);

        IEnumerable<Student> GetAll();

        public void DeleteStudent(Student student);


        //IEnumerable<Student> GetStudents();
    }
}

