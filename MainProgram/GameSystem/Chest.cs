using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon
{
    class Chest<Items>
    {
        protected String Name; protected String Description;
        private List<Chest<Item>> ChestItems = new List<Chest<Item>>();
        public Chest(String name, String description)
        {
            Name = name;
            Description = description;
        }
        public String GetName()
        {
            return Name;
        }
        public String GetDescription()
        {
            return Description;
        }
    }
}
