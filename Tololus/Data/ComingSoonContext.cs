using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tololus.Models;

namespace Tololus.Data
{
    public class ComingSoonContext : DbContext
    {
        public ComingSoonContext (DbContextOptions<ComingSoonContext> options)
            : base(options)
        {
        }

        public DbSet<Tololus.Models.ComingSoon> ComingSoon { get; set; } 
    }
}
