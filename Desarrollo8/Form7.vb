Imports System.IO

Public Class Form7
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim archivo As OpenFileDialog = New OpenFileDialog
        Dim sumar, i As Integer
        archivo.DefaultExt = "csv"
        archivo.InitialDirectory = "C:\"
        archivo.Filter = "All files|*.*| Text files|*.txt"
        archivo.ShowDialog()
        Try
            For Each linea In File.ReadAllLines(archivo.FileName)
                Dim vector As String() = Split(linea, ";")
                For i = 0 To vector.Length - 1
                    sumar += Val(vector(i))
                Next i
            Next
            txtResultado.Text = sumar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class