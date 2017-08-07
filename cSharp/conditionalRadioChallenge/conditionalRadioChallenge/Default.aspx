<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="conditionalRadioChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences<br />
        </div>
        <asp:RadioButton ID="pencilButton" runat="server" GroupName="note" Text="Pencil" />
        <br />
        <asp:RadioButton ID="penButton" runat="server" GroupName="note" Text="Pen" />
        <br />
        <asp:RadioButton ID="phoneButton" runat="server" GroupName="note" Text="Phone" />
        <br />
        <asp:RadioButton ID="tabletButton" runat="server" GroupName="note" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Image ID="noteImage" runat="server" />
        <br />
        <br />
        <asp:Label ID="outputLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
