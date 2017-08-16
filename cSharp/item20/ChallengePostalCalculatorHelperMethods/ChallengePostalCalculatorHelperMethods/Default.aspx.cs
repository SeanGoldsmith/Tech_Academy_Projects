using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    

    public partial class Default : System.Web.UI.Page
    {
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void widthBox_TextChanged(object sender, EventArgs e)
        {
            isReady();
        }

        protected void heightBox_TextChanged(object sender, EventArgs e)
        {
            isReady();
        }

        protected void lengthBox_TextChanged(object sender, EventArgs e)
        {
            isReady();
        }

        protected void groundBox_CheckedChanged(object sender, EventArgs e)
        {
            isReady();
        }

        protected void airButton_CheckedChanged(object sender, EventArgs e)
        {
            isReady();
        }

        protected void nextDayButton_CheckedChanged(object sender, EventArgs e)
        {
            isReady();
        }

        void isReady()
        {
            //Must have width and height as well as at least one radio button checked.
            if ((widthBox.Text != "" && heightBox.Text != "") && (groundButton.Checked || airButton.Checked || nextDayButton.Checked))
            {
                calculateCost();
            }
            else return;
        }

        void calculateCost()
        {
            double totalCost;
            double multi = generateMulti();
            double width = Double.Parse(widthBox.Text);
            double height = Double.Parse(heightBox.Text);
            double length;

            if (lengthBox.Text != "")
            {
                length = Double.Parse(lengthBox.Text);
            }
            else
            {
                length = 1.0;
            }

            totalCost = (width * height * length)*multi;

            setLabel(totalCost);
        }

        void setLabel(double cost)
        {
            
            resultLabel.Text = cost.ToString();
        }

        double generateMulti()
        {
            if (groundButton.Checked)
            {
                return .15;
            }
            else if (airButton.Checked)
            {
                return .25;
            }
            else if (nextDayButton.Checked)
            {
                return .45;
            }
            else return 0.0;
            
        }

        


    }
}