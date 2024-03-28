using SuperHeros.Models;

namespace SuperHeros.Services.HeroService
{
    public interface IHeroService
    {
        List<Hero> GetAllHeros();
        Hero GetHero(int id);
        List<Hero> AddHero(Hero hero);
        List<Hero> UpdateHero(int id, Hero request);
        List<Hero> DeleteHero(int id);
    }
}
