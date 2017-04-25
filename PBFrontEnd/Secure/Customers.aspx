<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Login.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <header align="center"> DmuAirline</header>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;</div>
                    <asp:ListBox ID="lstCustomers" runat="server" Height="391px" Width="387px"></asp:ListBox>
            </br>
            <asp:Label ID="LblError" runat="server" Text="Please enter a surname"></asp:Label>
            </br>
            
                    <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; width: 300px"></asp:TextBox>
                            
            
            
        
        <asp:Button ID="BtnSearchSurname" runat="server" OnClick="BtnSearchSurname_Click" Text="Search Surname" style="z-index: 1; left: 332px; top: 693px; position: absolute; height: 40px; width: 224px" />
            
            
            
        
                </br> 
                &nbsp;&nbsp;&nbsp;
            
            
            
        
                </br>
                    
        <asp:Button ID="BtnAdd" runat="server" Height="76px" OnClick="Add_Click1" Text="Add" Width="151px" />
            
            
            
        
        <asp:Button ID="BtnUpdate" runat="server" Height="77px" Text="Update" Width="143px" OnClick="BtnUpdate_Click" />
            
            
            
        
    </form>
</body>
</html>
