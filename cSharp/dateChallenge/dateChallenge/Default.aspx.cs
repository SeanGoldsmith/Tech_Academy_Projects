using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dateChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime firstDay = firstCal.SelectedDate;
            DateTime secondDay = secondCal.SelectedDate;

            TimeSpan diff = firstDay - secondDay;
            if (diff.Days > 0)
            {
                resultLabel.Text = diff.Days.ToString();
            }
            else if (diff.Days < 0)
            {
                resultLabel.Text = (diff.Days * -1).ToString();
            }
            else
            {
                resultLabel.Text = "0";
            }
        }
    }
}