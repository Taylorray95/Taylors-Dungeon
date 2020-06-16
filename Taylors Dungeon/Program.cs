using System;
using System.Threading;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Taylors_Dungeon
{
    class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;

        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            stats game = new stats();

            Console.WriteLine("Welcome to Taylor's he dungeon. What's your name young lad?");
            game.Name = Console.ReadLine();
            Console.WriteLine();
            if (game.Name == "")
            {
                Console.WriteLine("You seem to have forgotten your name. That's okay maybe you'll remember at some point in your journey.");
            }

            do
            {
                Console.WriteLine("Would you like to play on easy or hard??");
                game.difficultylevel = Console.ReadLine();

                if (game.difficultylevel != "easy" && game.difficultylevel != "hard")
                {
                    Console.WriteLine("You did not enter a correct difficulty level, please either enter 'easy' or 'hard'.");
                }
            } while (game.difficultylevel != "easy" && game.difficultylevel != "hard");
            Console.WriteLine();
            do
            {
                Console.WriteLine("What type of warrior are you? Are you a Holy Shaman, Barbarian, or a Mage?");
                game.warriortype = Console.ReadLine();

                if (game.warriortype != "holy shaman" && game.warriortype != "barbarian" && game.warriortype != "mage")
                {
                    Console.WriteLine("You did not enter a correct warrior type. Please either 'holy shaman', 'barbarian', or 'mage'");
                }
            } while (game.warriortype != "holy shaman" && game.warriortype != "barbarian" && game.warriortype != "mage");
            Console.WriteLine();
            Console.WriteLine("As a " + game.warriortype + " you have been given the following starting stats: ");
            game.CharacterCreation();
            game.outputstats();
            game.start();








            Console.ReadLine();
        }
    }
}
