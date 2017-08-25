using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace warGame
{
    public class Player
    {
        public List<Card> hand { get; set; }

        public Player()
        {
            hand = new List<Card>();
        }

        public void recieveCard(Card card)
        {
            
            this.hand.Add(card);
            
        }

    }
}