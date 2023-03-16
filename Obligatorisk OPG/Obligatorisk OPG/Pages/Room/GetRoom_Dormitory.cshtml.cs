using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.ViewModels;

namespace Obligatorisk_OPG.Pages.Room
{
    public class GetRoom_DormitoryModel : PageModel
    {

        public IEnumerable<Room_Dormitory> room_Dormitory { get; set; }

        IRoomService roomService { get; set; }

        public GetRoom_DormitoryModel(IRoomService service)
        {
            roomService = service;
        }

        public void OnGet(int aid) 
        {
            room_Dormitory = roomService.GetRoom_Dormitory(aid);
        }

        
    }
}
