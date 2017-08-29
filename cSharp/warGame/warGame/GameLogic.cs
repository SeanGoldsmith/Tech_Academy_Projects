using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace warGame
{
    public class GameLogic
    {
        public string runGame(DeckOfCards deck, Player firstPlayer, Player secondPlayer)
        {
            string output = "";
            while (firstPlayer.hand.Count > 10 && secondPlayer.hand.Count > 10)
            {
                
                    output += runRound(firstPlayer, secondPlayer);
                
                
            }
            if (firstPlayer.hand.Count > secondPlayer.hand.Count)
            {
                output += "FIRST PLAYER WINS THE GAME!";
            }
            else
            {
                output += "SECOND PLAYER WINS THE GAME!";
            }
            return output;
        }

        public static string runRound(Player firstPlayer, Player secondPlayer)
        {
            string output = String.Format("Battle Cards: {0} of {1} versus {2} of {3}<br>", firstPlayer.hand[0].value,
                                          firstPlayer.hand[0].suit, secondPlayer.hand[0].value, secondPlayer.hand[0].suit);
            output += String.Format("Bounty ...<Br>{0} of {1}<br>{2} of {3}<br>",firstPlayer.hand[0].value,
                                          firstPlayer.hand[0].suit, secondPlayer.hand[0].value, secondPlayer.hand[0].suit);

            int firstPlayerValue = convertCardValue(firstPlayer.hand[0]);
            int secondPlayerValue = convertCardValue(secondPlayer.hand[0]);
            if (firstPlayerValue > secondPlayerValue)
            {
                output += "First Player Wins!<br>";
                firstPlayer.hand.Add(secondPlayer.hand[0]);
                firstPlayer.hand.Add(firstPlayer.hand[0]);
                firstPlayer.hand.RemoveAt(0);
                secondPlayer.hand.RemoveAt(0);
                
            }
            else if (secondPlayerValue > firstPlayerValue)
            {
                output += "Second Player Wins!<br>";
                secondPlayer.hand.Add(firstPlayer.hand[0]);
                secondPlayer.hand.Add(secondPlayer.hand[0]);
                secondPlayer.hand.RemoveAt(0);
                firstPlayer.hand.RemoveAt(0);
            }
            else if (firstPlayerValue == secondPlayerValue)
            {
                output += War(firstPlayer, secondPlayer);
            }
            return output;

        }
        public static int convertCardValue(Card card)
        {
            
            if (card.value == "Ace")
            {
                return 14;
            }
            else if (card.value == "King")
            {
                return 13;
            }
            else if (card.value == "Queen")
            {
                return 12;
            }
            else if (card.value == "Jack")
            {
                return 11;
            }
            else
            {
                for (int i = 2; i < 11; i++)
                {
                    if (int.Parse(card.value) == i)
                    {
                        return i;
                    }
                }
            }
            return 0;
            
            
        }
        public static string War(Player firstPlayer, Player secondPlayer)
        {
            

                string output = "*********WAR***********<br>";
                output += String.Format("Battle Cards: {0} of {1} versus {2} of {3}<br>", firstPlayer.hand[1].value, firstPlayer.hand[1].suit,
                                                                                     secondPlayer.hand[1].value, secondPlayer.hand[1].suit);
                output += String.Format("Bounty:<br> {0} of {1}<br>{2} of{3}<br><{4} of {5}<br>" +
                    "{6} of {7}<br> {8} of {9}<br>{10} of {11}<br>{12} of {13}<br>{14} of {15}<br>",
                    firstPlayer.hand[0].value, firstPlayer.hand[0].suit, secondPlayer.hand[0].value, secondPlayer.hand[0].suit,
                    firstPlayer.hand[1].value, firstPlayer.hand[1].suit, secondPlayer.hand[1].value, secondPlayer.hand[1].suit,
                    firstPlayer.hand[2].value, firstPlayer.hand[2].suit, secondPlayer.hand[2].value, secondPlayer.hand[2].suit,
                    firstPlayer.hand[3].value, firstPlayer.hand[3].suit, secondPlayer.hand[3].value, secondPlayer.hand[3].suit);
                int firstPlayerValue = convertCardValue(firstPlayer.hand[1]);
                int secondPlayerValue = convertCardValue(secondPlayer.hand[1]);

                if (firstPlayerValue > secondPlayerValue)
                {
                    for (int i = 0; i < 4; i++)
                    {

                        firstPlayer.hand.Add(secondPlayer.hand[i]);
                        secondPlayer.hand.RemoveAt(i);
                        firstPlayer.hand.Add(firstPlayer.hand[i]);
                        firstPlayer.hand.RemoveAt(i);
                    }
                    output += "First Player Wins!<br>";
                }
                else if (secondPlayerValue > firstPlayerValue)
                {
                    for (int i = 0; i < 4; i++)
                    {

                        secondPlayer.hand.Add(firstPlayer.hand[i]);
                        firstPlayer.hand.RemoveAt(i);
                        secondPlayer.hand.Add(secondPlayer.hand[i]);
                        secondPlayer.hand.RemoveAt(i);
                    }
                    output += "Second Player Wins!<br>";
                }
                else
                {
                    firstPlayer.recieveCard(firstPlayer.hand[0]);
                    firstPlayer.hand.RemoveAt(0);
                    secondPlayer.recieveCard(secondPlayer.hand[0]);
                    secondPlayer.hand.RemoveAt(0);
                    output += "Let's move on...<br>";
                }
                return output;
            
        }
        
        
        
    }
}