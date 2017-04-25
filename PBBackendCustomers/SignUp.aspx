<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

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
    
    </div>
    
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" style="z-index: 1; left: 452px; top: 269px; position: absolute; height: 486px; width: 515px">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" />
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
        </asp:CreateUserWizard>
    
    </form>
</body>
</html>
