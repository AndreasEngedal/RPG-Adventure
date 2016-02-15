using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Skeleton : Monster
    {
        public override int ID { get { return 4; } }
        public override string Name { get { return "a skeleton"; } }

        public override int MinimumDamage { get { return 1; } }
        public override int MaximumDamage { get { return 2; } }
        public override int CurrentHitPoints { get { return 10; } }
        public override int MaximumHitPoints { get { return 10; } }

        public override int RewardExperiencePoints { get { return 5; } }
        public override int RewardGold { get { return 10; } }

        public override List<Item> LootTable { get; set; }

        private int LootChance = RandomNumber.NumberBetween(0, 100);

        public Skeleton()
        {
            if (LootChance < 10)
                LootTable.Add(new Longsword(1));
            if (LootChance < 50)
                LootTable.Add(new HealingPotion(PotionType.Lesser));
        }
    }
}
