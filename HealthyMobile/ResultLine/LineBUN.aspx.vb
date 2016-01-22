Imports System.Data
Imports System.Data.SqlClient
Partial Class ResultLine_BUN
    Inherits System.Web.UI.Page
    Dim m1 As New ClassConnect
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Me.ClientScript.RegisterStartupScript(Page.GetType(), "Registered Script", sScript2, True)
    End Sub
    Public Function PlodLine() As String
        Dim cmsID As String
        cmsID = Session("cmsID")


        'หาค่า Ref
        Dim SqlRef, Ref_Value, RMin, RMax As String
        SqlRef = "SELECT * FROM RefValue WHERE Tcode='BUN'"
        Dim dtRef As DataTable = m1.GetDatatable(SqlRef)
        If dtRef.Rows.Count > 0 Then
            Dim drRef As DataRow = dtRef.Rows(0)
            RMin = drRef("RefMin")
            RMax = drRef("RefMax")
            Ref_Value = "ค่าปกติ " & RMin & "-" & RMax
        End If

        Dim SqlPlotChart As String
        SqlPlotChart = "SELECT * FROM PlotChart WHERE cmsID='" & cmsID & "' and Tcode='BUN' ORDER BY Servicedate"
        Dim dt As DataTable
        dt = m1.GetDatatable(SqlPlotChart)
        Dim sScript2 As String = ""
        If dt.Rows.Count > 0 Then

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
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID1", "BUN", "ค่า BUN", Ref_Value, RMin, RMax)
        End If
        Return "<script type = text/javascript> " & sScript2 & " </script>"
    End Function
    Public Function PlodLine1() As String
        Dim cmsID As String
        cmsID = Session("cmsID")
        'หาเพศ
        Dim SqlEmp, Gender, Ref_Value As String
        SqlEmp = "SELECT Gender FROM Employee WHERE cmsID='" & cmsID & "'"
        Dim dtGender As DataTable = m1.GetDatatable(SqlEmp)
        If dtGender.Rows.Count > 0 Then
            Dim drG As DataRow = dtGender.Rows(0)
            Gender = drG("Gender")
        End If
        'หาค่า Ref
        Dim SqlRef, RMin, RMax As String
        SqlRef = "SELECT * FROM RefValue WHERE Tcode='CRE' AND Gender='" & Gender & "'"
        Dim dtRef As DataTable = m1.GetDatatable(SqlRef)
        If dtRef.Rows.Count > 0 Then
            Dim drRef As DataRow = dtRef.Rows(0)
            RMin = drRef("RefMin")
            RMax = drRef("RefMax")
            Ref_Value = "ค่าปกติ " & RMin & "-" & RMax
        End If


        Dim SqlPlotChart As String
        SqlPlotChart = "SELECT * FROM PlotChart WHERE cmsID='" & cmsID & "' and Tcode='CRE' ORDER BY Servicedate"
        Dim dt As DataTable
        dt = m1.GetDatatable(SqlPlotChart)
        Dim sScript2 As String = ""
        If dt.Rows.Count > 0 Then

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
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID2", "CRE", "ค่า CRE", Ref_Value, RMin, RMax)
        End If
        Return "<script type = text/javascript> " & sScript2 & " </script>"
    End Function

    Protected Sub btnMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMain.Click
        Response.Redirect("../MainHealthy.aspx")
    End Sub
End Class
