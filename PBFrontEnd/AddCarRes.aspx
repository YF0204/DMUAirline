<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCarRes.aspx.cs" Inherits="AddCarRes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href ="OmerStylesheet.css" rel ="stylesheet" type ="text/css" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <header align="center"> 
    <form id="form1" runat="server">
        <div class="auto-style1">
            DmuAirline<br />
            <asp:Label ID="Label3" runat="server" Text="Add Car Park reservation"></asp:Label>
            <br />
        </div>
    <div>
    
        <asp:Label ID="lblBookingDate" runat="server" Text="Booking Date" style="z-index: 1; left: 10px; top: 62px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtBookingDate" runat="server" style="z-index: 1; left: 241px; top: 55px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Car Reg No" style="z-index: 1; left: 8px; top: 107px; position: absolute; height: 20px"></asp:Label>
        <asp:TextBox ID="txtCarReg" runat="server" style="z-index: 1; left: 241px; top: 105px; position: absolute; height: 16px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStartDate" runat="server" Text="Start Date" style="z-index: 1; left: 8px; top: 165px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server" style="z-index: 1; left: 239px; top: 151px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEndDate" runat="server" Text="End Date" style="z-index: 1; left: 12px; top: 223px; position: absolute; bottom: 422px"></asp:Label>
        <asp:TextBox ID="txtEndDate" runat="server" style="z-index: 1; left: 242px; top: 207px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Location" style="z-index: 1; left: 11px; top: 273px; position: absolute"></asp:Label>
        <asp:DropDownList ID="ddlLocation" runat="server" style="z-index: 1; left: 251px; top: 262px; position: absolute">
            <asp:ListItem>A1</asp:ListItem>
            <asp:ListItem>B2</asp:ListItem>
            <asp:ListItem>C3</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 320px; position: absolute"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnSkip" runat="server" OnClick="btnSkip_Click" style="z-index: 1; top: 355px; position: absolute; left: 30px" Text="Skip Car Park Reservation" />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Confirm Reservation" style="z-index: 1; left: 271px; top: 354px; position: absolute" />
    
    </div>
    </form>
</body>
</html>