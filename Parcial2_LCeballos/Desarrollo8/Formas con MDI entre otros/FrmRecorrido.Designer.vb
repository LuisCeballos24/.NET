<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecorrido
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
        Me.nudTope = New System.Windows.Forms.NumericUpDown()
        Me.dgvNumeros = New System.Windows.Forms.DataGridView()
        Me.dgvRecorrido = New System.Windows.Forms.DataGridView()
        Me.btnRecorrido = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        CType(Me.nudTope, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecorrido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recorrido de una Matriz"
        Me.Label1.UseWaitCursor = True
        '
        'nudTope
        '
        Me.nudTope.Location = New System.Drawing.Point(319, 157)
        Me.nudTope.Name = "nudTope"
        Me.nudTope.Size = New System.Drawing.Size(120, 20)
        Me.nudTope.TabIndex = 1
        Me.nudTope.UseWaitCursor = True
        '
        'dgvNumeros
        '
        Me.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNumeros.Location = New System.Drawing.Point(25, 228)
        Me.dgvNumeros.Name = "dgvNumeros"
        Me.dgvNumeros.Size = New System.Drawing.Size(374, 182)
        Me.dgvNumeros.TabIndex = 2
        Me.dgvNumeros.UseWaitCursor = True
        '
        'dgvRecorrido
        '
        Me.dgvRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecorrido.Location = New System.Drawing.Point(414, 228)
        Me.dgvRecorrido.Name = "dgvRecorrido"
        Me.dgvRecorrido.Size = New System.Drawing.Size(374, 182)
        Me.dgvRecorrido.TabIndex = 3
        Me.dgvRecorrido.UseWaitCursor = True
        '
        'btnRecorrido
        '
        Me.btnRecorrido.Location = New System.Drawing.Point(551, 194)
        Me.btnRecorrido.Name = "btnRecorrido"
        Me.btnRecorrido.Size = New System.Drawing.Size(75, 23)
        Me.btnRecorrido.TabIndex = 5
        Me.btnRecorrido.Text = "Recorrido"
        Me.btnRecorrido.UseVisualStyleBackColor = True
        Me.btnRecorrido.UseWaitCursor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(168, 194)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 6
        Me.btnGenerar.Text = "General"
        Me.btnGenerar.UseVisualStyleBackColor = True
        Me.btnGenerar.UseWaitCursor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnRecorrido)
        Me.Controls.Add(Me.dgvRecorrido)
        Me.Controls.Add(Me.dgvNumeros)
        Me.Controls.Add(Me.nudTope)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.UseWaitCursor = True
        CType(Me.nudTope, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecorrido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nudTope As NumericUpDown
    Friend WithEvents dgvNumeros As DataGridView
    Friend WithEvents dgvRecorrido As DataGridView
    Friend WithEvents btnRecorrido As Button
    Friend WithEvents btnGenerar As Button
End Class
