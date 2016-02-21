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

        public string shortString()
        {
            string returnString = "";
            string returnCardValue = "";
            string returnCardSuit = "";
            //if (this.CardSuit == Suit.Hearts)
            //{
            //    returnString = this.CardValue + "♥" + " ";
            //}
            //else
            //{
            //    returnString = this.CardValue + " of " + this.CardSuit + " ";
            //}
            if (this.CardSuit == Suit.Hearts) { returnCardSuit = "♥"; }
            else if (this.CardSuit == Suit.Spades) { returnCardSuit = "♠"; }
            else if (this.CardSuit == Suit.Clubs) { returnCardSuit = "♣"; }
            else { returnCardSuit = "♦"; }

            if (this.CardValue == Value.Ace) { returnCardValue = "A"; }
            else if (this.CardValue == Value.Two) { returnCardValue = "2"; }
            else if (this.CardValue == Value.Three) { returnCardValue = "3"; }
            else if (this.CardValue == Value.Four) { returnCardValue = "4"; }
            else if (this.CardValue == Value.Five) { returnCardValue = "5"; }
            else if (this.CardValue == Value.Six) { returnCardValue = "6"; }
            else if (this.CardValue == Value.Seven) { returnCardValue = "7"; }
            else if (this.CardValue == Value.Eight) { returnCardValue = "8"; }
            else if (this.CardValue == Value.Nine) { returnCardValue = "9"; }
            else if (this.CardValue == Value.Ten) { returnCardValue = "T"; }
            else if (this.CardValue == Value.Jack) { returnCardValue = "J"; }
            else if (this.CardValue == Value.Queen) { returnCardValue = "Q"; }
            else { returnCardValue = "K"; }

            returnString = returnCardValue + returnCardSuit + "";

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
