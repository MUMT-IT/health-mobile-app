Imports System.Data
Imports System.Data.SqlClient
Partial Class ResultLine_BUN
    Inherits System.Web.UI.Page
    Dim m1 As New ClassConnect
    Public Shared Pline, Pline1, Pline2, Pline3, Pline4, Pline5 As Boolean
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Me.ClientScript.RegisterStartupScript(Page.GetType(), "Registered Script", sScript2, True)
    End Sub
    Public Function PlodLine() As String
        'Neutrophil
        Dim cmsID As String
        cmsID = Session("cmsID")
        'หาค่า Ref
        Dim SqlRef, Ref_Value, RMin, RMax As String
        SqlRef = "SELECT * FROM RefValue WHERE Tcode='CBC02'"
        Dim dtRef As DataTable = m1.GetDatatable(SqlRef)
        If dtRef.Rows.Count > 0 Then
            Dim drRef As DataRow = dtRef.Rows(0)
            RMin = drRef("RefMin")
            RMax = drRef("RefMax")
            Ref_Value = "ค่าปกติ " & RMin & "-" & RMax
        End If

        Dim SqlPlotChart As String
        SqlPlotChart = "SELECT * FROM PlotChart WHERE cmsID='" & cmsID & "' and Tcode='CBC02' ORDER BY Servicedate"
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
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID1", "N", "ค่า Neutrophil", Ref_Value, RMin, RMax)
        Else
            Pline = False
        End If
        Return "<script type = text/javascript> " & sScript2 & " </script>"
    End Function
    Public Function PlodLine1() As String
        'L
        Dim cmsID As String
        cmsID = Session("cmsID")
        'หาค่า Ref
        Dim SqlRef, RMin, RMax, Ref_Value As String
        SqlRef = "SELECT * FROM RefValue WHERE Tcode='CBC03' "
        Dim dtRef As DataTable = m1.GetDatatable(SqlRef)
        If dtRef.Rows.Count > 0 Then
            Dim drRef As DataRow = dtRef.Rows(0)
            RMax = drRef("RefMax")
            RMin = drRef("RefMin")
            Ref_Value = "ค่าปกติ " & RMin & "-" & RMax
        End If
        Dim SqlPlotChart As String
        SqlPlotChart = "SELECT * FROM PlotChart WHERE cmsID='" & cmsID & "' and Tcode='CBC03' ORDER BY Servicedate"
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
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID2", "L", "ค่า Lymphocyte", Ref_Value, RMin, RMax)
        Else
            Pline1 = False
        End If
        Return "<script type = text/javascript> " & sScript2 & " </script>"
    End Function
    Public Function PlodLine2() As String
        'M
        Dim cmsID As String
        cmsID = Session("cmsID")
        'หาค่า Ref
        Dim SqlRef, RMin, RMax, Ref_Value As String
        SqlRef = "SELECT * FROM RefValue WHERE Tcode='CBC04'"
        Dim dtRef As DataTable = m1.GetDatatable(SqlRef)
        If dtRef.Rows.Count > 0 Then
            Dim drRef As DataRow = dtRef.Rows(0)
            RMin = drRef("RefMin")
            RMax = drRef("RefMax")
            Ref_Value = "ค่าปกติ " & RMin & "-" & RMax
        End If
        Dim SqlPlotChart As String
        SqlPlotChart = "SELECT * FROM PlotChart WHERE cmsID='" & cmsID & "' and Tcode='CBC04' ORDER BY Servicedate"
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
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID3", "M", "ค่า Monocyte", Ref_Value, RMin, RMax)
        Else
            Pline2 = False
        End If
        Return "<script type = text/javascript> " & sScript2 & " </script>"
    End Function
    Public Function PlodLine3() As String
        'E
        Dim cmsID As String
        cmsID = Session("cmsID")
        'หาค่า Ref
        Dim SqlRef, RMin, RMax, Ref_Value As String
        SqlRef = "SELECT * FROM RefValue WHERE Tcode='CBC05'"
        Dim dtRef As DataTable = m1.GetDatatable(SqlRef)
        If dtRef.Rows.Count > 0 Then
            Dim drRef As DataRow = dtRef.Rows(0)
            RMin = drRef("RefMin")
            RMax = drRef("RefMax")
            Ref_Value = "ค่าปกติ " & RMin & "-" & RMax
        End If
        Dim SqlPlotChart As String
        SqlPlotChart = "SELECT * FROM PlotChart WHERE cmsID='" & cmsID & "' and Tcode='CBC05' ORDER BY Servicedate"
        Dim dt As DataTable
        dt = m1.GetDatatable(SqlPlotChart)
        Dim sScript2 As String = ""
        If dt.Rows.Count > 0 Then
            Pline3 = True
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
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID4", "E", "ค่า Eosinophil", Ref_Value, "", RMax)
        Else
            Pline3 = False
        End If
        Return "<script type = text/javascript> " & sScript2 & " </script>"
    End Function
    Public Function PlodLine4() As String
        'B
        Dim cmsID As String
        cmsID = Session("cmsID")
        'หาค่า Ref
        Dim SqlRef, RMin, RMax, Ref_Value As String
        SqlRef = "SELECT * FROM RefValue WHERE Tcode='CBC06'"
        Dim dtRef As DataTable = m1.GetDatatable(SqlRef)
        If dtRef.Rows.Count > 0 Then
            Dim drRef As DataRow = dtRef.Rows(0)
            RMin = drRef("RefMin")
            RMax = drRef("RefMax")
            Ref_Value = "ค่าปกติ " & RMin & "-" & RMax
        End If
        Dim SqlPlotChart As String
        SqlPlotChart = "SELECT * FROM PlotChart WHERE cmsID='" & cmsID & "' and Tcode='CBC06' ORDER BY Servicedate"
        Dim dt As DataTable
        dt = m1.GetDatatable(SqlPlotChart)
        Dim sScript2 As String = ""
        If dt.Rows.Count > 0 Then
            Pline4 = True
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
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID5", "B", "ค่า Basophil", Ref_Value, "", RMax)
        Else
            Pline4 = False
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
    Public Function divP3() As String
        If Pline3 = True Then
            Return "<div id='PlotID4' style='min-width: 100%; height: 300px; margin: 0 auto' visible='true' ></div>"
        Else
            Return ""
        End If
    End Function
    Public Function divP4() As String
        If Pline4 = True Then
            Return "<div id='PlotID5' style='min-width: 100%; height: 300px; margin: 0 auto' visible='true' ></div>"
        Else
            Return ""
        End If
    End Function
   
   
    Protected Sub btnMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMain.Click
        Response.Redirect("../MainHealthy.aspx")
    End Sub
End Class
