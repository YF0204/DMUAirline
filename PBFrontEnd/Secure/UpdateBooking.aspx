<%@ Page Title="" Language="C#" MasterPageFile="~/Secure/ProjectBank.master" AutoEventWireup="true" CodeFile="UpdateBooking.aspx.cs" Inherits="UpdateBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 136px; top: 96px; position: absolute; right: 756px"></asp:TextBox>
    <asp:Label ID="lblID" runat="server" style="z-index: 1; left: 498px; top: 93px; position: absolute" Text="Destination ID:"></asp:Label>
    <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 245px; top: 122px; position: absolute" Text="Total Price:"></asp:Label>
    <asp:Label ID="lblBookingApproved" runat="server" style="z-index: 1; left: 197px; top: 157px; position: absolute" Text="Booking Approved:"></asp:Label>
    <asp:Label ID="lblBookingDate" runat="server" style="z-index: 1; left: 227px; top: 87px; position: absolute" Text="Booking Date:"></asp:Label>
    <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 502px; top: 124px; position: absolute" Text="Customer ID:"></asp:Label>
    <asp:Label ID="lblCarParkID" runat="server" style="z-index: 1; left: 505px; top: 159px; position: absolute" Text="Car Park ID:"></asp:Label>
    <asp:TextBox ID="txtBookingApproved" runat="server" style="z-index: 1; left: 141px; top: 124px; position: absolute"></asp:TextBox>
    <asp:Button ID="btnConfirmUpdate" runat="server" OnClick="btnConfirmUpdate_Click" style="z-index: 1; left: 6px; top: 165px; position: absolute" Text="Confirm Changes" />
    <asp:TextBox ID="txtBookingDate" runat="server" style="z-index: 1; left: 137px; top: 61px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtCarParkID" runat="server" style="z-index: 1; left: 413px; top: 128px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 414px; top: 93px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtDestinationID" runat="server" style="z-index: 1; left: 413px; top: 59px; position: absolute"></asp:TextBox>
</asp:Content>

