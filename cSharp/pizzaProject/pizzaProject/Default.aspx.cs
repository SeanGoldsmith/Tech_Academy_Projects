using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pizzaProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (babyButton.Checked)
            {
                total += 10;
            }
            else if (mamaButton.Checked)
            {
                total += 13;
            }
            else if (papaButton.Checked)
            {
                total += 16;
            }


            if (thickButton.Checked)
            {
                total += 2;
            }

            if (peppCheck.Checked)
            {
                total += 1.50;
            }
            if (onionCheck.Checked)
            {
                total += .75;
            }
            if (greenCheck.Checked)
            {
                total += .50;
            }
            if(redCheck.Checked)
            {
                total += .75;
            }
            if (anchCheck.Checked)
            {
                total += 2;
            }

            if ( (peppCheck.Checked && greenCheck.Checked && anchCheck.Checked) || (peppCheck.Checked && redCheck.Checked && onionCheck.Checked) )
            {
                total -= 2;
            }

            purchaseButton.Text = total.ToString();
            

        }
    }
}