using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AptekaCursovoy.Models;

namespace AptekaCursovoy.Data
{
    public class AptekaCursovoyContext : DbContext
    {
        public AptekaCursovoyContext (DbContextOptions<AptekaCursovoyContext> options)
            : base(options)
        {
            _ = Database.EnsureCreated();

        }

        public DbSet<AptekaCursovoy.Models.Tovar> Tovar { get; set; } = default!;
        public DbSet<AptekaCursovoy.Models.Employee> Employee { get; set; } = default!;
    }
}
