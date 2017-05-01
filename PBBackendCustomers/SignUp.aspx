<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CustomerStaff.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <header align="center"> DmuAirline</header>
    <form id="form1" runat="server" style="z-index: 1">
    <div>
    
        <br />
&nbsp;&nbsp;
        <br />
        <br />
        <br />
&nbsp;&nbsp;
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" CancelDestinationPageUrl="Login.aspx" ContinueDestinationPageUrl="Login.aspx">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" />
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
        </asp:CreateUserWizard>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    
    </form>
</body>
</html>
