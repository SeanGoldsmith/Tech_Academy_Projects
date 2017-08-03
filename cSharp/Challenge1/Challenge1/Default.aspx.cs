using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fortuneButton_Click(object sender, EventArgs e)
        {
            string age = firstTextBox.Text;
            string money = secondTextBox.Text;

            string output = "At " + age + " years old, $" + money + " is plenty.";

            messageLabel.Text = output;
        }
    }
}