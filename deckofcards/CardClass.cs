using System;
using System.Collections.Generic;
using System.Text;

namespace deckofcards
{
    public class CardClass
    {
        public CardClass()
        {
        }

        string _suit { get; set; }
        string _rank { get; set; }

        public string suit { get { return _suit; } set { _suit = value; } }
        public string rank { get { return _rank; } set { _rank = value; } }
    }

    public enum Suits
    {
        Cloves,
        Diamond,
        Heart,
        Spade
    }

    public enum Rank
    {
        A,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public static class Constants
    {
        public static readonly int FullDeck = 52;
    }
}
