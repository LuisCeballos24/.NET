<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mnustrPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecorridoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatrizToolStripMenuItem, Me.RadioButtonToolStripMenuItem, Me.ValidacionesToolStripMenuItem, Me.ComboBoxToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MatrizToolStripMenuItem
        '
        Me.MatrizToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecorridoToolStripMenuItem})
        Me.MatrizToolStripMenuItem.Name = "MatrizToolStripMenuItem"
        Me.MatrizToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MatrizToolStripMenuItem.Text = "Matriz"
        '
        'RecorridoToolStripMenuItem
        '
        Me.RecorridoToolStripMenuItem.Name = "RecorridoToolStripMenuItem"
        Me.RecorridoToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.RecorridoToolStripMenuItem.Text = "Recorrido"
        '
        'RadioButtonToolStripMenuItem
        '
        Me.RadioButtonToolStripMenuItem.Name = "RadioButtonToolStripMenuItem"
        Me.RadioButtonToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.RadioButtonToolStripMenuItem.Text = "RadioButton"
        '
        'ValidacionesToolStripMenuItem
        '
        Me.ValidacionesToolStripMenuItem.Name = "ValidacionesToolStripMenuItem"
        Me.ValidacionesToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ValidacionesToolStripMenuItem.Text = "Validaciones"
        '
        'ComboBoxToolStripMenuItem
        '
        Me.ComboBoxToolStripMenuItem.Name = "ComboBoxToolStripMenuItem"
        Me.ComboBoxToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ComboBoxToolStripMenuItem.Text = "ComboBox"
        '
        'mnustrPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mnustrPrincipal"
        Me.Text = "Form5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecorridoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValidacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBoxToolStripMenuItem As ToolStripMenuItem
End Class
