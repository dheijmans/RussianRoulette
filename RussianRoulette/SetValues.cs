using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    class SetValues
    {
        internal static int PlayerAmount(bool invaledInput, int playerAmountBegin)
        {
            Console.Clear();
            Frame.Title();
            do
            {
                invaledInput = false;
                Console.Write("Enter the amount of players (min. 2 and max. 10): ");
                try
                {
                    playerAmountBegin = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    playerAmountBegin = 0;
                    invaledInput = true;
                }
                if (playerAmountBegin < 2 || playerAmountBegin > 10)
                {
                    invaledInput = true;
                    Frame.ClearCurrentConsoleLine();
                }
            } while (invaledInput == true);
            return playerAmountBegin;
        }
        internal static int BarrelSize(bool invaledInput, int playerAmountBegin, int barrelSize)
        {
            do
            {
                invaledInput = false;
                Console.Write("Enter the size of the barrel (min. " + playerAmountBegin + " and max. 20): ");
                try
                {
                    barrelSize = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    barrelSize = 0;
                    invaledInput = true;
                }
                if (barrelSize < playerAmountBegin || barrelSize > 20)
                {
                    invaledInput = true;
                    Frame.ClearCurrentConsoleLine();
                }
            } while (invaledInput == true);
            return barrelSize;
        }
        internal static int NewBulletSpot(int bulletSpot, int barrelSize)
        {
            if (bulletSpot == (barrelSize - 1))
            {
                bulletSpot = 0;
            }
            else
            {
                bulletSpot++;
            }
            return bulletSpot;
        }
    }
}
