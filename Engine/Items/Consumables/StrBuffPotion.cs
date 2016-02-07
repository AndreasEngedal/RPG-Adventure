using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StrBuffPotion : Item
    {
        public int AmountStrBuffed { get; set; }
        public int DurationInTurns { get; set; }

        public StrBuffPotion(int id, string name, string namePlural, int amountStrBuffed, int durationInTurns) : base(id, name, namePlural)
        {
            AmountStrBuffed = amountStrBuffed;
            DurationInTurns = durationInTurns;
        }
    }
}