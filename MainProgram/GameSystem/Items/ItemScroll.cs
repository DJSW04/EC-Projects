using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon
{
    class ItemScroll : Item
    {
        private int spellDamage;
        public ItemScroll(string name, string description, int damage) : base (name, description) 
        {
            spellDamage = damage;
        }
        public override bool isItemScroll()
        {
            return true;
        }
        public override int GetItemScrollDamage()
        {
            return spellDamage;
        }

    }
}
