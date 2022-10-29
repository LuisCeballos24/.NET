Public Class Prom1
    Dim p1, p2, p3, nota, calculos As Decimal
    Dim MP2 As New ClaseProm1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            lstResultado.Items.Clear()
            If (0 <= Val(txtP1.Text) <= 100 And 0 <= Val(txtP2.Text) <= 100 And 0 <= Val(txtP3.Text) <= 100) Then
                MP2.Asignar(Val(txtP1.Text), Val(txtP2.Text), Val(txtP3.Text))
                nota = MP2.Pasa()
                If (nota < 21) Then
                    lstResultado.Items.Add("No pasarías el semestre con esas notas de parciales :(")
                Else
                    lstResultado.Items.Add("Necesitas lo siguiente:")
                    calculos = MP2.CalcularA()
                    If (calculos <= 100) Then
                        lstResultado.Items.Add("Un puntaje de " & calculos & " para la A.")
                    Else
                        lstResultado.Items.Add("Aunque saques 100, no llegarás a la A.")
                    End If
                    calculos = MP2.CalcularB()
                    If (calculos <= 100) Then
                        lstResultado.Items.Add("Un puntaje de " & calculos & " para la B.")
                    Else
                        lstResultado.Items.Add("Aunque saques 100, no llegarás a la B.")
                    End If
                    calculos = MP2.CalcularC()
                    If (calculos <= 100) Then
                        lstResultado.Items.Add("Un puntaje de " & calculos & " para la C")
                    Else
                        lstResultado.Items.Add("Aunque saques 100, no llegarás a la C.")
                    End If
                    calculos = MP2.CalcularD()
                    If (calculos <= 100) Then
                        lstResultado.Items.Add("Un puntaje de " & calculos & " para la D.")
                    Else
                        lstResultado.Items.Add("Aunque saques 100, no llegarás a la D.")
                    End If
                End If
            Else
                lstResultado.Items.Add("La nota debe de ir desde 0 a 100")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class