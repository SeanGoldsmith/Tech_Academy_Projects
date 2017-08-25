using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace warGame
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DeckOfCards testDeck = new DeckOfCards();
            testDeck.GenerateDeck();
            testDeck.shuffleDeck();
            resultLabel.Text = testDeck.printDeck();
            Player firstPlayer = new Player();
            Card test = (testDeck.deal());
            firstPlayer.hand.Add(test);
            resultLabel.Text += String.Format("<br><br> First player holds the {0}, of {1}", firstPlayer.hand.ElementAt(0).value,firstPlayer.hand.ElementAt(0).suit);
            resultLabel.Text += testDeck.printDeck();
            
        }
    }
}