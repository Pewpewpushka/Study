using Microsoft.AspNetCore.Mvc;
using System;

using System.Linq;
using System.Threading.Tasks;

namespace MyCompany2.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();// выводим список всех услуг которые есть у нас на сайте
        }


    }
}
