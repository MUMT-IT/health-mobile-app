Public Class ClassDate
    Public Function DateQuery(ByVal VDate As Date) As String
        Dim YearD As String = VDate.Year
        Dim MonthD As String = Format(VDate.Month, "00")
        Dim DayD As String = Format(VDate.Day, "00")
        DateQuery = YearD & "-" & MonthD & "-" & DayD
        'DateQuery = " BETWEEN CONVERT(DATETIME, '" & DQ & " 00:00:00', 102) AND CONVERT(DATETIME, '" & DQ & " 23:00:00', 102)"
    End Function
    Public Function D1Query(ByVal VDate As Date) As String
        Dim YearD As String = VDate.Year
        Dim MonthD As String = Format(VDate.Month, "00")
        Dim DayD As String = Format(VDate.Day, "00")
        Dim DQ As String = YearD & "-" & MonthD & "-" & DayD
        D1Query = " BETWEEN CONVERT(DATETIME, '" & DQ & " 00:00:00', 102) AND CONVERT(DATETIME, '" & DQ & " 23:00:00', 102)"
    End Function
End Class