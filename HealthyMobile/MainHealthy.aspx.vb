Imports System.Data
Imports System.Data.SqlClient
Partial Class MainHealthy
    Inherits System.Web.UI.Page
    Public sScript2 As String
    Public Shared CountHitbtnPhysical As Integer
    Dim FullName As String
    Dim M1 As New ClassConnect
    Private Sub BindName()
        Dim cmsID As String = Session("cmsID")
        Dim Sql As String
        Sql = "SELECT * FROM Employee WHERE cmsID='" & cmsID & "'"
        Dim dt As DataTable = M1.GetDatatable(Sql)
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.Rows(0)
            FullName = dr("Prename") & " " & dr("Fname") & " " & dr("Lname")
            BindGradeIMG(cmsID, dr("ServiceDate"), dr("Gender"), dr("Age"))
            Dim SqlPhysical As String
            SqlPhysical = "SELECT TOP (1) cmsID, BMI, Weight, Height, HeartRate, Systolic, DataDate " & _
                          "FROM Physical " & _
                          "WHERE (cmsID = N'" & cmsID & "') " & _
                          "ORDER BY DataDate DESC "
            Dim dtPhysical As DataTable
            dtPhysical = M1.GetDatatable(SqlPhysical)
            If dtPhysical.Rows.Count > 0 Then
                Dim drPhy As DataRow = dtPhysical.Rows(0)
                Dim CNULL As New ClassNULL
                lblHeight.Text = CNULL.DBNULL(drPhy("Height"))
                lblWeight.Text = CNULL.DBNULL(drPhy("Weight"))
                lblHeartRate.Text = CNULL.DBNULL(drPhy("HeartRate"))
                lblSystolic.Text = CNULL.DBNULL(drPhy("Systolic"))
                Dim CBMI As New ClassBMI
                Dim BMI As Double = 0
                If IsDBNull(drPhy("BMI")) = False Then
                    BMI = drPhy("BMI")
                    lblInterpBMI.Text = CBMI.InterpBMI(BMI)
                    If lblInterpBMI.Text = "ผอม" Then
                        Image1.ImageUrl = "~/image/StickPerson1.gif"
                    End If
                    If lblInterpBMI.Text = "รูปร่างสมส่วน" Then
                        Image1.ImageUrl = "~/image/StickPerson2.gif"
                    End If
                    If lblInterpBMI.Text = "น้ำหนักเกิน" Then
                        Image1.ImageUrl = "~/image/StickPerson3.gif"
                    End If
                    If lblInterpBMI.Text = "มีภาวะอ้วน" Then
                        Image1.ImageUrl = "~/image/StickPerson4.gif"
                    End If
                    If lblInterpBMI.Text = "อ้วนมาก" Then
                        Image1.ImageUrl = "~/image/StickPerson5.gif"
                    End If

                End If
            End If
        Else
            Response.Redirect("login.aspx")
        End If
    End Sub
   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        BindName()
        lblUserName.Text = FullName

        Dim TestP As New ClassJava.PPlotChart
        Dim lstTestP As New List(Of ClassJava.PPlotChart)
        For j As Integer = 0 To 3
            If j = 0 Then
                TestP.UXAxis = "2556"
                TestP.UPlot = "50"
                lstTestP.Add(TestP)
            End If
        Next
        Dim CBarChart As New ClassJava
        'sScript2 = CBarChart.PlotChart(lstTestP, "PlotID1", "ค่า BUN", "BUN", "100", "")
        lstTestP.Clear()
        For j As Integer = 0 To 3
            If j = 0 Then
                TestP.UXAxis = "2556"
                TestP.UPlot = "201"
                lstTestP.Add(TestP)
            End If
            If j = 1 Then
                TestP.UXAxis = "2557"
                TestP.UPlot = "222"
                lstTestP.Add(TestP)
            End If
            If j = 3 Then
                TestP.UXAxis = "2558"
                TestP.UPlot = "188"
                lstTestP.Add(TestP)
            End If
        Next

        'sScript2 += CBarChart.PlotChart(lstTestP, "PlotID2", "ค่า CRE", "CRE", "200", "")


      


        'Me.ClientScript.RegisterStartupScript(Page.GetType(), "Registered Script", sScript2, True)

    End Sub
   
    Public Function Stick() As String
        Return "StickPerson1.gif"
    End Function
    Private Sub BindGradeIMG(ByVal cmsID As String, ByVal SDate As Date, ByVal Gender As String, ByVal Age As String)
        Dim Cnull As New ClassNULL
        Dim GImg As New ClassGradeIMG
        Dim ClassDate As New ClassDate
        Dim StrDate As String = ClassDate.DateQuery(SDate)
        Dim Sql As String = "SELECT cmsID, Tcode, Result, ServiceDate FROM  PlotChart " & _
        "WHERE  (ServiceDate = CONVERT(DATETIME, '" & StrDate & " 00:00:00', 102)) AND (cmsID = N'" & cmsID & "')"
        Dim dt As DataTable = M1.GetDatatable(Sql)
        Dim GradeBUN, GradeCRE, GradeGLU, GradeAST, GradeALT, GradeALK, GradeUA As String
        GradeBUN = ""
        GradeCRE = ""
        GradeGLU = ""
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows(i)
                Dim Tcode As String = dr("Tcode")
                Dim Result As String = dr("Result")
                'ไต
                If Tcode = "BUN" Then
                    GradeBUN = GImg.GradeNum(cmsID, SDate, Tcode, "", 0)
                End If
                If Tcode = "CRE" Then
                    GradeCRE = GImg.GradeNum(cmsID, SDate, Tcode, "", 0)
                End If
                'เบาหวาน
                If Tcode = "GTT2" Then
                    GradeGLU = GImg.GradeNum(cmsID, SDate, Tcode, "", 0)
                End If
                'ตับ
                If Tcode = "AST" Then
                    GradeAST = GImg.GradeNum(cmsID, SDate, Tcode, "", 0)
                End If
                If Tcode = "ALT" Then
                    GradeALT = GImg.GradeNum(cmsID, SDate, Tcode, "", 0)
                End If
                If Tcode = "ALK" Then
                    GradeALK = GImg.GradeNum(cmsID, SDate, Tcode, "", Age)
                End If
                'เก๊าต์
                If Tcode = "UA" Then
                    GradeUA = GImg.GradeNum(cmsID, SDate, Tcode, "", 0)
                End If


            Next
            'ไต
            If GradeBUN = "5" Or GradeCRE = "5" Then
                imgBUN.ImageUrl = "~/image/GradeBar/GradeBar_5.gif"
            ElseIf GradeBUN = "4" Or GradeCRE = "4" Then
                imgBUN.ImageUrl = "~/image/GradeBar/GradeBar_4.gif"
            ElseIf GradeBUN = "3" Or GradeCRE = "3" Then
                imgBUN.ImageUrl = "~/image/GradeBar/GradeBar_3.gif"
            ElseIf GradeBUN = "2" Or GradeCRE = "2" Then
                imgBUN.ImageUrl = "~/image/GradeBar/GradeBar_2.gif"
            ElseIf GradeBUN = "1" And GradeCRE = "1" Then
                imgBUN.ImageUrl = "~/image/GradeBar/GradeBar_1.gif"
            End If
            'เบาหวาน
            If GradeGLU = "5" Then
                ImgGLU.ImageUrl = "~/image/GradeBar/GradeBar_5.gif"
            ElseIf GradeGLU = "4" Then
                ImgGLU.ImageUrl = "~/image/GradeBar/GradeBar_4.gif"
            ElseIf GradeGLU = "3" Then
                ImgGLU.ImageUrl = "~/image/GradeBar/GradeBar_3.gif"
            ElseIf GradeGLU = "2" Then
                ImgGLU.ImageUrl = "~/image/GradeBar/GradeBar_2.gif"
            ElseIf GradeGLU = "1" Then
                ImgGLU.ImageUrl = "~/image/GradeBar/GradeBar_1.gif"
            End If
            'ตับ
            If GradeAST = "5" Or GradeALT = "5" Or GradeALK = "5" Then
                ImgAST.ImageUrl = "~/image/GradeBar/GradeBar_5.gif"
            ElseIf GradeAST = "4" Or GradeALT = "4" Or GradeALK = "4" Then
                ImgAST.ImageUrl = "~/image/GradeBar/GradeBar_4.gif"
            ElseIf GradeAST = "3" Or GradeALT = "3" Or GradeALK = "3" Then
                ImgAST.ImageUrl = "~/image/GradeBar/GradeBar_3.gif"
            ElseIf GradeAST = "2" Or GradeALT = "2" Or GradeALK = "2" Then
                ImgAST.ImageUrl = "~/image/GradeBar/GradeBar_2.gif"
            ElseIf GradeAST = "1" And GradeALT = "1" And GradeALK = "1" Then
                ImgAST.ImageUrl = "~/image/GradeBar/GradeBar_1.gif"
            End If
            'เก๊าต์
            If GradeUA = "5" Then
                ImgUA.ImageUrl = "~/image/GradeBar/GradeBar_5.gif"
            ElseIf GradeUA = "4" Then
                ImgUA.ImageUrl = "~/image/GradeBar/GradeBar_4.gif"
            ElseIf GradeUA = "3" Then
                ImgUA.ImageUrl = "~/image/GradeBar/GradeBar_3.gif"
            ElseIf GradeUA = "2" Then
                ImgUA.ImageUrl = "~/image/GradeBar/GradeBar_2.gif"
            ElseIf GradeUA = "1" Then
                ImgUA.ImageUrl = "~/image/GradeBar/GradeBar_1.gif"
            End If
        End If


    End Sub
    'Protected Sub btnResultNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnResultNext.Click
    '    Dim TestP As New ClassJava.PPlotChart
    '    Dim lstTestP As New List(Of ClassJava.PPlotChart)
    '    For j As Integer = 0 To 3
    '        If j = 0 Then
    '            TestP.UXAxis = "2556"
    '            TestP.UPlot = "201"
    '            lstTestP.Add(TestP)
    '        End If
    '        If j = 1 Then
    '            TestP.UXAxis = "2557"
    '            TestP.UPlot = "222"
    '            lstTestP.Add(TestP)
    '        End If
    '        If j = 3 Then
    '            TestP.UXAxis = "2558"
    '            TestP.UPlot = "188"
    '            lstTestP.Add(TestP)
    '        End If
    '    Next
    '    Dim CBarChart As New ClassJava
    '    'sScript2 = CBarChart.PlotChart(lstTestP, "CRE", "ค่า CRE", "CRE", "200", "")
    'End Sub
    
End Class
