<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="Booking.aspx.cs" Inherits="Booking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblSelectTickets" runat="server" style="z-index: 1; left: 189px; top: 70px; position: absolute" Text="Select No. Of Tickets:"></asp:Label>
    <asp:Label ID="lblDestination" runat="server" Text="Destination Flying To:"></asp:Label>
    <asp:TextBox ID="txtDestination" runat="server" style="z-index: 1; left: 140px; top: -1px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 190px; top: 107px; position: absolute" Text="Total Price:"></asp:Label>
    <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 76px; top: 69px; position: absolute; right: 791px"></asp:TextBox>
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 225px; top: 66px; position: absolute" Text="OK" />
    <asp:DropDownList ID="ddlTickets" runat="server" style="z-index: 1; left: 141px; top: 33px; position: absolute">
        <asp:ListItem Value="1"></asp:ListItem>
        <asp:ListItem Value="2"></asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
    </asp:DropDownList>
</asp:Content>

