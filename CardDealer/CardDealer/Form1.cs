using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* To Do:
 * New line after cards
 * Shuffle method
 * Implement card games
 * Add images to cards
 * Let user choose size of hands 
*/

namespace CardDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            int numHands = Int32.Parse(txtNumHands.Text);
            int numCards = Int32.Parse(txtNumCards.Text);
            int totalCards = numCards * numHands;
            int maxCards = 52;

            if (totalCards > maxCards)
            {
                listDisplay.Items.Add("Unable to deal that many cards at once!");
            }
            else
            {
                Deck deck = new Deck();
                deck.Deal(listDisplay, numHands, numCards); //Deal(listBox, numHands, handSize)
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listDisplay.Items.Clear();
        }
    }
}
