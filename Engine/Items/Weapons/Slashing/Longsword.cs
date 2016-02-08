using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Longsword : BaseWeapon
    {
        public override int ID { get { return 1; } }        

        public override int MinimumDamage { get { return 2; } }
        public override int MaximumDamage { get { return 4; } }

        public override string Name { get { return "Long Sword"; } }
        public override string NamePlural { get { return "Long Swords"; } }

        public override WeaponType DamageType { get { return WeaponType.Slashing; } }
        public override WeaponRarity Rarity { get; set; }
        public override WeaponQuality Quality { get; set; }
        public override WeaponAccuracy Accuracy { get; set; }
        public override WeaponDurabilityLevel Durability { get; set; }

        private int betterLootChance = RandomNumber(0, 100);

        public Longsword(int lootTier) : base(lootTier)
        {            
            if (lootTier == 0 )
            {
                if (betterLootChance < 10)
                    Rarity = WeaponRarity.Uncommon;
                else
                    Rarity = WeaponRarity.Common;
            }
            if (lootTier == 1)
            {
                if (betterLootChance < 10)
                    Rarity = WeaponRarity.Rare;
                else
                    Rarity = WeaponRarity.Uncommon;
            }
        }
    }
}
