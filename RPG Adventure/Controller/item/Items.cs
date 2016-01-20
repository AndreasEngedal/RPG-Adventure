using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Adventure.Controller.item
{
    class Items
    {
        public static Item cabbage = new Item("Cabbage", "It's a cabbage.", 1);
        public static Item rubberChicken = new ItemWeapon("Rubber Chicken", "A fierce weapon", 1, 10);
        public static Item rottenFish = new ItemWeapon("Rotten Fish", "Not very useful.", -1, 10);
    }
}