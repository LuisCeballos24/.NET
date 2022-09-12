Public Class Form3
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim numero, z As Integer
        Dim objFac As New Factorial
        lstImpresion.Items.Clear()
        numero = InputBox("Ingerese un numero", "Ejemplo Factorial")
        txtNumero.Text = numero
        If numero >= 0 Then
            For z = 0 To numero
                objFac.asignar(z)
                lstImpresion.Items.Add(z & "!=" & objFac.calcularFac)
            Next
        Else
            MsgBox("Debe ser un numero positivo")
        End If
    End Sub
End Class