Public Class FrmOperaciones
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbSuma.CheckedChanged
        lblOperacion.Text = "+"
    End Sub

    Private Sub rbResta_CheckedChanged(sender As Object, e As EventArgs) Handles rbResta.CheckedChanged
        lblOperacion.Text = "-"
    End Sub

    Private Sub rbMultiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles rbMultiplicacion.CheckedChanged
        lblOperacion.Text = "*"
    End Sub

    Private Sub rbDivision_CheckedChanged(sender As Object, e As EventArgs) Handles rbDivision.CheckedChanged
        lblOperacion.Text = "/"
    End Sub

    Private Sub btnResolver_Click(sender As Object, e As EventArgs) Handles btnResolver.Click
        If rbSuma.Checked Then
            txtRes.Text = Val(txtNum1.Text) + Val(txtNum2.Text)
        ElseIf rbResta.Checked Then
            txtRes.Text = Val(txtNum1.Text) - Val(txtNum2.Text)
        ElseIf rbMultiplicacion.Checked Then
            txtRes.Text = Val(txtNum1.Text) * Val(txtNum2.Text)
        ElseIf rbDivision.Checked Then
            txtRes.Clear()
            If Val(txtNum2.Text) > 0 Then
                txtRes.Text = Val(txtNum1.Text) / Val(txtNum2.Text)
            Else
                MsgBox("No se puede realizar la division entre 0")
            End If
        End If
    End Sub
End Class