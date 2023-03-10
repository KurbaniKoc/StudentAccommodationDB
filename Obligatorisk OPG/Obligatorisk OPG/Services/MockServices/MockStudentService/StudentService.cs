using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;

namespace Obligatorisk_OPG.Services.MockServices.MockStudentService
{
    public class StudentService : IStudentService
    {

        private List<Student> students;

        public StudentService()
        {
            students = StudentCatalog.GetMockStudents();

        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public IEnumerable<Student> GetMockStudents()
        {
            return students;
        }

        public IEnumerable<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(Student student) 
        { 
            students.Add(student);
        }

        IEnumerable<Student> IStudentService.GetAllStudents()
        {
            return students;
        }

        //public IEnumerable<Student> GetStudentsByAdress(string adress)
        //{
        //    return students;
        //}

        //public IEnumerable<Student> GetStudentsByAdress(string adress)
        //{
        //    List<Student> lst = new List<Student>();
        //    foreach (var a in students)
        //    {
        //        if(a.Adress==adress)
        //            lst.Add(a);
        //       return lst;
        //    }
        //}


        //public void AddStudent(Student student)
        //{
        //    students.Add(student);
        //}
        //public IEnumerable<Student> GetStudents()
        //{
        //    return students;
        //}
        //public Student GetStudentById(int studentNo)
        //{
        //    foreach (var student in students)
        //    {
        //        if (student.StudentNo == studentNo)
        //            return student;
        //    }

        //    return null;
        //}

        //public void DeleteStudent(Student student)
        //{
        //    foreach (var a in students)
        //    {
        //        if (a.StudentNo == student.StudentNo)
        //        {
        //            students.Remove(a);
        //            break;
        //        }
        //    }
        //}

        //public IEnumerable<Student> GetStudentsByName(string name)
        //{
        //    List<Student> lst = new List<Student>();
        //    foreach (var a in students)
        //    {
        //        if (a.Country == country)
        //            lst.Add(a);
        //    }
        //    return lst;
        //}

        //public IEnumerable<Actor_Movies> GetActor_Movies()
        //{
        //    throw new NotImplementedException();
        //}


        //public IEnumerable<Sale> GetSalesByCustomer(int id)
        //{
        //    return adonetSaleService.GetSalesByCustomer(id).ToList();
        //}



        //public void DeleteSale(Sale sale)
        //{

        //    adonetSaleService.DeleteSale(sale);
        //}

        //public IEnumerable<Sale> GetSalesByAmount(int maxPrice, int minPrice = 0)
        //{
        //    return adonetSaleService.FilterSales(maxPrice);
        //}
    }
}

