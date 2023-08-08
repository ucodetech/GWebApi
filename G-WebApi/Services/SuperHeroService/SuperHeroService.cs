using G_WebApi.Data;
using G_WebApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace G_WebApi.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly ApplicationDbContext _db;
        public SuperHeroService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<SuperHero>> GetAllHeros()
        {
            var heros =  await _db.SuperHeroes.ToListAsync();
            return heros;
        }

        public async Task<SuperHero> GetSingleHero(int id)
        {
            var hero = await _db.SuperHeroes.FindAsync(id);
            if (hero == null)
                return null;
           
            return hero;
        }

        public async Task<List<SuperHero>> AddHero(SuperHero hero)
        {
              _db.SuperHeroes.Add(hero);
             await _db.SaveChangesAsync();
             return await _db.SuperHeroes.ToListAsync();
            
        }
        public async Task<List<SuperHero>> UpdateHero(int id, SuperHero request)
        {
            var hero = await _db.SuperHeroes.FindAsync(id);
            if (hero == null)
                return null;
            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            await _db.SaveChangesAsync();

            return await _db.SuperHeroes.ToListAsync();
        }
        public async Task<List<SuperHero>> DeleteHero(int id)
        {
            var hero = await _db.SuperHeroes.FindAsync(id);
            if(hero is null)
            {
                return null;
            }
            _db.SuperHeroes.Remove(hero);
            await _db.SaveChangesAsync();
            return await _db.SuperHeroes.ToListAsync();

        }

       
    }
}
