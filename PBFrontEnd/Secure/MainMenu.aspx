<%@ Page Title="" Language="C#" MasterPageFile="~/Secure/ProjectBank.master" AutoEventWireup="true" CodeFile="MainMenu.aspx.cs" Inherits="MainMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Welcome to the DMU Airline Booking System. From here, you can book flights to many destinations around the world.</p>
    <p>
        <asp:Button ID="btnDestinations" runat="server" Text="Book a Flight" OnClick="btnDestinations_Click" />
        <asp:Button ID="btnStaffAccess" runat="server" Text="Staff Access" OnClick="btnStaffAccess_Click" style="z-index: 1; left: 0px; top: 75px; position: absolute; margin-top: 0px" />
        <asp:Button ID="btnCarParkRes" runat="server" OnClick="btnCarParkRes_Click" Text="Make a Car Park Reservation" />
        <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="Sign Up to DMU Airline" />
        <asp:ListBox ID="lstFlights" runat="server" style="z-index: 1; left: 4px; top: 112px; position: absolute; height: 192px; width: 489px"></asp:ListBox>
</p>
</asp:Content>

