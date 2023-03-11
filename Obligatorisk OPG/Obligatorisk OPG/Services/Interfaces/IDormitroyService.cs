using Obligatorisk_OPG.Model;

namespace Obligatorisk_OPG.Services.Interfaces
{
    public interface IDormitroyService
    {
        IEnumerable<Dormitory> GetDormitories();
    }
}
