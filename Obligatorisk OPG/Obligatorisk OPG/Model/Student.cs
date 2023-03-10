using System.ComponentModel.DataAnnotations;

namespace Obligatorisk_OPG.Model
{
    public class Student
    {

        [Required]
        public int StudentNo { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Adress { get; set; }

        List<Student> students = new List<Student>();

    }
    

}


