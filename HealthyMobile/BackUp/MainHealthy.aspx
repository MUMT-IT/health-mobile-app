<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MainHealthy.aspx.vb" Inherits="MainHealthy" %>

<head runat="server">
    <title></title>
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
            width: 187px;
        }
        .style3
        {            height: 28px;
        }
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
            width: 66px;
            height: 33px;
        }
        .style16
        {
            height: 33px;
            width: 1063px;
        }
        </style>
</head>
<body>
<%=GraphChol()%>
    <form id="form1" runat="server">
    <div data-role="page" id="page1" data-theme="d">
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
                <center><asp:Label ID="lblUserName" runat="server" 
                        Text="นาย เชวงศักดิ์ พัฒนผลไพบูลย์"></asp:Label></center>
                 
            </div>
                <div data-role="collapsible"  data-collapsed="false">
                    <h3>รูปร่างและสัดส่วน</h3>
                    <p>
                        
                        <table class="style10">
                            <tr>
                                <td class="style1" rowspan="6">
                                    <img src="image/StickPerson5.gif" style="width: 156px; height: 160px" /></td>
                                <td class="style15">
                                    ส่วนสูง</td>
                                <td class="style16">
                                    : 167</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    น้ำหนัก</td>
                                <td class="style16">
                                    : 94</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    ชีพจร</td>
                                <td class="style16">
                                    : 86</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    ความดัน</td>
                                <td class="style16">
                                    : 142/90</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    รูปร่าง</td>
                                <td class="style16">
                                    อ้วนมาก</td>
                            </tr>
                            <tr>
                                <td class="style3" colspan="2">
                                    &nbsp;</td>
                            </tr>
                        </table>
                        
                    </p>
                  
                </div>
                <div data-role="collapsible"  data-collapsed="false">
                    <h1>แนวโน้มผลตรวจสุขภาพ</h1>
                    <p>
                    
                    <div id="PlotID1" style="min-width: 100%; height: 300px; margin: 0 auto"></div>
                        <table style="width:100%;">
                            <tr>
                                <td style="width:33.3%;">
                        <asp:Button ID="btnResultPre"  runat="server" Text="<" Width=50% />
                                </td>
                                <td style="width:33.3%;">
                        <asp:Button ID="Button8"  runat="server" Text="รายละเอียด" Width=50% />
                                </td>
                                <td>
                        <asp:Button ID="btnResultNext" runat="server" Text=">" Width=50% />
                        <a href="#page2">Page2</a>
                                </td>
                            </tr>
                    </table>
                    </p>
                </div>
                <div data-role="collapsible"  data-collapsed="false">
                    <h1>แปลผลตรวจสุขภาพ</h1>
                    <p>
                        <asp:Label ID="lblAdvise" runat="server" Text="--"></asp:Label>
                    </p>
                </div>
                <div data-role="collapsible"  data-collapsed="false" >
                    <h1>ความเสี่ยงต่อโรค</h1>
                    <p>
                        <table style="width: 100%;">
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_BUN_CRE.gif" 
                                        style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_1.gif" 
                                        style="width: 100%; height: auto" /></td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_AST.gif" style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_1.gif" 
                                        style="width: 100%; height: auto" /></td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_GLU.gif" style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_3.gif" 
                                        style="width: 100%; height: auto" /></td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_UA.gif" style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_2.gif" 
                                        style="width: 100%; height: auto" /></td>
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
               <div data-role="collapsible"  data-collapsed="false" >
                    <h1>เทียบสุขภาพคุณกับหน่วยงาน</h1>
                     <div id='Chol' style='width: 100%; height: 300px; margin: 0 auto'></div>   
                                           <table style="width:100%;">
                            <tr>
                                <td style="width:33.3%;">
                        <asp:Button ID="Button6"  runat="server" Text="<" Width=50% />
                                </td>
                                <td style="width:33.3%;">
                        <asp:Button ID="Button7"  runat="server" Text="รายละเอียด" Width=50% />
                                </td>
                                <td>
                        <asp:Button ID="Button9" runat="server" Text=">" Width=50% />
                                </td>
                            </tr>
                    </table>
                    
               </div>
               <div data-role="collapsible"  data-collapsed="false" >
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
                <h2>@ Faculty of Medical Technology</h2>
            </div>
    </div>
    <div data-role="page" id="page2" data-theme="d">
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
                <center><asp:Label ID="Label1" runat="server" 
                        Text="นาย เชวงศักดิ์ พัฒนผลไพบูลย์"></asp:Label></center>
                 
            </div>
                <div data-role="collapsible"  data-collapsed="false">
                    <h3>รูปร่างและสัดส่วน</h3>
                    <p>
                        
                        <table class="style10">
                            <tr>
                                <td class="style1" rowspan="6">
                                    <img src="image/StickPerson5.gif" style="width: 156px; height: 160px" /></td>
                                <td class="style15">
                                    ส่วนสูง</td>
                                <td class="style16">
                                    : 167</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    น้ำหนัก</td>
                                <td class="style16">
                                    : 94</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    ชีพจร</td>
                                <td class="style16">
                                    : 86</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    ความดัน</td>
                                <td class="style16">
                                    : 142/90</td>
                            </tr>
                            <tr>
                                <td class="style15">
                                    รูปร่าง</td>
                                <td class="style16">
                                    อ้วนมาก</td>
                            </tr>
                            <tr>
                                <td class="style3" colspan="2">
                                    &nbsp;</td>
                            </tr>
                        </table>
                        
                    </p>
                  
                </div>
                <div data-role="collapsible"  data-collapsed="false">
                    <h1>แนวโน้มผลตรวจสุขภาพ</h1>
                    <p>
                    
                    <div id="PlotID2" style="min-width: 100%; height: 300px; margin: 0 auto"></div>
                        <table style="width:100%;">
                            <tr>
                                <td style="width:33.3%;">
                        <asp:Button ID="Button4"  runat="server" Text="<" Width=50% />
                                </td>
                                <td style="width:33.3%;">
                        <asp:Button ID="Button5"  runat="server" Text="รายละเอียด" Width=50% />
                                </td>
                                <td>
                        <asp:Button ID="Button11" runat="server" Text=">" Width=50% />
                                </td>
                            </tr>
                    </table>
                    </p>
                </div>
                <div data-role="collapsible"  data-collapsed="false">
                    <h1>แปลผลตรวจสุขภาพ</h1>
                    <p>
                        <asp:Label ID="Label2" runat="server" Text="--"></asp:Label>
                    </p>
                </div>
                <div data-role="collapsible"  data-collapsed="false" >
                    <h1>ความเสี่ยงต่อโรค</h1>
                    <p>
                        <table style="width: 100%;">
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_BUN_CRE.gif" 
                                        style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_1.gif" 
                                        style="width: 100%; height: auto" /></td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_AST.gif" style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_1.gif" 
                                        style="width: 100%; height: auto" /></td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_GLU.gif" style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_3.gif" 
                                        style="width: 100%; height: auto" /></td>
                            </tr>
                            <tr>
                                <td class="style14">
                                    <img src="image/Banner/Banner_UA.gif" style="width: auto; height: 30px" /></td>
                                <td>
                                    <img src="image/GradeBar/GradeBar_2.gif" 
                                        style="width: 100%; height: auto" /></td>
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
               <div data-role="collapsible"  data-collapsed="false" >
                    <h1>เทียบสุขภาพคุณกับหน่วยงาน</h1>
                     <div id='Div3' style='width: 100%; height: 300px; margin: 0 auto'></div>   
                                           <table style="width:100%;">
                            <tr>
                                <td style="width:33.3%;">
                        <asp:Button ID="Button12"  runat="server" Text="<" Width=50% />
                                </td>
                                <td style="width:33.3%;">
                        <asp:Button ID="Button13"  runat="server" Text="รายละเอียด" Width=50% />
                                </td>
                                <td>
                        <asp:Button ID="Button14" runat="server" Text=">" Width=50% />
                                </td>
                            </tr>
                    </table>
                    
               </div>
               <div data-role="collapsible"  data-collapsed="false" >
                    <h1>คำแนะนำและข้อควรปฏิบัติ</h1>
                    <p>
                        <asp:Button ID="Button15" runat="server" Text="เบาหวาน" />
                        
                        <asp:Button ID="Button16" runat="server" Text="ไขมันสูง" />
                        <asp:Button ID="Button17" runat="server" Text="ความดันโลหิตสูง" />
                        <asp:Button ID="Button18" runat="server" Text="อ้วนลงพุง" />
                        
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
