using Microsoft.AspNetCore.Mvc;
using WebApplicationNewSait.DAL.Interfaces;
using WebApplicationNewSait.Domain.Entity;


namespace WebApplicationNewSait.Controllers
{
    public class PolyurethaneFoamController : Controller
    {
        private readonly IPolyurethaneFoamRepositories _polyurethaneFoamRepositories;
        public PolyurethaneFoamController(IPolyurethaneFoamRepositories polyurethaneFoamRepositories)
        {
            _polyurethaneFoamRepositories = polyurethaneFoamRepositories;
        }
        [HttpGet]

        public async Task <IActionResult> GetPolyurethaneFoam()
        {
            var response = await _polyurethaneFoamRepositories.Select();
            //var response1 = await _polyurethaneFoamRepositories.GetByName( "????-20");
            return View(response);
        }
    }
}
