namespace Obligatorisk_OPG.Model
{
    public class Dormitory
    {
        public Dormitory()
        {
        }

        public Dormitory(int dormitoryNo, string name, string adress)
        {
            Dormitory_No = dormitoryNo;
            Name = name;
            Address = adress;
        }

        public int Dormitory_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Dormitory_No)}={Dormitory_No.ToString()}, {nameof(Name)}={Name}, {nameof(Address)}={Address}}}";
        }
    }
}
