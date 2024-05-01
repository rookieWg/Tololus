using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tololus.Models;
using System.ComponentModel.DataAnnotations;

namespace Tololus.Pages
{
    public class IndexModel : PageModel
    {



        private readonly Tololus.Data.TololusContext _context;

        public IndexModel(Tololus.Data.TololusContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ContactForm contactForm { get; set; }

        public string successMessage = "";
        public string errorMessage = "";

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                errorMessage = "Data Validation Failed";
                return Page();
            }

        

            _context.ContactForm.Add(contactForm);
            await _context.SaveChangesAsync();
            return RedirectToPage("Success");
            //successMessage = "Your message has been received successfuly!!";
                    
            contactForm.Name = "";
            contactForm.EmailAddress = "";
            contactForm.PhoneNumber = "";
            contactForm.Category = "";
            contactForm.Subject = "";
            contactForm.Message = "";
            ModelState.Clear(); 
            return Page();
           

        }





    }
}