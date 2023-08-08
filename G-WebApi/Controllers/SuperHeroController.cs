using G_WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

       private static List<SuperHero> superHeros = new List<SuperHero>
            {
                new SuperHero {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                },
                 new SuperHero {
                    Id = 2,
                    Name = "Iron Man",
                    FirstName = "Tony",
                    LastName = "Stack",
                    Place = "Malibu"
                },
                  new SuperHero {
                    Id = 3,
                    Name = "Thor",
                    FirstName = "Chris",
                    LastName = "B",
                    Place = "Asgaurd"
                },
                  new SuperHero {
                    Id =  4,
                    Name = "Bat Man",
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Place =  "Gotham City"
                  }
            };


        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeros()
        {
            return Ok(superHeros);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var hero = superHeros.Find(x=>x.Id == id);
            if(hero is null)
            {
                return NotFound("Sorry! this hero doesn't eixst!");
            }
              return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            superHeros.Add(hero);
            return Ok(superHeros);
        }


        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero request)
        {
            var hero = superHeros.Find(x => x.Id == request.Id);
            if (hero is null){
                return NotFound("Sorry! hero not found!");
            }
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            hero.Name = request.Name;

            return Ok(superHeros);


        }
    }
}
