using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorisk_OPG.Model;
using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.Pages.Student;

namespace Obligatorisk_OPG
{
    public class DeleteStudentModel : PageModel
    {
        public IEnumerable<Student> Students { get; set; }

        IStudentService studentService;
        public DeleteStudentModel(IStudentService service)
        {
            this.studentService = service;
        }
        [BindProperty]
        public Student Student { get; set; }

        public IActionResult OnGet(int sid)
        {
            Student = studentService.GetStudentById(sid);
            return Page();
        }
        public IActionResult OnPostAsync()
        {
            studentService.DeleteStudent(Student);
            return RedirectToPage("GetAllStudents");
        }
    }
}
