using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tololus.Models;
using Tololus.Pages;


namespace Tololus.Pages
{
    public class comingSoonModel : PageModel
    {

        private readonly Tololus.Data.ComingSoonContext _context;

        public comingSoonModel(Tololus.Data.ComingSoonContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ComingSoon comingSoon { get; set; }

        public string successMessage = "";
        public string errorMessage = "";

        public async Task<IActionResult> OnPostAsync() 
        {
            if (!ModelState.IsValid)
            {
                errorMessage = "Data Validation Failed";
                return Page();
            }

            successMessage = "Your message has been received successfuly!!";

            _context.ComingSoon.Add(comingSoon);
            await _context.SaveChangesAsync();


            return RedirectToPage("Success");
            successMessage = "Your message has been received successfuly!!";


        }


    }
}
