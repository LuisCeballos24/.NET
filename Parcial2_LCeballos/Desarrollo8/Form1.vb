Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim parcial1, parcial2, lab1, lab2, semestral As Integer
        Dim nota As Double
        Dim notaLetra As String = ""
        parcial1 = Val(txtParcial1.Text)
        parcial2 = Val(txtParcial2.Text)
        lab1 = Val(txtLaboratorio1.Text)
        lab2 = Val(txtLaboratorio2.Text)
        semestral = Val(txtSemestral.Text)
        nota = parcial1 * 0.15 + parcial2 * 0.15 + lab1 * 0.15 + lab2 * 0.15 + semestral * 0.4
        If (nota >= 91 And nota <= 100) Then
            notaLetra = "A"
        ElseIf nota >= 81 And nota <= 90.9 Then
            notaLetra = "B"
        ElseIf nota >= 71 And nota <= 80.9 Then
            notaLetra = "C"
        ElseIf nota >= 61 And nota <= 70.9 Then
            notaLetra = "D"
        End If
        txtNota.Text = nota
        txtNotaLetra.Text = notaLetra

    End Sub
End Class
