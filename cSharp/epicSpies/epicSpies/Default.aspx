<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="epicSpies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="epic-spies-logo.jpg" />
        </div>
        <h1>Spy New Assignment Form</h1>
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="spyNameBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:
            <asp:TextBox ID="assignNameBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment:&nbsp; </p>
        <p>
            <asp:Calendar ID="endCal" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="startCal" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="finishCal" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="assignButton" runat="server" Text="Assign Spy" OnClick="assignButton_Click" />
        </p>
        <p>
            <asp:Label ID="outputLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
