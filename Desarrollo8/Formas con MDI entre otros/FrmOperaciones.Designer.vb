<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOperaciones
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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbSuma = New System.Windows.Forms.RadioButton()
        Me.rbResta = New System.Windows.Forms.RadioButton()
        Me.rbMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.rbDivision = New System.Windows.Forms.RadioButton()
        Me.btnResolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese los valores y seleccione la operacion "
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(104, 166)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 1
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(332, 166)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 2
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(560, 166)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.ReadOnly = True
        Me.txtRes.Size = New System.Drawing.Size(100, 20)
        Me.txtRes.TabIndex = 3
        '
        'lblOperacion
        '
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacion.Location = New System.Drawing.Point(246, 169)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(16, 18)
        Me.lblOperacion.TabIndex = 4
        Me.lblOperacion.Text = "?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(483, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "="
        '
        'rbSuma
        '
        Me.rbSuma.AutoSize = True
        Me.rbSuma.Location = New System.Drawing.Point(104, 226)
        Me.rbSuma.Name = "rbSuma"
        Me.rbSuma.Size = New System.Drawing.Size(52, 17)
        Me.rbSuma.TabIndex = 6
        Me.rbSuma.TabStop = True
        Me.rbSuma.Text = "Suma"
        Me.rbSuma.UseVisualStyleBackColor = True
        '
        'rbResta
        '
        Me.rbResta.AutoSize = True
        Me.rbResta.Location = New System.Drawing.Point(104, 249)
        Me.rbResta.Name = "rbResta"
        Me.rbResta.Size = New System.Drawing.Size(53, 17)
        Me.rbResta.TabIndex = 7
        Me.rbResta.TabStop = True
        Me.rbResta.Text = "Resta"
        Me.rbResta.UseVisualStyleBackColor = True
        '
        'rbMultiplicacion
        '
        Me.rbMultiplicacion.AutoSize = True
        Me.rbMultiplicacion.Location = New System.Drawing.Point(104, 272)
        Me.rbMultiplicacion.Name = "rbMultiplicacion"
        Me.rbMultiplicacion.Size = New System.Drawing.Size(89, 17)
        Me.rbMultiplicacion.TabIndex = 8
        Me.rbMultiplicacion.TabStop = True
        Me.rbMultiplicacion.Text = "Multiplicacion"
        Me.rbMultiplicacion.UseVisualStyleBackColor = True
        '
        'rbDivision
        '
        Me.rbDivision.AutoSize = True
        Me.rbDivision.Location = New System.Drawing.Point(104, 295)
        Me.rbDivision.Name = "rbDivision"
        Me.rbDivision.Size = New System.Drawing.Size(62, 17)
        Me.rbDivision.TabIndex = 9
        Me.rbDivision.TabStop = True
        Me.rbDivision.Text = "Division"
        Me.rbDivision.UseVisualStyleBackColor = True
        '
        'btnResolver
        '
        Me.btnResolver.Location = New System.Drawing.Point(560, 272)
        Me.btnResolver.Name = "btnResolver"
        Me.btnResolver.Size = New System.Drawing.Size(75, 23)
        Me.btnResolver.TabIndex = 10
        Me.btnResolver.Text = "Resolver"
        Me.btnResolver.UseVisualStyleBackColor = True
        '
        'FrmOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnResolver)
        Me.Controls.Add(Me.rbDivision)
        Me.Controls.Add(Me.rbMultiplicacion)
        Me.Controls.Add(Me.rbResta)
        Me.Controls.Add(Me.rbSuma)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblOperacion)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmOperaciones"
        Me.Text = "FrmOperaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtRes As TextBox
    Friend WithEvents lblOperacion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rbSuma As RadioButton
    Friend WithEvents rbResta As RadioButton
    Friend WithEvents rbMultiplicacion As RadioButton
    Friend WithEvents rbDivision As RadioButton
    Friend WithEvents btnResolver As Button
End Class
