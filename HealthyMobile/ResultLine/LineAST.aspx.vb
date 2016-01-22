Imports System.Data
Imports System.Data.SqlClient
Partial Class ResultLine_BUN
    Inherits System.Web.UI.Page
    Dim m1 As New ClassConnect
    Public Shared Pline, Pline1, Pline2, Pline3 As Boolean
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Me.ClientScript.RegisterStartupScript(Page.GetType(), "Registered Script", sScript2, True)
    End Sub
    Public Function PlodLine() As String
        Dim cmsID As String
        cmsID = Session("cmsID")
        'หาค่า Ref
        Dim SqlRef, Ref_Value, RMin, RMax As String
        SqlRef = "SELECT * FROM RefValue WHERE Tcode='AST'"
        Dim dtRef As DataTable = m1.GetDatatable(SqlRef)
        If dtRef.Rows.Count > 0 Then
            Dim drRef As DataRow = dtRef.Rows(0)
            RMax = drRef("RefMax")
            Ref_Value = "ค่าปกติน้อยกว่า " & RMax
        End If

        Dim SqlPlotChart As String
        SqlPlotChart = "SELECT * FROM PlotChart WHERE cmsID='" & cmsID & "' and Tcode='AST' ORDER BY Servicedate"
        Dim dt As DataTable
        dt = m1.GetDatatable(SqlPlotChart)
        Dim sScript2 As String = ""
        If dt.Rows.Count > 0 Then
            Pline = True
            Dim TestP As New ClassJava.PPlotChart
            Dim lstTestP As New List(Of ClassJava.PPlotChart)
            For i As Integer = dt.Rows.Count - 5 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows(i)
                Dim Sdate As Date = dr("ServiceDate")
                TestP.UXAxis = Sdate.Year
                TestP.UPlot = dr("Result")
                lstTestP.Add(TestP)
            Next

            Dim CBarChart As New ClassJava
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID1", "AST", "ค่า AST", Ref_Value, "", RMax)
        Else
            PlodLine = False
        End If
        Return "<script type = text/javascript> " & sScript2 & " </script>"
    End Function
    Public Function PlodLine1() As String
        Dim cmsID As String
        cmsID = Session("cmsID")
        'หาค่า Ref
        Dim SqlRef, RMin, RMax, Ref_Value As String
        SqlRef = "SELECT * FROM RefValue WHERE Tcode='ALT'"
        Dim dtRef As DataTable = m1.GetDatatable(SqlRef)
        If dtRef.Rows.Count > 0 Then
            Dim drRef As DataRow = dtRef.Rows(0)
            RMax = drRef("RefMax")
            Ref_Value = "ค่าปกติน้อยกว่า " & RMax
        End If
        Dim SqlPlotChart As String
        SqlPlotChart = "SELECT * FROM PlotChart WHERE cmsID='" & cmsID & "' and Tcode='ALT' ORDER BY Servicedate"
        Dim dt As DataTable
        dt = m1.GetDatatable(SqlPlotChart)
        Dim sScript2 As String = ""
        If dt.Rows.Count > 0 Then
            Pline1 = True
            Dim TestP As New ClassJava.PPlotChart
            Dim lstTestP As New List(Of ClassJava.PPlotChart)
            For i As Integer = dt.Rows.Count - 5 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows(i)
                Dim Sdate As Date = dr("ServiceDate")
                TestP.UXAxis = Sdate.Year
                TestP.UPlot = dr("Result")
                lstTestP.Add(TestP)
            Next

            Dim CBarChart As New ClassJava
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID2", "ALT", "ค่า ALT", Ref_Value, "", RMax)
        Else
            Pline1 = False
        End If
        Return "<script type = text/javascript> " & sScript2 & " </script>"
    End Function
    Public Function PlodLine2() As String
        Dim cmsID As String
        cmsID = Session("cmsID")
        'หาค่า Ref
        Dim SqlRef, RMin, RMax, Ref_Value As String
        SqlRef = "SELECT * FROM RefValue WHERE Tcode='ALK'"
        Dim dtRef As DataTable = m1.GetDatatable(SqlRef)
        If dtRef.Rows.Count > 0 Then
            Dim drRef As DataRow = dtRef.Rows(0)
            RMin = drRef("RefMin")
            RMax = drRef("RefMax")
            Ref_Value = "ค่าปกติ " & RMin & "-" & RMax
        End If
        Dim SqlPlotChart As String
        SqlPlotChart = "SELECT * FROM PlotChart WHERE cmsID='" & cmsID & "' and Tcode='ALK' ORDER BY Servicedate"
        Dim dt As DataTable
        dt = m1.GetDatatable(SqlPlotChart)
        Dim sScript2 As String = ""
        If dt.Rows.Count > 0 Then
            Pline2 = True
            Dim TestP As New ClassJava.PPlotChart
            Dim lstTestP As New List(Of ClassJava.PPlotChart)
            For i As Integer = dt.Rows.Count - 5 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows(i)
                Dim Sdate As Date = dr("ServiceDate")
                TestP.UXAxis = Sdate.Year
                TestP.UPlot = dr("Result")
                lstTestP.Add(TestP)
            Next

            Dim CBarChart As New ClassJava
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID3", "ALK", "ค่า ALK", Ref_Value, RMin, RMax)
        Else
            Pline2 = False
        End If
        Return "<script type = text/javascript> " & sScript2 & " </script>"
    End Function
   
    Public Function divP() As String
        If Pline = True Then
            Return "<div id='PlotID1' style='min-width: 100%; height: 300px; margin: 0 auto' visible='true' ></div>"
        Else
            Return ""
        End If
    End Function
    Public Function divP1() As String
        If Pline1 = True Then
            Return "<div id='PlotID2' style='min-width: 100%; height: 300px; margin: 0 auto' visible='true' ></div>"
        Else
            Return ""
        End If
    End Function
    Public Function divP2() As String
        If Pline2 = True Then
            Return "<div id='PlotID3' style='min-width: 100%; height: 300px; margin: 0 auto' visible='true' ></div>"
        Else
            Return ""
        End If
    End Function
   
    Protected Sub btnMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMain.Click
        Response.Redirect("../MainHealthy.aspx")
    End Sub
End Class
