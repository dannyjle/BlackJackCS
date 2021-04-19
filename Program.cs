using System;
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

    class Game
    {
        public void Play()
        {
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
            Console.WriteLine();

            var keepHitting = true;
            while (keepHitting == true && playerHand.TotalValue() <= 21)
            {
                var answer = Console.ReadLine().ToLower();

                Console.WriteLine();

                if (answer == "hit")
                {
                    var nextCard = deck[0];

                    deck.Remove(nextCard);
                    playerHand.Receive(nextCard);


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

                    if (playerHand.TotalValue() > 21)
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("BUST!");
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine();
                    }
                    if (playerHand.TotalValue() < 21)
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("Do you want to Hit or Stand?");
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine();
                    }


                }
                else
                {
                    keepHitting = false;
                    Console.WriteLine("Your cards are: ");
                    foreach (var card in playerHand.IndividualCards)
                    {
                        Console.WriteLine(card.Title());
                    }
                    Console.Write("Your total hand value is: ");
                    Console.WriteLine(playerHand.TotalValue());

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Okay stand!");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Dealer's turn....");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine();
                }
            }



            while (dealerHand.TotalValue() < 17 && playerHand.TotalValue() <= 21)
            {
                var newDealerCard = deck[0];
                deck.Remove(newDealerCard);

                dealerHand.Receive(newDealerCard);
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Dealers cards are: ");
            foreach (var card in dealerHand.IndividualCards)
            {
                Console.WriteLine(card.Title());
            }
            Console.Write(" total hand value is: ");
            Console.WriteLine(dealerHand.TotalValue());
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            if (playerHand.TotalValue() > 21)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Better luck next time...");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();

            }
            else if (dealerHand.TotalValue() > 21)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("LADY LUCK FAVORS YOU! YOU WIN!");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
            }
            else if (dealerHand.TotalValue() > playerHand.TotalValue())
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Better luck next time...");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
            }
            else if (playerHand.TotalValue() > dealerHand.TotalValue())
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("LADY LUCK FAVORS YOU! YOU WIN!");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Sorry! Ties go to the dealer!");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
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
            var answer = Console.ReadLine().ToLower();

            if (answer == "Y" | answer == "y" | answer == "Yes" | answer == "yes")
            {
                Console.WriteLine("Let's see who Lady Luck favors!");
            }
            else
            {
                Console.WriteLine("...OK READY OR NOT WE ARE PLAYING!!!");
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine();

            WelcomeToBlackJack();

            Console.WriteLine();

            WantToPlay();

            var playerWantsToKeepGoing = true;

            while (playerWantsToKeepGoing)
            {
                var theGame = new Game();
                theGame.Play();

                Console.Write("Again? [Y]/[N]: ");
                Console.WriteLine("");
                var answer = Console.ReadLine().ToLower();
                if (answer == "Y" | answer == "y" | answer == "Yes" | answer == "yes")
                {
                    playerWantsToKeepGoing = true;
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Alright again!");
                    Console.WriteLine("-----------------------------");
                }
                else
                {
                    playerWantsToKeepGoing = false;


                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("That was fun, bye!");
                    Console.WriteLine("-----------------------------");

                }
            }
        }
    }
}