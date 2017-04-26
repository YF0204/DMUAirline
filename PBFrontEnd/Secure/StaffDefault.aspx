<%@ Page Title="" Language="C#" MasterPageFile="~/Secure/ProjectBank.master" AutoEventWireup="true" CodeFile="StaffDefault.aspx.cs" Inherits="StaffDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Staff Members</p>
    <p>
        <asp:ListBox ID="lstStaff" runat="server" Height="215px" Width="237px"></asp:ListBox>
    </p>
    <p>
        <asp:TextBox ID="txtSearchStaff" runat="server"></asp:TextBox>
        <asp:Label ID="lblSearchStaff" runat="server" Text="Please enter the last name of a staff member"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnAddStaff" runat="server" OnClick="btnAddStaff_Click" Text="Add New Staff Member" />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update Staff Member Details" />
        <asp:Button ID="btnSearchStaff" runat="server" Text="Search for Staff Member" OnClick="btnSearchStaff_Click" />
    </p>
    <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </p>
</asp:Content>

