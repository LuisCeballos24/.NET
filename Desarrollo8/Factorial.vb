Public Class Factorial
    Private num As Integer
    Public Sub asignar(ByVal valor As Integer)
        num = valor
        MsgBox(Factorial(num))
    End Sub


    Function Factorial(n As Integer) As Integer
        If n <= 1 Then
            Return 1
        Else
            Return Factorial(n - 1) * 1
        End If
    End Function

    Public Function calcularFac()
        Dim i As Integer
        calcularFac = 1
        For i = 1 To num
            calcularFac *= i
        Next i
    End Function


End Class
