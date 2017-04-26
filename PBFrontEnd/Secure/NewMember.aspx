<%@ Page Title="" Language="C#" MasterPageFile="~/Secure/ProjectBank.master" AutoEventWireup="true" CodeFile="NewMember.aspx.cs" Inherits="NewMember" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        New Staff Member Details</p>
    <p>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 105px; top: 40px; position: absolute"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
&nbsp;<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblContactNo" runat="server" Text="Contact No"></asp:Label>
&nbsp;<asp:TextBox ID="txtContactNo" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Date of Birth"></asp:Label>
&nbsp;<asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblPostCode" runat="server" Text="Postcode"></asp:Label>
&nbsp;<asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblDateJoined" runat="server" Text="Date Joined"></asp:Label>
&nbsp;<asp:TextBox ID="txtDateJoined" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblEmail" runat="server" Text="Email Address"></asp:Label>
&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </p>
    <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </p>
</asp:Content>

