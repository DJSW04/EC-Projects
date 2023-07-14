using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon
{
    class ArmorItem : Item
    {
        private int ArmorHP;

        public ArmorItem(string name, string description, int AHP) : base(name, description)
        {
            ArmorHP = AHP;
        }
        public override bool isItemArmor()
        {
            return true;
        }
        public override int GetArmorHP()
        {
            return ArmorHP;
        }
    }
}
