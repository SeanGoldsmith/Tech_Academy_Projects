<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="assetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            height: 150px;
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" CssClass="newStyle1" ImageUrl="epic-spies-logo.jpg" />
        </div>
        <h1>Asset Performance Tracker</h1>
        <p>
            Asset Name:&nbsp;
            <asp:TextBox ID="assetBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:&nbsp;
            <asp:TextBox ID="electionBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:
            <asp:TextBox ID="subBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <p>
            <asp:Label ID="outputLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
