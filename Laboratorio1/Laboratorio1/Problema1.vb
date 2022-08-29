Public Class Problema1

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim valorV As Single
        Dim impuestoV As Single
        Dim comisionV As Single

        valorV = txtValor.Text
        impuestoV = valorV * 0.06
        comisionV = valorV * 0.12

        txtValorFinal.Text = Format(Val(valorV + impuestoV + comisionV), "0.00")

    End Sub
End Class
