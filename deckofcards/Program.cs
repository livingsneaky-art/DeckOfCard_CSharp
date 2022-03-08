using System;

namespace deckofcards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            App app = new App();
            while(true)
            {
                switch(app.Choice())
                {
                    case "1":
                        app.CreateDeck();
                        break;
                    case "2":
                        app.ShuffleDeck();
                        break;
                    case "3":
                        Console.Write("How many?");
                        app.Deal(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "4":
                        app.DisplayDeck();
                        break;
                }
            }
        }
    }
}
