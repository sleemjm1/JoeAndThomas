using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            shuffleDeck();
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
        //Need to refactor now that we are passing in a list box, no need to store a list of hands, etc
        public void Deal(ListBox listBox, int numHands, int handSize)
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
            foreach (Hand hand in hands)
            {
                listBox.Items.Add("H A N D :");
                listBox.Items.Add(hand.toString());
                listBox.Items.Add("");
            }
        }

        public void shuffleDeck()
        {
            int numShuffles = 113;
            int maxCards = cards.Count()-1; //-1 cause 0 based
            Random random = new Random();
            for (int i = 0; i < numShuffles; i++)
            {
                int origin = random.Next(0, maxCards);
                int destination = random.Next(0, maxCards);

                Card tempCard = cards[origin];
                cards[origin] = cards[destination];
                cards[destination] = tempCard;
            }
        }
    }
}
