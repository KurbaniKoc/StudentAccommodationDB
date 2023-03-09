namespace Obligatorisk_OPG.Model
{
    public class Room
    {
        public Room()
        {
        }

        public Room(int roomNo, string types, double price)
        {
            RoomNo = roomNo;
            Types = types;
            Price = price;
        }

        public int RoomNo { get; set; }
        public string Types { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(RoomNo)}={RoomNo.ToString()}, {nameof(Types)}={Types}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}
