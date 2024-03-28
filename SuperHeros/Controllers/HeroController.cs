using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeros.Models;
using SuperHeros.Services.HeroService;

namespace SuperHeros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly IHeroService _heroService;

        public HeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Hero>>> GetAllHeros()
        {
            var result = _heroService.GetAllHeros();
            if (result is null) 
                return NotFound("Hero not found");
            return Ok(result);            
        }
        [HttpPost]
        public async Task<ActionResult<List<Hero>>> AddHeros(Hero hero)
        {
            var result = _heroService.AddHero(hero);
            if (result is null)
                return NotFound("Hero not found");
            return Ok(result);
        }
    }
}
