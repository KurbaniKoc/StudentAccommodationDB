using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.Services.MockServices.MockStudentService;

namespace Obligatorisk_OPG.Pages.Student
{
    public class GetAllStudentsModel : PageModel
    {
        IStudentService studentService { get; set; }
        public GetAllStudentsModel(IStudentService Service)
        {
            studentService = Service;
        }

        public void OnGet()
        {

        }
    }
}
    //{
    //    [BindProperty(SupportsGet = true)]
    //    public string NameCriteria { get; set; }

    //    [BindProperty(SupportsGet = true)]
    //    public int AdressCriteria { get; set; }
    //    public IEnumerable<Student> Students { get; set; }
    //    public Student Student { get; set; }


    //    IStudentService studentService { get; set; }
    //    public GetAllStudentsModel(IStudentService service)
    //    {
    //        studentService = service;
    //    }
    //    public void OnGet()
    //    {
    //        if (!String.IsNullOrEmpty(NameCriteria))
    //        {
    //            Students = studentService.GetActorsByCountry(NameCriteria);
    //        }
    //        else if (!String.IsNullOrEmpty(AdressCriteria.ToString()) && AdressCriteria != 0)
    //        {
    //            Student = studentService.GetStudentByStudentNo(AdressCriteria);
    //        }
    //        else
    //            Students = studentService.GetStudents();
    //    }
    //    public void OnPost()
    //    {

    //    }
    //}

