Imports Microsoft.VisualBasic

Public Class ClassBMI
    Public Function InterpBMI(ByVal BMI As Double) As String
        If BMI < 18.5 Then
            InterpBMI = "ผอม"
        ElseIf BMI >= 18.5 And BMI <= 22.9 Then
            InterpBMI = "รูปร่างสมส่วน"
        ElseIf BMI >= 23 And BMI <= 24.9 Then
            InterpBMI = "น้ำหนักเกิน"
        ElseIf BMI >= 25 And BMI <= 29.9 Then
            InterpBMI = "มีภาวะอ้วน"
        ElseIf BMI > 29.9 Then
            InterpBMI = "อ้วนมาก"
        End If

    End Function
End Class
