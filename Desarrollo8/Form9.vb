Public Class Form9
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim numero As Integer
        numero = Val(txtNumero.Text)
        lstMostrar.Items.Add(numero)
        Do
            If numero Mod 2 = 0 Then
                numero /= 2
            Else
                numero = numero * 3 + 1
            End If
            lstMostrar.Items.Add(numero)
        Loop Until 1 >= numero

    End Sub
End Class