using Microsoft.AspNetCore.Mvc;
using System;
using MyCompany.Domain;
using System.Linq;
using System.Threading.Tasks;



namespace MyCompany.Areas.Admin.Controllers
{   // по этому атрибуту определяется правило AdminAreaAuthorization
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItems());// выводим список всех услуг которые есть у нас на сайте
        }
        [HttpPost]
        
        public ActionResult Index(string content1, string content2)
        {
            ViewBag.Content1 = content1;
            ViewBag.Content2 = content2;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

}
