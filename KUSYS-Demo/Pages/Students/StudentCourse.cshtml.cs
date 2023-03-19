using KUSYS_Demo.DataContext;
using KUSYS_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace KUSYS_Demo.Pages.Students
{
    public class StudentCourseModel : PageModel
    {
       
        private readonly AplicationDbContext aplicationDbContext;

        public StudentCourseModel(AplicationDbContext aplicationDbContext)
        {
            this.aplicationDbContext = aplicationDbContext;
        }
        public List<Student> students { get; set; }
        public async Task OnGet()
        {
            students = await aplicationDbContext.Students.ToListAsync();
        }

       


    }
}
