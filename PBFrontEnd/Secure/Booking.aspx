<%@ Page Title="" Language="C#" MasterPageFile="~/Secure/ProjectBank.master" AutoEventWireup="true" CodeFile="Booking.aspx.cs" Inherits="Booking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblSelectTickets" runat="server" style="z-index: 1; left: 141px; top: 148px; position: absolute" Text="Select No. Of Tickets:"></asp:Label>
    <asp:Label ID="lblID" runat="server" style="z-index: 1; left: 761px; top: 246px; position: absolute" Text="Destination ID:"></asp:Label>
    <asp:Label ID="lblPP" runat="server" style="z-index: 1; left: 764px; top: 182px; position: absolute" Text="Price Per Person:"></asp:Label>
    <asp:Label ID="lblDestination" runat="server" Text="Destination Flying To:" style="z-index: 1; left: 758px; top: 118px; position: absolute"></asp:Label>
    <asp:TextBox ID="txtDestination" runat="server" style="z-index: 1; left: 795px; top: 61px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 146px; top: 266px; position: absolute" Text="Total Price:"></asp:Label>
    <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 165px; top: 216px; position: absolute; right: 1051px"></asp:TextBox>
    <asp:TextBox ID="txtBookingApproved" runat="server" style="z-index: 1; left: 164px; top: 288px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblBookingApproved" runat="server" style="z-index: 1; left: 147px; top: 346px; position: absolute" Text="Booking Approved:"></asp:Label>
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 301px; top: 497px; position: absolute" Text="Submit Booking" />
    <asp:DropDownList ID="ddlTickets" runat="server" style="z-index: 1; left: 171px; top: 91px; position: absolute">
        <asp:ListItem Value="1"></asp:ListItem>
        <asp:ListItem Value="2"></asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="lblBookingDate" runat="server" style="z-index: 1; left: 145px; top: 200px; position: absolute" Text="Booking Date:"></asp:Label>
    <asp:TextBox ID="txtBookingDate" runat="server" style="z-index: 1; left: 161px; top: 150px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 764px; top: 298px; position: absolute" Text="Customer ID:"></asp:Label>
    <asp:TextBox ID="txtCarParkID" runat="server" style="z-index: 1; left: 807px; top: 248px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblCarParkID" runat="server" style="z-index: 1; left: 770px; top: 364px; position: absolute" Text="Car Park ID:"></asp:Label>
    <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 806px; top: 315px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtID" runat="server" style="z-index: 1; left: 803px; top: 189px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPP" runat="server" style="z-index: 1; left: 801px; top: 131px; position: absolute"></asp:TextBox>
    <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" style="z-index: 1; left: -126px; top: 497px; position: absolute" Text="Calculate Price" />
</asp:Content>

