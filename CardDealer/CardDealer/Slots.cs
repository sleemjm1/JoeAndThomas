using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardDealer
{
    class Slots
    {


        public void Roll(ListBox listBox)
        {
            Deck deck = new Deck();
            deck.Deal(listBox, 3, 5);
        }
    }
}
