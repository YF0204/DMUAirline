<%@ Page Title="" Language="C#" MasterPageFile="~/Secure/ProjectBank.master" AutoEventWireup="true" CodeFile="ListOfBookings.aspx.cs" Inherits="ListOfBookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ListBox ID="lstBookings" runat="server" Height="213px" Width="338px"></asp:ListBox>
    <asp:Label ID="lblError" runat="server" style="position: absolute; z-index: 1; left: 199px; top: 299px"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Update Booking" OnClick="btnUpdate_Click" />
    <asp:Button ID="btnFilterDate" runat="server" Text="Filter Bookings by Date" OnClick="btnFilterDate_Click" />
    </asp:Content>

