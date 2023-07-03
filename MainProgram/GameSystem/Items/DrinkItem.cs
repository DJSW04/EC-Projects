using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon
{
    class DrinkItem : Item
    {
        private int HealAmount;
        public DrinkItem(string name, string description, int heals) : base(name, description)
        {
            HealAmount = heals;
        }
        public override int GetHeals()
        {
            return base.GetHeals();
        }
        public override bool? EdibleOrQuenchable()
        {
            return false;
        }
    }
}
