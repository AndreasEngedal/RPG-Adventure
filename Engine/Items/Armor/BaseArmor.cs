using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaseArmor : Item
    {        

        public bool m_Identified;
        public int m_HitPointBonus { get; set; }

        public virtual double Weight { get; set; }
        public virtual int ArmorBase { get { return 0; } }
        public virtual int StrRequirement { get; set; }

        public BaseArmor(int id, string name, string namePlural) : base(id, name, namePlural)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
        }

        public bool Identified
        {
            get { return m_Identified; }
            set { m_Identified = value; }
        }
    }
}
