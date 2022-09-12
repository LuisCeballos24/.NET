<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProblema4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstResultado = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(138, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Programa para Determinar la fecha del Domingo de Pascua"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(138, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Teclee el Año:"
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(276, 187)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(100, 23)
        Me.txtAnio.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(333, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 44)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "btnEjecutar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstResultado
        '
        Me.lstResultado.FormattingEnabled = True
        Me.lstResultado.ItemHeight = 15
        Me.lstResultado.Location = New System.Drawing.Point(441, 187)
        Me.lstResultado.Name = "lstResultado"
        Me.lstResultado.Size = New System.Drawing.Size(329, 94)
        Me.lstResultado.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(441, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "La Fecha del Domingo de Pascua es:"
        '
        'frmProblema4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstResultado)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmProblema4"
        Me.Text = "s"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lstResultado As ListBox
    Friend WithEvents Label3 As Label
End Class
