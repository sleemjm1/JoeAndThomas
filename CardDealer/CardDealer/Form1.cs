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
            Deck deck = new Deck();
            deck.Deal(listDisplay, 5, 3);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listDisplay.Items.Clear();
        }
    }
}
