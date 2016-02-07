using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaseWeapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        WeaponRarity rarity;

        public BaseWeapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage) : base(id, name, namePlural)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}