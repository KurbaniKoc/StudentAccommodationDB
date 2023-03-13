using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;

namespace Obligatorisk_OPG.Services.TabelServices.RoomS
{
    public class RoomService:IRoomService
    {
        public IEnumerable<Room> GetRooms()
        {
            return SQL_Room.GetAllRooms();
        }
    }
}
