﻿using Microsoft.AspNetCore.Mvc;
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
            //return await _foamRepository.Select();
           
        }
    //public class SuperHeroController : ControllerBase
    //{
    //    private readonly ISuperHeroService _superHeroService;

    //    public SuperHeroController(ISuperHeroService superHeroService)
    //    {
    //        _superHeroService = superHeroService;
    //    }

    //    [HttpGet]
    //    public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
    //    {
    //        return await _superHeroService.GetAllHeroes();
    //    }

    }
}