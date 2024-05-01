using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tololus.Models;

namespace Tololus.Data
{
    public class CreateModel : PageModel
    {
        private readonly Tololus.Data.TololusContext _context;

        public CreateModel(Tololus.Data.TololusContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ContactForm ContactForm { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.ContactForm == null || ContactForm == null)
            {
                return Page();
            }

            _context.ContactForm.Add(ContactForm);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
