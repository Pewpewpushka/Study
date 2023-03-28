using Microsoft.AspNetCore.Mvc;
using SaitForPPY.Models;
using System.Diagnostics;
using SaitForPPY.Controllers;

namespace SaitForPPY.Controllers
{
    public class HomeController : Controller
    {   public  ILogger<HomeController> _logger;
        public IConfiguration _configuration;
        public HomeController( ILogger<HomeController> logger,IConfiguration configuration) 
        {
            _logger = logger;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
           
            return View();
        }
        #region Ввод значений
        //public IActionResult PrintInfo() { return View(); }
        [HttpGet]
        public IActionResult PrintValue()
        {
            int age = 65;
            var user = new User {  Age = age };
            return View(user);  
        }
        #endregion


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}