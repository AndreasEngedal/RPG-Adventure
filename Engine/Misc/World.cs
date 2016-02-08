using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<LootItem> loot = new List<LootItem>();        

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Longsword(1));
            Items.Add(new HealingPotion(PotionType.Lesser));
        }

        private static void PopulateMonsters()
        {
            Monsters.Add(new Skeleton());
        }

        private static void PopulateQuests()
        {         
            //Quests.Add();
            //Quests.Add();
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(1, "Home", "Your house. You really need to clean up the place.");
            Location townSquare = new Location(2, "Town square", "You see a fountain.");            

            // Link the locations together
            home.LocationToNorth = townSquare;

            townSquare.LocationToSouth = home;            

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(townSquare);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}