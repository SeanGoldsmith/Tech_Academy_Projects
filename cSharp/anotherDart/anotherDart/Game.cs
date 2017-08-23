using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace anotherDart
{
    public class Game
    {
        public Random generator { get; set; }
        public Dart gameDart { get; set; }
        public int playerOneScore { get; set; }
        public int playerTwoScore { get; set; }

        public Game(Random _generator)
        {
            this.generator = _generator;
        }

        public string playGame(Dart gameDart)
        {
            this.gameDart = new Dart(this.generator);
            while (this.playerOneScore < 300 && this.playerTwoScore < 300)
            {
                gameDart.Throw();
                playerOneScore += Score.calcScore(gameDart.position, gameDart._double, gameDart.triple);
                if (playerOneScore > 300)
                {
                    break;
                }
                gameDart.Throw();
                playerTwoScore += Score.calcScore(gameDart.position, gameDart._double, gameDart.triple);

            }
            if (this.playerOneScore > this.playerTwoScore)
            {
                return String.Format("Player One's Score: {0}<br> Player Two's Score: {1}<br> Player One Wins!", this.playerOneScore, this.playerTwoScore);
            }
            else
            {
                return String.Format("Player One's Score: {0}<br> Player Two's Score: {1}<br> Player Two Wins!", this.playerOneScore, this.playerTwoScore);
            }
        }


    }
}