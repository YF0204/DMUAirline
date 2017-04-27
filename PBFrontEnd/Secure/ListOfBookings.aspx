<%@ Page Title="" Language="C#" MasterPageFile="~/Secure/ProjectBank.master" AutoEventWireup="true" CodeFile="ListOfBookings.aspx.cs" Inherits="ListOfBookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ListBox ID="lstBookings" runat="server" Height="213px" Width="338px"></asp:ListBox>
    <asp:Label ID="lblError" runat="server" style="position: absolute; z-index: 1; left: 192px; top: 396px"></asp:Label>
    <asp:Button ID="btnCustomerManage" runat="server" OnClick="btnCustomerManage_Click" style="z-index: 1; left: 196px; top: 277px; position: absolute" Text="Customer Management" />
    <asp:Button ID="btnManageCarParkRes" runat="server" OnClick="btnManageCarParkRes_Click" style="z-index: 1; left: 2px; top: 277px; position: absolute" Text="Car Park Reservations" />
    <asp:Button ID="btnDestinationManage" runat="server" OnClick="btnDestinationManage_Click" style="z-index: 1; left: 556px; top: 277px; position: absolute" Text="Destinations" />
    <br />
    <asp:Button ID="btnStaffManage" runat="server" OnClick="btnStaffManage_Click" style="z-index: 1; left: 399px; top: 277px; position: absolute" Text="Staff Management" />
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Update Booking" OnClick="btnUpdate_Click" />
    <asp:Button ID="btnFilterDate" runat="server" Text="Filter Bookings by Date" OnClick="btnFilterDate_Click" />
    </asp:Content>

