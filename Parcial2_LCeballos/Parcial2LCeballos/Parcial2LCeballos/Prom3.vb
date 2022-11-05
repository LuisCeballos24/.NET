Public Class Prom3
    Dim InfoPart(,) As Double
    Dim Usuario() As String
    Dim CantidadParticipantes, peso(), suma, suma1, suma2 As Integer
    Dim promedioF, promedioI, pesoPerdida() As Double
    Dim nombre() As String
    Dim input
    Private Sub Prom3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAñadirP.Enabled = False
        btnPesaje.Enabled = False
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        NumeroyDecimal(txtCantidad, e)
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            CantidadParticipantes = Val(txtCantidad.Text)
            If (CantidadParticipantes > 0) Then
                dgvInfo.RowCount = CantidadParticipantes
                dgvInfo.ColumnCount = 2
                dgvInfo1.RowCount = 1
                dgvInfo1.ColumnCount = 3
                With dgvInfo
                    'Numero de columna
                    .Columns(0).HeaderText = "Nombre"
                    .Columns(1).HeaderText = "Cantidad de libras perdidas"
                End With
                With dgvInfo1
                    'Numero de columna
                    .Columns(0).HeaderText = "Peso Promedio Incial"
                    .Columns(1).HeaderText = "Peso Promedio Final"
                    .Columns(2).HeaderText = "Ganador"
                End With
                btnAñadirP.Enabled = True
                btnEnviar.Enabled = False
                btnPesaje.Enabled = False
            End If
        Catch ex As Exception
            txtCantidad.Text = "Tiene que ser mayor a 0"
        End Try
    End Sub

    Private Sub btnAñadirP_Click(sender As Object, e As EventArgs) Handles btnAñadirP.Click
        Try
            For i = 0 To CantidadParticipantes - 1
                Array.Resize(peso, CantidadParticipantes)
                Array.Resize(nombre, CantidadParticipantes)
                nombre(i) = InputBox("Introduzca su Nombre", "Nombre", "")
                peso(i) = InputBox("Introduzca su Peso", "Peso", "")
                suma += peso(i)
                promedioI = suma / CantidadParticipantes
            Next i

            For i = 0 To CantidadParticipantes - 1
                For j = 0 To 1 - 1
                    ReDim Usuario(CantidadParticipantes)
                    Usuario(i) = nombre(i)
                    dgvInfo.Rows(i).Cells(j).Value = Usuario(i)
                Next j
            Next i
            If (nombre.Length > 0 And peso.Length) Then
                btnAñadirP.Enabled = False
                btnEnviar.Enabled = False
                btnPesaje.Enabled = True
            Else
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnPesaje_Click(sender As Object, e As EventArgs) Handles btnPesaje.Click
        Try
            ReDim InfoPart(CantidadParticipantes - 1, 7)
            ReDim pesoPerdida(CantidadParticipantes - 1)
            For i = 0 To CantidadParticipantes - 1
                For j = 0 To 6
                    InfoPart(i, j) = InputBox("Introduzca su Peso", "Peso", "")
                    suma1 += InfoPart(i, j)
                    suma2 = peso(i) - InfoPart(i, j)
                    pesoPerdida(i) = suma - suma2
                Next j
                dgvInfo.Rows(i).Cells(1).Value = pesoPerdida(i)
            Next i
            dgvInfo1.Rows(0).Cells(0).Value = promedioI
            dgvInfo1.Rows(0).Cells(1).Value = promedioF
        Catch ex As Exception
        End Try
    End Sub
End Class