using System;
using System.Collections.Generic;

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


            var cards = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suits = new List<string>() { "Spades", "Clubs", "Diamonds", "Hearts" };

            var deck = new List<string>();

            for (var c = 0; c < cards.Count; c++)
            {
                for (var s = 0; s < suits.Count; s++)
                {
                    var allCards = ($"{cards[c]} of {suits[s]}");
                    deck.Add(allCards);
                }

            }

            foreach (var all in deck) ;

            var numberOfCards = deck.Count;

            for (var rightIndex = numberOfCards - 1; rightIndex >= 0; rightIndex--)
            {
                var leftIndex = new Random().Next(0, rightIndex);
                // Placeholder for rightcard
                var rightCard = deck[rightIndex];
                // Placeholder for leftcard
                var leftCard = deck[leftIndex];

                deck[leftIndex] = rightCard;
                deck[rightIndex] = leftCard;

            }

            foreach (var all in deck) ;

            Console.WriteLine();



            var playerHand = new List<string>();

            var firstHand = ($"{deck[0]} and {deck[1]}");

            foreach (var hand in firstHand)
            {
                playerHand.Add(firstHand);
            }
            Console.WriteLine();
            Console.WriteLine("...dealing...");
            Console.WriteLine();
            Console.WriteLine($"So {firstHand}");





            // if (cards == Ace)
            // {
            //     var Ace = 11;
            // }





            Console.WriteLine($"So you've got the {deck[0]} and the {deck[1]}");

            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Do you want to Hit or Stand?");

            var answer = Console.ReadLine();

            if (answer == "Hit" || answer == "hit" | answer == "HIT")
            {
                Console.WriteLine($"Next card is {deck[4]}.");
            }
            else if (answer == "Stand" || answer == "stand" | answer == "STAND")
            {
                // command for standing
            }

            Console.WriteLine("-----------------------------");



            // if (cards == Ace)
            // {
            //     var Ace = 11;
            // }





        }
    }
}
