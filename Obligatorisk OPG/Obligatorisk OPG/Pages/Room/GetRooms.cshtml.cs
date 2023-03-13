using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.Services.TabelServices;
using Obligatorisk_OPG.Model;

namespace Obligatorisk_OPG
{
    public class GetRoomsModel : PageModel
    {
        public IEnumerable<Room> Rooms { get; set; }
        //public Room Room { get; set; }


        IRoomService roomService { get; set; }
        public GetRoomsModel(IRoomService service)
        {
            roomService = service;
        }

        public void OnGet()
        {
            Rooms = roomService.GetRooms();

        }

        public void OnPost()
        {

        }
    }
}
