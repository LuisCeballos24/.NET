Public Class frmProblema1
    Dim less500 As New List(Of Integer)
    Dim between As New List(Of Integer)
    Dim more1000 As New List(Of Integer)

    Private Sub btnAgregarVenta_Click(sender As Object, e As EventArgs) Handles btnAgregarVenta.Click
        Dim venta As Integer
        venta = Val(txtVenta.Text)
        If venta < 500 Then
            less500.Add(venta)
        ElseIf venta >= 500 And venta <= 1000 Then
            between.Add(venta)
        ElseIf venta > 1000 Then
            more1000.Add(venta)
        End If
        txtVenta.Clear()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        ' Calcular total Mayor a 1000
        txtCuantas1000.Text = more1000.Count
        txtCuanto1000.Text = more1000.Sum

        ' Calcular total menores a 500
        txtCuantasBetween.Text = between.Count
        txtCuantoBetween.Text = between.Sum

        ' Calcular total menores a 500
        txtCuantasMenor500.Text = less500.Count
        txtCuantoMenor500.Text = less500.Sum

        ' Calcular total ventas
        txtTotalVentas.Text = more1000.Sum + between.Sum + less500.Sum
    End Sub
End Class