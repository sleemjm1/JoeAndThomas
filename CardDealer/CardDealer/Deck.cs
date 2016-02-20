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
        private List<Card> cards;
        public Deck()
        {
            //come back to this
            cards = new List<Card>();
            InitializeCards();
        }

        public void InitializeCards()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    cards.Add(new Card(value, suit));
                }
            }
        }

        public string Deal(int numHands, int handSize)
        {
            int positionInDeck = 0;
            List<Hand> hands = new List<Hand>();
            for (int i = 0; i < numHands; i++)
            {
                List<Card> cardsToDeal = new List<Card>();
                for (int c = positionInDeck; c < (positionInDeck + handSize); c++)
                {
                    Card currentCard = cards[c];
                    cardsToDeal.Add(currentCard);
                }
                Hand currentHand = new Hand(cardsToDeal);
                hands.Add(currentHand);
                positionInDeck += handSize;
            }
            string returnString ="";
            foreach (Hand hand in hands)
            {
                returnString += hand.toString();
            }
            return returnString;
        }
    }
}
