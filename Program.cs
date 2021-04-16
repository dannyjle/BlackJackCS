using System;

namespace BlackJackCS
{
    class Program
    {
        static void WelcomeToBlackJack()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" Welcome to No Stakes Blackjack!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }
        static void WantToPlay()
        {
            Console.WriteLine("Are you ready to play? [Y/N]:");
            var answer = Console.ReadLine();

            if (answer == "Y" || answer == "y" | answer == "YES" | answer == "Yes" | answer == "yes")
            {
                Console.WriteLine("Let's see who Lady Luck favors!");
            }
            else
            {
                Console.WriteLine("Uhm... Ok... READY OR NOT WE ARE PLAYING!");
            }

        }
        static void Main(string[] args)
        {
            WelcomeToBlackJack();

            WantToPlay();








        }
    }
}
