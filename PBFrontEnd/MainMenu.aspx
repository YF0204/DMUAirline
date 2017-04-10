<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="MainMenu.aspx.cs" Inherits="MainMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    Select a flight to book from the list below:</p>
    <p>
        <asp:ListBox ID="lstDestinationPicker" runat="server" Height="214px" Width="384px"></asp:ListBox>
        <br />
</p>
</asp:Content>

