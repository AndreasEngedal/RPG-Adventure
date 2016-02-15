using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Player : BaseCreature
    {
        public Location CurrentLocation { get; set; }

        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public virtual int Strength { get { return 10; } }
        public virtual int Dexterity { get { return 10; } }
        public virtual int Intelligence { get { return 10; } }
        
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level, string name, List<InventoryItem> inventory, List<PlayerQuest> quests)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            Name = name;
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;

            Inventory = inventory;
            Quests = quests;
        }

        public Player( int experiencePoints, int level, string name)
        {
            Gold = 10;
            ExperiencePoints = experiencePoints;
            Level = level;
            Name = name;
            CurrentHitPoints = 10;
            MaximumHitPoints = 10;

            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }

        public Player( string name )
        {
            Gold = 10;
            ExperiencePoints = 0;
            Level = 1;
            Name = name;
            CurrentHitPoints = 10;
            MaximumHitPoints = 10;

            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}
