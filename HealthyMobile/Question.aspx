<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Question.aspx.vb" Inherits="Question" %>

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
    <style type="text/css">
        .style1
        {
            height: 24px;
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
            <h3 class="ui-bar ui-bar-a">แบบสอบถาม</h3>
                <table style="width:100%; top: 0px;">
                    <tr>
                        <td class="style1">
                            <table style="width:100%;">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="1. เพศ"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:RadioButtonList ID="RadioButtonList3" runat="server" 
                                            RepeatDirection="Horizontal">
                                            <asp:ListItem>ชาย</asp:ListItem>
                                            <asp:ListItem>หญิง</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <table style="width:100%;">
                                <tr>
                                    <td class="style1">
                                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="2. อายุ"></asp:Label>
                                    </td>
                                    <td class="style1">
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="3. สูบบุหรี่"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Size="Small">
                                <asp:ListItem>ไม่สูบ</asp:ListItem>
                                <asp:ListItem>สูบ 5 - 10 มวน</asp:ListItem>
                                <asp:ListItem>สูบ 10 - 15 มวน</asp:ListItem>
                                <asp:ListItem>สูบมากกว่า 20 มวน</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="4. ดื่มสุรา"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                                <asp:ListItem>ไม่ดื่ม</asp:ListItem>
                                <asp:ListItem>ดื่มเป็นประจำ</asp:ListItem>
                                <asp:ListItem>ดื่มเป็นครั้งคราว</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="5. โรคประจำตัว"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="เบาหวาน" />
                            <asp:CheckBox ID="CheckBox2" runat="server" Text="โรคความดันโลหิตสูง" />
                            <asp:CheckBox ID="CheckBox3" runat="server" Text="ภาวะไขมันสูง" />
                            <asp:CheckBox ID="CheckBox4" runat="server" Text="โรคตับ" />
                            <asp:CheckBox ID="CheckBox5" runat="server" Text="โลหิตจาง" />
                            <asp:CheckBox ID="CheckBox6" runat="server" Text="โรคเก๊าต์" />
                            <asp:CheckBox ID="CheckBox7" runat="server" Text="โรคต่อมธัยรอยด์" />
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
