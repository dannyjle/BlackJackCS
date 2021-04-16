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
            Console.WriteLine();

            WelcomeToBlackJack();

            Console.WriteLine();

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

            var dealerHand = new List<string>();

            var secondHand = ($"{deck[2]} and {deck[3]}");

            foreach (var hand in secondHand)
            {
                playerHand.Add(secondHand);
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("...dealing...");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine($"So you've got {firstHand}");





            // if (cards == Ace)
            // {
            //     var Ace = 11;
            // }



            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Do you want to Hit or Stand?");

            Console.WriteLine("-----------------------------");

            var answer = Console.ReadLine();

            Console.WriteLine();

            playerHand.Clear();

            if (answer == "Hit" || answer == "hit" | answer == "HIT")
            {
                Console.WriteLine($"Next card is {deck[4]}.");
                var thirdHand = ($"{deck[2]},{deck[3]}, and {deck[4]}");

                foreach (var hand in thirdHand)
                {
                    playerHand.Add(thirdHand);
                }
            }
            else if (answer == "Stand" || answer == "stand" | answer == "STAND")
            {
                // command for standing
            }

            Console.WriteLine($"{playerHand}");
            Console.WriteLine("-----------------------------");



            // if (cards == Ace)
            // {
            //     var Ace = 11;
            // }





        }
    }
}
