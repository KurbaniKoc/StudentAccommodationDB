using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;

//namespace Obligatorisk_OPG.Pages.Student
//{
//    public class CreateStudentModel : PageModel
//    {
//        [BindProperty]
//        public Student Student { get; set; } = new Student();
//        public void OnGet(int studentNo)
//        {
//            Student.StudentNo = studentNo;
//        }
//        IStudentService studentService;
//        public CreateModel(IStudentService service)
//        {
//            this.studentService = service;
//        }
//        public IActionResult OnPost(Student student)
//        {
//            if (!ModelState.IsValid)
//            {
//                return Page();
//            }
//            studentService.AddStudent(Student);
//            return RedirectToPage("GetStudents");
//        }
//    }
//}
