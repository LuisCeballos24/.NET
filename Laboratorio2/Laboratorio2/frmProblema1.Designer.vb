<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProblema1
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
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnAgregarVenta = New System.Windows.Forms.Button()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuantas1000 = New System.Windows.Forms.TextBox()
        Me.txtCuanto1000 = New System.Windows.Forms.TextBox()
        Me.txtCuantasBetween = New System.Windows.Forms.TextBox()
        Me.txtCuantoBetween = New System.Windows.Forms.TextBox()
        Me.txtCuantasMenor500 = New System.Windows.Forms.TextBox()
        Me.txtCuantoMenor500 = New System.Windows.Forms.TextBox()
        Me.txtTotalVentas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(117, 438)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(200, 23)
        Me.btnTotal.TabIndex = 0
        Me.btnTotal.Text = "Calcular total y cantidad"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnAgregarVenta
        '
        Me.btnAgregarVenta.Location = New System.Drawing.Point(233, 55)
        Me.btnAgregarVenta.Name = "btnAgregarVenta"
        Me.btnAgregarVenta.Size = New System.Drawing.Size(112, 23)
        Me.btnAgregarVenta.TabIndex = 1
        Me.btnAgregarVenta.Text = "Agregar venta"
        Me.btnAgregarVenta.UseVisualStyleBackColor = True
        '
        'txtVenta
        '
        Me.txtVenta.Location = New System.Drawing.Point(101, 55)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(100, 23)
        Me.txtVenta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mayores a 1000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Menores a 1000 y Mayores a 500"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Menores a 500"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total ventas"
        '
        'txtCuantas1000
        '
        Me.txtCuantas1000.Enabled = False
        Me.txtCuantas1000.Location = New System.Drawing.Point(101, 133)
        Me.txtCuantas1000.Name = "txtCuantas1000"
        Me.txtCuantas1000.Size = New System.Drawing.Size(100, 23)
        Me.txtCuantas1000.TabIndex = 9
        '
        'txtCuanto1000
        '
        Me.txtCuanto1000.Enabled = False
        Me.txtCuanto1000.Location = New System.Drawing.Point(233, 133)
        Me.txtCuanto1000.Name = "txtCuanto1000"
        Me.txtCuanto1000.Size = New System.Drawing.Size(100, 23)
        Me.txtCuanto1000.TabIndex = 10
        '
        'txtCuantasBetween
        '
        Me.txtCuantasBetween.Enabled = False
        Me.txtCuantasBetween.Location = New System.Drawing.Point(101, 212)
        Me.txtCuantasBetween.Name = "txtCuantasBetween"
        Me.txtCuantasBetween.Size = New System.Drawing.Size(100, 23)
        Me.txtCuantasBetween.TabIndex = 11
        '
        'txtCuantoBetween
        '
        Me.txtCuantoBetween.Enabled = False
        Me.txtCuantoBetween.Location = New System.Drawing.Point(233, 212)
        Me.txtCuantoBetween.Name = "txtCuantoBetween"
        Me.txtCuantoBetween.Size = New System.Drawing.Size(100, 23)
        Me.txtCuantoBetween.TabIndex = 12
        '
        'txtCuantasMenor500
        '
        Me.txtCuantasMenor500.Enabled = False
        Me.txtCuantasMenor500.Location = New System.Drawing.Point(101, 296)
        Me.txtCuantasMenor500.Name = "txtCuantasMenor500"
        Me.txtCuantasMenor500.Size = New System.Drawing.Size(100, 23)
        Me.txtCuantasMenor500.TabIndex = 13
        '
        'txtCuantoMenor500
        '
        Me.txtCuantoMenor500.Enabled = False
        Me.txtCuantoMenor500.Location = New System.Drawing.Point(233, 296)
        Me.txtCuantoMenor500.Name = "txtCuantoMenor500"
        Me.txtCuantoMenor500.Size = New System.Drawing.Size(100, 23)
        Me.txtCuantoMenor500.TabIndex = 14
        '
        'txtTotalVentas
        '
        Me.txtTotalVentas.Enabled = False
        Me.txtTotalVentas.Location = New System.Drawing.Point(172, 370)
        Me.txtTotalVentas.Name = "txtTotalVentas"
        Me.txtTotalVentas.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalVentas.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Cuantas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(261, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Cuanto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(271, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Cuanto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(127, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cuantas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(271, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Cuanto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(127, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Cuantas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(117, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 15)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Ingrese venta"
        '
        'frmProblema1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 507)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalVentas)
        Me.Controls.Add(Me.txtCuantoMenor500)
        Me.Controls.Add(Me.txtCuantasMenor500)
        Me.Controls.Add(Me.txtCuantoBetween)
        Me.Controls.Add(Me.txtCuantasBetween)
        Me.Controls.Add(Me.txtCuanto1000)
        Me.Controls.Add(Me.txtCuantas1000)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVenta)
        Me.Controls.Add(Me.btnAgregarVenta)
        Me.Controls.Add(Me.btnTotal)
        Me.Name = "frmProblema1"
        Me.Text = "frmProblema1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTotal As Button
    Friend WithEvents btnAgregarVenta As Button
    Friend WithEvents txtVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCuantas1000 As TextBox
    Friend WithEvents txtCuanto1000 As TextBox
    Friend WithEvents txtCuantasBetween As TextBox
    Friend WithEvents txtCuantoBetween As TextBox
    Friend WithEvents txtCuantasMenor500 As TextBox
    Friend WithEvents txtCuantoMenor500 As TextBox
    Friend WithEvents txtTotalVentas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
