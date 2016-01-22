<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Knowledge.aspx.vb" Inherits="Knowledge" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="themes/MyJQueryTheme.css" />
    <link rel="stylesheet" href="themes/jquery.mobile.icons.min.css" />
    <link rel="stylesheet" href="JQuery/jquery.mobile-1.4.5.min.css" />
    <script type="text/javascript" src="JQuery/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="JQuery/jquery.mobile-1.4.5.min.js"></script>    
    <style type="text/css">
        .style1
        {
            width: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div data-role="page" data-theme="d">
            <div data-role="header">
                <h1>Heathy Mobile</h1>
                <div data-role="navbar">
                    <ul>
                        <li><a href="MainHealthy.aspx" data-icon="home">Home</a></li>
                        <li><a href="AppHealthy.aspx"  data-icon="search">Knowledge</a></li>
                        <li><a href="AppHealthy.aspx" data-icon="heart">App Healthy</a></li>
                        <li><a href="#page3" data-icon="info">Contact</a></li>
                    </ul>
                </div>
            </div>
           
            <div data-role="main" class="ui-content">
            <div data-theme="d" data-form="ui-body-d" class="ui-body ui-body-d ui-corner-all">
            <h3 class="ui-bar ui-bar-a">ความรู้ คำแนะนำด้านสุขภาพ</h3>
                <table style="width:100%;">
                    <tr>
                        <td >
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        <td class="style1">
                            <asp:Button ID="btnSearch" data-icon="search" runat="server" text="ค้นหา" />
                        </td>
                    </tr>
                </table>
                 
            </div>
             
           
            <div data-role="footer">
                <h2>@ Faculty of Medical Technology</h2>
            </div>
    </div>
    </form>
</body>
</html>
