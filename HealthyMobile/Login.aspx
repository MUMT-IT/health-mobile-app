<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="themes/MyJQueryTheme.css" />
    <link rel="stylesheet" href="themes/jquery.mobile.icons.min.css" />
    <link rel="stylesheet" href="JQuery/jquery.mobile-1.4.5.min.css" />
    <script type="text/javascript" src="JQuery/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="JQuery/jquery.mobile-1.4.5.min.js"></script>    
    <script src="highcharts/js/highcharts.js" type="text/javascript"></script>
    <script src="highcharts/js/modules/data.js" type="text/javascript"></script>
    <script src="highcharts/js/modules/drilldown.js" type="text/javascript"></script>
    <style type="text/css">
        .style3
        {
            height: 23px;
        }
        .style4
        {
            height: 23px;
        }
        .style5
        {
        }
        .style6
        {
            height: 23px;
            width: 104px;
        }
        .style7
        {
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
     <div data-role="page">
            <div data-role="header">
                <h1>Healthy Mobile</h1>
            </div>
            <div data-role="main" class="ui-content">
                <table style="width:100%;">
                    <tr>
                        <td class="style6">
                            &nbsp;<img src="image/Banner/20120724132713.gif" style="width: 69px; height: 72px" /></td>
                        <td class="style3">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
                                Text="Login Good Healthy Mobile"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4" colspan="2">
                            บัตรประชาชน                    <tr>
                        <td class="style4" colspan="2">
                            <asp:TextBox ID="txtCID" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5" colspan="2">
                            รหัสผ่าน</td>
                    </tr>
                    <tr>
                        <td class="style5" colspan="2">
                            <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7" colspan="2">
                            <asp:Button ID="btnLogIN" data-icon="lock" runat="server" Text="Login" />
                        </td>
                    </tr>
                    </table>
              
                </p>
            </div>
            <div data-role="footer">
                <h2>@ Faculty of Medical Technology</h2>
            </div>
    </div>
    </form>
</body>
</html>
