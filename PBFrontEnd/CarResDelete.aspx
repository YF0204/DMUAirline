<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarResDelete.aspx.cs" Inherits="CarResDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href ="OmerStylesheet.css" rel ="stylesheet" type ="text/css" />
</head>
<body style="height: 353px">
    <header align="center"> DmuAirline<br />
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="LblMessage" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 18px; width: 191px" Text="Are you sure you want to delete this reservation?"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnNo" runat="server" style="z-index: 1; left: 69px; top: 202px; position: absolute" Text="No" />
        </p>
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" Text="Yes" />
    </form>
</body>
</html>
