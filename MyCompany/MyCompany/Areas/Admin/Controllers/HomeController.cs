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
    }
}
