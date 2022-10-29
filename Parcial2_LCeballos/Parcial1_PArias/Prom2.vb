Public Class Prom2
    Dim pendiente As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            txtPendiente.Text = PendienteRecta(Val(txtX1.Text), Val(txtX2.Text), Val(txtY1.Text), Val(txtY2.Text))
        Catch ex As Exception
            txtPendiente.Text = "Error en el cálculo"
        End Try
    End Sub
End Class