Public Class F
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim cantidad, vectorNumeros(), i As Integer
        cantidad = Val(txtCantidad.Text)
        ReDim vectorNumeros(cantidad - 1)
        lstImpresion.Items.Clear()
        For i = 0 To cantidad - 1
            vectorNumeros(i) = InputBox("Ingrese un numero", "Cargar Datos")
            lstImpresion.Items.Add(vectorNumeros(i))
        Next
        lstImpresion.Items.Add("Sumatoria =>" & sumarNumeros(vectorNumeros))
    End Sub
    Function sumarNumeros(ByVal vector() As Integer)
        Dim i As Integer
        sumarNumeros = 0
        For i = 0 To vector.Length - 1
            sumarNumeros += vector(i)
        Next

    End Function

    Private Sub lstImpresion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstImpresion.SelectedIndexChanged
        Dim dato As String
        Dim posicion As Integer
        dato = lstImpresion.SelectedItem
        posicion = lstImpresion.SelectedIndex
        MsgBox("El dato seleccionado " & dato & "En la posicion" & posicion)
    End Sub
End Class