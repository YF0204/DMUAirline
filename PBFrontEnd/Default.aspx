<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:ListBox ID="lstDestinations" runat="server" Height="172px" Width="213px"></asp:ListBox>
    </p>
    <p>
        <asp:Button ID="btnAddDestination" runat="server" OnClick="btnAddDestination_Click" Text="Add Destination" />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update Destination" />
        <asp:Button ID="btnSearch" runat="server" Text="Search for Destination" OnClick="btnSearch_Click" />
</p>
    <p>
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        <asp:Label ID="lblSearch" runat="server" Text="Please enter a Destination"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 510px; top: 263px; position: absolute"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>


