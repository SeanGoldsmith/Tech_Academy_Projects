using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace epicSpies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                endCal.SelectedDate = DateTime.Today;

                startCal.SelectedDate = DateTime.Today.AddDays(14);

                finishCal.SelectedDate = DateTime.Today.AddDays(21);
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            DateTime endDate = endCal.SelectedDate;
            DateTime startDate = startCal.SelectedDate;
            DateTime finishDate = finishCal.SelectedDate;

            string name = spyNameBox.Text;
            string assignmentName = assignNameBox.Text;

            TimeSpan sinceWorked = startDate - endDate;
            if (sinceWorked.Days < 14)
            {
                outputLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment.";
            }
            else
            {
                TimeSpan daysWorked = finishDate - startDate;
                if (daysWorked.Days <= 21)
                {
                  
                    double paycheck = ((double)(daysWorked.Days) * 500);
                    outputLabel.Text = String.Format("Assingment of {0} to assignment Project: {1} is authorized. Budget Total: {2:C}",name,assignmentName,paycheck);
                }
                else if (daysWorked.Days > 21)
                {
                    double paycheck = (((double)(daysWorked.Days) * 500) + 1000);
                    outputLabel.Text = String.Format("Assingment of {0} to assignment Project: {1} is authorized. Budget Total: {2:C}", name, assignmentName, paycheck);
                }
            }
        }
    }
}