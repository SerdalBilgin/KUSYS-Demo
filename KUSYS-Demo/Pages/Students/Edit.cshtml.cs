using KUSYS_Demo.DataContext;
using KUSYS_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KUSYS_Demo.Pages.Students
{

    public class EditModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }

        [BindProperty]
        public Course Course { get; set; }

        private readonly AplicationDbContext aplicationDbContext;
            
        public EditModel( AplicationDbContext aplicationDbContext)
        {
            this.aplicationDbContext = aplicationDbContext;
        }

        public List<Course> Courses { get; set; }

        public async Task OnGet(int StudentId)
        {
          Student = await aplicationDbContext.Students.FindAsync(StudentId);
          //Courses = await aplicationDbContext.Courses.Include(c => c.StudentId == StudentId).ToListAsync();        
        
        }
        public async Task<IActionResult> OnPostEdit() 
        {
            var existingStudent =await aplicationDbContext.Students.FindAsync(Student.StudentId);
            
            if (existingStudent != null) 
            {
                existingStudent.FirstName = Student.FirstName;   
                existingStudent.LastName = Student.LastName;
                existingStudent.BirthDate = Student.BirthDate;
            }
          await  aplicationDbContext.SaveChangesAsync();
            return RedirectToPage("/Students/List");
        }
        public async Task<IActionResult> OnPostDelete() 
        {
            var existingStudent= await aplicationDbContext.Students.FindAsync(Student.StudentId);
            if (existingStudent != null) 
            {
            aplicationDbContext.Students.Remove(existingStudent);
               await aplicationDbContext.SaveChangesAsync(true);
                return RedirectToPage("/Students/List");
            }
            return Page();
        }
    }
}
