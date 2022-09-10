Public Class Form2
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim suma As Integer
        Call MultiplosDeTres(Val(TxtInicial.Text), Val(txtFinal.Text), suma)
        txtResultado.Text = suma
    End Sub
End Class