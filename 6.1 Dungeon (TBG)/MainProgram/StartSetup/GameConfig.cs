using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon
{
    class GameConfig
    {
        Tools dungeonTools = new Tools();

        private const int STARTING_HEALTH = 100;
        private const int STARTING_AHP = 0;
        public void PlayGame()
        {
            String command = "";
            Boolean gameOver = false;

            // Room configuration
            Room startRoom = new Room("You are in the starting cave.");
            Room lavaRoom = new Room("You are in a dark cave with a glowing river of lava.");
            Room caveRoom = new Room("You are in a dark and dreary cave.");

            // Item configuration
            Item stoneApple = new Item("sapple", "a beautiful apple made of stone.");
            Item glass = new Item("glass", "glassy glass.");

            // FoodItem configuration
            FoodItem apple = new FoodItem("apple", "a beautiful rosy red apple, it looks delicious.", 10);
            DrinkItem water = new DrinkItem("water", "Everian, the best!.", 10);

            // ItemScroll configuration
            ItemScroll firebolt = new ItemScroll("fireboltScroll", "Consumed upon reading, adds firebolt to spellbook", 50);

            // ArmorItem configuration
            ArmorItem woodarmor = new ArmorItem("woodenArmor", "Armor made of wood [ITEM IS CONSUMED UPON WEARING]", 10);

            // Chest configuration
            Chest<Item> chest = new Chest<Item>("woodenChest", "A chest made of wood which seems to contain items within");

            // Creature configuration
            DragonCreature dragon = new DragonCreature();
            GoblinCreature goblin = new GoblinCreature();

            /* Room-To-Room (Connection) configuration */

            // STARTROOM
            startRoom.AddConnection(new Connection(startRoom, lavaRoom, "north"));
            // LAVAROOM
            lavaRoom.AddConnection(new Connection(lavaRoom, startRoom, "south"));
            lavaRoom.AddConnection(new Connection(lavaRoom, caveRoom, "east"));
            // CAVEROOM
            caveRoom.AddConnection(new Connection(caveRoom, lavaRoom, "west"));

            //-----------------------------------------------------------------------
            // Chest Items configuration

            // Room Items configuration
            startRoom.AddItem(apple);
            startRoom.AddItem(glass);
            startRoom.AddItem(firebolt);
            startRoom.AddItem(woodarmor);


            // Room MOB configuration
            lavaRoom.AddCreature(dragon);
            caveRoom.AddCreature(goblin);

            // Player configuration
            Player pc = new Player(STARTING_HEALTH, STARTING_AHP);
            pc.SetLocation(startRoom);
            pc.AddItem(apple);
            pc.AddItem(water);
            pc.AddItem(stoneApple);

            /* GAME IN PROGRESS */
            while (!gameOver)
            {
                Console.WriteLine();
                dungeonTools.DisplayText("What would you like to do? ");
                command = Console.ReadLine();
                gameOver = pc.DoCommand(command);
            }

            /* GAME END MESSAGE */
            dungeonTools.DisplayText("Thank you for playing Dungeon! See you again soon, brave dungeoneer.");
            Console.ReadLine();
        }
    }
}
