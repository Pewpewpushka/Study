using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PPUmarket.DAL.Interfaces;
using PPUmarket.Domain.Entity;
using System.Linq;

namespace PPUmarket.Controllers
{
    public class FoamController : Controller
    {
        private readonly IFoamRepository _foamRepository;

        public FoamController(IFoamRepository foamRepository)
        {
            _foamRepository = foamRepository;
        }
        //public async Task<IActionResult> GetFoamsAsync()
        //{
        //    var response = await _foamRepository.Select();

        //    return View(response);
        //}
        [HttpGet]
        public async Task<IActionResult> GetFoams()
        {
            var response = await _foamRepository.Select().AsQueryable().ToListAsync();
            return View(response);
        }

    }
}
