using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tololus.Models;

namespace Tololus.Data
{
    public class EditModel : PageModel
    {
        private readonly Tololus.Data.TololusContext _context;

        public EditModel(Tololus.Data.TololusContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContactForm ContactForm { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ContactForm == null)
            {
                return NotFound();
            }

            var contactform =  await _context.ContactForm.FirstOrDefaultAsync(m => m.Id == id);
            if (contactform == null)
            {
                return NotFound();
            }
            ContactForm = contactform;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ContactForm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactFormExists(ContactForm.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ContactFormExists(int id)
        {
          return (_context.ContactForm?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
