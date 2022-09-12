Public Class CalTemp4
    Private temp As Integer

    Public Sub Asignar(ByVal num1 As Integer)
        temp = num1
    End Sub

    Public Function Verificar() As Integer
        If (temp >= 37) Then
            Verificar = 1
        ElseIf (temp <= 33) Then
            Verificar = 2
        Else
            Verificar = 0
        End If
    End Function
End Class