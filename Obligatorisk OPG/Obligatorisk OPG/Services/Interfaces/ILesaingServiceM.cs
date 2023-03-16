using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.ViewModels;

namespace Obligatorisk_OPG.Services.Interfaces
{
    public interface ILeasingServiceM
    {
        IEnumerable<Leasing> GetAllLeasing();
        IEnumerable<Leasing> GetAll();
        void AddLeasing(Leasing leasing);
        public IEnumerable<Leasing_Student> GetLeasingStudent(int id);
        public IEnumerable<Leasing_Room> GetLeasingRoom(int lid);





    }

}
