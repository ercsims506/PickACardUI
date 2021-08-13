using ImTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardUI   
{
    class CardPicker
    {
        static Random random = new Random(); //the static field called "random" that was used to generate random numbers
        
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickCards;
        }

        private static string RandomSuit()
        {
            // get a random number from 1 to 4 (1 is less than 5 so you have 4)
            int value = random.Next(1, 5);
            // if it's 1 return the string Spades
            if (value == 1) return "Spades";
            //if it's 2 return the string Hearts
            if (value == 2) return "Hearts";
            // if it's 3 return the string Clubs
            if (value == 3) return "Clubs";
            // if we haven't returned yet, return the string Diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            // get a random number from 1 to 4
            int value = random.Next(1, 14);
            // if it's 1 return the string Ace
            if (value == 1) return "Ace";
            //if it's 11 return the string Jack
            if (value == 11) return "Jack";
            //if it's 12 return the string Queen
            if (value == 12) return "Queen";
            //if it's 13 return the string Queen
            if (value == 13) return "King";
            // if there isn't another value to return, it will 
            return value.ToString();
        }
    }
}
