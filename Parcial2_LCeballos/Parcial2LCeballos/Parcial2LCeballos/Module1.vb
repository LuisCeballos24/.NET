Module Module1
    Public Sub NumeroyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) AndAlso
            (Not e.KeyChar = "." Or CajaTexto.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub
End Module
