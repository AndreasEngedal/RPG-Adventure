using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaseCreature
    {
        public virtual int CurrentHitPoints { get; set; }
        public virtual int MaximumHitPoints { get; set; }
        public string Name { get; set; }

    }
}