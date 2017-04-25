<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="SelinaLogin1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <header align="center"> &nbsp;DmuAirline</header>
    <form id="form1" runat="server">
    <div>
    
        <asp:Login ID="Login1" runat="server" CreateUserText="Sign Up" CreateUserUrl="SignUp.aspx" DestinationPageUrl="Secure/Customers.aspx" style="z-index: 1; left: 500px; top: 281px; position: absolute; height: 264px; width: 420px; right: 315px;">
        </asp:Login>
    
    </div>
    </form>
</body>
</html>
