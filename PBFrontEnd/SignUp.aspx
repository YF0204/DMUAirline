<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SignUp.aspx.vb" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="SelinaLogin1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <header align="center"> DmuAirline</header>
    <form id="form1" runat="server">
    <div>
    
    </div>
    
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" ContinueDestinationPageUrl="MainMenu.aspx" style="height: 486px; width: 515px; z-index: 1; left: 689px; top: 271px; position: absolute;">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" />
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
        </asp:CreateUserWizard>
    
    </form>
</body>
</html>
