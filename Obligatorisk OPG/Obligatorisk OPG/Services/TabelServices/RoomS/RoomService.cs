using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.ViewModels;

namespace Obligatorisk_OPG.Services.TabelServices.RoomS
{
    public class RoomService:IRoomService
    {
        public IEnumerable<Room> GetRooms()
        {
            return SQL_Room.GetAllRooms();
        }

        public IEnumerable<Room_Dormitory> GetRoom_Dormitory(int id) 
        {
            return SQL_Room.GetRoomDormitory(id);
        }
    }
}
