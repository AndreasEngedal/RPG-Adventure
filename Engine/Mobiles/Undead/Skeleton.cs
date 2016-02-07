using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Skeleton : Monster
    {    
        public override int MinimumDamage { get { return 1; } }
        public override int MaximumDamage { get { return 2; } }
        public override int CurrentHitPoints { get { return 10; } }
        public override int MaximumHitPoints { get { return 10; } }

        // public List<LootItem> LootTable { get; set; }

        public Skeleton(int id, string name, int rewardExperiencePoints, int rewardGold) : base(id, name, rewardExperiencePoints, rewardGold)
        {
            ID = id;
            Name = name;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
        }
    }
}
