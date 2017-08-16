using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace slots
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int placeHolder = 0;

            Random someNumber = new Random();

            if (!Page.IsPostBack)
            {
                moneyLabel.Text = "100.00";
                firstImage.ImageUrl = chooseImg(someNumber.Next(0, 11),out placeHolder);
                secondImage.ImageUrl = chooseImg(someNumber.Next(0, 11),out placeHolder);
                thirdImage.ImageUrl = chooseImg(someNumber.Next(0, 11),out placeHolder);
            }

            
              
        }

        

        protected void pullButton_Click(object sender, EventArgs e)
        {
            double playerMoney = Double.Parse(moneyLabel.Text);

            double winnings = 0.0;

            double playerBet = Double.Parse(betBox.Text);

            int[] currentImgs = new int[3];

            Random someNumber = new Random();

            firstImage.ImageUrl = chooseImg(someNumber.Next(0, 11),out currentImgs[0]);
            secondImage.ImageUrl = chooseImg(someNumber.Next(0, 11),out currentImgs[1]);
            thirdImage.ImageUrl = chooseImg(someNumber.Next(0, 11), out currentImgs[2]);

            
            
            if (!checkBar(currentImgs))
            {
                int cherryNumber = 0;
                if (checkJackPot(currentImgs))
                {
                    winnings = playerBet * 100;
                    printWin(playerBet, winnings);
                    playerMoney = addMoney(winnings, playerMoney);
                    updateMoney(playerMoney);
                }

                
                else if (checkCherries(currentImgs, out cherryNumber))
                {
                    winnings = playerBet * ((double)cherryNumber + 1);
                    printWin(playerBet, winnings);
                    playerMoney = addMoney(winnings, playerMoney);
                    updateMoney(playerMoney);
                }
                else
                {
                    printLose(playerBet);
                    playerMoney = removeMoney(playerBet,playerMoney);
                    updateMoney(playerMoney);
                }
                
            }

            else if(checkBar(currentImgs))
            {
                printLose(playerBet);
                playerMoney = removeMoney(playerBet,playerMoney);
                updateMoney(playerMoney);
            }

            
            
        }

        string chooseImg(int number, out int currentImgs)
        {
            string[] pictures = new string[12] { "Bar.png" , "Bell.png"
            , "Cherry.png" , "Clover.png" , "Diamond.png" , "HorseShoe.png"
            , "Lemon.png" , "Orange.png" , "Plum.png" , "Seven.png"
            , "Strawberry.png" , "Watermelon.png"};

            currentImgs = number;

            return pictures[number];

        }

        void displayMoney(double amount)
        {
            moneyLabel.Text = amount.ToString();
        }

        bool checkBar(int[] currentImgs)
        {
            for (int i = 0; i < 3; i++)
            {
                if (currentImgs[i] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        bool checkCherries(int[] currentImgs,out int cherries)
        {
            cherries = 0;
            for (int i = 0; i < 3; i++)
            {
                if (currentImgs[i] == 2)
                {
                    cherries += 1;
                }
            }

            if (cherries >= 1)
            {
                return true;
            }
            else return false;
        }
        bool checkJackPot(int[] currentImgs)
        {
            int total7 = 0;
            for (int i = 0; i >3; i++)
            {
                if (currentImgs[i] == 9)
                {
                    total7 += 1;
                }
            }

            if (total7 == 3) return true;
            else return false;
        }

        void printLose(double bet)
        {
            resultLabel.Text = String.Format("Sorry, you lost ${0:N2}. Better luck next time.", bet);
        }

        void printWin(double bet, double winnings)
        {
            resultLabel.Text = String.Format("You bet ${0:N2} and won ${1:N2}!",bet,winnings);
        }

        double addMoney(double winnings,double playerMoney)
        {
            
            return playerMoney + winnings;
        }

        double removeMoney(double playerBet,double playerMoney)
        {
            return playerMoney - playerBet;
        }
        void updateMoney(double playerMoney)
        {
            moneyLabel.Text = playerMoney.ToString();
        }
    }
}

    