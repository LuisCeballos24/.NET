<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRegistrarProducto = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnImportar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnExportar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Button1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtPrecio = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCantidad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnRegistrarProducto)
        Me.GroupBox1.Controls.Add(Me.btnImportar)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.dgvProductos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblPrecio)
        Me.GroupBox1.Controls.Add(Me.lblCantidad)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 85)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(927, 449)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'btnRegistrarProducto
        '
        Me.btnRegistrarProducto.AutoRoundedCorners = True
        Me.btnRegistrarProducto.BorderColor = System.Drawing.Color.PaleGreen
        Me.btnRegistrarProducto.BorderRadius = 21
        Me.btnRegistrarProducto.BorderThickness = 1
        Me.btnRegistrarProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrarProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegistrarProducto.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegistrarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegistrarProducto.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnRegistrarProducto.FillColor2 = System.Drawing.Color.Empty
        Me.btnRegistrarProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnRegistrarProducto.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarProducto.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btnRegistrarProducto.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnRegistrarProducto.Location = New System.Drawing.Point(393, 391)
        Me.btnRegistrarProducto.Name = "btnRegistrarProducto"
        Me.btnRegistrarProducto.Size = New System.Drawing.Size(177, 44)
        Me.btnRegistrarProducto.TabIndex = 33
        Me.btnRegistrarProducto.Text = "Registrar"
        Me.btnRegistrarProducto.UseTransparentBackground = True
        '
        'btnImportar
        '
        Me.btnImportar.AutoRoundedCorners = True
        Me.btnImportar.BorderColor = System.Drawing.Color.PaleGreen
        Me.btnImportar.BorderRadius = 21
        Me.btnImportar.BorderThickness = 1
        Me.btnImportar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnImportar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnImportar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnImportar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnImportar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnImportar.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnImportar.FillColor2 = System.Drawing.Color.Empty
        Me.btnImportar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnImportar.ForeColor = System.Drawing.Color.White
        Me.btnImportar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btnImportar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnImportar.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_doble_abajo_50
        Me.btnImportar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnImportar.Location = New System.Drawing.Point(13, 143)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(177, 44)
        Me.btnImportar.TabIndex = 32
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseTransparentBackground = True
        '
        'btnExportar
        '
        Me.btnExportar.AutoRoundedCorners = True
        Me.btnExportar.BorderColor = System.Drawing.Color.PaleGreen
        Me.btnExportar.BorderRadius = 21
        Me.btnExportar.BorderThickness = 1
        Me.btnExportar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExportar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExportar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExportar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExportar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExportar.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnExportar.FillColor2 = System.Drawing.Color.Empty
        Me.btnExportar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnExportar.ForeColor = System.Drawing.Color.White
        Me.btnExportar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btnExportar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnExportar.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_doble_arriba_50
        Me.btnExportar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnExportar.Location = New System.Drawing.Point(723, 143)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(177, 44)
        Me.btnExportar.TabIndex = 31
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseTransparentBackground = True
        '
        'Button1
        '
        Me.Button1.AutoRoundedCorners = True
        Me.Button1.BorderColor = System.Drawing.Color.PaleGreen
        Me.Button1.BorderRadius = 13
        Me.Button1.BorderThickness = 1
        Me.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.FillColor2 = System.Drawing.Color.Empty
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Button1.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_editor_de_fotos_50
        Me.Button1.Location = New System.Drawing.Point(498, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 28)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Seleccione imagen"
        Me.Button1.UseTransparentBackground = True
        '
        'txtPrecio
        '
        Me.txtPrecio.AutoRoundedCorners = True
        Me.txtPrecio.BorderColor = System.Drawing.Color.PaleGreen
        Me.txtPrecio.BorderRadius = 13
        Me.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrecio.DefaultText = ""
        Me.txtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrecio.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrecio.Location = New System.Drawing.Point(498, 24)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecio.PlaceholderText = ""
        Me.txtPrecio.SelectedText = ""
        Me.txtPrecio.Size = New System.Drawing.Size(206, 28)
        Me.txtPrecio.TabIndex = 28
        '
        'txtCantidad
        '
        Me.txtCantidad.AutoRoundedCorners = True
        Me.txtCantidad.BorderColor = System.Drawing.Color.PaleGreen
        Me.txtCantidad.BorderRadius = 13
        Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCantidad.DefaultText = ""
        Me.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCantidad.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(134, 80)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCantidad.PlaceholderText = ""
        Me.txtCantidad.SelectedText = ""
        Me.txtCantidad.Size = New System.Drawing.Size(228, 28)
        Me.txtCantidad.TabIndex = 27
        '
        'txtNombre
        '
        Me.txtNombre.AutoRoundedCorners = True
        Me.txtNombre.BorderColor = System.Drawing.Color.PaleGreen
        Me.txtNombre.BorderRadius = 13
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.DefaultText = ""
        Me.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(134, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PlaceholderText = ""
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(228, 28)
        Me.txtNombre.TabIndex = 26
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(200, 143)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(517, 232)
        Me.dgvProductos.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(381, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Imagen:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.White
        Me.lblPrecio.Location = New System.Drawing.Point(388, 27)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(74, 25)
        Me.lblPrecio.TabIndex = 9
        Me.lblPrecio.Text = "Precio:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.White
        Me.lblCantidad.Location = New System.Drawing.Point(8, 83)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(100, 25)
        Me.lblCantidad.TabIndex = 5
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(16, 27)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(92, 25)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(406, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Registrar Producto"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'RegistrarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoSemestral.My.Resources.Resources.rm378_01c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(997, 581)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarProducto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarProducto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents txtNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCantidad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPrecio As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegistrarProducto As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnImportar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnExportar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2GradientButton
End Class
