<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarResDefault.aspx.cs" Inherits="CarResDefault" %>

<head runat="server">
    <title></title>
    <link href ="OmerStylesheet.css" rel ="stylesheet" type ="text/css" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <header align="center" class="auto-style1"> DmuAirline<br />
     
    </header>
    <form id="form1" runat="server">
        <asp:ListBox ID="LstCarReg" runat="server" OnSelectedIndexChanged="LstCarReg_SelectedIndexChanged" style="z-index: 1; left: 415px; top: 121px; position: absolute; width: 665px; height: 282px"></asp:ListBox>
    <div style="text-align: center">
    
        <asp:Label ID="LblCarReg" runat="server" Text="Please Enter Your Car Reg" style="z-index: 1; left: 13px; top: 150px; position: absolute"></asp:Label>
    
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 563px; top: 91px; position: absolute" Text="Booking Date"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 758px; top: 88px; position: absolute" Text="Start Date"></asp:Label>
        Car Park Reservation<asp:Label ID="Label4" runat="server" style="z-index: 1; left: 938px; top: 86px; position: absolute" Text="End Date"></asp:Label>
    
    </div>
        <p>
            <asp:TextBox ID="TxtCarReg" runat="server" style="z-index: 1; left: 10px; top: 107px; position: absolute"></asp:TextBox>
            <asp:Button ID="BtnFilter" runat="server" OnClick="BtnFilter_Click" style="z-index: 1; left: 163px; top: 109px; position: absolute; height: 20px; right: 1149px; width: 48px;" Text="Apply" />
            <asp:Button ID="BtnAdd" runat="server" Text="Add" Width="78px" OnClick="BtnAdd_Click" style="height: 26px; z-index: 1; left: 421px; top: 417px; position: absolute;" />
            <asp:Button ID="BtnUpdate" runat="server" Text="Update" Width="63px" OnClick="BtnUpdate_Click" style="height: 26px; z-index: 1; left: 528px; top: 418px; position: absolute;" />
            <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" style="z-index: 1; left: 625px; top: 421px; position: absolute; height: 27px; width: 66px; " Text="Delete" />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 429px; top: 95px; position: absolute; width: 53px" Text="Car Reg"></asp:Label>
        </p>
    </form>
</body>
</html>

