using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace conditionalRadioChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilButton.Checked)
            {
                outputLabel.Text = "You selected the pencil.";
                noteImage.ImageUrl = "pencil.png";
                
            }
            else if (penButton.Checked)
            {
                outputLabel.Text = "You selected the pen.";
                noteImage.ImageUrl = "pen.png";
            }
            else if (phoneButton.Checked)
            {
                outputLabel.Text = "You Selected the phone.";
                noteImage.ImageUrl = "phone.png";
            }
            else if (tabletButton.Checked)
            {
                outputLabel.Text = "You selected the tablet.";
                noteImage.ImageUrl = "tablet.png";
            }
            else
            {
                outputLabel.Text = "Please make a selection.";
            }
        }
    }
}