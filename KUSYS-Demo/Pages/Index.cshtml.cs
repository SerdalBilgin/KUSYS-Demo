﻿using KUSYS_Demo.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KUSYS_Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        
        public IndexModel(ILogger<IndexModel> logger)
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
            else if (Username.Equals("admin") && Password.Equals("admin") )
            {
                return RedirectToPage("/Students/List");
            }
            else
            {
                Msg = "Username or Password is İncorrect";
                return Page();
            }
        }

    }
}