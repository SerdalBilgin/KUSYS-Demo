using KUSYS_Demo.DataContext;
using KUSYS_Demo.Models;
using KUSYS_Demo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KUSYS_Demo.Pages.Students
{
    public class ListModel : PageModel
    {
       

        private readonly AplicationDbContext aplicationDbContext;

        public ListModel(AplicationDbContext aplicationDbContext)
        {
            this.aplicationDbContext = aplicationDbContext;     
        }
       public List<Student> students { get; set; }
       
      
        public async Task OnGet() 
        {
            students =await aplicationDbContext.Students.ToListAsync();
        }
      
    }
}
