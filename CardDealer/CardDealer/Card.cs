using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealer
{
    public enum Value
    {
        Ace, 
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
        King,
    }

    public enum Suit
    {
        Hearts,
        Spades,
        Clubs,
        Diamonds,
    }

    class Card
    {
        private Value CardValue;
        private Suit CardSuit;

        public Card(Value CardValue, Suit CardSuit)
        {
            this.CardValue = CardValue;
            this.CardSuit = CardSuit;
        }

        public Value cardValue
        {
            get
            {
                return CardValue;
            }
            set
            {
                cardValue = value;
            }
        }

        public Suit cardSuit
        {
            get
            {
                return CardSuit;
            }
            set
            {
                cardSuit = value;
            }
        }

        public string toString()
        {
            string returnString = this.CardValue + " of " + this.CardSuit + " ";
            return returnString;
        }

        public bool Compare(Card cardToCompare)
        {
            bool isTheSame = false;
            if (cardToCompare.toString().Equals(this.toString()))
            {
                isTheSame = true;
            }
            return isTheSame;
        }

    }
}
