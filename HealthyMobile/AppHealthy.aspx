<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AppHealthy.aspx.vb" Inherits="AppHealthy" %>

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
    <script type="text/javascript" src="JQuery/jquery.canvasjs.min.js"></script>
    <script src="highcharts/js/highcharts.js" type="text/javascript"></script>
    <script src="highcharts/js/modules/data.js" type="text/javascript"></script>
    <script src="highcharts/js/modules/drilldown.js" type="text/javascript"></script>
    <style type="text/css">
        .style1
        {
            width: 107px;
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
                        <li><a href="Knowledge.aspx" data-transition="slide" data-icon="search">Knowledge</a></li>
                        <li><a href="AppHealthy.aspx" data-icon="heart">App Healthy</a></li>
                        <li><a href="#page3" data-icon="info">Contact</a></li>
                    </ul>
                </div>
            </div>
           <div data-role="main" class="ui-content">
            <div data-theme="d" data-form="ui-body-d" class="ui-body ui-body-d ui-corner-all">
            <div data-role="collapsible"  data-collapsed="false">
                <h3>แนะนำ Application</h3>
                <p>
                    <table style="width:100%;">
                        <tr>
                            <td class="style1">
                                <img src="image/App/ICON_DoctorMe.jpg" style="width: 80px; height: 78px" /></td>
                            <td style="font-size: small">
                                <b>DoctorMe</b> แอพเพื่อสุขภาพ 
                                เปลี่ยนตัวเองให้เป็นผู้รอบรู้ในเรื่องการดูแลสุขภาพได้ง่ายๆแค่ปลายนิ้ว</td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <img src="image/App/ICON_GoogleFit.jpg" style="width: 79px; height: 66px" /></td>
                            <td style="font-size: small">
                                <b>Google Fit</b> นับจำนวนก้าวที่เดิน ระยะทาง 
                                หรือแม้แต่ปริมาณแคลอรี่ที่เผาผลาญไป โดยแอพพลิเคชั่นนี้จะคำนวณให้โดยอัตโนมัติ</td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <img src="image/App/ICON_Kalmemo8.jpg" style="width: 74px; height: 70px" /></td>
                            <td style="font-size: small">
                                <b>Kalmemo8</b> Web 
                                ฐานข้อมูลแคลอรี่ในอาหารเพื่อให้คุณสามารถควบคุณปริมาณแคลอรี่ที่ควรบริโภคได้</td>
                        </tr>
                        <tr>
                            <td class="style1">
                                <img src="image/App/ICON_RunKeeper.jpg" style="width: 72px; height: 70px" /></td>
                            <td style="font-size: small">
                                <b>RunKeeper</b> ตรวจจับระยะทาง ความเร็วในการวิ่ง พลังงานที่เผาผลาญ 
                                และอัตราการเต้นของหัวใจในขณะที่กำลังวิ่งได้</td>
                        </tr>
                    </table>
                </p>
            </div>  
            </div>
            <div data-role="footer">
                <h2>@ Faculty of Medical Technology</h2>
            </div>
    </div>
    </form>
</body>
</html>
