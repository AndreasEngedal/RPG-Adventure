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

        public ItemWeapon(string name, string description, int value, int damage) : base(name, description, value)
        {
            Damage = damage;
        }

        public int getDamage()
        {
            return rand.Next(Damage);
        }
    }
}
