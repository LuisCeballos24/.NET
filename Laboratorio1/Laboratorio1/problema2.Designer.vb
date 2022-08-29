<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class problema2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEdadMama = New System.Windows.Forms.TextBox()
        Me.txtEdadAna = New System.Windows.Forms.TextBox()
        Me.txtEdadAlberto = New System.Windows.Forms.TextBox()
        Me.txtEdadJuan = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(68, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mamá de Elba Gisela"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(68, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 41)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ana"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(68, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 41)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alberto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(68, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 41)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Juan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(538, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edad"
        '
        'txtEdadMama
        '
        Me.txtEdadMama.Enabled = False
        Me.txtEdadMama.Location = New System.Drawing.Point(507, 86)
        Me.txtEdadMama.Name = "txtEdadMama"
        Me.txtEdadMama.Size = New System.Drawing.Size(125, 27)
        Me.txtEdadMama.TabIndex = 5
        '
        'txtEdadAna
        '
        Me.txtEdadAna.Enabled = False
        Me.txtEdadAna.Location = New System.Drawing.Point(507, 398)
        Me.txtEdadAna.Name = "txtEdadAna"
        Me.txtEdadAna.Size = New System.Drawing.Size(125, 27)
        Me.txtEdadAna.TabIndex = 6
        '
        'txtEdadAlberto
        '
        Me.txtEdadAlberto.Enabled = False
        Me.txtEdadAlberto.Location = New System.Drawing.Point(507, 298)
        Me.txtEdadAlberto.Name = "txtEdadAlberto"
        Me.txtEdadAlberto.Size = New System.Drawing.Size(125, 27)
        Me.txtEdadAlberto.TabIndex = 7
        '
        'txtEdadJuan
        '
        Me.txtEdadJuan.Enabled = False
        Me.txtEdadJuan.Location = New System.Drawing.Point(507, 191)
        Me.txtEdadJuan.Name = "txtEdadJuan"
        Me.txtEdadJuan.Size = New System.Drawing.Size(125, 27)
        Me.txtEdadJuan.TabIndex = 8
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(257, 470)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(184, 29)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular edad"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 542)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtEdadJuan)
        Me.Controls.Add(Me.txtEdadAlberto)
        Me.Controls.Add(Me.txtEdadAna)
        Me.Controls.Add(Me.txtEdadMama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEdadMama As TextBox
    Friend WithEvents txtEdadAna As TextBox
    Friend WithEvents txtEdadAlberto As TextBox
    Friend WithEvents txtEdadJuan As TextBox
    Friend WithEvents btnCalcular As Button
End Class
