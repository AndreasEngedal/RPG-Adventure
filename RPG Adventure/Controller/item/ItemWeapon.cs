using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Adventure.Controller.item
{
    class ItemWeapon : Item
    {
        public int Damage { get; set; }

        public ItemWeapon(string name, int value, int damage) : base(name, value)
        {
            Damage = damage;
        }
    }
}
