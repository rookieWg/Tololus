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
    public class IndexModel : PageModel
    {
        private readonly Tololus.Data.TololusContext _context;

        public IndexModel(Tololus.Data.TololusContext context)
        {
            _context = context;
        }

        public IList<ContactForm> ContactForm { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ContactForm != null)
            {
                ContactForm = await _context.ContactForm.ToListAsync();
            }
        }
    }
}
