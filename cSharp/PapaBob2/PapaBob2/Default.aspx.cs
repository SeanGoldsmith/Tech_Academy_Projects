using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBob2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_CLick(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a name.";
                validationLabel.Visible = true;
                return;
            }
            if (addressTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter address.";
                validationLabel.Visible = true;
                return;
            }
            if (validationLabel.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a zip code.";
                validationLabel.Visible = true;
                return;
            }
            if (phoneTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a phone number.";
                validationLabel.Visible = true;
                return;
            }

            try
            {
                var order = buildOrder();
                papaBobsDomain.orderManager.CreateOrder(order);
                Response.Redirect("success.aspx");
            }
            catch (Exception ex)
            {
                validationLabel.Text = ex.Message;
                validationLabel.Visible = true;
                return;
            }
        }

        private papaBobs.DTO.Enums.paymentType determinePaymentType()
        {
            papaBobs.DTO.Enums.paymentType paymentType;
            if (cashRadio.Checked)
            {
                paymentType = papaBobs.DTO.Enums.paymentType.Cash;
            }
            else 
            {
                paymentType = papaBobs.DTO.Enums.paymentType.Credit;
            }
            
            return paymentType;
        }


        private papaBobs.DTO.Enums.SizeType determineSize()
        {
            papaBobs.DTO.Enums.SizeType size;
            if (!Enum.TryParse(sizeDropDown.SelectedValue, out size))
            {
                throw new Exception("Could not determine Pizza Curst!");
            }
            return size;

        }
        private papaBobs.DTO.Enums.crustType determineCrust()
        {
            papaBobs.DTO.Enums.crustType crust;
            if (!Enum.TryParse(crustDropDown.SelectedValue,out crust) )
            {
                throw new Exception("Could not determine crust");
            }
            return crust;

        }

        protected void recalculateTotalCost(object sender,EventArgs e)
        {
            if (sizeDropDown.SelectedValue == String.Empty) return;
            if (crustDropDown.SelectedValue == String.Empty) return;
            var order = buildOrder();

            try
            {
                costLabel.Text = papaBobsDomain.pizzaPriceManager.calculatePizzaPrice(order).ToString("C");
            }
            catch
            {

            }

        }

        private papaBobs.DTO.OrderDTO buildOrder()
        {
            var order = new papaBobs.DTO.OrderDTO();

            order.size = determineSize();
            order.crust = determineCrust();
            order.sausage = sausageCheck.Checked;
            order.pepperoni = pepperoniCheck.Checked;
            order.onions = onionsCheck.Checked;
            order.greenPeppers = greenPepperCheck.Checked;
            order.customerName = nameTextBox.Text;
            order.customerAddress = addressTextBox.Text;
            order.customerZip = zipTextBox.Text;
            order.customerPhone = phoneTextBox.Text;
            order.paymentType = determinePaymentType();

            return order;
        }
    }
}