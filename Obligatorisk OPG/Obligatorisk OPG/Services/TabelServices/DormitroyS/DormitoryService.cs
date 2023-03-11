using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;

namespace Obligatorisk_OPG.Services.TabelServices.DormitroyS
{
    public class DormitoryService:IDormitroyService
    {
        private List<Dormitory> dormitories;
        public IEnumerable<Dormitory> GetDormitories()
        {
            return dormitories;
        }

    }
}
