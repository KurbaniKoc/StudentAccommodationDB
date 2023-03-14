using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.ViewModels;

namespace Obligatorisk_OPG.Pages.Leasing
{
    public class GetLeasing_StudentModel : PageModel
    {
        public IEnumerable<Leasing_Student> Leasing_student { get; set; }

        ILeasingServiceM leasingServiceM { get; set; }

        public GetLeasing_StudentModel(ILeasingServiceM service)
        {
            leasingServiceM = service;
        }

        public void OnGet(int aid)
        {
            Leasing_student = leasingServiceM.GetLeasingStudent(aid);
        }

    }
}
