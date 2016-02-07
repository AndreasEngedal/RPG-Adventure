using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Monster : BaseCreature
    {
        // Monster ID, still need to decide how to do this.       
        public int ID { get; set; }

        // Base Damage, Minimum and Maximum.
        public virtual int MinimumDamage { get { return 1; } }
        public virtual int MaximumDamage { get { return 2; } }

        // How much experience does the monster give, when killed, and how much gold/loot.
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        // public List<LootItem> LootTable { get; set; }

        // The amount of hitpoints the monster starts with. Max and Current.
        //public override int CurrentHitPoints { get { return 10; } }
        //public override int MaximumHitPoints { get { return 10; } }

        public Monster(int id, string name, int rewardExperiencePoints, int rewardGold)
        {
            ID = id;
            Name = name;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
        }
    }
}
