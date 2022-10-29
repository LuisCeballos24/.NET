<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtParcial1 = New System.Windows.Forms.TextBox()
        Me.txtParcial2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLaboratorio1 = New System.Windows.Forms.TextBox()
        Me.txtLaboratorio2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSemestral = New System.Windows.Forms.TextBox()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.lblNotaLetra = New System.Windows.Forms.Label()
        Me.txtNotaLetra = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calcular Promedio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "parcial 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "parcial 2"
        '
        'txtParcial1
        '
        Me.txtParcial1.Location = New System.Drawing.Point(175, 124)
        Me.txtParcial1.Name = "txtParcial1"
        Me.txtParcial1.Size = New System.Drawing.Size(100, 20)
        Me.txtParcial1.TabIndex = 3
        '
        'txtParcial2
        '
        Me.txtParcial2.Location = New System.Drawing.Point(175, 176)
        Me.txtParcial2.Name = "txtParcial2"
        Me.txtParcial2.Size = New System.Drawing.Size(100, 20)
        Me.txtParcial2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Laboratorio 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(366, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Laboratorio 2"
        '
        'txtLaboratorio1
        '
        Me.txtLaboratorio1.Location = New System.Drawing.Point(441, 129)
        Me.txtLaboratorio1.Name = "txtLaboratorio1"
        Me.txtLaboratorio1.Size = New System.Drawing.Size(100, 20)
        Me.txtLaboratorio1.TabIndex = 7
        '
        'txtLaboratorio2
        '
        Me.txtLaboratorio2.Location = New System.Drawing.Point(441, 183)
        Me.txtLaboratorio2.Name = "txtLaboratorio2"
        Me.txtLaboratorio2.Size = New System.Drawing.Size(100, 20)
        Me.txtLaboratorio2.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(121, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Semestral"
        '
        'txtSemestral
        '
        Me.txtSemestral.Location = New System.Drawing.Point(180, 232)
        Me.txtSemestral.Name = "txtSemestral"
        Me.txtSemestral.Size = New System.Drawing.Size(100, 20)
        Me.txtSemestral.TabIndex = 10
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Location = New System.Drawing.Point(121, 289)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(30, 13)
        Me.lblNota.TabIndex = 11
        Me.lblNota.Text = "Nota"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(175, 286)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.ReadOnly = True
        Me.txtNota.Size = New System.Drawing.Size(100, 20)
        Me.txtNota.TabIndex = 12
        '
        'lblNotaLetra
        '
        Me.lblNotaLetra.AutoSize = True
        Me.lblNotaLetra.Location = New System.Drawing.Point(121, 339)
        Me.lblNotaLetra.Name = "lblNotaLetra"
        Me.lblNotaLetra.Size = New System.Drawing.Size(57, 13)
        Me.lblNotaLetra.TabIndex = 13
        Me.lblNotaLetra.Text = "Nota Letra"
        '
        'txtNotaLetra
        '
        Me.txtNotaLetra.Location = New System.Drawing.Point(184, 336)
        Me.txtNotaLetra.Name = "txtNotaLetra"
        Me.txtNotaLetra.ReadOnly = True
        Me.txtNotaLetra.Size = New System.Drawing.Size(100, 20)
        Me.txtNotaLetra.TabIndex = 14
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(349, 378)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(117, 29)
        Me.btnCalcular.TabIndex = 15
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtNotaLetra)
        Me.Controls.Add(Me.lblNotaLetra)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.txtSemestral)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLaboratorio2)
        Me.Controls.Add(Me.txtLaboratorio1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtParcial2)
        Me.Controls.Add(Me.txtParcial1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Notas Estudiante"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtParcial1 As TextBox
    Friend WithEvents txtParcial2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLaboratorio1 As TextBox
    Friend WithEvents txtLaboratorio2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSemestral As TextBox
    Friend WithEvents lblNota As Label
    Friend WithEvents txtNota As TextBox
    Friend WithEvents lblNotaLetra As Label
    Friend WithEvents txtNotaLetra As TextBox
    Friend WithEvents btnCalcular As Button
End Class
