Imports System.Data
Imports System.Data.SqlClient
Partial Class UInDept_BMIUDept
    Inherits System.Web.UI.Page
    Dim M1 As New ClassConnect
    Public Function DeptBar() As String
        Dim sScript As String = ""
        Dim cmsID As String = "17604"
        'cmsID = Session("cmsID")
        Dim Sql As String
        Sql = "SELECT * FROM UDept WHERE cmsID='" & cmsID & "' ORDER BY indexBar"
        Dim dt As DataTable = M1.GetDatatable(Sql)
        Dim DeptData As ClassJava.BarData
        Dim lstTest As New List(Of ClassJava.BarData)
        Dim BarName As String = ""
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows(i)
                DeptData.Range = dr("Range")
                DeptData.People = dr("PeopleNUM")
                DeptData.PointU = dr("PointU")
                lstTest.Add(DeptData)
                BarName = dr("TestName")
            Next
            Dim CBarChart As New ClassJava
            sScript = CBarChart.BarChart(lstTest, BarName, "UBar")
        End If
        Return "<script type = text/javascript> " & sScript & " </script>"
    End Function
    Protected Sub btnMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMain.Click
        Response.Redirect("../MainHealthy.aspx")
    End Sub
End Class
