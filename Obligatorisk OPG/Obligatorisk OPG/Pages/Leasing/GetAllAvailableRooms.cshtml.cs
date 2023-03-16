using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;

namespace Obligatorisk_OPG
{
    public class GetAllAvailableRoomsModel : PageModel
    {
        public IEnumerable<Room> Rooms { get; set; }
        //public Room Room { get; set; }


        ILeasingServiceM roomService { get; set; }
        public GetAllAvailableRoomsModel(ILeasingServiceM service)
        {
            roomService = service;
        }

        public void OnGet()
        {
            Rooms = roomService.GetAllAvailableRooms();
        }

        public void OnPost()
        {

        }
    }
}
