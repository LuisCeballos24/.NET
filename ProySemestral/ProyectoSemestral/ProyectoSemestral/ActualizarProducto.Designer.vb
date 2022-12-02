<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarProducto
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
        Me.btnVolver = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnActualizar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnReiniciar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Button1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtPrecio = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCantidad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtImg = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnVolver)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnReiniciar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtImg)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompleto)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(38, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(722, 453)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.AutoRoundedCorners = True
        Me.btnVolver.BorderRadius = 19
        Me.btnVolver.CustomizableEdges.BottomLeft = False
        Me.btnVolver.CustomizableEdges.TopLeft = False
        Me.btnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVolver.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVolver.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnVolver.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnVolver.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_izquierda_50
        Me.btnVolver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnVolver.Location = New System.Drawing.Point(0, 407)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(135, 41)
        Me.btnVolver.TabIndex = 31
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseTransparentBackground = True
        '
        'btnActualizar
        '
        Me.btnActualizar.AutoRoundedCorners = True
        Me.btnActualizar.BorderRadius = 19
        Me.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnActualizar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnActualizar.FillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnActualizar.FillColor2 = System.Drawing.Color.Black
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btnActualizar.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_sincronizar_50
        Me.btnActualizar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnActualizar.Location = New System.Drawing.Point(374, 358)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(151, 41)
        Me.btnActualizar.TabIndex = 30
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseTransparentBackground = True
        '
        'btnReiniciar
        '
        Me.btnReiniciar.AutoRoundedCorners = True
        Me.btnReiniciar.BorderRadius = 19
        Me.btnReiniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReiniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReiniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReiniciar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReiniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReiniciar.FillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnReiniciar.FillColor2 = System.Drawing.Color.Black
        Me.btnReiniciar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReiniciar.ForeColor = System.Drawing.Color.White
        Me.btnReiniciar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.btnReiniciar.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_repite_uno_50
        Me.btnReiniciar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReiniciar.Location = New System.Drawing.Point(206, 358)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(151, 41)
        Me.btnReiniciar.TabIndex = 29
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseTransparentBackground = True
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
        Me.Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button1.FillColor2 = System.Drawing.Color.Empty
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Button1.Location = New System.Drawing.Point(454, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 28)
        Me.Button1.TabIndex = 28
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
        Me.txtPrecio.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrecio.Location = New System.Drawing.Point(452, 60)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecio.PlaceholderText = ""
        Me.txtPrecio.SelectedText = ""
        Me.txtPrecio.Size = New System.Drawing.Size(206, 28)
        Me.txtPrecio.TabIndex = 27
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
        Me.txtCantidad.Location = New System.Drawing.Point(126, 107)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCantidad.PlaceholderText = ""
        Me.txtCantidad.SelectedText = ""
        Me.txtCantidad.Size = New System.Drawing.Size(228, 28)
        Me.txtCantidad.TabIndex = 26
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
        Me.txtNombre.Location = New System.Drawing.Point(126, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PlaceholderText = ""
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(228, 28)
        Me.txtNombre.TabIndex = 25
        '
        'txtImg
        '
        Me.txtImg.Location = New System.Drawing.Point(662, 410)
        Me.txtImg.Margin = New System.Windows.Forms.Padding(2)
        Me.txtImg.Name = "txtImg"
        Me.txtImg.Size = New System.Drawing.Size(15, 20)
        Me.txtImg.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(237, 144)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 197)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(370, 108)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 22)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Imagen:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(614, 15)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ID:"
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.White
        Me.txtId.Location = New System.Drawing.Point(642, 15)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(30, 22)
        Me.txtId.TabIndex = 16
        Me.txtId.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(28, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(370, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Precio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.AutoSize = True
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.ForeColor = System.Drawing.Color.White
        Me.txtNombreCompleto.Location = New System.Drawing.Point(8, 17)
        Me.txtNombreCompleto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(260, 30)
        Me.txtNombreCompleto.TabIndex = 1
        Me.txtNombreCompleto.Text = "Producto Seleccionado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(248, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Actualizar Producto"
        '
        'ActualizarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoSemestral.My.Resources.Resources.rm378_01c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(814, 609)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ActualizarProducto"
        Me.Text = "Actualizar Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtId As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreCompleto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtImg As TextBox
    Friend WithEvents txtNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtPrecio As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCantidad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnActualizar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnReiniciar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnVolver As Guna.UI2.WinForms.Guna2GradientButton
End Class
