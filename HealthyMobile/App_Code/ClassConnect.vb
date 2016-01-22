Imports System.IO
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class ClassConnect
    Public ConnectStr As String
    Public Sub New()
        'ConnectStr = "Data Source=TOY-PC\TOY;Initial Catalog=MobileHealthy;Persist Security Info=True;User ID=Chang;Password=lucifer"
        ConnectStr = "Data Source=10.4.101.2;Initial Catalog=MobileHealthy;Persist Security Info=True;User ID=Chang;Password=lucifer"
    End Sub
    Public Function GetDataSet(ByVal strsql As String, Optional ByVal DatasetName As String = "Dataset1", Optional ByVal TableName As String = "Table1") As DataSet
        Dim Da As New SqlDataAdapter(strsql, ConnectStr)
        'Dim Da As New MySqlDataAdapter(strsql, ConnectStr)
        Dim DS As New DataSet(DatasetName)
        Try
            Da.Fill(DS, TableName)
        Catch x1 As Exception
            Err.Raise(60002, , x1.Message)
        End Try
        Return DS
    End Function
    Public Function GetDatatable(ByVal strsql As String, Optional ByVal TableName As String = "Table1") As DataTable
        Dim Da As New SqlDataAdapter(strsql, ConnectStr)
        Dim DT As New DataTable(TableName)
        Try
            Da.Fill(DT)
        Catch x1 As Exception
            Err.Raise(60002, , x1.Message)
        End Try
        Return DT
    End Function

End Class
