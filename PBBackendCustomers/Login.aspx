<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="CustomerStaff.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <header align="center"> DmuAirline</header>
    <form id="form1" runat="server">
    <div>
    
        <asp:Login ID="Login1" runat="server" CreateUserText="Sign Up" CreateUserUrl="SignUp.aspx" DestinationPageUrl="Secure/MainMenu.aspx" style="z-index: 1; left: 445px; top: 311px; position: absolute; height: 264px; width: 420px">
        </asp:Login>
    
    </div>
    </form>
</body>
</html>
