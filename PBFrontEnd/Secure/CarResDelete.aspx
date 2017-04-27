<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarResDelete.aspx.cs" Inherits="CarResDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href ="OmerStylesheet.css" rel ="stylesheet" type ="text/css" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="height: 353px">
    <header align="center"> 
        <div class="auto-style1">
            DmuAirline<br />
        </div>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="LblMessage" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 18px; width: 191px" Text="Are you sure you want to delete this reservation?"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnNo" runat="server" style="z-index: 1; left: 65px; top: 100px; position: absolute; width: 39px;" Text="No" />
        </p>
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" Text="Yes" style="z-index: 1; left: 16px; top: 99px; position: absolute" />
    </form>
</body>
</html>
