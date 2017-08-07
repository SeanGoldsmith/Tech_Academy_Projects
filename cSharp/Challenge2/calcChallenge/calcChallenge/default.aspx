<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="calcChallenge._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
        </div>
        First Value:&nbsp;
        <asp:TextBox ID="value1" runat="server"></asp:TextBox>
        <br />
        Second Value:<asp:TextBox ID="value2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" Width="25px" />
&nbsp;
        <asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" Width="25px" />
&nbsp;
        <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" Width="25px" />
&nbsp;
        <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" Width="25px" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" Text="Label"></asp:Label>
        <br />
    </form>
</body>
</html>
