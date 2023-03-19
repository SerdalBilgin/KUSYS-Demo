using KUSYS_Demo.DataContext;
using KUSYS_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KUSYS_Demo.Pages.Courses
{
    public class listModel : PageModel
    {
        private readonly AplicationDbContext aplicationDbContext;

        
        public listModel(AplicationDbContext aplicationDbContext)
        {
            this.aplicationDbContext = aplicationDbContext;
        }
        public List<Course> Courses { get; set; }
        public List<Student> students { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }

        public void OnGet()
        {
            Courses=aplicationDbContext.Courses.ToList();
            students=aplicationDbContext.Students.ToList();
            //StudentCourses=aplicationDbContext.StudentCourses.ToList();  
        }
    }
}
