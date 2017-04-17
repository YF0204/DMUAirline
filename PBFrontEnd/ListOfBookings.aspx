<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="ListOfBookings.aspx.cs" Inherits="ListOfBookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ListBox ID="lstBookings" runat="server" Height="255px" Width="288px"></asp:ListBox>
    <br />
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Update Booking" />
    <asp:Button ID="btnFilterDate" runat="server" Text="Filter Bookings by Date" />
    <br />
    <br />
</asp:Content>

