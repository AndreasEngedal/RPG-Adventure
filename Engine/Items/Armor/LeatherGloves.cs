using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LeatherGloves : BaseArmor
    {
        public override int ArmorBase { get { return 3; } }
        public override double Weight { get { return 1.0; } }
        public override int StrRequirement { get { return 0; } }

        public LeatherGloves()
        {
            Identified = false;
        }
    }
}
