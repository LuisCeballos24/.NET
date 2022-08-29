Public Class Menu
    Private Sub btnProblema1_Click(sender As Object, e As EventArgs) Handles btnProblema1.Click
        Problema1.Show()
        problema2.Close()
        Problema3.Close()
        Problema4.Close()
    End Sub

    Private Sub btnProblema2_Click(sender As Object, e As EventArgs) Handles btnProblema2.Click
        Problema1.Close()
        problema2.Show()
        Problema3.Close()
        Problema4.Close()
    End Sub

    Private Sub btnProblema3_Click(sender As Object, e As EventArgs) Handles btnProblema3.Click
        Problema1.Close()
        problema2.Close()
        Problema3.Show()
        Problema4.Close()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProblema4.Click
        Problema1.Close()
        problema2.Close()
        Problema3.Close()
        Problema4.Show()
    End Sub
End Class