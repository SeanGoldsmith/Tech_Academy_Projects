<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="pizzaProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="font-family: Arial, Helvetica, sans-serif">
                <asp:Image ID="Image1" runat="server" ImageUrl="papabob.png" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Papa Bob&#39;s Pizza and Software</h1>
        </div>
        <asp:RadioButton ID="babyButton" runat="server" GroupName="size" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Baby Bob Size(10&quot;) $10" />
        <br />
        <asp:RadioButton ID="mamaButton" runat="server" GroupName="size" Text="Mama Bob Size(13&quot;)$13" />
        <br />
        <asp:RadioButton ID="papaButton" runat="server" GroupName="size" Text="Papa Bob Size(16&quot; - $16)" />
        <br />
        <br />
        <asp:RadioButton ID="thinButton" runat="server" GroupName="crust" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="thickButton" runat="server" GroupName="crust" Text="Deep Dish(+$2.00)" />
        <br />
        <br />
        <asp:CheckBox ID="peppCheck" runat="server" Text="Pepperoni(+$1.50)" />
        <br />
        <asp:CheckBox ID="onionCheck" runat="server" Text="Onions(+$0.75)" />
        <br />
        <asp:CheckBox ID="greenCheck" runat="server" Text="Green Peppers(+$0.50)" />
        <br />
        <asp:CheckBox ID="redCheck" runat="server" Text="Red Peppers(+$0.75)" />
        <br />
        <asp:CheckBox ID="anchCheck" runat="server" Text="Anchovies(+$2.00)" />
        <br />
        <br />
        <h1>Papa Bob&#39;s <span class="newStyle1">Special Deal</span></h1>
        <p>
            Save $2.00 when you add Pepperoni, Green Peppers, and Anchovies OR Pepperoni, Red Peppers, and Onions to your pizza.</p>
        <p>
            <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        </p>
        <p>
            <asp:Label ID="totalLabel" runat="server"></asp:Label>
        </p>
        <p>
            Sorry, at this time you can only order one pizza online, and pick-up only.</p>
        <h1 style="color: #FF0000">&nbsp;</h1>
    </form>
</body>
</html>
