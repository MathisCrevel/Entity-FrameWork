using SuperHeros.Models;

namespace SuperHeros.Services.HeroService
{
    public class HeroService : IHeroService
    {
        private static List<Hero> heros = new List<Hero>
        {
            new Hero("Batman","Riche",1)
        };
        public List<Hero> AddHero(Hero hero)
        {
            heros.Add(hero);
            return heros;
        }

        public List<Hero> DeleteHero(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hero> GetAllHeros()
        {
            return heros;
        }

        public Hero GetHero(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hero> UpdateHero(int id, Hero request)
        {
            throw new NotImplementedException();
        }
    }
}
