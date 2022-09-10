Public Class Form1
    Private Sub btnProblema1_Click(sender As Object, e As EventArgs) Handles btnProblema1.Click
        frmProblema1.Show()
        frmProblema6.Hide()
    End Sub

    Private Sub btnProblema6_Click(sender As Object, e As EventArgs) Handles btnProblema6.Click
        frmProblema1.Hide()
        frmProblema6.Show()
    End Sub
End Class
