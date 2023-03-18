using Obligatorisk_OPG.Services.TabelServices;
using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.ViewModels;

namespace Obligatorisk_OPG.Services.Interfaces
{
    public interface IDormitoryService
    {
        IEnumerable<Dormitory> GetDormitories();
        public IEnumerable<Room_Student> GetRoomStudent(int did);

        public int GetDormitoryNoByRoomNo(int roomNo);


    }


}
