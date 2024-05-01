using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tololus.Data;
using Tololus.Models;

namespace Tololus.WaitListData
{
    public class DetailsModel : PageModel
    {
        private readonly Tololus.Data.ComingSoonContext _context;

        public DetailsModel(Tololus.Data.ComingSoonContext context)
        {
            _context = context;
        }

      public ComingSoon ComingSoon { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ComingSoon == null)
            {
                return NotFound();
            }

            var comingsoon = await _context.ComingSoon.FirstOrDefaultAsync(m => m.Id == id);
            if (comingsoon == null)
            {
                return NotFound();
            }
            else 
            {
                ComingSoon = comingsoon;
            }
            return Page();
        }
    }
}
