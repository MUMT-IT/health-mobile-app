<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LineBMI.aspx.vb" Inherits="ResultLine_LineBMI" %>
<html>
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="../themes/MyJQueryTheme.css" />
    <link rel="stylesheet" href="../themes/jquery.mobile.icons.min.css" />
    <link rel="stylesheet" href="../JQuery/jquery.mobile-1.4.5.min.css" />
    <script type="text/javascript" src="../JQuery/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="../JQuery/jquery.mobile-1.4.5.min.js"></script>    
    <script src="../highcharts/js/highcharts.js" type="text/javascript"></script>
    <script src="../highcharts/js/modules/data.js" type="text/javascript"></script>
    <script src="../highcharts/js/modules/drilldown.js" type="text/javascript"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <%=PlodLine()%>
    <div id="PlotID1" style="min-width: 100%; height: 300px; margin: 0 auto" visible="true" ></div>
    <div data-theme="d" data-form="ui-body-d" class="ui-body ui-body-d ui-corner-all">
        คำอธิบาย xxxxxxxxxxxxxxxxxxxx
    </div>
    <asp:Button ID="btnMain" runat="server"  Text="Back" />
    </form>
</body>
</html>
