Public Class FrmRecorrido
    Dim cantidad As Integer
    Private Sub nudTope_ValueChanged(sender As Object, e As EventArgs) Handles nudTope.ValueChanged
        cantidad = nudTope.Value
        If cantidad >= 1 Then
            dgvNumeros.RowCount = cantidad
            dgvRecorrido.RowCount = cantidad
            dgvNumeros.ColumnCount = cantidad
            dgvRecorrido.ColumnCount = cantidad
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim i, j As Integer
        For i = 0 To cantidad - 1
            For j = 0 To cantidad - 1
                dgvNumeros.Rows(i).Cells(j).Value = CInt(Math.Floor(100 - 1) * Rnd()) + 1
            Next j
        Next i
    End Sub

    Private Sub btnRecorrido_Click(sender As Object, e As EventArgs) Handles btnRecorrido.Click
        Dim i, j, incial, tope, incremento, pos As Integer
        For i = 0 To cantidad - 1
            pos = 0
            If i Mod 2 = 0 Then
                incial = cantidad - 1
                tope = 0
                incremento = -1
            Else
                incial = 0
                tope = cantidad - 1
                incremento = 1
            End If
            For j = incial To tope Step incremento
                dgvRecorrido.Rows(i).Cells(pos).Value = dgvNumeros.Rows(i).Cells(j).Value
                pos += 1
            Next j
        Next i
    End Sub
End Class