using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.TabelServices.LeasingS;

namespace Obligatorisk_OPG
{
    public class CreateLeasingModel : PageModel
    {
        private readonly ILeasingServiceM _leasingServiceM;
        private readonly IDormitoryService _dormitoryService;

        [BindProperty]
        public Leasing leasing { get; set; } = new Leasing();

        public CreateLeasingModel(ILeasingServiceM leasingServiceM, IDormitoryService dormitoryService)
        {
            _leasingServiceM = leasingServiceM;
            _dormitoryService = dormitoryService;
        }

        public void OnGet(int roomNo)
        {
            leasing.RoomNo = roomNo;
            leasing.DormitoryNumber = _dormitoryService.GetDormitoryNoByRoomNo(roomNo);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _leasingServiceM.AddLeasing(leasing);

            return RedirectToPage("GetLeasing");
        }
    }

}
