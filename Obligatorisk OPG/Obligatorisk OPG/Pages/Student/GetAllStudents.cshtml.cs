using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.Services.MockServices.MockStudentService;

namespace Obligatorisk_OPG.Pages.Student
{
    public class GetAllStudentsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string AdressCriteria { get; set; }

        [BindProperty(SupportsGet = true)]
        public int IdCriteria { get; set; }
        public IEnumerable<IStudent> Students { get; set; }
        public IStudent Student { get; set; }

        IStudentService studentService { get; set; }

        public GetAllStudentsModel(IStudentService Service)
        {
            studentService = Service;
        }

        public void OnGet()
        {
            //if (!String.IsNullOrEmpty(AdressCriteria))
            //{
            //    Students = studentService.GetStudentsByAdress(AdressCriteria);
            //}
            //else if (!String.IsNullOrEmpty(IdCriteria.ToString()) && IdCriteria != 0)
            //{
            //    Student = studentService.GetStudentById(IdCriteria);
            //}
            //else
            //    Students = studentService.GetStudents();
        }

        public void OnPost()
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

