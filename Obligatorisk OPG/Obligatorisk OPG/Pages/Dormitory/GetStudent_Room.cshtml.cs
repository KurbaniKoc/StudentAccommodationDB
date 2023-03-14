using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.ViewModels;

namespace Obligatorisk_OPG.Pages.Dormitory
{
    public class GetStudent_RoomModel : PageModel
    {

        public IEnumerable<Room_Student> Room_Student { get; set; }

        IDormitoryService dormitoryService { get; set; }

        public GetStudent_RoomModel(IDormitoryService service)
        {
            dormitoryService = service;
        }

        public void OnGet(int did)
        {
            Room_Student = dormitoryService.GetRoomStudent(did);
        }
       
    }
}
