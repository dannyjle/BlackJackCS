﻿using System;
using System.Collections.Generic;

namespace BlackJackCS
{

    class Hand
    {
        public List<Card> IndividualCards { get; set; } = new List<Card>();

        public void Receive(Card newCard)
        {
            IndividualCards.Add(newCard);
        }
        public int TotalValue()
        {
            var total = 0;
            foreach (var card in IndividualCards)
            {
                total += card.Value();
            }
            return total;
        }


    }

    class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }

        public int Value()
        {
            var theCardValue = 0;
            if (Rank == "2")
            {
                theCardValue = 2;
            }
            else if (Rank == "3")
            {
                theCardValue = 3;
            }
            else if (Rank == "4")
            {
                theCardValue = 4;
            }
            else if (Rank == "5")
            {
                theCardValue = 5;
            }
            else if (Rank == "6")
            {
                theCardValue = 6;
            }
            else if (Rank == "7")
            {
                theCardValue = 7;
            }
            else if (Rank == "8")
            {
                theCardValue = 8;
            }
            else if (Rank == "9")
            {
                theCardValue = 9;
            }
            else if (Rank == "10")
            {
                theCardValue = 10;
            }
            else if (Rank == "Jack")
            {
                theCardValue = 10;
            }
            else if (Rank == "Queen")
            {
                theCardValue = 10;
            }
            else if (Rank == "King")
            {
                theCardValue = 10;
            }
            else if (Rank == "Ace")
            {
                theCardValue = 11;
            }
            return theCardValue;
        }

        public string Title()
        {
            var newTitleString = $"The {Rank} of {Suit} - this awards {Value()} points!";

            return newTitleString;
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

                // still needs class for game restart


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

            //creating the deck
            var deck = new List<Card>();
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suits = new List<string>() { "Spades", "Clubs", "Diamonds", "Hearts" };


            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    var card = new Card { Suit = suit, Rank = rank };
                    deck.Add(card);
                }

            }

            // shuffle
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

            foreach (var card in deck) ;

            Console.WriteLine();

            var playerHand = new Hand();
            var dealerHand = new Hand();

            var newCard = deck[0];
            deck.Remove(newCard);

            playerHand.Receive(newCard);

            newCard = deck[0];
            deck.Remove(newCard);

            playerHand.Receive(newCard);

            newCard = deck[0];
            deck.Remove(newCard);

            dealerHand.Receive(newCard);

            newCard = deck[0];
            deck.Remove(newCard);

            dealerHand.Receive(newCard);

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("...dealing...");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Your cards are: ");
            foreach (var card in playerHand.IndividualCards)
            {
                Console.WriteLine(card.Title());
            }
            Console.Write("Your total hand value is: ");
            Console.WriteLine(playerHand.TotalValue());


            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Do you want to Hit or Stand?");

            Console.WriteLine("-----------------------------");

            var answer = Console.ReadLine();

            Console.WriteLine();

            newCard = deck[0];

            if (answer == "Hit" || answer == "hit" | answer == "HIT")
            {
                Console.WriteLine($"Next card is {newCard}.");
                deck.Remove(newCard);
                playerHand.Receive(newCard);


                Console.WriteLine();

                Console.WriteLine("-----------------------------");

                Console.WriteLine("Okay hit");

                Console.WriteLine("-----------------------------");

                Console.WriteLine();

                Console.WriteLine("Your cards are now: ");
                foreach (var card in playerHand.IndividualCards)
                {
                    Console.WriteLine(card.Title());
                }
                Console.Write("Your total hand value is now: ");
                Console.WriteLine(playerHand.TotalValue());


                // code for value evaluation to see if bust and replay prompt

            }
            else if (answer == "Stand" || answer == "stand" | answer == "STAND")
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Okay dealers turn...");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Dealers cards are: ");
            foreach (var card in dealerHand.IndividualCards)
            {
                Console.WriteLine(card.Title());
            }
            Console.Write("Your total hand value is: ");
            Console.WriteLine(dealerHand.TotalValue());
            Console.WriteLine("-----------------------------");
            Console.WriteLine();




            newCard = deck[0];
            Console.WriteLine($"Dealer gets a {deck[0]}.");
            deck.Remove(newCard);
            dealerHand.Receive(newCard);





            Console.WriteLine("-----------------------------");
            WantToReplay();
            Console.WriteLine("Let's try your luck again real soon!");
            Console.WriteLine("-----------------------------");

        }
    }
}
