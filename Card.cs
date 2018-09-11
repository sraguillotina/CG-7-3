using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
   

    public class Card
    {
        //The Card class only has 2 properties and one method for returning the full card name
        //Face value and suit properties
       
        public string FaceValue { get; set; }
        public string Suit { get; set; }
       
        //Created a public method that gives the full name of the card
        //Returns a string
        public string GetFullName ()
        {
            return $"{FaceValue} of {Suit}";
        }

    }
}
