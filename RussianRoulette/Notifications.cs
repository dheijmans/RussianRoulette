using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    class Notifications
    {
        internal static void Choice(int playerAmount, int playerAmountBegin, string name, bool barrel, bool pass)
        {
            Console.Clear();
            Frame.Alive(playerAmount, playerAmountBegin);
            Frame.Title();
            Console.WriteLine(name + ", what do you want?");
            Console.WriteLine();
            Console.WriteLine("Shoot (1)");
            if (barrel == false)
            {
                Console.WriteLine("Turn the barrel and shoot (2)");
            }
            if (pass == false)
            {
                Console.WriteLine("Pass on (3)");
            }
            Console.WriteLine();
        }
        internal static void Pass(string name)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(name + " passed the gun!");
            Console.ResetColor();
        }

        internal static void Shot(string name)
        {
            Console.WriteLine();
            Console.WriteLine(name + " has shot!");
            Console.WriteLine();
        }
        internal static void TurnedBarrel(string name)
        {
            Console.WriteLine();
            Console.WriteLine(name + " turned the barrel and had shot!");
            Console.WriteLine();
        }
        internal static void Survived(string name)
        {
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name + " survived!");
            Console.ResetColor();
        }

        internal static void Isdead(string name)
        {
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(name + " is dead!");
            Console.ResetColor();
        }

        internal static void Continue(int yPosition)
        {
            Console.SetCursorPosition(0, yPosition);
            Console.WriteLine();
            Console.Write("Press any key to continue ");
            Console.ReadKey();
        }

        internal static string PlayAgain(string playAgainInput)
        {
            Console.WriteLine();
            Console.Write("Enter 'a' to play again: ");
            playAgainInput = Console.ReadLine();
            return playAgainInput;
        }
    }
}
