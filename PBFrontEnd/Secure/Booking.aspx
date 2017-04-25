<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="Booking.aspx.cs" Inherits="Booking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblSelectTickets" runat="server" style="z-index: 1; left: 283px; top: 81px; position: absolute" Text="Select No. Of Tickets:"></asp:Label>
    <asp:Label ID="lblID" runat="server" style="z-index: 1; left: 645px; top: 148px; position: absolute" Text="Destination ID:"></asp:Label>
    <asp:Label ID="lblPP" runat="server" style="z-index: 1; left: 641px; top: 113px; position: absolute" Text="Price Per Person:"></asp:Label>
    <asp:Label ID="lblDestination" runat="server" Text="Destination Flying To:" style="z-index: 1; left: 636px; top: 80px; position: absolute"></asp:Label>
    <asp:TextBox ID="txtDestination" runat="server" style="z-index: 1; left: 488px; top: 31px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 287px; top: 149px; position: absolute" Text="Total Price:"></asp:Label>
    <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 136px; top: 96px; position: absolute; right: 756px"></asp:TextBox>
    <asp:TextBox ID="txtBookingApproved" runat="server" style="z-index: 1; left: 138px; top: 132px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblBookingApproved" runat="server" style="z-index: 1; left: 287px; top: 180px; position: absolute" Text="Booking Approved:"></asp:Label>
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: -105px; top: 178px; position: absolute" Text="Submit Booking" />
    <asp:DropDownList ID="ddlTickets" runat="server" style="z-index: 1; left: 189px; top: 34px; position: absolute">
        <asp:ListItem Value="1"></asp:ListItem>
        <asp:ListItem Value="2"></asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="lblBookingDate" runat="server" style="z-index: 1; left: 285px; top: 113px; position: absolute" Text="Booking Date:"></asp:Label>
    <asp:TextBox ID="txtBookingDate" runat="server" style="z-index: 1; left: 137px; top: 61px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtID" runat="server" style="z-index: 1; left: 491px; top: 101px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPP" runat="server" style="z-index: 1; left: 488px; top: 64px; position: absolute"></asp:TextBox>
    <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" style="z-index: 1; left: 41px; top: 177px; position: absolute" Text="Calculate Price" />
</asp:Content>

