using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Adventure.Controller.item
{
    public class Item
    {
        public static Random rand = new Random();
        public string Name { get; set; }
        public string Description { get; set; }

        public int Value { get; set; }

        public Item(string name, string description, int value)
        {
            Name = name;
            Description = description;
            Value = value;
        }

        public bool canItemBeSold()
        {
            return Value >= 0;
        }
    }
}