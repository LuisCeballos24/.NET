Public Class Cifrado

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, temp, num2 As Integer
        Dim cuatroDigitos As Double
        Dim digitos(4) As Integer
        Dim num As String
        Try
            num = Val(txtNumEntero.Text)
            cuatroDigitos = num / 1000
            num = txtNumEntero.Text
            cuatroDigitos = Val(num) / 1000
            If (cuatroDigitos >= 1 And cuatroDigitos <= 10) Then
                For x = 0 To digitos.Length - 2
                    digitos(3 - x) = (Val(num.Chars(3 - x)) + 7) Mod 10
                Next

                temp = digitos(2)
                digitos(2) = digitos(0)
                digitos(0) = temp

                temp = digitos(3)
                digitos(3) = digitos(1)
                digitos(1) = temp

                txtCifrado.Text = ""
                For x = 0 To digitos.Length - 2
                    txtCifrado.Text = txtCifrado.Text & digitos(x)
                Next

                temp = digitos(2)
                digitos(2) = digitos(0)
                digitos(0) = temp

                temp = digitos(3)
                digitos(3) = digitos(1)
                digitos(1) = temp

                num = ""
                For x = 0 To digitos.Length - 2
                    num += digitos(x).ToString
                Next

                For x = 0 To digitos.Length - 2
                    digitos(3 - x) = 0
                    digitos(3 - x) = Val(num.Chars(3 - x)) + num2
                Next

                txtDescifrado.Text = ""
                For x = 0 To digitos.Length - 2
                    If (digitos(x) >= 10) Then
                        digitos(x) = digitos(x) Mod 10
                    End If
                    txtDescifrado.Text = txtDescifrado.Text & digitos(x)
                Next

            Else
                txtError.Text = "Tiene que ser un numero de 4 dígitos..."
            End If

        Catch ex As Exception
            txtError.Text = ex.Message
        End Try
    End Sub

End Class