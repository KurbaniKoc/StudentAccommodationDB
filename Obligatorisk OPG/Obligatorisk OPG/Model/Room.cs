namespace Obligatorisk_OPG.Model
{
    public class Room
    {
        public Room()
        {
        }

        public Room(int roomNo, string types, string price)
        {
            RoomNo = roomNo;
            Types = types;
            Price = price;
        }

        public int RoomNo { get; set; }
        public string Types { get; set; }
        public string Price { get; set; }
        public int DormitoryNo { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(RoomNo)}={RoomNo.ToString()}, {nameof(Types)}={Types}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}
