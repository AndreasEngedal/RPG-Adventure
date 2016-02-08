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
        public virtual int ID { get; set; }

        // Base Damage, Minimum and Maximum.
        public virtual int MinimumDamage { get { return 1; } }
        public virtual int MaximumDamage { get { return 2; } }

        // How much experience does the monster give, when killed, and how much gold/loot.
        public virtual int RewardExperiencePoints { get { return 0; } }
        public virtual int RewardGold { get { return 0; } }

        // Monster's Inventory
        public virtual List<Item> LootTable { get; set; }

        // The amount of hitpoints the monster starts with. Max and Current.
        //public override int CurrentHitPoints { get { return 10; } }
        //public override int MaximumHitPoints { get { return 10; } }

        public Monster()
        {

        }
    }
}
