using Microsoft.AspNetCore.Mvc;
using PPUmarket.DAL.Interfaces;
using PPUmarket.Domain.Entity;
using PPUmarket.Models;
using System.Diagnostics;

namespace PPUmarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoamRepository _foamRepository;

        public HomeController(IFoamRepository foamRepository)
        {
            _foamRepository = foamRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

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