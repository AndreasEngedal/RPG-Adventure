using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HealingPotion : Item
    {
        public override int ID { get { return 2; } }
        public override string Name { get { return "Healing Potion"; } }
        public override string NamePlural { get { return "Healing Potions"; } }

        public int AmountToHeal { get; set; }

        public HealingPotion(PotionType type)
        {
            if (type == PotionType.Regular)
            {
                AmountToHeal = 30;
            }
            if (type == PotionType.Lesser)
            {
                AmountToHeal = 15;
            }
            if (type == PotionType.Greater)
            {
                AmountToHeal = 45;
            }
        }
    }
}