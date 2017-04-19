<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="Booking.aspx.cs" Inherits="Booking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblSelectTickets" runat="server" style="z-index: 1; left: 189px; top: 56px; position: absolute" Text="Select No. Of Tickets:"></asp:Label>
    <asp:Label ID="lblDestination" runat="server" Text="Destination Flying To:"></asp:Label>
    <asp:TextBox ID="txtDestination" runat="server" style="z-index: 1; left: 140px; top: -1px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 190px; top: 127px; position: absolute" Text="Total Price:"></asp:Label>
    <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 136px; top: 96px; position: absolute; right: 756px"></asp:TextBox>
    <asp:TextBox ID="txtBookingApproved" runat="server" style="z-index: 1; left: 138px; top: 132px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblBookingApproved" runat="server" style="z-index: 1; left: 193px; top: 162px; position: absolute" Text="Booking Approved:"></asp:Label>
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 304px; top: 76px; position: absolute" Text="OK" />
    <asp:DropDownList ID="ddlTickets" runat="server" style="z-index: 1; left: 189px; top: 34px; position: absolute">
        <asp:ListItem Value="1"></asp:ListItem>
        <asp:ListItem Value="2"></asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="lblBookingDate" runat="server" style="z-index: 1; left: 192px; top: 89px; position: absolute" Text="Booking Date:"></asp:Label>
    <asp:TextBox ID="txtBookingDate" runat="server" style="z-index: 1; left: 137px; top: 61px; position: absolute"></asp:TextBox>
</asp:Content>

