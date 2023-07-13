using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon
{
    class Item
    {
        protected String Name; protected String Description;

        public Item(String name, String description)
        {
            Name = name;
            Description = description;
        }
        public virtual int GetItemScrollDamage()
        {
            return 0; // DEFAULT VALUE
        }
        public virtual int GetArmorHP()
        {
            return 0; // DEFAULT VALUE
        }
        public virtual int GetHeals()
        {
            return 0; // DEFAULT VALUE
        }
        public virtual bool isItemScroll()
        {
            // IF SET TRUE - ITEM IS A SPELL SCROLL
            // IF SET FALSE - ITEM IS NOT A SPELL SCROLL
            return false;
        }
        public virtual bool isItemArmor()
        {
            // IF SET TRUE - ITEM IS ARMOR
            // IF SET FALSE - ITEM IS NOT ARMOR
            return false;
        }
        public virtual bool? EdibleOrQuenchable()
        {
            // IF SET TRUE - ITEM IS EDIBLE
            // IF SET FALSE - ITEM IS QUENCHABLE
            // IF SET NULL - ITEM IS INEDIBLE, UNQUENCHABLE.
            return null; 
        }
        public String GetName()
        {
            return Name;
        }
        public void SetName(String name)
        {
            Name = name;
        }
        public String GetDescription()
        {
            return Description;
        }
        public void SetDescription(String description)
        {
            Description = description;
        }
    }
}
