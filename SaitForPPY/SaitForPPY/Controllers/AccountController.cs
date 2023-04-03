using Microsoft.AspNetCore.Mvc;
using SaitForPPY.Models;

namespace SaitForPPY.Controllers
{
    public class AccountController : Controller
	{
        public ILogger<AccountController> _logger;
        public IConfiguration _configuration;


        public AccountController(ILogger<AccountController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult GetAllUsers()
		{
			List<CreateUserViewModel> allUsers = UserService.GetAllUsers();

			return View(allUsers);
		}
	}
}
