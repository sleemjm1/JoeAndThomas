using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealer
{
    public enum Value
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        MinValue = Ace,
        MaxValue = King,
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
            string returnString = this.CardSuit + " " + this.CardValue;
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
