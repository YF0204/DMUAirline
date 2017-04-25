<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="MainMenu.aspx.cs" Inherits="MainMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Welcome to the DMU Airline Booking System. From here, you can book flights to many destinations around the world.</p>
    <p>
        <asp:Button ID="btnDestinations" runat="server" Text="Destinations" />
        <asp:Button ID="btnStaffAccess" runat="server" Text="Staff Access" />
</p>
</asp:Content>

