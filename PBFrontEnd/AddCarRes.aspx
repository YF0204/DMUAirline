<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCarRes.aspx.cs" Inherits="AddCarRes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href ="OmerStylesheet.css" rel ="stylesheet" type ="text/css" />
</head>
<body>
    <header align="center"> DmuAirline<br />
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblBookingDate" runat="server" Text="Booking Date"></asp:Label>
        <asp:TextBox ID="txtBookingDate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Car Reg No"></asp:Label>
        <asp:TextBox ID="txtCarReg" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStartDate" runat="server" Text="Start Date"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEndDate" runat="server" Text="End Date"></asp:Label>
        <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="ddlLocation" runat="server" style="z-index: 1; left: 77px; top: 232px; position: absolute">
            <asp:ListItem>A1</asp:ListItem>
            <asp:ListItem>B2</asp:ListItem>
            <asp:ListItem>C3</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Location"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="BtnCancel" runat="server" OnClick="BtnCancel_Click" style="z-index: 1; left: 77px; top: 311px; position: absolute; width: 60px; height: 21px" Text="Cancel" />
    
    </div>
    </form>
</body>
</html>