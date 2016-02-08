using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaseWeapon : Item
    {
        public virtual int MinimumDamage { get { return 1; } }
        public virtual int MaximumDamage { get { return 2; } }

        public override int LootTier { get; set; }

        public virtual WeaponType DamageType { get; set; }
        public virtual WeaponRarity Rarity { get; set; }
        public virtual WeaponQuality Quality { get; set; }
        public virtual WeaponAccuracy Accuracy { get; set; }
        public virtual WeaponDurabilityLevel Durability { get; set; }

        public BaseWeapon(int lootTier)
        {
            LootTier = lootTier;
        }
    }
}