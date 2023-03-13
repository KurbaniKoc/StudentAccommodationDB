using Obligatorisk_OPG.Model;

namespace Obligatorisk_OPG.Services.Interfaces
{
    public interface IRoomService
    {
        IEnumerable<Room> GetRooms();
    }
}
