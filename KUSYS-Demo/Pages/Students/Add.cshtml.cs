using KUSYS_Demo.DataContext;
using KUSYS_Demo.Models.ViewModels;
using KUSYS_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KUSYS_Demo.Pages.Students
{
    public class AddModel : PageModel
    {
        private readonly AplicationDbContext addStudentContext;

        [BindProperty]
        public AddStudent AddStudentRequest { get; set; }

        public AddModel(AplicationDbContext aplicationDbContext)
        {
            this.addStudentContext = aplicationDbContext;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult>  OnPost()
        {
            var student = new Student()
            {
                
                FirstName = AddStudentRequest.FirstName,
                LastName = AddStudentRequest.LastName,
                BirthDate = AddStudentRequest.BirthDate,
            };

          await  addStudentContext.Students.AddAsync(student);
          await  addStudentContext.SaveChangesAsync();
            return RedirectToPage("/Students/List");

        }
    }
}
