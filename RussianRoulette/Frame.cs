using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    class Frame
    {
        internal static void Title()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(@"   __               _             
  /__\_   _ ___ ___(_) __ _ _ __  
 / \// | | / __/ __| |/ _` | '_ \ 
/ _  \ |_| \__ \__ \ | (_| | | | |
\/ \_/\__,_|___/___/_|\__,_|_| |_|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"   __             _      _   _       
  /__\ ___  _   _| | ___| |_| |_ ___ 
 / \/// _ \| | | | |/ _ \ __| __/ _ \
/ _  \ (_) | |_| | |  __/ |_| ||  __/
\/ \_/\___/ \__,_|_|\___|\__|\__\___|");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@" ____    ___  
|___ \  / _ \ 
  __) || | | |
 / __/ | |_| |
|_____(_)___/ 

");
            Console.ResetColor();
        }
        internal static void Alive(int playerAmount, int playerAmountBegin)
        {
            Console.SetCursorPosition(20, 11);
            Console.WriteLine("┌────────────────────────┐");
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("│    Players Alive:      │");
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("│    Players Dead:       │");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("└────────────────────────┘");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine(playerAmount);
            Console.SetCursorPosition(39, 13);
            Console.WriteLine(playerAmountBegin - playerAmount);
        }
        internal static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = (Console.CursorTop - 1);
            Console.SetCursorPosition(0, (Console.CursorTop - 1));
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        internal static void Clear()
        {
            Console.Clear();
            Frame.Title();
        }
    }
}
