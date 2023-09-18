using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebApplicationNewSait.DAL.Interfaces;
using WebApplicationNewSait.Domain.Entity;
using WebApplicationNewSait.Models;

namespace WebApplicationNewSait.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IPolyurethaneFoamRepositories _polyurethaneFoamRepositories;

        public HomeController(IPolyurethaneFoamRepositories polyurethaneFoamRepositories)
        {
            _polyurethaneFoamRepositories= polyurethaneFoamRepositories;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var response = await _polyurethaneFoamRepositories.Select();

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