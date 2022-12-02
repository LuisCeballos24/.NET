<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BienvenidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearProductoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearClienteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarClienteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BienvenidaToolStripMenuItem, Me.AdministracionToolStripMenuItem, Me.FacturacionToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.ItemSesion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(810, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BienvenidaToolStripMenuItem
        '
        Me.BienvenidaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BienvenidaToolStripMenuItem.Name = "BienvenidaToolStripMenuItem"
        Me.BienvenidaToolStripMenuItem.Size = New System.Drawing.Size(105, 25)
        Me.BienvenidaToolStripMenuItem.Text = "Bienvenida"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.AdministracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUsuarioToolStripMenuItem, Me.ActualizarUsuarioToolStripMenuItem})
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(136, 25)
        Me.AdministracionToolStripMenuItem.Text = "Administración"
        '
        'CrearUsuarioToolStripMenuItem
        '
        Me.CrearUsuarioToolStripMenuItem.Name = "CrearUsuarioToolStripMenuItem"
        Me.CrearUsuarioToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.CrearUsuarioToolStripMenuItem.Text = "Crear Usuario"
        '
        'ActualizarUsuarioToolStripMenuItem
        '
        Me.ActualizarUsuarioToolStripMenuItem.Name = "ActualizarUsuarioToolStripMenuItem"
        Me.ActualizarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.ActualizarUsuarioToolStripMenuItem.Text = "Actualizar Usuario"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.FacturacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CobrarToolStripMenuItem1})
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(111, 25)
        Me.FacturacionToolStripMenuItem.Text = "Facturación"
        '
        'CobrarToolStripMenuItem1
        '
        Me.CobrarToolStripMenuItem1.Name = "CobrarToolStripMenuItem1"
        Me.CobrarToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.CobrarToolStripMenuItem1.Text = "Cobrar"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearProductoToolStripMenuItem2, Me.ActualizarProductoToolStripMenuItem, Me.EliminarProductoToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(99, 25)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'CrearProductoToolStripMenuItem2
        '
        Me.CrearProductoToolStripMenuItem2.Name = "CrearProductoToolStripMenuItem2"
        Me.CrearProductoToolStripMenuItem2.Size = New System.Drawing.Size(230, 26)
        Me.CrearProductoToolStripMenuItem2.Text = "Crear Producto"
        '
        'ActualizarProductoToolStripMenuItem
        '
        Me.ActualizarProductoToolStripMenuItem.Name = "ActualizarProductoToolStripMenuItem"
        Me.ActualizarProductoToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ActualizarProductoToolStripMenuItem.Text = "Actualizar Producto"
        '
        'EliminarProductoToolStripMenuItem
        '
        Me.EliminarProductoToolStripMenuItem.Name = "EliminarProductoToolStripMenuItem"
        Me.EliminarProductoToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.EliminarProductoToolStripMenuItem.Text = "Eliminar Producto"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearClienteToolStripMenuItem2, Me.ActualizarClienteToolStripMenuItem2})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(82, 25)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CrearClienteToolStripMenuItem2
        '
        Me.CrearClienteToolStripMenuItem2.Name = "CrearClienteToolStripMenuItem2"
        Me.CrearClienteToolStripMenuItem2.Size = New System.Drawing.Size(213, 26)
        Me.CrearClienteToolStripMenuItem2.Text = "Crear Cliente"
        '
        'ActualizarClienteToolStripMenuItem2
        '
        Me.ActualizarClienteToolStripMenuItem2.Name = "ActualizarClienteToolStripMenuItem2"
        Me.ActualizarClienteToolStripMenuItem2.Size = New System.Drawing.Size(213, 26)
        Me.ActualizarClienteToolStripMenuItem2.Text = "Actualizar Cliente"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(82, 25)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'ItemSesion
        '
        Me.ItemSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ItemSesion.BackColor = System.Drawing.Color.Black
        Me.ItemSesion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.ItemSesion.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ItemSesion.Name = "ItemSesion"
        Me.ItemSesion.Size = New System.Drawing.Size(71, 25)
        Me.ItemSesion.Text = "Sesión"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.ProyectoSemestral.My.Resources.Resources.rm378_02c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(810, 570)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuPrincipal"
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CobrarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearProductoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearClienteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ActualizarClienteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BienvenidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemSesion As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
End Class
