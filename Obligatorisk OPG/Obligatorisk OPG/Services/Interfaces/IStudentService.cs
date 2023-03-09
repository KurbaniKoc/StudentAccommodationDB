using Obligatorisk_OPG.Model;

namespace Obligatorisk_OPG.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        //void AddStudent(Student student);
        //IEnumerable<Student> GetStudentsByName(string name);
        //IEnumerable<Student> GetStudentsByAdress(string adress);
        //public Student GetStudentByStudentNo(int studentNo);
        //public void DeleteStudent(Student student);

    }
}

