Imports System.Data
Imports System.Data.SqlClient
Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub btnLogIN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogIN.Click
        Dim vCID As String = txtCID.Text
        Dim vPass As String = txtPass.Text
        Dim CID() As String = vCID.Split(",")
        Dim Pass() As String = vPass.Split(",")
        vCID = CID.Last
        vPass = Pass.Last
        Dim M1 As New ClassConnect
        Dim ds As DataSet = M1.GetDataSet("SELECT * FROM Employee WHERE CID='" & vCID & "' And PasswordH='" & vPass & "'")
        If ds.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = ds.Tables(0).Rows(0)
            Session("cmsID") = dr("cmsID")
            Response.Redirect("MainHealthy.aspx")
        Else
            txtCID.Text = ""
            txtPass.Text = ""
        End If
    End Sub
End Class
