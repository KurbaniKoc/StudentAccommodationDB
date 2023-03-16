using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.ViewModels;

namespace Obligatorisk_OPG.Pages.Dormitory
{
    public class GetLeasing_RoomModel : PageModel
    {
        public IEnumerable<Leasing_Room> leasing_Room { get; set; }

        ILeasingServiceM leasingServiceM { get; set; }

        public GetLeasing_RoomModel(ILeasingServiceM service)
        {
            leasingServiceM = service;
        }

        public void OnGet(int lid)
        {
            leasing_Room = leasingServiceM.GetLeasingRoom(lid);
        }
    }
}
