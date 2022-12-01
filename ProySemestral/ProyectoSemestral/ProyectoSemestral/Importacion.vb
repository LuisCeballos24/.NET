Module Importacion

    Sub importarCSV(ByVal ofd As OpenFileDialog, ByVal tabla As DataGridView, ByVal delimitador As String)
        Try
            Dim ruta As String = ""

            ofd.InitialDirectory = "c:\temp\"
            ofd.Filter = "CSV files (*.csv)|*.CSV"
            ofd.FilterIndex = 2
            ofd.RestoreDirectory = True

            If (ofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then

                ruta = ofd.FileName

            End If

            Dim TextLine As String = ""
            Dim SplitLine() As String


            If System.IO.File.Exists(ruta) = True Then

                Dim objReader As New System.IO.StreamReader(ruta)

                Do While objReader.Peek() <> -1

                    TextLine = objReader.ReadLine()

                    SplitLine = Split(TextLine, delimitador)
                    tabla.ColumnCount = SplitLine.Length - 1
                    tabla.Rows.Add(SplitLine)
                Loop
            Else
                MsgBox("Archivo Inexistente", MsgBoxStyle.Information, "CSV Inexistente")
            End If
        Catch ex As Exception
            MsgBox("Error de Importacion: " + ex.ToString)
        End Try
    End Sub
End Module
