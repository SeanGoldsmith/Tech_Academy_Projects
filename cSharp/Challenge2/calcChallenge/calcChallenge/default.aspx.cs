using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calcChallenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(value1.Text);
            double num2 = double.Parse(value2.Text);

            double result = num1 + num2;

            resultLabel.Text = result.ToString();
            ;

        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(value1.Text);
            double num2 = double.Parse(value2.Text);

            double result = num1 - num2;

            resultLabel.Text = result.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(value1.Text);
            double num2 = double.Parse(value2.Text);

            double result = num1 * num2;

            resultLabel.Text = result.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(value1.Text);
            double num2 = double.Parse(value2.Text);

            double result = num1 / num2;

            resultLabel.Text = result.ToString();
        }
    }
}