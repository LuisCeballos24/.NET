<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lstImpresion = New System.Windows.Forms.ListBox()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(196, 51)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(385, 25)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "SUMA DE NUMEROS EN UN VECTOR"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(111, 119)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(66, 18)
        Me.lblCantidad.TabIndex = 1
        Me.lblCantidad.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.txtCantidad.Location = New System.Drawing.Point(201, 120)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 2
        '
        'lstImpresion
        '
        Me.lstImpresion.FormattingEnabled = True
        Me.lstImpresion.Location = New System.Drawing.Point(221, 166)
        Me.lstImpresion.Name = "lstImpresion"
        Me.lstImpresion.Size = New System.Drawing.Size(374, 212)
        Me.lstImpresion.TabIndex = 3
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(339, 404)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(117, 34)
        Me.btnEjecutar.TabIndex = 4
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'F
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.lstImpresion)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "F"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lstImpresion As ListBox
    Friend WithEvents btnEjecutar As Button
End Class
