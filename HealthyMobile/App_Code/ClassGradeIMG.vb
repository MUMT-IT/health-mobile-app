Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class ClassGradeIMG
    Dim M1 As New ClassConnect
    Public Function GradeNum(ByVal cmsID As String, ByVal CuDate As Date, ByVal Tcode As String, ByVal Gender As String, ByVal Age As Integer) As String
        Dim Cnull As New ClassNULL
        Dim GNum As String = ""
        Dim CdDate As New ClassDate
        Dim StrDate As String = CdDate.DateQuery(CuDate)
        Dim Sql As String
        Sql = "SELECT cmsID, Tcode, Result, ServiceDate FROM  PlotChart " & _
              "WHERE (ServiceDate = CONVERT(DATETIME, '" & StrDate & " 00:00:00', 102)) AND (cmsID = N'" & cmsID & "') AND Tcode='" & Tcode & "'"
        Dim dt As DataTable = M1.GetDatatable(Sql)
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.Rows(0)
            Dim Result As Double
            If IsNumeric(dr("Result")) Then
                Result = dr("Result")
            Else
                Return ""
                Exit Function
            End If

            Dim QGender As String = ""
            If Gender <> "" Then
                QGender = "AND Gender='" & Gender & "'"
            End If
            Dim QAge As String = ""
            If Age <> 0 Then
                QAge = "AND AgeMin <= " & Age & " AND AgeMax >= " & Age
            End If
            Dim SqlRef As String
            SqlRef = "SELECT * FROM GradeIMG WHERE Tcode='" & Tcode & "'" & QGender & QAge
            Dim dtRef As DataTable = M1.GetDatatable(SqlRef)
            If dtRef.Rows.Count > 0 Then
                Dim drRef As DataRow = dtRef.Rows(0)
                Dim Min1 As String = Cnull.DBNULL(drRef("Min1"))
                Dim Max1 As String = Cnull.DBNULL(drRef("Max1"))
                Dim Min2 As String = Cnull.DBNULL(drRef("Min2"))
                Dim Max2 As String = Cnull.DBNULL(drRef("Max2"))
                Dim Min3 As String = Cnull.DBNULL(drRef("Min3"))
                Dim Max3 As String = Cnull.DBNULL(drRef("Max3"))
                Dim Min4 As String = Cnull.DBNULL(drRef("Min4"))
                Dim Max4 As String = Cnull.DBNULL(drRef("Max4"))
                Dim Min5 As String = Cnull.DBNULL(drRef("Min5"))
                Dim Max5 As String = Cnull.DBNULL(drRef("Max5"))
                'Lv1

                If Min1 = "" Then
                    If Result < CDbl(Max1) Then
                        GNum = 1
                    End If
                ElseIf CDbl(Min1) <= Result And Result <= CDbl(Max1) Then
                    GNum = 1
                End If

                'Lv2
                If CDbl(Min2) <= Result And Result <= CDbl(Max2) Then
                    GNum = 2
                End If
                'Lv3
                If CDbl(Min3) <= Result And Result <= CDbl(Max3) Then
                    GNum = 3
                End If
                'Lv4
                If CDbl(Min4) <= Result And Result <= CDbl(Max4) Then
                    GNum = 4
                End If
                'Lv5
                If Max5 = "" Then
                    If Result > Min5 Then
                        GNum = 5
                    End If
                ElseIf CDbl(Min5) <= Result And Result <= CDbl(Max5) Then
                    GNum = 5
                End If

            End If
        End If
        Return GNum
    End Function
End Class
