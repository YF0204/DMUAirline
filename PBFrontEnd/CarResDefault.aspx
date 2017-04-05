<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarResDefault.aspx.cs" Inherits="CarResDefault" %>

<<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href ="OmerStylesheet.css" rel ="stylesheet" type ="text/css" />
</head>
<body>
    <header align="center"> DmuAirline<br />
     
    </header>
    <form id="form1" runat="server">
        <asp:ListBox ID="LstCarReg" runat="server" Height="267px" Width="249px"></asp:ListBox>
    <div>
    
        <asp:Label ID="LblCarReg" runat="server" Text="Please Enter Your Car Reg"></asp:Label>
    
    </div>
        <p>
            <asp:TextBox ID="TxtCarReg" runat="server"></asp:TextBox>
            <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" style="z-index: 1; left: 169px; top: 493px; position: absolute; height: 27px; width: 66px; right: 1165px;" Text="Delete" />
            <asp:Button ID="BtnFilter" runat="server" OnClick="BtnFilter_Click" style="z-index: 1; left: 163px; top: 452px; position: absolute; height: 26px" Text="Apply" />
        </p>
        <p>
            <asp:Button ID="BtnAdd" runat="server" Text="Add" Width="78px" OnClick="BtnAdd_Click" style="height: 26px" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Update" Width="63px" OnClick="BtnUpdate_Click" style="height: 26px" />
        </p>
    </form>
</body>
</html>

