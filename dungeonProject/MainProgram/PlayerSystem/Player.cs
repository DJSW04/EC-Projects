using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace dungeon
{
    class Player
    {
        Tools dungeonTools = new Tools();

        // attributes/properties
        private int Health;
        private int ArmorHealth;
        private Room Location;
        private List<Item> Inventory = new List<Item>();
        private Dictionary<string, int> SpellBook = new Dictionary<string, int> { };
        private Random random;

        public Player(int health, int armorHP)
        {
            Health = health;
            ArmorHealth = armorHP;

            Health += ArmorHealth;
            random = new Random();
        }
        public void AddItem(Item item)
        {
            Inventory.Add(item);
        }
        public int GetHealth()
        {
            return Health;
        }
        public int GetArmorHP()
        {
            return ArmorHealth;
        }
        public void SetHealth(int health)
        {
            Health = health;
        }
        public Room GetLocation()
        {
            return Location;
        }
        public void SetLocation(Room location)
        {
            Location = location;
            Console.WriteLine(Location.GetDescription());

        }
        // other methods
        public int AdjustHealth(int health)
        {
            Health += health;
            return Health;
        }
        public Boolean DoCommand(String command)
        {
            if (command == "QUIT")
            {
                return true;
            }

            List<String> instructions = command.Split(' ').ToList();

            switch (instructions[0])
            {
                case "read":
                    if (instructions.Count <= 1) { Console.WriteLine("Read what item? [ITEM NOT SPECIFIED]"); }
                    else { Read(instructions[1]); }
                    break;

                case "spellbook":
                    Console.WriteLine();
                    foreach (KeyValuePair<string, int> pair in SpellBook)
                    {
                        dungeonTools.DisplayText($"Spell: {pair.Key}, Damage: {pair.Value}");
                    }
                    break;

                case "look":
                    Console.WriteLine(Location.GetDescription());
                    break;

                case "health": case "h":
                    if (ArmorHealth > 0) { dungeonTools.DisplayText($"Your armor has {ArmorHealth} Hit Points"); dungeonTools.DisplayText($"You have a total {Health} Hit Points."); }
                    else { Console.WriteLine($"You have a total {Health} Hit Points."); }
                    break;

                case "armor":
                    if (ArmorHealth > 0) { dungeonTools.DisplayText($"Your armor has {ArmorHealth} durability left"); }
                    else { dungeonTools.DisplayText("Your armor is broken."); }
                    break;

                case "move": case "go":
                    if (instructions.Count <= 1) { Console.WriteLine("Move where? [DIRECTION NOT SPECIFIED]"); }
                    else { Move(instructions[1]); }
                    break;

                case "get": case "take":
                    if (instructions.Count <= 1) { Console.WriteLine("Eat what item? [ITEM NOT SPECIFIED]"); }
                    else { Take(instructions[1]); }
                    break;

                case "attack":
                    Creature deadCreature = null;
                    foreach (Creature creature in Location.GetCreatures())
                    {
                        if (creature.GetName() == instructions[1])
                        {
                            int damage = random.Next(1, 100);
                            bool dead = creature.TakeDamage(damage);
                            if (dead)
                            {
                                Console.WriteLine($"Your attack killed the {creature.GetName()}");
                                deadCreature = creature;
                            }
                            else
                            {
                                Console.WriteLine($"Your attack caused the {creature.GetName()} to lose {damage} health.");
                                Health -= creature.GetAttackDamage();
                                if (Health < 0)
                                {
                                    Console.WriteLine("You die.");
                                    return true;
                                }
                                else { return false; }
                            }
                        }
                    }
                    if (deadCreature != null) { Location.RemoveCreature(deadCreature); }
                    break;
                case "cast":
                    if (instructions.Count < 3)
                    {
                        Console.WriteLine("Cast which spell at which target? [SPELL OR TARGET NOT SPECIFIED]");
                    }
                    else
                    {
                        string spell = instructions[1];
                        string target = instructions[2];
                        Creature creatureToRemove = null;

                        if (SpellBook.ContainsKey(spell))
                        {
                            foreach (Creature creature in Location.GetCreatures())
                            {
                                if (creature.GetName() == target)
                                {
                                    bool dead = creature.TakeSpellDamage(spell, SpellBook[spell]);
                                    if (dead)
                                    {
                                        Console.WriteLine($"Your {spell} killed the {creature.GetName()}");
                                        creatureToRemove = creature;
                                    }
                                    else
                                    {
                                        Health -= creature.GetAttackDamage();
                                        if (Health < 0)
                                        {
                                            Console.WriteLine("You die.");
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                }
                            }
                            if (creatureToRemove != null)
                            {
                                Location.RemoveCreature(creatureToRemove);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You don't know that spell!");
                        }
                    }
                    break;

                case "examine":
                case "inspect":
                    if (instructions.Count <= 1)
                    {
                        Console.WriteLine("Examine what? [ITEM NOT SPECIFIED]");
                    }
                    else
                    {
                        for (int i = 0; i < Inventory.Count; i++)
                        {
                            if (instructions[1] == Inventory[i].GetName())
                            {
                                Console.WriteLine(Inventory[i].GetDescription());
                            }
                        }

                    }
                    break;

                case "eat":
                    if (instructions.Count <= 1) { Console.WriteLine("Eat what item? [ITEM NOT SPECIFIED]"); }
                    else { Eat(instructions[1]); }
                    break;

                case "drink":
                    if (instructions.Count <= 1) { Console.WriteLine("Drink what item? [ITEM NOT SPECIFIED]"); }
                    else { Drink(instructions[1]); }
                    break;
                case "wear":
                    if (instructions.Count <= 1) { Console.WriteLine("Wear what item? [ITEM NOT SPECIFIED]"); }
                    else { Wear(instructions[1]); }
                    break;

                case "inventory":
                case "i":
                    String items = "\n";

                    if (Inventory.Count > 0)
                    {
                        if (Inventory.Count == 1)
                        {
                            items += $"You have the following item: {Inventory[0].GetName()}.";
                        }
                        else
                        {
                            items += $"You have the following items: {Inventory[0].GetName()}";
                            for (int i = 1; i < Inventory.Count - 1; i++)
                            {
                                items += ", " + Inventory[i].GetName();
                            }
                            items += $" and {Inventory[Inventory.Count - 1].GetName()}.";
                        }
                    }
                    else
                    {
                        items += "You aren't carrying anything.";
                    }
                    Console.WriteLine(items);
                    break;
                default:
                    Console.WriteLine("You can't do that!");
                    break;
            }

            return false; // they didn't quit
        }

        private void Wear(string armor)
        {
            int armorPosition; int armorHP;
            for (armorPosition = 0; armorPosition < Inventory.Count; armorPosition++)
            {
                if (Inventory[armorPosition].GetName() == armor)
                {
                    if (Inventory[armorPosition].isItemArmor() == true)
                    {
                        armorHP = Inventory[armorPosition].GetArmorHP();

                        if (ArmorHealth > 0)
                        {
                            ArmorHealth = 0;
                            ArmorHealth += armorHP;
                            dungeonTools.DisplayText("You have discarded your previous armor");
                            dungeonTools.DisplayText($"You have worn {armor}");
                            Inventory.RemoveAt(armorPosition);
                            Health += ArmorHealth;
                            break;
                        }
                        else
                        {
                            ArmorHealth += armorHP;
                            dungeonTools.DisplayText($"You have worn {armor}");
                            Inventory.RemoveAt(armorPosition);
                            Health += ArmorHealth;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This item is not wearable.");
                        break;
                    }
                }
            }
        }

        private void Read(string scroll)
        {
            int scrollPosition; int scrollDamage;
            for (scrollPosition = 0; scrollPosition < Inventory.Count; scrollPosition++)
            {
                if (Inventory[scrollPosition].GetName() == scroll)
                {
                    if (Inventory[scrollPosition].isItemScroll() == true)
                    {
                        scrollDamage = Inventory[scrollPosition].GetItemScrollDamage();
                        Console.WriteLine($"You have learnt {scroll}");
                        SpellBook.Add(scroll, scrollDamage);
                        Inventory.RemoveAt(scrollPosition);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This item is unreadable.");
                        break;
                    }
                }
            }
        }
        private void Take(string name)
        {
            List<Item> ExistingItems = Location.GetContents();

            int itemPosition; 

            for (itemPosition = 0; itemPosition < ExistingItems.Count; itemPosition++) 
            {
                if (ExistingItems[itemPosition].GetName() == name) 
                {
                    Inventory.Add(ExistingItems[itemPosition]);
                    foreach (Item item in ExistingItems)
                    {
                        ExistingItems.Remove(item);
                    }
                    Location.RemoveItem(name);
                    Console.WriteLine($"You have taken {name}");
                }
                if (ExistingItems[itemPosition].GetName() != name && itemPosition == ExistingItems.Count - 1)
                {
                    Console.WriteLine("No such item exists within the room");
                }
            }

        }

        private void Move(String direction)
        {
            List<String> exits = Location.GetDirections();
            Boolean directionFound = false;

            for (int i = 0; i < exits.Count; i++)
            {
                if (direction == exits[i])
                {
                    directionFound = true;
                    if (!Location.GetConnections()[i].GoThrough(this, direction))
                    {
                        Console.WriteLine($"You can't go {direction}");
                    }
                }
            }

            if (!directionFound)
            {
                Console.WriteLine($"There is no exit to the {direction}");
            }
        }
        private void Eat(string food)
        {
            int foodPosition;
            for (foodPosition = 0; foodPosition < Inventory.Count; foodPosition++)
            {
                if (Inventory[foodPosition].GetName() == food)
                {
                    if (Inventory[foodPosition].EdibleOrQuenchable() == true)
                    {
                        dungeonTools.DisplayText($"You have eaten {food}");
                        Health += Inventory[foodPosition].GetHeals();
                        Inventory.RemoveAt(foodPosition);
                        break;
                    }
                    else if (Inventory[foodPosition].EdibleOrQuenchable() == false)
                    {
                        dungeonTools.DisplayText("This item is not edible but quenchable");
                        Console.WriteLine("TRY COMMAND PREFIX: drink");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This item is inedible and unquenchable");
                        break;
                    }
                }
            }
        }
        private void Drink(string drink)
        {
            int foodPosition;
            for (foodPosition = 0; foodPosition < Inventory.Count; foodPosition++)
            {
                if (Inventory[foodPosition].GetName() == drink)
                {
                    if (Inventory[foodPosition].EdibleOrQuenchable() == false)
                    {
                        dungeonTools.DisplayText($"You have drunk {drink}");
                        Health += Inventory[foodPosition].GetHeals();
                        Inventory.RemoveAt(foodPosition);
                        break;
                    }
                    else if (Inventory[foodPosition].EdibleOrQuenchable() == true)
                    {
                        dungeonTools.DisplayText("This item is not quenchable but edible");
                        Console.WriteLine("TRY COMMAND PREFIX: eat");
                        break;
                    }
                    else
                    {
                        dungeonTools.DisplayText("This item is inedible and unquenchable");
                        break;
                    }
                }
            }
        }
    }
}
