using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.TabelServices.LeasingS;

namespace Obligatorisk_OPG
{
    public class CreateLeasingModel : PageModel
    {
        [BindProperty]
       
        public Leasing leasing { get; set; } = new Leasing ();
        public void OnGet(int leasingNo)
        {
            leasing.LeasingNo = leasingNo;
        }
        ILeasingServiceM leasingServiceM;
        
        public CreateLeasingModel(ILeasingServiceM Service)
        {
            this.leasingServiceM = Service;
        }
        
        public IActionResult OnPost(Leasing leasing)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            leasingServiceM.AddLeasing(leasing);
            //Create a method called changeRoomStatus som tager leasing som argument SetRoomOccapied = true
            return RedirectToPage("GetLeasing");
        }
    }
}
