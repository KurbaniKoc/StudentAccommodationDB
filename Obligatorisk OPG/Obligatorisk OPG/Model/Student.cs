namespace Obligatorisk_OPG.Model
{
    public class Student
    {
        public Student()
        {
        }

        public Student(int studentNo, string name, string adress)
        {
            StudentNo = studentNo;
            Name = name;
            Adress = adress;
        }

        public int StudentNo { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(StudentNo)}={StudentNo.ToString()}, {nameof(Name)}={Name}, {nameof(Adress)}={Adress}}}";
        }
    }
}
