using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDealer
{
    class Deck
    {
        //private List<Card> cards = new List<Card>();
        private Card[] cards;
        public Deck(Card[] cards)
        {
            //come back to this
        }

        public void InitializeCards()
        {
            int maxCards = 52;
            int maxCardsPerSuit = 13;
            int maxSuits = 4;
            string currentSuit;

            for (int cs = 0; cc < maxCards; cc++)
            {
                for (int i = 0; i < maxCardsPerSuit; i++)
                {
                    cards[cc].cardValue =;
                }
            }
        }
    }
}
