<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="NewDestination.aspx.cs" Inherits="NewDestination" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <asp:Label ID="lblDestinationName" runat="server" Text="Destination Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtDestinationName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblPrice" runat="server" Text="Price Per Person"></asp:Label>
&nbsp;<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Day of Flight"></asp:Label>
        <asp:TextBox ID="txtDayofFlight" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblReturnDate" runat="server" Text="Return Date"></asp:Label>
        <asp:TextBox ID="txtReturnDate" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

