<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ChanceDisease.aspx.vb" Inherits="ChanceDisease" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
     <link rel="stylesheet" href="themes/MyJQueryTheme.css" />
    <link rel="stylesheet" href="themes/jquery.mobile.icons.min.css" />
    <link rel="stylesheet" href="JQuery/jquery.mobile-1.4.5.min.css" />
    <script type="text/javascript" src="JQuery/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="JQuery/jquery.mobile-1.4.5.min.js"></script>    
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
            <h3 class="ui-bar ui-bar-a">ความเสี่ยงต่อโรค</h3>
                <table style="width: 100%;">
                    <tr>
                        <td>
                            <asp:Label ID="Label12" runat="server" Text="ความดันโลหิตสูง"></asp:Label>
                        </td>
                        <td >
                            <asp:Label ID="Label13" runat="server" ForeColor="#00CC00" 
                                style="font-weight: 700" Text="15 %"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="Button8" runat="server" Text="รายละเอียด" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="ภาวะไขมันสูง"></asp:Label>
                        </td>
                        <td >
                            <asp:Label ID="Label6" runat="server" ForeColor="#FF6600" 
                                style="font-weight: 700" Text="54 %"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="รายละเอียด" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="เบาหวาน"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label7" runat="server" ForeColor="#00CC00" 
                                style="font-weight: 700" Text="5 %"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="Button3" runat="server" Text="รายละเอียด" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="โรคไต"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label8" runat="server" ForeColor="#00CC00" 
                                style="font-weight: 700" Text="16 %"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="Button4" runat="server" Text="รายละเอียด" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            โรคตับ</td>
                        <td>
                            <asp:Label ID="Label9" runat="server" ForeColor="#FFCC00" 
                                style="font-weight: 700" Text="38 %"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="Button5" runat="server" Text="รายละเอียด" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            โรคเก๊าต์</td>
                        <td>
                            <asp:Label ID="Label10" runat="server" ForeColor="#00CC00" 
                                style="font-weight: 700" Text="15 %"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="Button6" runat="server" Text="รายละเอียด" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            ภาวะซีด</td>
                        <td>
                            <asp:Label ID="Label11" runat="server" ForeColor="#00CC00" 
                                style="font-weight: 700" Text="8 %"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="Button7" runat="server" Text="รายละเอียด" />
                        </td>
                    </tr>
                </table>
             <h3 class="ui-bar ui-bar-a">โรคตับ</h3>
                <table style="width: 100%;">
                    <tr>
                        <td>
                            <asp:Label ID="Label14" runat="server" Text="AST,ALT,ALK"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label15" runat="server" Font-Size="Small" Text="ดูสมรรถภาพตับ"></asp:Label>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    </table>
            <div data-role="footer">
                <h2>@ Faculty of Medical Technology</h2>
            </div>
    </div>
    </form>
</body>
</html>
