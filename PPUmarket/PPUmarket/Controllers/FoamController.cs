using Microsoft.AspNetCore.Mvc;
using PPUmarket.DAL.Interfaces;
using PPUmarket.Domain.Entity;

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
        public async Task<IActionResult> GetFoamsAsync()
        {
            var response = await _foamRepository.Select().ToListAsync();

            return View(response);
        }

    }
}
