using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StrBuffPotion : Item
    {
        public override int ID { get { return 3; } }
        public override string Name { get { return "Strength Potion"; } }
        public override string NamePlural { get { return "Strength Potions"; } }

        public int AmountStrBuffed { get; set; }
        public int DurationInTurns { get; set; }

        public StrBuffPotion(PotionType type)
        {
            if (type == PotionType.Lesser)
            {
                AmountStrBuffed = 5;
                DurationInTurns = 3;
            }
            if (type == PotionType.Regular)
            {
                AmountStrBuffed = 10;
                DurationInTurns = 5;
            }
            if (type == PotionType.Greater)
            {
                AmountStrBuffed = 15;
                DurationInTurns = 8;
            }
        }
    }
}