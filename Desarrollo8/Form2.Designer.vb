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
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.rdbSimple = New System.Windows.Forms.RadioButton()
        Me.rdbSerie = New System.Windows.Forms.RadioButton()
        Me.rdbParalelo = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Elija una opcion en la que quiere el reultado"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(252, 293)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(124, 28)
        Me.btnEjecutar.TabIndex = 5
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'rdbSimple
        '
        Me.rdbSimple.AutoSize = True
        Me.rdbSimple.Location = New System.Drawing.Point(151, 134)
        Me.rdbSimple.Name = "rdbSimple"
        Me.rdbSimple.Size = New System.Drawing.Size(95, 17)
        Me.rdbSimple.TabIndex = 9
        Me.rdbSimple.TabStop = True
        Me.rdbSimple.Text = "Tuberia Simple"
        Me.rdbSimple.UseVisualStyleBackColor = True
        '
        'rdbSerie
        '
        Me.rdbSerie.AutoSize = True
        Me.rdbSerie.Location = New System.Drawing.Point(151, 168)
        Me.rdbSerie.Name = "rdbSerie"
        Me.rdbSerie.Size = New System.Drawing.Size(104, 17)
        Me.rdbSerie.TabIndex = 10
        Me.rdbSerie.TabStop = True
        Me.rdbSerie.Text = "Tuberia En Serie"
        Me.rdbSerie.UseVisualStyleBackColor = True
        '
        'rdbParalelo
        '
        Me.rdbParalelo.AutoSize = True
        Me.rdbParalelo.Location = New System.Drawing.Point(151, 202)
        Me.rdbParalelo.Name = "rdbParalelo"
        Me.rdbParalelo.Size = New System.Drawing.Size(117, 17)
        Me.rdbParalelo.TabIndex = 11
        Me.rdbParalelo.TabStop = True
        Me.rdbParalelo.Text = "Tuberia en Paralelo"
        Me.rdbParalelo.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 450)
        Me.Controls.Add(Me.rdbParalelo)
        Me.Controls.Add(Me.rdbSerie)
        Me.Controls.Add(Me.rdbSimple)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents rdbSimple As RadioButton
    Friend WithEvents rdbSerie As RadioButton
    Friend WithEvents rdbParalelo As RadioButton
End Class
