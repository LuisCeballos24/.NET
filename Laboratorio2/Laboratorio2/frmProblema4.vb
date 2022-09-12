Public Class frmProblema4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim anio, a, b, c, d, dia, f As Integer
        anio = Val(txtAnio.Text)
        a = anio Mod 19
        b = anio Mod 4
        c = anio Mod 7
        d = (19 * a + 24) Mod 30
        f = (2 * b + 4 * c + 6 * d + 5) Mod 7
        dia = 22 + d + f
        lstResultado.Items.Add("La Fecha del Domingo de Pascua del: " & anio)
        If (dia <= 31) Then
            lstResultado.Items.Add(" es el dia " & dia & " de Marzo ")
        Else
            lstResultado.Items.Add("es el dia " & dia - 31 & " de Abril ")
        End If
    End Sub
End Class
