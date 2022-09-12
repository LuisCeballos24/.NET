Public Class frmProblema6
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim alcaldia As New Alcaldia
        alcaldia.cargarAlcaldes(Val(txtAlcalde1.Text), Val(txtAlcalde2.Text), Val(txtAlcalde3.Text), Val(txtAlcalde4.Text))
        txtGanador.Text = alcaldia.calcularMayor
        txtMenor.Text = alcaldia.calcularMenor
    End Sub
End Class