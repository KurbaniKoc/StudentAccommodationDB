using Obligatorisk_OPG.Model;

namespace Obligatorisk_OPG.Services.Interfaces
{
    public interface ILeasingService
    {
        IEnumerable<Leasing> GetAllLeasing();
        IEnumerable<Leasing> GetAll();
        //IEnumerable<Leasing> GetLeasings();

        //public Leasing GetLeasingByLeasingNo(int leasingNo);
        //void AddLeasing(Leasing leasing);
        //IEnumerable<Leasing> Get(string country);
        //public Leasing GetLeasingByLeasingNo(int LeasingNo);
        //public void DeleteLeasing(Leasing leasing);
        //public IEnumerable<Actor_Movies> GetActor_Movies();

    }
}
