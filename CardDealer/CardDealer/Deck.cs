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
        private List<Card> cards;
        public Deck()
        {
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
        
        public void Deal(ListBox listBox, int numHands, int handSize)
        {
            int positionInDeck = 0;
            List<Hand> hands = new List<Hand>();
            int handCount = 0;
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
            listBox.Items.Add("");
            foreach (Hand hand in hands)
            {
                handCount++;
                //listBox.Items.Add("Hand no. " + handCount);
                listBox.Items.Add(hand.toString());
                //listBox.Items.Add("");
            }
        }

        public void shuffleDeck()
        {
            int numShuffles = 113; //113 times will give us a fairly random deck
            int maxCards = cards.Count()-1; //-1 cause 0 based
            Random random = new Random();
            for (int i = 0; i < numShuffles; i++)
            {
                int origin = random.Next(0, maxCards); //Generate a random number origin
                int destination = random.Next(0, maxCards); //Generate another for destination

                Card tempCard = cards[origin]; //store original card in temporary Card object
                cards[origin] = cards[destination]; //place destination card in original cards' old slot
                cards[destination] = tempCard; //place original card in destinations's old slot
            }
        }
    }
}
