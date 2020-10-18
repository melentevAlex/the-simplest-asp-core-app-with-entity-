using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationExm.Models
{
    public class AppContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        public AppContext(DbContextOptions<AppContext> options) : base (options)
        {
            Database.EnsureCreated();
        }
    }
}
