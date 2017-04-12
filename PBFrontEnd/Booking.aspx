<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="Booking.aspx.cs" Inherits="Booking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblDestination" runat="server" Text="Destination flying to:"></asp:Label>
    <asp:TextBox ID="txtDestination" runat="server" style="z-index: 1; left: 140px; top: -1px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 207px; top: 88px; position: absolute" Text="Total Price:"></asp:Label>
    <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 142px; top: 33px; position: absolute; right: 577px"></asp:TextBox>
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 9px; top: 70px; position: absolute" Text="OK" />
</asp:Content>

