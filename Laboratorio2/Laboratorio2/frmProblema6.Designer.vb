<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProblema6
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
        Me.txtAlcalde1 = New System.Windows.Forms.TextBox()
        Me.txtAlcalde3 = New System.Windows.Forms.TextBox()
        Me.txtAlcalde2 = New System.Windows.Forms.TextBox()
        Me.txtAlcalde4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGanador = New System.Windows.Forms.TextBox()
        Me.txtMenor = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAlcalde1
        '
        Me.txtAlcalde1.Location = New System.Drawing.Point(39, 91)
        Me.txtAlcalde1.Name = "txtAlcalde1"
        Me.txtAlcalde1.Size = New System.Drawing.Size(100, 23)
        Me.txtAlcalde1.TabIndex = 0
        '
        'txtAlcalde3
        '
        Me.txtAlcalde3.Location = New System.Drawing.Point(427, 91)
        Me.txtAlcalde3.Name = "txtAlcalde3"
        Me.txtAlcalde3.Size = New System.Drawing.Size(100, 23)
        Me.txtAlcalde3.TabIndex = 1
        '
        'txtAlcalde2
        '
        Me.txtAlcalde2.Location = New System.Drawing.Point(220, 91)
        Me.txtAlcalde2.Name = "txtAlcalde2"
        Me.txtAlcalde2.Size = New System.Drawing.Size(100, 23)
        Me.txtAlcalde2.TabIndex = 2
        '
        'txtAlcalde4
        '
        Me.txtAlcalde4.Location = New System.Drawing.Point(610, 91)
        Me.txtAlcalde4.Name = "txtAlcalde4"
        Me.txtAlcalde4.Size = New System.Drawing.Size(100, 23)
        Me.txtAlcalde4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Votos de alcalde 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Votos de alcalde 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(426, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Votos de alcalde 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(610, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Votos de alcalde 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(316, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Alcaldia de cartagena"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Ganador"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(451, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Menor"
        '
        'txtGanador
        '
        Me.txtGanador.Location = New System.Drawing.Point(248, 183)
        Me.txtGanador.Name = "txtGanador"
        Me.txtGanador.Size = New System.Drawing.Size(100, 23)
        Me.txtGanador.TabIndex = 11
        '
        'txtMenor
        '
        Me.txtMenor.Location = New System.Drawing.Point(426, 183)
        Me.txtMenor.Name = "txtMenor"
        Me.txtMenor.Size = New System.Drawing.Size(100, 23)
        Me.txtMenor.TabIndex = 12
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(352, 253)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 13
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'frmProblema6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 318)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtMenor)
        Me.Controls.Add(Me.txtGanador)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAlcalde4)
        Me.Controls.Add(Me.txtAlcalde2)
        Me.Controls.Add(Me.txtAlcalde3)
        Me.Controls.Add(Me.txtAlcalde1)
        Me.Name = "frmProblema6"
        Me.Text = "frmProblema6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAlcalde1 As TextBox
    Friend WithEvents txtAlcalde3 As TextBox
    Friend WithEvents txtAlcalde2 As TextBox
    Friend WithEvents txtAlcalde4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtGanador As TextBox
    Friend WithEvents txtMenor As TextBox
    Friend WithEvents btnCalcular As Button
End Class
