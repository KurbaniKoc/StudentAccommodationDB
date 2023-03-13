using System.ComponentModel.DataAnnotations;

namespace Obligatorisk_OPG.Model
{
    public class Student
    {

        [Required]
        public int Student_No { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

    }
    

}


