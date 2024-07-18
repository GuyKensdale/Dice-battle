using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int pcRandomNum;


            int playerPoints = 0;
            int pcPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                pcRandomNum = random.Next(1, 7);
                Console.WriteLine("The computer rolled a " + pcRandomNum);

                if (playerRandomNum > pcRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Well done!");
                }
                else if (pcRandomNum > playerRandomNum)
                {
                    pcPoints++;
                    Console.WriteLine("Unlucky better bring your A game!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                    playerPoints++;
                    pcPoints++;
                }
                Console.WriteLine("the score is now " + playerPoints + " to you and " + pcPoints + " to the computre!");
                Console.WriteLine();
            }
            if (playerPoints > pcPoints)
            {
                Console.WriteLine("Well done you win!");
            }
            else if (pcPoints > playerPoints)
            {
                Console.WriteLine("Better luck next time!");
            }
            else
            {
                Console.WriteLine("Its a Draw!");
            }

            Console.ReadKey();
        }
    }
}
