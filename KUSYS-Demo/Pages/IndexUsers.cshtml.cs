using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KUSYS_Demo.Pages
{
    public class IndexUsersModel : PageModel
    {
        private readonly ILogger<IndexUsersModel> _logger;

        public IndexUsersModel(ILogger<IndexUsersModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }

        public IActionResult OnPost()
        {
            if (Username == null || Password == null)
            {
                Msg = "Required to Fill in The Fields";
                return Page();
            }
            else if (Username.Equals("user") && Password.Equals("user"))
            {
                return RedirectToPage("/Students/Add");
            }
            else
            {
                Msg = "Username or Password is Ýncorrect";
                return Page();
            }
        }
    }
}