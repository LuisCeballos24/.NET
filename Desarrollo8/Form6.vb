Imports System.Diagnostics.CodeAnalysis

Public Class Form6
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim inicio, fin, suma As Integer
        inicio = Val(txtValorInicial.Text)
        fin = Val(txtValorFinal.Text)
        txtResultado.Text = sumaRecursivo(inicio, fin)
    End Sub

    Function sumaRecursivo(ByVal ini As Integer, ByVal final As Integer)
        If final <= ini Then
            Return sumaRecursivo
        End If
        Return sumaRecursivo(ini + 1, final) + ini
    End Function
End Class