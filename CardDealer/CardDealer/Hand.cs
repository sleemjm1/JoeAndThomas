using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealer
{
    class Hand
    {
        List<Card> cards;

        public Hand()
        {
            //nothing
        }

        public Hand(List<Card> dealtCards)
        {
            cards = dealtCards;
        }

        public string toString()
        {
            string returnString = "";
            foreach (Card card in cards)
            {
                returnString += card.shortString() + " ";
            }
            return returnString;
        }
    }
}
