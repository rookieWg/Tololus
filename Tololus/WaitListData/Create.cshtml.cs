using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tololus.Data;
using Tololus.Models;

namespace Tololus.WaitListData
{
    public class CreateModel : PageModel
    {
        private readonly Tololus.Data.ComingSoonContext _context;

        public CreateModel(Tololus.Data.ComingSoonContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ComingSoon ComingSoon { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.ComingSoon == null || ComingSoon == null)
            {
                return Page();
            }

            _context.ComingSoon.Add(ComingSoon);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
