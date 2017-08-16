<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="slots.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="firstImage" runat="server" Height="200px" Width="200px" />
            <asp:Image ID="secondImage" runat="server" Height="200px" Width="200px" />
            <asp:Image ID="thirdImage" runat="server" Height="200px" Width="200px" />
        </div>
        <p>
            Your Bet:
            <asp:TextBox ID="betBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="pullButton" runat="server" OnClick="pullButton_Click" Text="Pull The Lever!" />
        </p>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry&nbsp;&nbsp; - x2 Your Bet<br />
        2 Cherries - x3 Your Bet<br />
        3 Cherries - x4 Your Bet<br />
        3 7&#39;s - Jackpot - x100 Your Bet<br />
        HOWEVER ... if there&#39;s even one BAR you win nothing.</form>
</body>
</html>
