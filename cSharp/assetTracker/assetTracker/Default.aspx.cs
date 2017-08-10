using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assets = new string[0];
                int[] elections = new int[0];
                int[] subt = new int[0];

                ViewState.Add("Assets", assets);
                ViewState.Add("Elections", elections);
                ViewState.Add("Subt", subt);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] assets = (string[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            int[] subt = (int[])ViewState["Subt"];

            int newLength = assets.Length + 1;

            Array.Resize(ref assets, newLength);
            Array.Resize(ref elections, newLength);
            Array.Resize(ref subt, newLength);

            int newIndex = assets.GetUpperBound(0);

            assets[newIndex] = assetBox.Text;
            elections[newIndex] = int.Parse(electionBox.Text);
            subt[newIndex] = int.Parse(subBox.Text);

            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Subt"] = subt;

            outputLabel.Text = String.Format("Total Election Rigged: {0}<br>" +
                "Average Acts of Subterfuge: {1:N2}<br>" +
                "(Last Asset You Added: {2})",elections.Sum(),subt.Average(),assets[newIndex]);

            assetBox.Text = "";
            electionBox.Text = "";
            subBox.Text = "";
        }
    }
}