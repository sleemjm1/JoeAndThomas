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
 * Implement card games
 * Fix validation for when user adds a string instead of number to one of the text boxes
 *  
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
            int numHands = 0;
            int numCards = 0;

            try
            {
                numHands = Int32.Parse(txtNumHands.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Only Numeric values accepted for No. of Cards", "Format Exception");
            }
            
            try
            {
                numCards = Int32.Parse(txtNumCards.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Only Numeric values accepted for Cards Per Hand", "Format Exception");
            }
            
            int totalCards = numCards * numHands;
            int maxCards = 52; 

            //We need to check that it is possible to perform a deal with the parameters supplied by
            //the user. We need less than maxCards (52), and more than 0 cards in order to perform a deal

            if (totalCards > maxCards || totalCards < 0)
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
            txtNumCards.Text = String.Empty;
            txtNumHands.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listSlots.Items.Clear();
            Slots slots = new Slots();
            slots.Roll(listSlots);
        }
    }
}
