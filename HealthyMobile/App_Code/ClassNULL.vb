Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class ClassNULL
    Public Function DBNULL(ByVal DB As Object) As String
        If IsDBNull(DB) = False Then
            DBNULL = DB
        Else
            DBNULL = ""
        End If
    End Function

End Class
