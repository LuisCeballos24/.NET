Imports System.Data.SqlClient
Imports System.IO.Path
Public Class RegistrarProducto

    Dim openFileDialog1 As OpenFileDialog
    Dim IMAGEN As String
    Dim nombreImagen As String = "Producto.jpg"
    Dim extension As String

    Private Sub btnRegistrarProducto_Click(sender As Object, e As EventArgs) Handles btnRegistrarProducto.Click
        Dim glComand As New SqlCommand

        Dim nombre As String
        Dim nuevaRuta As String
        Dim precio As Double
        Dim cantidad As Integer
        Dim now1 As Date = Now
        Dim fecha As String

        If txtNombre.Text <> "" And txtPrecio.Text <> "" And txtCantidad.Text <> "" Then

            fecha = Replace(now1, "/", "")
            fecha = Replace(fecha, ":", "")
            fecha = Replace(fecha, " ", "")
            nombre = txtNombre.Text
            precio = txtPrecio.Text
            cantidad = txtCantidad.Text
            nuevaRuta = "..\..\Productos\" & nombre & fecha & extension

            CopiarArchivo(nombreImagen, nuevaRuta)


            If precio < 0 Then
                MsgBox("El precio de ser mayor que cero. Precio= " & precio, vbYes, "Error")
            ElseIf cantidad < 0 Then
                MsgBox("Debe ingresar una cantidad mayor a cero.", vbYes, "Error")
            Else
                glComand.Connection = mYConn
                glComand.CommandText = "SP_RegistrarProducto"
                glComand.Parameters.AddWithValue("@nombreP", nombre)
                glComand.Parameters.AddWithValue("@precioP", precio)
                glComand.Parameters.AddWithValue("@cantidadP", cantidad)
                glComand.Parameters.AddWithValue("@byteImageP", nombre & fecha & extension)

                glComand.CommandTimeout = 0
                glComand.CommandType = CommandType.StoredProcedure

                Try
                    mYConn.Open()
                    glComand.ExecuteNonQuery()
                    MsgBox("Producto registrado exitosamente", vbYes, "Exito")

                    txtNombre.Text = ""
                    txtPrecio.Text = ""
                    txtCantidad.Text = ""

                Catch ex As Exception
                    MsgBox("No se pudo registrar al producto, vuelva a intentarlo
                        Error:" & ex.Message, vbYes, "Error")
                Finally
                    If mYConn.State <> ConnectionState.Closed Then
                        mYConn.Close()
                    End If
                End Try
            End If
        Else
            MsgBox("Debe llenar todos los campos.", vbYes, "Error")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso
            Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub RegistrarProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Bienvenida.MdiParent = MenuPrincipal
        Bienvenida.WindowState = FormWindowState.Maximized
        Bienvenida.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim openFileDialog1 As New OpenFileDialog

            openFileDialog1.InitialDirectory = "C:\"
            openFileDialog1.CheckFileExists = True
            openFileDialog1.ShowDialog()
            If openFileDialog1.FileName = "" Then
                IMAGEN = openFileDialog1.FileName
                Dim largo As Integer = IMAGEN.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                        MsgBox("Formato no valido") : Exit Sub
                        If imagen2 <> "log1" Then Exit Sub
                    End If

                End If
            End If
            extension = GetExtension(openFileDialog1.FileName)
            nombreImagen = openFileDialog1.FileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RegistrarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Top = Me.Height / 6 - (Label1.Height / 2)
        GroupBox1.Top = Me.Height / 2.5 - (GroupBox1.Height / 2)
        btnRegistrarProducto.Top = Me.Height / 1.4 - (btnRegistrarProducto.Height / 2)

        Label1.Left = Me.Width / 2 - (Label1.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        btnRegistrarProducto.Left = Me.Width / 2 - (btnRegistrarProducto.Width / 2)

        Label1.BackColor = Color.FromArgb(230, 64, 64, 64)
        GroupBox1.BackColor = Color.FromArgb(230, 64, 64, 64)
        btnRegistrarProducto.BackColor = Color.FromArgb(230, 64, 64, 64)
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        importarCSV(OpenFileDialog2, dgvProductos, ",")
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim ruta As String
        Dim StrExport As String

        For Each c As DataGridViewColumn In dgvProductos.Columns
            StrExport &= """" & c.HeaderText & ""","
        Next
        StrExport = StrExport.Substring(0, StrExport.Length - 1)
        StrExport &= Environment.NewLine

        Dim columnas As Integer = dgvProductos.ColumnCount
        Dim filas As Integer = dgvProductos.RowCount
        Dim total As Integer = columnas * filas

        For Each r As DataGridViewRow In dgvProductos.Rows
            For Each c As DataGridViewCell In r.Cells
                If Not c.Value Is Nothing Then
                    StrExport &= """" & c.Value.ToString & ""","
                Else
                    StrExport &= """" & "" & ""","
                End If
            Next
            StrExport = StrExport.Substring(0, StrExport.Length - 1)
            StrExport &= Environment.NewLine
        Next

        Dim saveFileDialog As SaveFileDialog = New SaveFileDialog
        saveFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        saveFileDialog.Filter = "Archivos CSV (*.CSV)|* .CSV"
        saveFileDialog.FilterIndex = 2
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            ruta = saveFileDialog.FileName
            MsgBox("exportado Correctamente", MsgBoxStyle.Information)
            Dim tw As IO.TextWriter = New IO.StreamWriter(ruta)
            tw.Write(StrExport)
            tw.Close()
        Else
            Return
        End If
    End Sub

End Class