using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    // a Deck class that contains an array of all the cards.
    public class Deck
    {
        //Declared a random variable
        private Random _random;

        //created a Card class array called Cards
        public Card[] Cards { get; set; }

        //created the Deck class
        public Deck()
        {
            //The random variable is used to create new randomization
            _random = new Random();

            //The Cards array is assigned 52 elements representing 52 cards in a deck
            Cards = new Card[52];

            //A counter is initiated
            int counter = 0;
            //loop through the face values and loop through the suits
            //therefore, loop inside loop.
            for (int i = 2; i <= 14; i++)
            {
                //this loop assigns face values of cards
                string faceValue;
                if (i < 11) faceValue = i.ToString();
                else if (i == 11) faceValue = "Jack";
                else if (i == 12) faceValue = "Queen";
                else if (i == 13) faceValue = "King";
                else faceValue = "Ace";

                //this loop assigns the suit value
                for (int j = 1; j <= 4; j++)
                {

                    string suit;
                    if (j == 1) suit = "Hearts";
                    else if (j == 2) suit = "Diamonds";
                    else if (j == 3) suit = "Spades";
                    else suit = "Clubs";

                    //The counter will only be able to continue through the 52 elements
                    //A new card object is assigned to each element of the Cards array as
                    //the loop continues
                    Cards[counter] = new Card
                    {
                        FaceValue = faceValue,
                        Suit = suit
                    };

                    counter++;
                }
                
            }
        }

        //a public method that selects a random card from the deck
        public Card Draw()
        {
            var number = _random.Next(Cards.Length);
            return Cards[number];

        }
    }

}
