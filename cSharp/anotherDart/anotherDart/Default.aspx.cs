using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace anotherDart
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random generator = new Random();
            Dart gameDart = new Dart(generator);
            Game newGame = new Game(generator);
            resultLabel.Text = newGame.playGame(gameDart);
        }
    }
}