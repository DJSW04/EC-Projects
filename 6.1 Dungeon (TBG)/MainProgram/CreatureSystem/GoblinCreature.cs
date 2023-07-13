using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon
{
    class GoblinCreature : Creature
    {
        public GoblinCreature() : base("Goblin", 10) { } // GoblinCreature inherits base attributes
        public override int GetAttackDamage()
        {
            int attackDamage = base.GetAttackDamage();
            //CRITICAL HIT (RANDOM CHANCE)
            if (attackDamage >= 7)
            {
                Console.WriteLine($"The goblin lands a critical hit! (-{attackDamage} Hit Points)");
                return attackDamage;
            }

            else
            {
                Console.WriteLine($"The goblin charges at you and lands a hit! (-{attackDamage} Hit Points)");
                return attackDamage;
            }
        }
    }
}
