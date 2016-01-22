Imports Microsoft.VisualBasic

Public Class ClassJava
    Public Structure BarData
        Dim Range As String
        Dim People As String
        Dim PointU As Boolean
    End Structure
    Public Structure PPlotChart
        Dim UXAxis As String
        Dim UPlot As String
    End Structure
    Structure ColorBar
        Dim NormalC As String
        Dim UserC As String
    End Structure
    Public Function JQueryJAVA(ByVal HStr As String, ByVal ObjName As String, ByVal lstValue As List(Of String)) As String
        Dim HJava, FJava As String
        HJava = " $(function() { var options = { title: {text: '" & HStr & "'}, animationEnabled: false, data: [ {type: 'spline',dataPoints: ["
        FJava = "]}]};$('#" & ObjName & "').CanvasJSChart(options);});"
        Dim PlotJava As String
        Dim CRow As Integer = 1
        For Each txt In lstValue
            PlotJava += "{ x: " & CRow & ", y: " & txt & " },"
        Next
        JQueryJAVA = HJava & PlotJava & FJava
    End Function
    Public Function PlotChart(ByVal lstPlot As List(Of PPlotChart), ByVal PlotID As String, ByVal PlotName As String, ByVal Title As String, ByVal SubTitle As String, ByVal Min As String, ByVal Max As String) As String

        Dim xAxis, vMAX, vMIN As String
        Dim AllPlot As String
        For i As Integer = 0 To lstPlot.Count - 1
            Dim vAXis As String = lstPlot(i).UXAxis
            Dim vUPlot As String = lstPlot(i).UPlot
            If i = 0 Then
                xAxis = "'" & vAXis & "'"
                AllPlot = vUPlot
                If Max <> "" Then
                    vMAX = Max
                End If
                If Min <> "" Then
                    vMIN = Min
                End If
            Else
                xAxis = xAxis & ",'" & vAXis & "'"
                AllPlot = AllPlot & "," & vUPlot
                If Max <> "" Then
                    vMAX = vMAX & "," & Max
                End If
                If Min <> "" Then
                    vMIN = vMIN & "," & Min
                End If
            End If
        Next
        Dim AllMax, AllMin As String
        If Max <> "" Then
            AllMax = ", {" & _
            "name: 'MAX'," & _
            "data: [" & vMAX & "]}"
        End If
        If Min <> "" Then
            AllMin = ", {" & _
            "name: 'MIN'," & _
            "data: [" & vMIN & "]}"
        End If

        Dim StrPlot As String
        StrPlot = "$(function () { " & _
    "$('#" & PlotID & "').highcharts({ " & _
        "chart: {" & _
            "type: 'line'" & _
        "}," & _
        "title: {" & _
            "text: '" & Title & "'" & _
        "}," & _
        "subtitle: {" & _
            "text: '" & SubTitle & "'" & _
        "}," & _
        "xAxis: {" & _
            "categories: [" & xAxis & "]" & _
        "}," & _
        "yAxis: {" & _
            "title: {" & _
                "text: ''" & _
            "}" & _
        "}," & _
        "plotOptions: {" & _
            "line: {" & _
                "dataLabels: {" & _
                    "enabled: true" & _
                "}," & _
                "enableMouseTracking: false" & _
            "}" & _
        "}," & _
        "series: [{" & _
            "name: '" & PlotName & "'," & _
            "data: [" & AllPlot & "]" & _
        "} " & AllMin & AllMax & "]" & _
    "});" & _
"});"
        Return StrPlot
    End Function
    Public Function BarChart(ByVal lst As List(Of BarData), ByVal BarChartName As String, ByVal BarCharID As String) As String
        Dim StrJavaH, StrJavaP, StrJavaR, StrJavaRFull, StrJavaF, StrFull As String
        StrJavaH = "$(function() { $('#" & BarCharID & "').highcharts({chart: {type:'column'}, title: {text:''}," & _
        "subtitle: {text:'" & BarChartName & "'}, xAxis: {type:'category'}, yAxis: { title: {text:'จำนวนคน '} },legend: {enabled: false}," & _
        "plotOptions: { series: {borderWidth: 0,dataLabels: { enabled: true,format: '{point.y}'} }}," & _
        "tooltip: {headerFormat:  '<span style=font-size:11px>{series.name}</span><br>'," & _
        "pointFormat:  '<span>{point.name}</span>: <b>{point.y}คน</b> <br/>'},"
        StrJavaP = "series: [{name:   '" & BarChartName & "', colorByPoint: false,"
        StrJavaF = "drilldown: {} }); });"
        Dim lstColor As New List(Of ColorBar)
        Dim CBar As ColorBar
        CBar.NormalC = "#a4fff9"
        CBar.UserC = "#00529e"
        lstColor.Add(CBar) '00529e สีเข้ม
        CBar.NormalC = "#a4fff9"
        CBar.UserC = "#026436"
        lstColor.Add(CBar) '026436
        CBar.NormalC = "#a4fff9"
        CBar.UserC = "#bda700"
        lstColor.Add(CBar) 'bda700
        CBar.NormalC = "#a4fff9"
        CBar.UserC = "#1c1e58"
        lstColor.Add(CBar) 'b35b00
        CBar.NormalC = "#a4fff9"
        CBar.UserC = "#a80700"
        lstColor.Add(CBar) 'a80700
        For i As Integer = 0 To lst.Count - 1
            Dim Rang As String = lst(i).Range
            Dim Pepole As String = lst(i).People
            Dim PointU As Boolean = lst(i).PointU
            If PointU = False Then
                StrJavaR = StrJavaR & "{name: '" & Rang & "', y:" & Pepole & ",color:'" & lstColor(i).NormalC & "'},"
            Else
                StrJavaR = StrJavaR & "{name: '" & Rang & "', y:" & Pepole & ",color:'" & lstColor(i).UserC & "'},"
            End If

        Next
        StrJavaRFull = "data:[" & StrJavaR & "]}],"

        StrFull = StrJavaH & StrJavaP & StrJavaRFull & StrJavaF
        Return StrFull
    End Function
End Class
