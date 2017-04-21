<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="MakeBooking.aspx.cs" Inherits="MakeBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ListBox ID="lstPickDestination" runat="server" Height="322px" Width="310px"></asp:ListBox>
    <asp:Button ID="btnMakeBooking" runat="server" OnClick="btnMakeBooking_Click" style="z-index: 1; left: 5px; top: 332px; position: absolute" Text="Make Booking For Selected Destination" />
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 652px; top: 382px; position: absolute"></asp:Label>
</asp:Content>

