<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="dateChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How many days have elapsed?<br />
            <br />
            Chose a date:<br />
            <asp:Calendar ID="firstCal" runat="server"></asp:Calendar>
            <br />
            <br />
            Chose a second date:<br />
            <asp:Calendar ID="secondCal" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
