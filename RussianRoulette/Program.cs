using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Player[] player = new Player[10];
                int playerAmountBegin = 0;
                int playerAmount;
                bool doubleName;
                int barrelSize = 0;
                bool gameIsOn = true;
                Random random = new Random();
                int bulletSpot;
                int choice;
                bool invaledInput = false;
                int yPosition;
                string playAgainInput = "";
                playerAmountBegin = SetValues.PlayerAmount(invaledInput, playerAmountBegin);
                playerAmount = playerAmountBegin;
                Frame.Clear();
                for (int i = 0; i < playerAmountBegin; i++)
                {
                    do
                    {
                        invaledInput = false;
                        doubleName = false;
                        Console.Write("Enter the name of player " + (i + 1) + " (max. 10 characters): ");
                        try
                        {
                            player[i] = new Player(Console.ReadLine());
                        }
                        catch
                        {
                            player[i].Name = "";
                            invaledInput = true;
                        }
                        for (int j = 0; j < playerAmountBegin; j++)
                        {
                            if (i <= j)
                            {
                                continue;
                            }
                            if (player[i].Name.Trim() == player[j].Name.Trim())
                            {
                                doubleName = true;
                            }
                        }
                        if (player[i].Name.Trim() == "" || player[i].Name.Trim().Length > 10 || doubleName == true)
                        {
                            invaledInput = true;
                            Frame.ClearCurrentConsoleLine();
                        }
                    } while (invaledInput == true);
                }
                Frame.Clear();
                barrelSize = SetValues.BarrelSize(invaledInput, playerAmountBegin, barrelSize);
                bulletSpot = random.Next(0, (barrelSize - 1));
                while (gameIsOn)
                {
                    for (int i = 0; i < playerAmountBegin; i++)
                    {
                        if (player[i].Alive == false)
                        {
                            continue;
                        }
                        Notifications.Choice(playerAmount, playerAmountBegin, player[i].Name, player[i].Barrel, player[i].Pass);
                        do
                        {
                            Console.Write("Your choice: ");
                            invaledInput = false;
                            try
                            {
                                choice = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                choice = 0;
                                invaledInput = true;
                            }
                            if (choice == 1)
                            {
                                yPosition = 28;
                                Notifications.Shot(player[i].Name);
                                if (bulletSpot == 0)
                                {
                                    Notifications.Isdead(player[i].Name);
                                    player[i].Alive = false;
                                    playerAmount--;
                                    bulletSpot = random.Next(0, (barrelSize - 1));
                                }
                                else
                                {
                                    Notifications.Survived(player[i].Name);
                                    bulletSpot = SetValues.NewBulletSpot(bulletSpot, barrelSize);
                                }
                            }
                            else if (choice == 2 && player[i].Barrel == false)
                            {
                                yPosition = 28;
                                Notifications.TurnedBarrel(player[i].Name);
                                bulletSpot = SetValues.NewBulletSpot(bulletSpot, barrelSize);
                                if (bulletSpot == 0)
                                {
                                    Notifications.Isdead(player[i].Name);
                                    player[i].Alive = false;
                                    playerAmount--;
                                    bulletSpot = random.Next(0, (barrelSize - 1));
                                }
                                else
                                {
                                    Notifications.Survived(player[i].Name);
                                    bulletSpot = SetValues.NewBulletSpot(bulletSpot, barrelSize);
                                }
                                player[i].Barrel = true;
                            }
                            else if (choice == 3 && player[i].Pass == false)
                            {
                                yPosition = 26;
                                Notifications.Pass(player[i].Name);
                                player[i].Pass = true;
                            }
                            else
                            {
                                yPosition = 28;
                                invaledInput = true;
                                Frame.ClearCurrentConsoleLine();
                            }
                        } while (invaledInput == true);
                        Frame.Alive(playerAmount, playerAmountBegin);
                        Notifications.Continue(yPosition);
                        if (playerAmount == 1)
                        {
                            gameIsOn = false;
                            break;
                        }
                    }
                }
                Frame.Clear();
                for (int i = 0; i < playerAmountBegin; i++)
                {
                    if (player[i].Alive == true)
                    {
                        Console.WriteLine(player[i].Name + " won the game!");
                    }
                }
                playAgainInput = Notifications.PlayAgain(playAgainInput);
                if (playAgainInput.Trim() == "a")
                {
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);
        }
    }
}
