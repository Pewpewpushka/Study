using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SaitForPPY.Models
{
    public class UserContextcs : DbContext
    {
        public DbSet<CreatedAtActionResult> CreatedAt { get; set; }
        public DbSet<CreateUserViewModel> CreatedBy { get; set; } 

        public IActionResult Index()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
