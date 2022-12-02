<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActualizarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnVolver = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnActualizar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnReiniciar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtApellido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCedula = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnVolver)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnReiniciar)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
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
        Me.GroupBox1.Size = New System.Drawing.Size(613, 379)
        Me.GroupBox1.TabIndex = 5
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
        Me.btnVolver.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnVolver.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVolver.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_izquierda_50
        Me.btnVolver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnVolver.Location = New System.Drawing.Point(0, 333)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(135, 41)
        Me.btnVolver.TabIndex = 25
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
        Me.btnActualizar.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnActualizar.FillColor2 = System.Drawing.Color.Black
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btnActualizar.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_sincronizar_50
        Me.btnActualizar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnActualizar.Location = New System.Drawing.Point(320, 273)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(151, 41)
        Me.btnActualizar.TabIndex = 24
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
        Me.btnReiniciar.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnReiniciar.FillColor2 = System.Drawing.Color.Black
        Me.btnReiniciar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReiniciar.ForeColor = System.Drawing.Color.White
        Me.btnReiniciar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.btnReiniciar.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_repite_uno_50
        Me.btnReiniciar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReiniciar.Location = New System.Drawing.Point(157, 273)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(151, 41)
        Me.btnReiniciar.TabIndex = 23
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseTransparentBackground = True
        '
        'txtApellido
        '
        Me.txtApellido.AutoRoundedCorners = True
        Me.txtApellido.BorderColor = System.Drawing.Color.Lime
        Me.txtApellido.BorderRadius = 13
        Me.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellido.DefaultText = ""
        Me.txtApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellido.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellido.Location = New System.Drawing.Point(405, 94)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellido.PlaceholderText = ""
        Me.txtApellido.SelectedText = ""
        Me.txtApellido.Size = New System.Drawing.Size(200, 28)
        Me.txtApellido.TabIndex = 22
        '
        'txtCedula
        '
        Me.txtCedula.AutoRoundedCorners = True
        Me.txtCedula.BorderColor = System.Drawing.Color.Lime
        Me.txtCedula.BorderRadius = 13
        Me.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCedula.DefaultText = ""
        Me.txtCedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCedula.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCedula.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCedula.Location = New System.Drawing.Point(108, 139)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCedula.PlaceholderText = ""
        Me.txtCedula.SelectedText = ""
        Me.txtCedula.Size = New System.Drawing.Size(200, 28)
        Me.txtCedula.TabIndex = 21
        '
        'txtNombre
        '
        Me.txtNombre.AutoRoundedCorners = True
        Me.txtNombre.BorderColor = System.Drawing.Color.Lime
        Me.txtNombre.BorderRadius = 13
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.DefaultText = ""
        Me.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(108, 92)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PlaceholderText = ""
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(200, 28)
        Me.txtNombre.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(531, 23)
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
        Me.txtId.Location = New System.Drawing.Point(560, 23)
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
        Me.Label4.Location = New System.Drawing.Point(15, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cédula:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(316, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 94)
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
        Me.txtNombreCompleto.Size = New System.Drawing.Size(237, 30)
        Me.txtNombreCompleto.TabIndex = 1
        Me.txtNombreCompleto.Text = "Cliente Seleccionado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(224, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Actualizar Cliente"
        '
        'ActualizarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoSemestral.My.Resources.Resources._17926
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(688, 484)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ActualizarCliente"
        Me.Text = "Actualizar Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents txtNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtApellido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCedula As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnReiniciar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnActualizar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnVolver As Guna.UI2.WinForms.Guna2GradientButton
End Class
