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
            Player firstPlayer = new Player();
            Player secondPlayer = new Player();
            testDeck.GenerateDeck();
            testDeck.shuffleDeck();
            dealCards(testDeck, firstPlayer, secondPlayer);
            GameLogic game = new GameLogic();
            resultLabel.Text += game.runGame(testDeck,firstPlayer,secondPlayer);
            

            
        }

        public void dealCards(DeckOfCards deck, Player firstPlayer,Player secondPlayer)
        {
            int holdCurrentIndex = 0;
            while(deck.deckList.Count > 0)
            {
                firstPlayer.recieveCard(deck.deal());
                resultLabel.Text += String.Format("First player recieves the {0} of {1}<br>", firstPlayer.hand[holdCurrentIndex].value, firstPlayer.hand[holdCurrentIndex].suit);
                secondPlayer.recieveCard(deck.deal());
                resultLabel.Text += String.Format("Second player recieves the {0} of {1}<br>", secondPlayer.hand[holdCurrentIndex].value,secondPlayer.hand[holdCurrentIndex].suit);
                holdCurrentIndex++;
            }
        }
    }
}