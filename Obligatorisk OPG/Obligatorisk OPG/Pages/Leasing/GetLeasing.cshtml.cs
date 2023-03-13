using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;

namespace Obligatorisk_OPG
{
    public class GetLeasingModel : PageModel
    {

        public IEnumerable<Leasing> Leasings { get; set; }
        //public Leasing Leasing { get; set; }

        ILeasingServiceM leasingService { get; set; }
        public GetLeasingModel(ILeasingServiceM Service)
        {
            leasingService = Service;
        }

        public void OnGet()
        {

            //Leasing = SQL_Leasing.GetAllLeasings();
            //if (!String.IsNullOrEmpty(leasingNo))
            //{
            //    leasings = leasingService.GetLeasingByLeasingNo(leasingNo);
            //}
            //else if (!String.IsNullOrEmpty(leasingNo.ToString()) && leasingNo != 0)
            //{
            //    Actor = actorService.GetActorById(IdCriteria);
            //}
            //else
            //    Actors = actorService.GetActors();
            Leasings = leasingService.GetAll();

        }

        public void OnGetLeasing(int leasingNo) 
        {
            
        }

        public void OnPost()
        {

        }

    }
}