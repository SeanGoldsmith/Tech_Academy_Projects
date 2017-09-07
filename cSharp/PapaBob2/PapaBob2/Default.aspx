<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBob2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Content/bootstrap.css" rel="stylesheet" />
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <!--START BOOTSTRAP-->
        <div class="container">
            
            <!--HEADER-->
            <div class="page-header">
                <h1>Papa Bob's Pizza</h1>
                <p>Pizza to Code By</p>
            </div>
            <!--END HEADER-->

            <!--DROP DOWN FORMS-->
            <div class="form-group">
                <label>Size: </label>
                <asp:DropDownList ID="sizeDropDown" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost">
                    <asp:ListItem Text="Choose One..." Value="" Selected="True" />
                    <asp:ListItem Text="Small (12 inch - $12)" Value="Small" />
                    <asp:ListItem Text="Medium (14 inch - $14)" Value="Medium" />
                    <asp:ListItem Text="Large (16 inch - $16)" Value="Large" />
                </asp:DropDownList>

                
            </div>

            <div class="form-group">
                <label>Crust: </label>
                <asp:DropDownList ID="crustDropDown" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost">
                    <asp:ListItem Text="Choose One..."  Value="" Selected="True"/>
                    <asp:ListItem Text="Regular" Value="Regular" />
                    <asp:ListItem Text="Thin" Value="Thin" />
                    <asp:ListItem Text="Thick - $2" Value="Thick" />
                </asp:DropDownList>
            </div>
            <!--END DROP DOWN FORMS-->

            <!--TOPPING CHECK BOXES-->
            <div class="checkbox">
                <label>
                    <asp:CheckBox ID="sausageCheck" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/>Sausage
                </label>
            </div>
            <div class="checkbox">
                <label>
                <asp:CheckBox ID="pepperoniCheck" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/>Pepperoni
                </label>
            </div>
            <div class="checkbox">
                <label>
                <asp:CheckBox ID="onionsCheck" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/>Onions
                </label>
            </div>
            <div class="checkbox">
                <label>
                    <asp:CheckBox ID="greenPepperCheck" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/>Green Peppers
                </label>
            </div>
            <!--END TOPPING CHECK BOXES-->

           
            <!-- CUSTOMER INFOR-->
            <h3> Deliver To:</h3>

            <div class="form-group">
                <label>Name: </label>
                <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Address: </label>
                <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Zip: </label>
                <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Phone:</label>
                <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <!--END CUSTOMER INFO-->

            <!--PAYMENT TYPE AND ORDER BUTTON-->
            <h3>Payment: </h3>

            <div class="radio">
                <label> <asp:RadioButton ID="cashRadio" runat="server" GroupName="payment" Checked="True" />Credit</label>
               
            </div>
            <div class="radio">
                <label><asp:RadioButton ID="creditRadio" runat="server" GroupName="payment"/>Cash</label>
            </div>

            <asp:Button ID="orderButton" runat="server" Text="Order" OnClick="orderButton_CLick" CssClass="btn btn-lg btn-primary" />

            <asp:Label ID="validationLabel" runat="server" Text="Label" CssClass="bg-danger" Visible="false"></asp:Label>

            <h3>Total Cost: <asp:Label ID="costLabel" runat="server"></asp:Label></h3>
            <!--END PAYMENT TYPE-->
        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
</body>
</html>
