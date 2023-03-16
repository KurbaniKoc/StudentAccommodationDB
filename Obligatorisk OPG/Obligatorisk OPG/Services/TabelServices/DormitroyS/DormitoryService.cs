using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.ViewModels;

namespace Obligatorisk_OPG.Services.TabelServices.DormitroyS
{
    public class DormitoryService:IDormitoryService
    {
       
        public IEnumerable<Dormitory> GetDormitories()
        {
            return SQL_Dormitory.GetAllDormitories();
        }

        public IEnumerable<Room_Student> GetRoomStudent(int did)
        {
            return SQL_Dormitory.GetRoomsAndStudents(did);
            
        }
    }
}
