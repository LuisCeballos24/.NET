Public Class frmMenuPrincipal
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmProblema2.Close()
        frmProblema4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmProblema2.Show()
        frmProblema4.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
