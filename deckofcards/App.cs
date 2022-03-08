using System;
using System.Collections.Generic;
using System.Text;

namespace deckofcards
{
    public class App 
    {
        protected List<CardClass> deck;

        public App()
        {
            deck = new List<CardClass>();
        }

        public string Choice()
        {
            Console.WriteLine("Deck of Cards\n1 - Create\n2 - Shuffle\n3 - Deal\n4 - Display Deck");
            Console.WriteLine("Choice: ");
            return Console.ReadLine();
        }

        public void CreateDeck()
        {
            deck.Clear();
            GC.Collect();
            string[] cards = Enum.GetNames(typeof(Suits));
            foreach(string suitType in cards)
            {
                string[] cards2 = Enum.GetNames(typeof(Rank));
                foreach (string rankType in cards2)
                {
                    deck.Add(new CardClass
                    {
                        suit = suitType,
                        rank = rankType
                    });
                }
            }
            Console.Write("New deck created!\n");
        }

        public void ShuffleDeck()
        {
            if (deck.Count > 0)
            {
                Random rand = new Random();
                for (int i = 0; i < deck.Count; i++)
                {
                    int ndx = rand.Next(51);
                    CardClass temp = deck[i];
                    deck[i] = deck[ndx];
                    deck[ndx] = temp;
                }
                Console.Write("Deck shuffled.\n");
            }
            else
            {
                Console.WriteLine("Deck is empty!");
            }
        }

        public void DisplayDeck()
        {
            foreach (CardClass card in deck)
            {
                Console.WriteLine("Suit: " + card.suit + "; Rank: " + card.rank);
            }
            Console.WriteLine($"Number of cards: {deck.Count}");
        }

        public void Deal(int deal)
        {
            List<CardClass> dealtCards = new List<CardClass>();
            if (deck.Count > 0 && deck.Count > deal)
            {
                for (int i = 0; i < deal; i++)
                {
                    dealtCards.Add(deck[i]);
                }
                deck.RemoveRange(0, deal);
                {
                    foreach (CardClass card in dealtCards)
                    {
                        Console.WriteLine("Suit: "+ card.suit + "; Rank: " + card.rank);
                    }
                    return;
                }
            }
            Console.WriteLine("Cannot deal if deck has less cards than the asked number.");
        }
    }
}
