<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblInicial = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.TxtInicial = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Multiplos de 3"
        '
        'lblInicial
        '
        Me.lblInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.lblInicial.AutoSize = True
        Me.lblInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicial.Location = New System.Drawing.Point(143, 131)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(76, 16)
        Me.lblInicial.TabIndex = 1
        Me.lblInicial.Text = "Valor Inicial"
        '
        'lblFinal
        '
        Me.lblFinal.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(148, 217)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(71, 16)
        Me.lblFinal.TabIndex = 2
        Me.lblFinal.Text = "Valor Final"
        '
        'TxtInicial
        '
        Me.TxtInicial.Location = New System.Drawing.Point(234, 131)
        Me.TxtInicial.Name = "TxtInicial"
        Me.TxtInicial.Size = New System.Drawing.Size(100, 20)
        Me.TxtInicial.TabIndex = 3
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(234, 213)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtFinal.TabIndex = 4
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(384, 364)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(124, 28)
        Me.btnEjecutar.TabIndex = 5
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(148, 298)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(69, 16)
        Me.lblResultado.TabIndex = 6
        Me.lblResultado.Text = "Resultado"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(234, 294)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Multiplos de 3"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 450)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.TxtInicial)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblInicial As Label
    Friend WithEvents lblFinal As Label
    Friend WithEvents TxtInicial As TextBox
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label2 As Label
End Class
