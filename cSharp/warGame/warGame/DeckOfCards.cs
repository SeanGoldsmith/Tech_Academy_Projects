using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace warGame
{
    public class DeckOfCards
    {
        public List<Card> deckList { get; set; }
        public static Random rng = new Random();

        public void shuffleDeck()
        {
            int n = this.deckList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card holdValue = deckList[k];
                deckList[k] = deckList[n];
                deckList[n] = holdValue;
            

            }


        }

        public void GenerateDeck()
        {
            string[] suits = new string[4];
            suits[0] = "Hearts";
            suits[1] = "Clubs";
            suits[2] = "Diamonds";
            suits[3] = "Spades";

            string[] faces = new string[5];
            faces[0] = "Jack";
            faces[1] = "Queen";
            faces[2] = "King";
            faces[3] = "Ace";

            List<Card> newDeck = new List<Card>();

            for (int j = 0; j < 4; j++)
            {
                for (int i = 2; i < 11; i++)
                {
                    newDeck.Add(new Card { suit = suits[j], value = i.ToString() });
                    this.deckList = newDeck;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    newDeck.Add(new Card { suit = suits[j], value = faces[i] });
                }
            }
            
            

            
        }
        public string printDeck() //for testing
        {
            string output = "";
            foreach (Card card in this.deckList)
            {
                output += String.Format("The {0} of {1}<br>", card.value, card.suit);
            }
            return output;
        }

        public Card deal()
        {
            Card holdCard = this.deckList.ElementAt(0);
            deckList.RemoveAt(0);
            return holdCard;

        }
    }
}