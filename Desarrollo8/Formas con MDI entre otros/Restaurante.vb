Public Class Restaurante
    Private menu As String
    Public Sub asignar(ByVal opcion As String)
        menu = opcion
    End Sub
    Public Function extraerPrecio() As Double
        Dim posicion As Integer
        posicion = InStr(menu, ":")
        extraerPrecio = Val(Mid(menu, posicion + 1))
    End Function
End Class
