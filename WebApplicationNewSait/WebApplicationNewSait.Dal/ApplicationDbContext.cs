 using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationNewSait.Domain.Entity;

namespace WebApplicationNewSait.DAL
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<PolyurethaneFoam> PolyurethaneFoam { get; set; }
    }
}
