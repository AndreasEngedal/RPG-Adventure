using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Longsword : BaseWeapon
    {
        public Longsword(int id, string name, string namePlural, int minimumDamage, int maximumDamage)  :  base(id, name, namePlural, minimumDamage, maximumDamage)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
