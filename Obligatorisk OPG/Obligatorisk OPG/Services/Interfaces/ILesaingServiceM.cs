using Obligatorisk_OPG.Model;

namespace Obligatorisk_OPG.Services.Interfaces
{
  
        public interface ILeasingServiceM
        {
            IEnumerable<Leasing> GetAllLeasing();
            IEnumerable<Leasing> GetAll();
            //IEnumerable<Leasing> GetLeasings();
        }
    
}
