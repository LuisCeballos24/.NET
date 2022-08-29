Public Class Problema2
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim edadJuan, edadAlberto, edadAna As Integer
        edadJuan = InputBox("¿Cúal es la edad de Juan?")
        edadAlberto = edadJuan * 0.66
        edadAna = edadJuan * 1.33
        txtEdadAna.Text = edadAna
        txtEdadAlberto.Text = edadAlberto
        txtEdadJuan.Text = edadJuan
        txtEdadMama.Text = edadJuan + edadAna + edadAlberto
    End Sub

    Private Sub Problema2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class