Public Class Problema4
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim primerNumero, segundoNumero As Integer

        primerNumero = InputBox("Ingrese primer número")
        segundoNumero = InputBox("Ingrese segundo número")

        If primerNumero = segundoNumero Then
            apply_modification("Multiplicación", primerNumero * segundoNumero)
        ElseIf primerNumero > segundoNumero Then
            apply_modification("Resta", primerNumero - segundoNumero)
        ElseIf primerNumero < segundoNumero Then
            apply_modification("Suma", primerNumero + segundoNumero)
        End If

    End Sub

    Private Sub apply_modification(ByVal operacion As String, ByVal valor As Integer)
        txtOperación.Text = operacion
        txtResultado.Text = valor
    End Sub
End Class