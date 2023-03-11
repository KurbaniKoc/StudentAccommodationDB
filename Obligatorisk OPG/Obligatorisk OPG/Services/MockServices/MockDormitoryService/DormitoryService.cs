using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;

namespace Obligatorisk_OPG.Services.MockServices.MockDormitoryService
{
    public class DormitoryService:IDormitroyService
    {
       
        public IEnumerable<Dormitory> GetDormitories()
        {
            return SQL_Dormitory.GetAllDormitories();
        }
    }
}
