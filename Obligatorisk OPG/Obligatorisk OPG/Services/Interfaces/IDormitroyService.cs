using Obligatorisk_OPG.Services.TabelServices;
using Obligatorisk_OPG.Model;


namespace Obligatorisk_OPG.Services.Interfaces
{
    public interface IDormitoryService
    {
        IEnumerable<Dormitory> GetDormitories();

        public int GetDormitoryNoByRoomNo(int roomNo);

    }


}
