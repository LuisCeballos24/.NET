<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarUsuario
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
        Me.cboTipoCuenta = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtCedula = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtApellido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContraseña2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContraseña = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblContraseña2 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgRU = New System.Windows.Forms.DataGridView()
        Me.btnRegistrarUsuario = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgRU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cboTipoCuenta)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtContraseña2)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtContraseña)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.lblApellido)
        Me.GroupBox1.Controls.Add(Me.lblContraseña2)
        Me.GroupBox1.Controls.Add(Me.lblCedula)
        Me.GroupBox1.Controls.Add(Me.lblContraseña)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.lblCorreo)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 84)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(805, 271)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'cboTipoCuenta
        '
        Me.cboTipoCuenta.AutoRoundedCorners = True
        Me.cboTipoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.cboTipoCuenta.BorderColor = System.Drawing.Color.Lime
        Me.cboTipoCuenta.BorderRadius = 17
        Me.cboTipoCuenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCuenta.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.cboTipoCuenta.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTipoCuenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTipoCuenta.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboTipoCuenta.ForeColor = System.Drawing.Color.Lime
        Me.cboTipoCuenta.ItemHeight = 30
        Me.cboTipoCuenta.Location = New System.Drawing.Point(519, 147)
        Me.cboTipoCuenta.Name = "cboTipoCuenta"
        Me.cboTipoCuenta.Size = New System.Drawing.Size(214, 36)
        Me.cboTipoCuenta.TabIndex = 21
        '
        'txtCedula
        '
        Me.txtCedula.AutoRoundedCorners = True
        Me.txtCedula.BorderColor = System.Drawing.Color.Lime
        Me.txtCedula.BorderRadius = 12
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
        Me.txtCedula.Location = New System.Drawing.Point(519, 93)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCedula.PlaceholderText = ""
        Me.txtCedula.SelectedText = ""
        Me.txtCedula.Size = New System.Drawing.Size(214, 26)
        Me.txtCedula.TabIndex = 20
        '
        'txtApellido
        '
        Me.txtApellido.AutoRoundedCorners = True
        Me.txtApellido.BorderColor = System.Drawing.Color.Lime
        Me.txtApellido.BorderRadius = 12
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
        Me.txtApellido.Location = New System.Drawing.Point(519, 40)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellido.PlaceholderText = ""
        Me.txtApellido.SelectedText = ""
        Me.txtApellido.Size = New System.Drawing.Size(214, 26)
        Me.txtApellido.TabIndex = 19
        '
        'txtContraseña2
        '
        Me.txtContraseña2.AutoRoundedCorners = True
        Me.txtContraseña2.BorderColor = System.Drawing.Color.Lime
        Me.txtContraseña2.BorderRadius = 12
        Me.txtContraseña2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña2.DefaultText = ""
        Me.txtContraseña2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContraseña2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContraseña2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña2.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtContraseña2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtContraseña2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña2.Location = New System.Drawing.Point(157, 198)
        Me.txtContraseña2.Name = "txtContraseña2"
        Me.txtContraseña2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContraseña2.PlaceholderText = ""
        Me.txtContraseña2.SelectedText = ""
        Me.txtContraseña2.Size = New System.Drawing.Size(214, 26)
        Me.txtContraseña2.TabIndex = 18
        '
        'txtCorreo
        '
        Me.txtCorreo.AutoRoundedCorners = True
        Me.txtCorreo.BorderColor = System.Drawing.Color.Lime
        Me.txtCorreo.BorderRadius = 12
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreo.DefaultText = ""
        Me.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.Location = New System.Drawing.Point(157, 92)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.PlaceholderText = ""
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.Size = New System.Drawing.Size(214, 26)
        Me.txtCorreo.TabIndex = 17
        '
        'txtContraseña
        '
        Me.txtContraseña.AutoRoundedCorners = True
        Me.txtContraseña.BorderColor = System.Drawing.Color.Lime
        Me.txtContraseña.BorderRadius = 12
        Me.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña.DefaultText = ""
        Me.txtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña.Location = New System.Drawing.Point(157, 147)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContraseña.PlaceholderText = ""
        Me.txtContraseña.SelectedText = ""
        Me.txtContraseña.Size = New System.Drawing.Size(214, 26)
        Me.txtContraseña.TabIndex = 16
        '
        'txtNombre
        '
        Me.txtNombre.AutoRoundedCorners = True
        Me.txtNombre.BorderColor = System.Drawing.Color.Lime
        Me.txtNombre.BorderRadius = 12
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
        Me.txtNombre.Location = New System.Drawing.Point(157, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PlaceholderText = ""
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(214, 26)
        Me.txtNombre.TabIndex = 15
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(445, 147)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(57, 25)
        Me.lblTipo.TabIndex = 14
        Me.lblTipo.Text = "Tipo:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(422, 40)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(92, 25)
        Me.lblApellido.TabIndex = 9
        Me.lblApellido.Text = "Apellido:"
        '
        'lblContraseña2
        '
        Me.lblContraseña2.AutoSize = True
        Me.lblContraseña2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña2.ForeColor = System.Drawing.Color.White
        Me.lblContraseña2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblContraseña2.Location = New System.Drawing.Point(30, 199)
        Me.lblContraseña2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContraseña2.Name = "lblContraseña2"
        Me.lblContraseña2.Size = New System.Drawing.Size(122, 25)
        Me.lblContraseña2.TabIndex = 10
        Me.lblContraseña2.Text = "Contraseña:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.Color.White
        Me.lblCedula.Location = New System.Drawing.Point(433, 93)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(81, 25)
        Me.lblCedula.TabIndex = 5
        Me.lblCedula.Text = "Cédula:"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.White
        Me.lblContraseña.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblContraseña.Location = New System.Drawing.Point(30, 147)
        Me.lblContraseña.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(122, 25)
        Me.lblContraseña.TabIndex = 6
        Me.lblContraseña.Text = "Contraseña:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(60, 40)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(92, 25)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.White
        Me.lblCorreo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblCorreo.Location = New System.Drawing.Point(73, 93)
        Me.lblCorreo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(79, 25)
        Me.lblCorreo.TabIndex = 2
        Me.lblCorreo.Text = "Correo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(342, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Registrar Usuario"
        '
        'dtgRU
        '
        Me.dtgRU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRU.Location = New System.Drawing.Point(891, 438)
        Me.dtgRU.Name = "dtgRU"
        Me.dtgRU.RowHeadersWidth = 51
        Me.dtgRU.Size = New System.Drawing.Size(17, 17)
        Me.dtgRU.TabIndex = 8
        Me.dtgRU.Visible = False
        '
        'btnRegistrarUsuario
        '
        Me.btnRegistrarUsuario.AutoRoundedCorners = True
        Me.btnRegistrarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarUsuario.BorderRadius = 28
        Me.btnRegistrarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegistrarUsuario.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegistrarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegistrarUsuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnRegistrarUsuario.FillColor2 = System.Drawing.Color.Black
        Me.btnRegistrarUsuario.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarUsuario.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnRegistrarUsuario.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_usuario_masculino_en_círculo_50
        Me.btnRegistrarUsuario.Location = New System.Drawing.Point(369, 369)
        Me.btnRegistrarUsuario.Name = "btnRegistrarUsuario"
        Me.btnRegistrarUsuario.Size = New System.Drawing.Size(183, 58)
        Me.btnRegistrarUsuario.TabIndex = 29
        Me.btnRegistrarUsuario.Text = "Registrar"
        Me.btnRegistrarUsuario.UseTransparentBackground = True
        '
        'RegistrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoSemestral.My.Resources.Resources._17926
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(920, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRegistrarUsuario)
        Me.Controls.Add(Me.dtgRU)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "RegistrarUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgRU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblContraseña2 As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents dtgRU As DataGridView
    Friend WithEvents txtNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCedula As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtApellido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContraseña2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContraseña As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cboTipoCuenta As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnRegistrarUsuario As Guna.UI2.WinForms.Guna2GradientButton
End Class
