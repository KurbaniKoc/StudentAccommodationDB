using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;

namespace Obligatorisk_OPG.Services.TabelServices.DormitroyS
{
    public class DormitoryService:IDormitoryService
    {
       
        public IEnumerable<Dormitory> GetDormitories()
        {
            return SQL_Dormitory.GetAllDormitories();
        }

        public int GetDormitoryNoByRoomNo(int roomNo)
        {
            return SQL_Dormitory.GetDormitoryNoByRoomNo(roomNo);
        }

    }
}
