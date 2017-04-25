<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerSignUp.aspx.cs" Inherits="CustomerSignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">

        <link href="Login.css" rel="stylesheet" type="text/css" />
    <div>
        <header align="center"> DmuAirline</header>
        <table align="center">
        <tr>
            

            <td>FirstName:</td>
            <td>
                <asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox>
            </td></tr>

            <tr>
                <td> Surname:</td>
                </td><td> 
                    <asp:TextBox ID="TxtSurname" runat="server"></asp:TextBox>
                </td></tr>
            <tr>
                <td>Address1</td>
                <td>
                    <asp:TextBox ID="TxtAddress1" runat="server"></asp:TextBox>
                </td>                
        </tr>
         <tr>
                <td> Address2:</td>
                <td>
                    <asp:TextBox ID="TxtAddress2" runat="server"></asp:TextBox>
                </td>                
        </tr>
        <tr>
          <td> Postcode:</td>
                <td>
                    <asp:TextBox ID="TxtPostcode" runat="server"></asp:TextBox>
            </td>                
        </tr>
          <td> PhoneNumber:</td>
                <td>
                    <asp:TextBox ID="TxtPhoneNumber" runat="server"></asp:TextBox>
            </td>                
        </tr>
        <td> Email:</td>
                <td>
                    <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            </td>                
        </tr>


         </table>
    
        <asp:Button ID="BtnOK" runat="server" OnClick="BtnOk_Click" Text="OK" Width="119px" />
        <asp:Button ID="BtnCancel" runat="server" Text="Cancel" />
        <asp:Label ID="LblError" runat="server" Text="LblError"></asp:Label>
    
    </div>
    </form>
</body>
</html>
    <div>
    
   
