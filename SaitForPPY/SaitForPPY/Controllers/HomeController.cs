 using Microsoft.AspNetCore.Mvc;
using SaitForPPY.Models;
using System.Diagnostics;

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

        #region Коллекции

        [HttpGet]
        public IActionResult PrintValueColletion()
        {
            var numbersList = new List<int> { 1, 2, 3, 4, 5 };
            var numbersArrey = new string[] { "1", "2", "3" };
            var users = new List<User>
            {
                new User {Name= "Андрей", Age = 17},
                new User {Name= "Михаил", Age = 35},
                new User {Name= "Владимир", Age = 23},
            };
            return View(users);
        }

        #endregion


        #region Результат
        [HttpGet]
        public IActionResult Calculate(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            return View(result);
        }
        #endregion

        #region Передача данных в БД
        [HttpGet]

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
               await UserService.AddUser(model);
               
                return RedirectToAction("GetAllUsers", "Account");
            }
            return View();
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