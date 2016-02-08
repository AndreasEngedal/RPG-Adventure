using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Item
    {
        public virtual int ID { get { return 0; } }
        public virtual int LootTier { get; set; }
        
        public virtual string Name { get { return "Dummy Item"; } }
        public virtual string NamePlural { get { return "Dummy Items"; } }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }

        public Item()
        {

        }
    }
}