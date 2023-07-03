using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon
{
    class StartMenu
    {
        GameConfig dungeonGameConfig = new GameConfig();
        Tools dungeonTools = new Tools();
        public void PlayMenu()
        {
            /* GAME INITIALISATION */
            dungeonTools.DisplayText("Welcome to...");
            Console.WriteLine();
            dungeonTools.DisplayText("______ _   _ _   _ _____  _____ _____ _   _ ");
            Console.WriteLine();
            dungeonTools.DisplayText("|  _  \\ | | | \\ | |  __ \\|  ___|  _  | \\ | |");
            Console.WriteLine();
            dungeonTools.DisplayText("| | | | | | |  \\| | |  \\/| |__ | | | |  \\| |");
            Console.WriteLine();
            dungeonTools.DisplayText("| | | | | | | . ` | | __ |  __|| | | | . ` |");
            Console.WriteLine();
            dungeonTools.DisplayText("| |/ /| |_| | |\\  | |_\\ \\| |___\\ \\_/ / |\\  |");
            Console.WriteLine();
            dungeonTools.DisplayText("|___/  \\___/\\_| \\_/\\____/\\____/ \\___/\\_| \\_/");
            Console.WriteLine();

            /* MENU */
            bool menuLoop = true;

            while (menuLoop)
            {
                dungeonTools.DisplayText("Start Game - 1");
                dungeonTools.DisplayText("Quit Game - 2");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.Clear();
                    dungeonGameConfig.PlayGame();
                    menuLoop = false;

                }
                else if (option == "2")
                {
                    menuLoop = false;
                }
                else
                {
                    Console.WriteLine("ERROR: INPUT MUST BE EITHER 1 OR 2");
                }
            }

        }
    }
}
