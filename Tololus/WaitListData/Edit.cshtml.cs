using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tololus.Data;
using Tololus.Models;

namespace Tololus.WaitListData
{
    public class EditModel : PageModel
    {
        private readonly Tololus.Data.ComingSoonContext _context;

        public EditModel(Tololus.Data.ComingSoonContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ComingSoon ComingSoon { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ComingSoon == null)
            {
                return NotFound();
            }

            var comingsoon =  await _context.ComingSoon.FirstOrDefaultAsync(m => m.Id == id);
            if (comingsoon == null)
            {
                return NotFound();
            }
            ComingSoon = comingsoon;
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

            _context.Attach(ComingSoon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComingSoonExists(ComingSoon.Id))
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

        private bool ComingSoonExists(int id)
        {
          return (_context.ComingSoon?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
