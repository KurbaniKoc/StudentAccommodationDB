namespace Obligatorisk_OPG.Model
{
    public class Dormitory
    {
        public Dormitory()
        {
        }

        public Dormitory(int dormitoryNo, string name, string adress)
        {
            DormitoryNo = dormitoryNo;
            Name = name;
            Adress = adress;
        }

        public int DormitoryNo { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(DormitoryNo)}={DormitoryNo.ToString()}, {nameof(Name)}={Name}, {nameof(Adress)}={Adress}}}";
        }
    }
}
