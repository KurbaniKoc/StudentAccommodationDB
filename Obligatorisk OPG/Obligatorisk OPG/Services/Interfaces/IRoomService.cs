using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.ViewModels;

namespace Obligatorisk_OPG.Services.Interfaces
{
    public interface IRoomService
    {
        IEnumerable<Room> GetRooms();
        public IEnumerable<Room_Dormitory> GetRoom_Dormitory(int rid);
    }
}
