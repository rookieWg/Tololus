using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tololus.Models;

namespace Tololus.Data
{
    public class TololusContext : DbContext
    {
        public TololusContext (DbContextOptions<TololusContext> options)
            : base(options)
        {
        }

        public DbSet<Tololus.Models.ContactForm> ContactForm { get; set; } 
    }
}
