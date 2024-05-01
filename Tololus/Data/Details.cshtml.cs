using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tololus.Models;

namespace Tololus.Data
{
    public class DetailsModel : PageModel
    {
        private readonly Tololus.Data.TololusContext _context;

        public DetailsModel(Tololus.Data.TololusContext context)
        {
            _context = context;
        }

      public ContactForm ContactForm { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ContactForm == null)
            {
                return NotFound();
            }

            var contactform = await _context.ContactForm.FirstOrDefaultAsync(m => m.Id == id);
            if (contactform == null)
            {
                return NotFound();
            }
            else 
            {
                ContactForm = contactform;
            }
            return Page();
        }
    }
}
