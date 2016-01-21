using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Adventure
{
    class Hero
    {
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public byte Level { get; set; }
        public int Experience { get; set; }
        public int Coins { get; set; }

        public Hero(string name)
        {
            Name = name;
            MaxHealth = 20;
            CurrentHealth = MaxHealth;
            MinDamage = 1;
            MaxDamage = 3;
            Level = 1;
            Experience = 0;
            Coins = 0;
            
        }
        public Hero()
        {

        }
    }
}
