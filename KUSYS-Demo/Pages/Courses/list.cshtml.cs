using KUSYS_Demo.DataContext;
using KUSYS_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
        public void OnGet()
        {
            Courses=aplicationDbContext.Courses.ToList();

        }
    }
}
