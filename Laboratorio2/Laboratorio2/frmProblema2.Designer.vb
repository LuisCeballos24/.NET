<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProblema2
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lstTemp3 = New System.Windows.Forms.ListBox()
        Me.lstTemp2 = New System.Windows.Forms.ListBox()
        Me.lstTemp1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(661, 135)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(107, 32)
        Me.btnLimpiar.TabIndex = 28
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lstTemp3
        '
        Me.lstTemp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTemp3.FormattingEnabled = True
        Me.lstTemp3.ItemHeight = 25
        Me.lstTemp3.Location = New System.Drawing.Point(545, 245)
        Me.lstTemp3.Name = "lstTemp3"
        Me.lstTemp3.Size = New System.Drawing.Size(223, 179)
        Me.lstTemp3.TabIndex = 27
        '
        'lstTemp2
        '
        Me.lstTemp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTemp2.FormattingEnabled = True
        Me.lstTemp2.ItemHeight = 25
        Me.lstTemp2.Location = New System.Drawing.Point(293, 245)
        Me.lstTemp2.Name = "lstTemp2"
        Me.lstTemp2.Size = New System.Drawing.Size(223, 179)
        Me.lstTemp2.TabIndex = 26
        '
        'lstTemp1
        '
        Me.lstTemp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTemp1.FormattingEnabled = True
        Me.lstTemp1.ItemHeight = 25
        Me.lstTemp1.Location = New System.Drawing.Point(32, 245)
        Me.lstTemp1.Name = "lstTemp1"
        Me.lstTemp1.Size = New System.Drawing.Size(223, 179)
        Me.lstTemp1.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(335, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Mayor a 37°C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(590, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Menor a 33°C"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Temperaturas"
        '
        'btnReg
        '
        Me.btnReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.Location = New System.Drawing.Point(325, 130)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(157, 39)
        Me.btnReg.TabIndex = 21
        Me.btnReg.Text = "Registrar"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'txtTemp
        '
        Me.txtTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp.Location = New System.Drawing.Point(430, 84)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(100, 30)
        Me.txtTemp.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Temperatura:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 32)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Registros De Temperatura"
        '
        'Problema4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lstTemp3)
        Me.Controls.Add(Me.lstTemp2)
        Me.Controls.Add(Me.lstTemp1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Problema4"
        Me.Text = "Problema 4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lstTemp3 As ListBox
    Friend WithEvents lstTemp2 As ListBox
    Friend WithEvents lstTemp1 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReg As Button
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
