using Microsoft.AspNetCore.Mvc;
using PPUmarket.DAL.Interfaces;
using PPUmarket.Domain.Entity;
using PPUmarket.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PPUmarket.Controllers
{
    public class HomeController : Controller
    {
       
        //public async Task<IEnumerable<Foam>> Select()
        //{
        //    IEnumerable<Foam> response = await Task.FromResult(_foamRepository.Select());

        //    return response;
        //}
        public async Task<IActionResult> Indexasync()
        {
            return View();
        }

        //public async Task<IActionResult> Index()
        //{
        //    var response = _foamRepository.Select();

        //    return View(await Task.FromResult(response));
        //}
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