﻿using Microsoft.AspNetCore.Mvc;
using SaitForPPY.Models;
using System.Diagnostics;

namespace SaitForPPY.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        public HomeController( ILogger<HomeController> logger,IConfiguration configuration) 
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult PrintInfo() { return View(); }
        public IActionResult PrintValue()
        {
            int age = 16;
            string name = "Mikhail";
            var user = new User { Name = name, Age = age };
            return View(); 
        }
       

        public IActionResult Index()
        {
            var adminName= _configuration.GetSection("Admin:Name" );
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