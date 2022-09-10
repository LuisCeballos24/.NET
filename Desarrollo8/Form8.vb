Imports System.Speech.Synthesis
Public Class Form8
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim entrada As New SpeechSynthesizer
        Try
            entrada.Speak(txtEntrada.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class