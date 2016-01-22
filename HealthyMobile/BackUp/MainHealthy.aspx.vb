
Partial Class MainHealthy
    Inherits System.Web.UI.Page
    Public sScript2 As String
    Public Shared CountHitbtnPhysical As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            lblAdvise.Text = "แนวโน้มไขมันสูง<br>ความดันโลหิตสูง<br>ควรออกกำลังกายสม่ำเสมอ<br>"


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
            sScript2 = CBarChart.PlotChart(lstTestP, "PlotID1", "BUN", "ค่า BUN", "BUN", "100", "")
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

            sScript2 += CBarChart.PlotChart(lstTestP, "PlotID2", "CRE", "ค่า CRE", "CRE", "200", "")


            Dim TestB As New ClassJava.BarData
            Dim lstTest As New List(Of ClassJava.BarData)
            For i As Integer = 0 To 3
                If i = 0 Then
                    TestB.Range = "น้อยกว่า 200"
                    TestB.People = "47"
                    TestB.PointU = True
                    lstTest.Add(TestB)
                End If
                If i = 1 Then
                    TestB.Range = "200-240"
                    TestB.People = "35.5"
                    TestB.PointU = False
                    lstTest.Add(TestB)
                End If
                If i = 2 Then
                    TestB.Range = "สูงกว่า 240"
                    TestB.People = "17.5"
                    TestB.PointU = False
                    lstTest.Add(TestB)
                End If
            Next

            sScript2 += CBarChart.BarChart(lstTest, "ไขมันในเลือด Cholesterol ", "Chol")


            'Me.ClientScript.RegisterStartupScript(Page.GetType(), "Registered Script", sScript2, True)
        End If
    End Sub
    Public Function GraphChol() As String
        Return "<script type = text/javascript> " & sScript2 & " </script>"
        'Return "<div id='chartContainer1' style='height: 200px; width: 100%;'></div>"
    End Function

    Protected Sub btnResultNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnResultNext.Click
        Dim TestP As New ClassJava.PPlotChart
        Dim lstTestP As New List(Of ClassJava.PPlotChart)
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
        Dim CBarChart As New ClassJava
        sScript2 = CBarChart.PlotChart(lstTestP, "CRE", "CRE", "ค่า CRE", "CRE", "200", "")
        'Me.ClientScript.RegisterStartupScript(Page.GetType(), "Registered Script", sScript2, True)
    End Sub
End Class
