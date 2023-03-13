using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Pages.Dormitory;
using Obligatorisk_OPG.Services.Interfaces;

namespace Obligatorisk_OPG

{

    public class ViewDormitoryModel : PageModel
    {

        public IEnumerable<Dormitory> Dormitories { get; set; }
        public Dormitory Dormitory { get; set; }


        IDormitoryService dormitoryService { get; set; }
        public ViewDormitoryModel(IDormitoryService service)
        {
            dormitoryService = service;
        }

        public void OnGet()
        {
            Dormitories = dormitoryService.GetDormitories();

        }

        public void OnPost()
        {

        }


    }

}