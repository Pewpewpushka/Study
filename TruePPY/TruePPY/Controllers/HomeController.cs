﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TruePPY.Domain.Entity;
using TruePPY.Models;

namespace TruePPY.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            SystemsPPY  systemsPPY = new SystemsPPY() 
            {
                Name= "Home-45",
                Density = 45
             
            };
            return View(systemsPPY);
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