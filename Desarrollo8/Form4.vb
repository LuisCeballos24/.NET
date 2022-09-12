Public Class Form4
    Private Sub btnProblema1_Click(sender As Object, e As EventArgs) Handles btnProblema1.Click
        Form1.Show()
        Form2.Close()
        Form3.Close()
        F.Close()
    End Sub

    Private Sub btnProblema2_Click(sender As Object, e As EventArgs) Handles btnProblema2.Click
        Form1.Close()
        Form2.Show()
        Form3.Close()
        F.Close()
    End Sub

    Private Sub btnProblema3_Click(sender As Object, e As EventArgs) Handles btnProblema3.Click
        Form1.Close()
        Form2.Close()
        Form3.Show()
        F.Close()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProblema4.Click
        Form1.Close()
        Form2.Close()
        Form3.Close()
        F.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form6.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form7.Show()
    End Sub

    Private Sub btnProblema8_Click(sender As Object, e As EventArgs) Handles btnProblema7.Click
        Form8.Show()
    End Sub

    Private Sub btnProblema8_Click_1(sender As Object, e As EventArgs) Handles btnProblema8.Click
        Form9.Show()
    End Sub
End Class