﻿Imports System.Data
Imports System.Data.SqlClient
Partial Class ResultLine_LineBMI
    Inherits System.Web.UI.Page
    Dim m1 As New ClassConnect
    Public Function PlodLine() As String
        Dim cmsID As String
        cmsID = Session("cmsID")

        'หาค่า Ref
        Dim SqlRef, Ref_Value, RMin, RMAX As String
        SqlRef = "SELECT * FROM RefValue WHERE Tcode='BMI'"
        Dim dtRef As DataTable = m1.GetDatatable(SqlRef)
        If dtRef.Rows.Count > 0 Then
            Dim drRef As DataRow = dtRef.Rows(0)
            RMin = drRef("RefMin")
            RMAX = drRef("RefMax")
            Ref_Value = "ค่าปกติ " & RMin & "-" & RMAX
        End If

        Dim SqlPlotChart As String
        SqlPlotChart = "SELECT BMI,DataDate FROM Physical WHERE cmsID='" & cmsID & "' ORDER BY DataDate"
        Dim dt As DataTable
        dt = m1.GetDatatable(SqlPlotChart)
        Dim sScript2 As String = ""
        If dt.Rows.Count > 0 Then

            Dim TestP As New ClassJava.PPlotChart
            Dim lstTestP As New List(Of ClassJava.PPlotChart)
            For i As Integer = dt.Rows.Count - 5 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows(i)
                Dim DDate As Date = dr("DataDate")
                TestP.UXAxis = DDate.Year
                TestP.UPlot = dr("BMI")
                lstTestP.Add(TestP)
            Next

            Dim CBarChart As New ClassJava
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID1", "BMI", "ค่า BMI", Ref_Value, RMin, RMAX)
        End If
        Return "<script type = text/javascript> " & sScript2 & " </script>"

    End Function
    Protected Sub btnMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMain.Click
        Response.Redirect("../MainHealthy.aspx")
    End Sub
End Class
