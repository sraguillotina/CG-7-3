using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a deck object in the main program

            Deck deck = new Deck();

            // Draws a random card
            var card1 = deck.Draw();

            
            //shows the value of the drawn card
            Console.WriteLine($"A random card was drawn from the deck for you: {card1.GetFullName()}");
            Console.ReadLine();
        }
    }
}
