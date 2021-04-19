using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    class Card
    {
        public string Rank;
        public string Suit;
        public int Value()
        {
            if (Rank == "2")
            {
                return 1;
            }
            if (Rank == "3")
            {
                return 1;
            }
            if (Rank == "4")
            {
                return 1;
            }
            if (Rank == "5")
            {
                return 1;
            }
            if (Rank == "6")
            {
                return 1;
            }
            if (Rank == "7")
            {
                return 1;
            }
            if (Rank == "8")
            {
                return 1;
            }
            if (Rank == "9")
            {
                return 1;
            }

            if (Rank == "Ace")
            {
                return 11;
            }
            else if (Rank == "Jack" || Rank == "Queen" || Rank == "King")
            {
                return 10;
            }
            else
            {
                return int.Parse(Rank);
            }
        }
    }



    class Program
    {

        // welcome code
        static void WelcomeToBlackJack()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" Welcome to No Stakes Blackjack!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine();

        }

        // start game code
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
        // endgame code
        static void WantToReplay()
        {
            var activeGame = true;
            while (activeGame != true) ;
            Console.WriteLine("Do you want to play again?");
            var answer = Console.ReadLine();
            if (answer == "Y" || answer == "y" | answer == "YES" | answer == "Yes" | answer == "yes")
            {
                activeGame = true;
                Console.WriteLine("That's the spirit!");

                // still needs method for game restart


            }
            else
            {
                activeGame = false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine();

            WelcomeToBlackJack();

            Console.WriteLine();

            WantToPlay();


            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suits = new List<string>() { "Spades", "Clubs", "Diamonds", "Hearts" };

            var deck = new List<string>();

            for (var r = 0; r < ranks.Count; r++)
            {
                for (var s = 0; s < suits.Count; s++)
                {
                    var allCards = ($"{ranks[r]} of {suits[s]}");
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

            var dealtPlayerHand = ($"{deck[0]} and {deck[2]}");
            deck.RemoveAt(0);
            deck.RemoveAt(1);

            var dealerHand = new List<string>();

            var dealtDealerHand = ($"{deck[1]} and {deck[3]}");
            deck.RemoveAt(2);
            deck.RemoveAt(3);






            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("...dealing...");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine($"So you've got {dealtPlayerHand}");


            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Do you want to Hit or Stand?");

            Console.WriteLine("-----------------------------");

            var answer = Console.ReadLine();

            Console.WriteLine();


            if (answer == "Hit" || answer == "hit" | answer == "HIT")
            {
                Console.WriteLine($"Next card is {deck[0]}.");

                var playerFirstHand = ($"{dealtPlayerHand} and {deck[0]}");
                playerHand.Add($"deck[0]");
                deck.RemoveAt(0);

                Console.WriteLine();

                Console.WriteLine("-----------------------------");

                Console.WriteLine("Okay hit");

                Console.WriteLine("-----------------------------");

                Console.WriteLine();

                Console.WriteLine($"Your hand is now {playerFirstHand}");


                // code for value evaluation to see if bust and replay prompt

            }
            else if (answer == "Stand" || answer == "stand" | answer == "STAND")
            {
                Console.WriteLine();
                Console.WriteLine("Okay dealers turn...");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Dealer has {dealtDealerHand}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.WriteLine($"Dealer gets a {deck[0]}.");

            var dealerFirstHand = ($"{dealtDealerHand} and {deck[0]}");
            dealerHand.Add($"deck[0]");
            deck.RemoveAt(0);



            WantToReplay();
            Console.WriteLine("Let's try your luck again real soon!");
        }
    }
}
