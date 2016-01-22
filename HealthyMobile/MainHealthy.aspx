<%@ Page Language="VB"  CodeFile="MainHealthy.aspx.vb" Inherits="MainHealthy" %>
    
    
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="themes/MyJQueryTheme.css" />
    <link rel="stylesheet" href="themes/jquery.mobile.icons.min.css" />
    <link rel="stylesheet" href="JQuery/jquery.mobile-1.4.5.min.css" />
    <script type="text/javascript" src="JQuery/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="JQuery/jquery.mobile-1.4.5.min.js"></script>    
    <script src="highcharts/js/highcharts.js" type="text/javascript"></script>
    <script src="highcharts/js/modules/data.js" type="text/javascript"></script>
    <script src="highcharts/js/modules/drilldown.js" type="text/javascript"></script>
    <title></title>
    
    <style type="text/css">
        .style10
        {
            width: 1241px;
            height: 164px;
        }
        .style14
        {
            width: 15px;
            height: 50px;
        }
        .style15
        {
            width: 60px;
            height: 33px;
        }
        .style16
        {
            height: 33px;
            width: 1063px;
        }
        .style17
        {
            width: 60px;
        }
        </style>
</head>
<body>

    <form id="form1" runat="server">
    <div data-role="page" id="page1" data-theme="d">
            <div data-role="header">
                <h1>Heathy Mobile</h1>
                <div data-role="navbar">
                    <ul>
                        <li><a href="MainHealthy.aspx" data-icon="home" >Home</a></li>
                        <li><a href="Knowledge.aspx"  data-icon="search">Knowledge</a></li>
                        <li><a href="AppHealthy.aspx" data-icon="heart">App Healthy</a></li>
                        <li><a href="#page3" data-icon="info">Contact</a></li>
                    </ul>
                </div>
            </div>
          
            <div data-theme="d" data-form="ui-body-d" class="ui-body ui-body-d ui-corner-all">
                <center>
                    <asp:Label ID="lblUserName" runat="server" 
                        Text="--"></asp:Label></center>
                 
            </div>
                <div data-role="collapsible"  data-collapsed="true">
                    <h1>รูปร่างและสัดส่วน</h1>
                    <p>
                        
                        <table class="style10">
                            <tr>
                                <td class="style15">
                                    <asp:Image ID="Image1" runat="server" Height="119px" Width="100px" />
                                </td>
                                <td class="style16">
                                    <table style="width:100%;">
                                        <tr>
                                            <td class="style17">
                                    ส่วนสูง</td>
                                            <td>
                                    <asp:Label ID="lblHeight" runat="server" Text="--" Font-Bold="True"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style17">
                                    น้ำหนัก</td>
                                            <td>
                                    <asp:Label ID="lblWeight" runat="server" Text="--" Font-Bold="True"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style17">
                                    ชีพจร</td>
                                            <td>
                                    <asp:Label ID="lblHeartRate" runat="server" Text="--" Font-Bold="True"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style17">
                                    ความดัน</td>
                                            <td>
                                    <asp:Label ID="lblSystolic" runat="server" Text="--" Font-Bold="True"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style17">
                                    รูปร่าง</td>
                                            <td>
                                    <asp:Label ID="lblInterpBMI" runat="server" Text="--" Font-Bold="True"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            </table>
                        
                    </p>
                  
                </div>
                <div data-role="collapsible"  data-collapsed="true">
                    <h1>แนวโน้มผลตรวจสุขภาพ</h1>
                <p>
                <div class="ui-grid-a">
                    <div class="ui-block-a"><a href="ResultLine/LineBMI.aspx" data-transition="pop" class="ui-btn ui-mini">รูปร่าง</a></div>
                    <div class="ui-block-b"><a href="ResultLine/LineBUN.aspx" data-transition="pop" class="ui-btn ui-mini">การทำงานไต</a></div>
                </div>
                <div class="ui-grid-a">
                    <div class="ui-block-a"> <a href="ResultLine/LineGLU.aspx" data-transition="pop" class="ui-btn ui-mini">น้ำตาลในเลือด</a></div>
                    <div class="ui-block-b"> <a href="ResultLine/LineUA.aspx" data-transition="pop" class="ui-btn ui-mini">กรดยูริกในเลือด</a></div>
                </div>
                <div class="ui-grid-a">
                    <div class="ui-block-a"><a href="ResultLine/LineChol.aspx" data-transition="pop" class="ui-btn ui-mini">กลุ่มไขมัน</a></div>
                    <div class="ui-block-b"><a href="ResultLine/LineAST.aspx" data-transition="pop" class="ui-btn ui-mini">การทำงานตับ</a></div>
                </div>
                <div class="ui-grid-a">
                    <div class="ui-block-a"><a href="ResultLine/LineCBC_Hb.aspx" data-transition="pop" class="ui-btn ui-mini">ดัชนีโลหิตวิทยา</a></div>
                    <div class="ui-block-b"><a href="ResultLine/LineCBC_P.aspx" data-transition="pop" class="ui-btn ui-mini">เกล็ดเลือด</a></div>
                </div>
                <div class="ui-grid-a">
                    <div class="ui-block-a"><a href="ResultLine/LineCBC_WBC_Count.aspx" data-transition="pop" class="ui-btn ui-mini">ปริมาณเม็ดเลือดขาว</a></div>
                    <div class="ui-block-b"> <a href="ResultLine/LineCBC_WBC.aspx" data-transition="pop" class="ui-btn ui-mini">เม็ดเลือดขาว</a></div>
                </div>
                        
                </p>
                </div>
                     
             
                <div data-role="collapsible"  data-collapsed="true" >
                    <h1>ความเสี่ยงต่อโรค</h1>
                    <p>
                        <table style="width: 100%;">
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_BUN_CRE.gif" 
                                        style="width: auto; height: 30px" /></td>
                                <td>
                                    <asp:Image ID="imgBUN" runat="server" Width="100%" />
                                </td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_AST.gif" style="width: auto; height: 30px" /></td>
                                <td>
                                    <asp:Image ID="ImgAST" runat="server" Width="100%" />
                                </td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_GLU.gif" style="width: auto; height: 30px" /></td>
                                <td>
                                    <asp:Image ID="ImgGLU" runat="server" Width="100%" />
                                 </td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_UA.gif" style="width: auto; height: 30px" /></td>
                                <td>
                                   <asp:Image ID="ImgUA" runat="server" Width="100%" />
                                </td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_Chol_TG.gif" style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_5.gif" 
                                        style="width: 100%; height: auto" /></td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_Systolic.gif" 
                                        style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_4.gif" 
                                        style="width: 100%; height: auto" /></td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_MS.gif" 
                                        style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_4.gif" 
                                        style="width: 100%; height: auto" /></td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_Hb.gif" 
                                        style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_2.gif" 
                                        style="width: 100%; height: auto" /></td>
                            </tr>
                        </table>
                    </p>
                </div>
               <div data-role="collapsible"  data-collapsed="true" >
                    <h1>เทียบสุขภาพคุณกับหน่วยงาน</h1>
                    <p> 
                    <div class="ui-grid-a">
                    <div class="ui-block-a"><a href="UInDept/BMIUDept.aspx" data-transition="pop" class="ui-btn ui-mini">รูปร่าง</a></div>
                    </div>
                    </p>
   
               </div>
               <div data-role="collapsible"  data-collapsed="true" >
                    <h1>คำแนะนำและข้อควรปฏิบัติ</h1>
                    <p>
                        <asp:Button ID="Button10" runat="server" Text="เบาหวาน" />
                        
                        <asp:Button ID="Button1" runat="server" Text="ไขมันสูง" />
                        <asp:Button ID="Button2" runat="server" Text="ความดันโลหิตสูง" />
                        <asp:Button ID="Button3" runat="server" Text="อ้วนลงพุง" />
                        
                        </p>
               </div>
            </div>
           
            <div data-role="footer">
             
            </div>
    </div>
   
    </form>
</body>
</html>
