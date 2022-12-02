<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cobrar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnVolver = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnCobrar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.cboProductos = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtg2 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtg1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.Label()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnVolver)
        Me.GroupBox1.Controls.Add(Me.btnCobrar)
        Me.GroupBox1.Controls.Add(Me.cboProductos)
        Me.GroupBox1.Controls.Add(Me.dtg2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.dtg1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.lblProductos)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompleto)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 75)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(826, 405)
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
        Me.btnVolver.FillColor = System.Drawing.Color.Empty
        Me.btnVolver.FillColor2 = System.Drawing.Color.Empty
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnVolver.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_izquierda_50
        Me.btnVolver.Location = New System.Drawing.Point(0, 359)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(135, 41)
        Me.btnVolver.TabIndex = 28
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseTransparentBackground = True
        '
        'btnCobrar
        '
        Me.btnCobrar.AutoRoundedCorners = True
        Me.btnCobrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCobrar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCobrar.BorderRadius = 21
        Me.btnCobrar.BorderThickness = 1
        Me.btnCobrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCobrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCobrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCobrar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCobrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCobrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnCobrar.FillColor2 = System.Drawing.Color.Empty
        Me.btnCobrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCobrar.ForeColor = System.Drawing.Color.White
        Me.btnCobrar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.btnCobrar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCobrar.Image = Global.ProyectoSemestral.My.Resources.Resources.icons8_checkout_50__1_
        Me.btnCobrar.Location = New System.Drawing.Point(353, 313)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(187, 45)
        Me.btnCobrar.TabIndex = 27
        Me.btnCobrar.Text = "Confirmar Compra"
        Me.btnCobrar.UseTransparentBackground = True
        '
        'cboProductos
        '
        Me.cboProductos.BackColor = System.Drawing.Color.Transparent
        Me.cboProductos.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboProductos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductos.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cboProductos.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProductos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProductos.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboProductos.ItemHeight = 30
        Me.cboProductos.Location = New System.Drawing.Point(587, 57)
        Me.cboProductos.Name = "cboProductos"
        Me.cboProductos.Size = New System.Drawing.Size(196, 36)
        Me.cboProductos.TabIndex = 26
        '
        'dtg2
        '
        Me.dtg2.AllowUserToAddRows = False
        Me.dtg2.AllowUserToDeleteRows = False
        Me.dtg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg2.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg2.ColumnHeadersHeight = 29
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg2.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtg2.GridColor = System.Drawing.Color.White
        Me.dtg2.Location = New System.Drawing.Point(28, 106)
        Me.dtg2.Margin = New System.Windows.Forms.Padding(2)
        Me.dtg2.Name = "dtg2"
        Me.dtg2.ReadOnly = True
        Me.dtg2.RowHeadersVisible = False
        Me.dtg2.RowHeadersWidth = 51
        Me.dtg2.RowTemplate.Height = 24
        Me.dtg2.ShowCellErrors = False
        Me.dtg2.ShowRowErrors = False
        Me.dtg2.Size = New System.Drawing.Size(512, 189)
        Me.dtg2.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoSemestral.My.Resources.Resources.Producto
        Me.PictureBox1.Location = New System.Drawing.Point(574, 106)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'dtg1
        '
        Me.dtg1.AllowUserToAddRows = False
        Me.dtg1.AllowUserToDeleteRows = False
        Me.dtg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg1.BackgroundColor = System.Drawing.Color.LightCoral
        Me.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg1.GridColor = System.Drawing.Color.Maroon
        Me.dtg1.Location = New System.Drawing.Point(826, 376)
        Me.dtg1.Margin = New System.Windows.Forms.Padding(2)
        Me.dtg1.Name = "dtg1"
        Me.dtg1.ReadOnly = True
        Me.dtg1.RowHeadersWidth = 51
        Me.dtg1.RowTemplate.Height = 24
        Me.dtg1.Size = New System.Drawing.Size(24, 25)
        Me.dtg1.TabIndex = 21
        Me.dtg1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 30)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Productos Seleccionados"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(461, 63)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 30)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ID:"
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.White
        Me.txtId.Location = New System.Drawing.Point(504, 63)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(39, 30)
        Me.txtId.TabIndex = 16
        Me.txtId.Text = "00"
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductos.ForeColor = System.Drawing.Color.White
        Me.lblProductos.Location = New System.Drawing.Point(693, 17)
        Me.lblProductos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(114, 30)
        Me.lblProductos.TabIndex = 14
        Me.lblProductos.Text = "Producto:"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.AutoSize = True
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.ForeColor = System.Drawing.Color.White
        Me.txtNombreCompleto.Location = New System.Drawing.Point(23, 17)
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
        Me.Label1.Location = New System.Drawing.Point(406, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cobrar"
        '
        'Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoSemestral.My.Resources.Resources.rm378_02c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(947, 488)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cobrar"
        Me.ShowIcon = False
        Me.Text = "Cobrar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtId As Label
    Friend WithEvents lblProductos As Label
    Friend WithEvents txtNombreCompleto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtg1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtg2 As DataGridView
    Friend WithEvents cboProductos As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnCobrar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnVolver As Guna.UI2.WinForms.Guna2GradientButton
End Class
