using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace anotherDart
{
    public class Score
    {
        

        public static int calcScore(int position,bool _Double,bool triple)
        {
            int score = 0;
            if (position == 25 || position == 50)
            {
                return position;
            }
            else
            {
                if (_Double == true)
                {
                    score = (position) * 2;
                }
                else if (triple == true)
                {
                    score = (position) * 3;
                }
                else score = position;
                return score;
            }

        }

    }


}