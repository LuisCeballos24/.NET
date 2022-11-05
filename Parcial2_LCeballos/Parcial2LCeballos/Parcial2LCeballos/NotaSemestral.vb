Public Class NotaSemestral
    Dim nota, calculos As Decimal

    Private Sub Prom1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim claseCalcular As New Calcular
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            lstResultado.Items.Clear()
            If ((0 <= Val(txtP1.Text) And Val(txtP1.Text) <= 100) And (0 <= Val(txtP2.Text) And Val(txtP2.Text) <= 100) And (0 <= Val(txtP3.Text) And Val(txtP3.Text) <= 100)) Then
                claseCalcular.Asignar(Val(txtP1.Text), Val(txtP2.Text), Val(txtP3.Text))
                nota = claseCalcular.Aprueba()
                If (nota < 21) Then
                    lstResultado.Items.Add("Con esas notas no puedes pasar el semestre :(")
                Else
                    lstResultado.Items.Add("Actualmente estás aprobando con " & nota & ".")
                    lstResultado.Items.Add("Necesitas los siguientes puntajes mínimos:")
                    calculos = claseCalcular.CalcularA()
                    If (calculos <= 100) Then
                        lstResultado.Items.Add("Puntaje de " & calculos & " para la letra A.")
                    Else
                        lstResultado.Items.Add("Aunque saques 100, no llegarás a la letra A")
                    End If
                    calculos = claseCalcular.CalcularB()
                    If (calculos <= 100) Then
                        lstResultado.Items.Add("Puntaje de  " & calculos & " para la letra B.")
                    Else
                        lstResultado.Items.Add("Aunque saques 100, no llegarás a la letra B")
                    End If
                    calculos = claseCalcular.CalcularC()
                    If (calculos <= 100) Then
                        lstResultado.Items.Add("Puntaje de  " & calculos & " para la letra C")
                    Else
                        lstResultado.Items.Add("Aunque saques 100, no llegarás a la letra C")
                    End If
                    calculos = claseCalcular.CalcularD()
                    If (calculos <= 100) Then
                        lstResultado.Items.Add("Puntaje de  " & calculos & " para la letra D.")
                    Else
                        lstResultado.Items.Add("Aunque saques 100, no llegarás a la letra D")
                    End If
                End If
            Else
                lstResultado.Items.Add("La nota debe de ir desde 0 a 100")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class