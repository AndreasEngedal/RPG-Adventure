using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Adventure
{
    class DataController
    {
        Data data;
        public List<Hero> heroes;
        public DataController()
        {
            data = new Data();
            heroes = LoadHeroes();
        }

        public List<Hero> LoadHeroes()
        {
            return data.LoadHeroes();
        }

        public void CreateHero(string name)
        {
            Hero hero = new Hero(name);
            data.CreateHero(hero);
            heroes.Add(hero);
        }

        public int DeleteHero(string name)
        {
            foreach (Hero hero in heroes)
            {
                if (hero.Name == name)
                {
                    data.DeleteHero(hero);
                    return heroes.IndexOf(hero);
                }
            }
            return -1;
        }
    }
}
