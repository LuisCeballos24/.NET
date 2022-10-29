Public Class Prom3
    Dim InfoPart()() As String
    Dim CantidadParticipantes, peso, repetir, parti As Integer
    Dim nombre As String
    Private Sub Prom3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAñadirP.Enabled = False
        btnEjecutar.Enabled = False
        btnPesaje.Enabled = False
        txtParticipante.Enabled = False
        txtPesoInicial.Enabled = False
        txtLibraPesaje.Enabled = False
    End Sub
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            CantidadParticipantes = Val(txtCantidad.Text)
            If (CantidadParticipantes > 0) Then
                dgvInfo.RowCount = CantidadParticipantes
                dgvInfo.ColumnCount = CantidadParticipantes
                dgvLibrasP.RowCount = CantidadParticipantes
                dgvLibrasP.ColumnCount = 2
                repetir = 0
                btnAñadirP.Enabled = True
                btnEnviar.Enabled = False
                btnPesaje.Enabled = False
                txtParticipante.Enabled = True
                txtPesoInicial.Enabled = True
            Else
                txtCantidad.Text = ""
            End If
        Catch ex As Exception
            txtCantidad.Text = "Tiene que ser mayor a 0"
        End Try
    End Sub

    Private Sub btnAñadirP_Click(sender As Object, e As EventArgs) Handles btnAñadirP.Click
        Try
            nombre = Val(txtParticipante.Text)
            peso = Val(txtPesoInicial.Text)
            If (nombre.Trim.Length > 0 And peso < 0) Then
                btnAñadirP.Enabled = False
                btnEnviar.Enabled = False
                btnPesaje.Enabled = True
                txtLibraPesaje.Enabled = True
                parti = 0
            Else
                txtParticipante.Text = ""
                txtPesoInicial.Text = ""
            End If
        Catch ex As Exception
            txtError.Text = "Ingresa los datos solicitados"
        End Try

    End Sub
    Private Sub btnPesaje_Click(sender As Object, e As EventArgs) Handles btnPesaje.Click
        Try
            InfoPart(parti)(repetir) = Val(txtLibraPesaje.Text)
            repetir = repetir + 1
            If (repetir = 7) Then
                repetir = 0
                parti = parti + 1
                txtLibraPesaje.Enabled = False
                btnPesaje.Enabled = False
                btnAñadirP.Enabled = True
                txtParticipante.Enabled = True
                txtPesoInicial.Enabled = True
            End If
        Catch ex As Exception
            txtError.Text = "Ingresa el peso solicitados"
        End Try

    End Sub
End Class