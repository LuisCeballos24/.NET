Public Class frmProblema2
    Private Sub btnLimpiar_Click_1(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lstTemp1.Items.Clear()
        lstTemp2.Items.Clear()
        lstTemp3.Items.Clear()
    End Sub

    Private Sub btnReg_Click_1(sender As Object, e As EventArgs) Handles btnReg.Click
        Dim temperatura As Integer
        temperatura = txtTemp.Text
        lstTemp1.Items.Add(temperatura & "°C")

        Dim calTemp As New CalTemp4
        calTemp.Asignar(temperatura)

        If (calTemp.Verificar() = 1) Then
            lstTemp2.Items.Add(temperatura & "°C")
        ElseIf (calTemp.Verificar() = 2) Then
            lstTemp3.Items.Add(temperatura & "°C")
        Else

        End If
    End Sub
End Class