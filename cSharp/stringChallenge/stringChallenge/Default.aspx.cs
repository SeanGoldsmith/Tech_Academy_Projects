using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stringChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            challengOne();
            challengeTwo();
            challengeThree();
            challengeFour();

            

            
        }

        void challengOne()
        {
            //PART 1
            string myName = "Sean Goldsmith";
            string revname = "";

            for (int i = myName.Length - 1; i >= 0; i--)
            {
                revname += myName[i];
            }
            firstLabel.Text = revname;
            //END PART 1
        }

        void challengeTwo()
        {
            //PART TWO
            string names = "Luke,Leia,Han,Chewbacca";
            string[] namesList = names.Split(',');
            string newNames = "";
            for (int i = namesList.Length - 1; i >= 0; i--)
            {
                newNames += namesList[i] + ",";
            }
            newNames = newNames.Remove(newNames.Length - 1);
            secondLabel.Text = newNames;
            //END PART TWO
        }

        void challengeThree()
        {
            int forLeftPad = 0;
            string names = "Luke,Leia,Han,Chewbacca";
            string[] namesList = names.Split(',');
            string output = "";
            for (int i = 0;i < namesList.Length; i++)
            {
                forLeftPad = ((14 - namesList[i].Length) / 2);
                output += namesList[i].PadLeft(namesList[i].Length+forLeftPad, '*').PadRight(14,'*') + "<br>";
            }
            thirdLabel.Text = output;

        }

        void challengeFour()
        {
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            puzzle = puzzle.Replace("Z", "T");
            int index = puzzle.IndexOf("remove-me", 0, puzzle.Length);
            puzzle = puzzle.Remove(index, 9);
            puzzle = puzzle.Trim();
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");
            fourthLabel.Text = puzzle;
        }


    }
}