<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="JQuery/jquery.mobile-1.4.5.min.css" />
    <script src="JQuery/jquery-1.11.1.min.js"></script>
    <script src="JQuery/jquery.mobile-1.4.5.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
   
    <div data-role="page">
            <div data-role="header">
                <h1>My First Page</h1>
            </div>
            <div data-role="main" class="ui-content">
               
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Button" />
               
            </div>
            <div data-role="footer">
                <h2>Test Footer</h2>
            </div>
    </div>
    
    </form>
</body>
</html>
