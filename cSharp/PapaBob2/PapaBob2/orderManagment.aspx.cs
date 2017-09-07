using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBob2
{
    public partial class orderManagment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[index];
            var value = row.Cells[1].Text.ToString();
            var orderId = Guid.Parse(value);

            papaBobsDomain.orderManager.CompleteOrder(orderId);

            var orders = papaBobsDomain.orderManager.GetOrders();
            GridView1.DataSource = orders;
            GridView1.DataBind();

        }

        private void refreshGridView()
        {
            var orders = papaBobsDomain.orderManager.GetOrders();
            GridView1.DataSource = orders;
            GridView1.DataBind();
        }
    }
}