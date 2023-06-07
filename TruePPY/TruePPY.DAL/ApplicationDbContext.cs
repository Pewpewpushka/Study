using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruePPY.Domain.Entity;

namespace TruePPY.DAL
{
    internal class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) 
        { 
            Database.EnsureCreated();
        }

        public DbSet<SystemsPPY> SystemsPPY { get; set; }
    }
}
