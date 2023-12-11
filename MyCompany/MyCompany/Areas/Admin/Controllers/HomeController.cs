using Microsoft.AspNetCore.Mvc;

namespace MyCompany.Areas.Admin.Controllers
{   // по этому атрибуту определяется правило AdminAreaAuthorization
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
