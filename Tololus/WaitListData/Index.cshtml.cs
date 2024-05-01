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
    public class IndexModel : PageModel
    {
        private readonly Tololus.Data.ComingSoonContext _context;

        public IndexModel(Tololus.Data.ComingSoonContext context)
        {
            _context = context;
        }

        public IList<ComingSoon> ComingSoon { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ComingSoon != null)
            {
                ComingSoon = await _context.ComingSoon.ToListAsync();
            }
        }
    }
}
