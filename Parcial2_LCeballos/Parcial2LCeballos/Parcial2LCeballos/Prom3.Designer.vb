<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prom3
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
        Me.dgvInfo = New System.Windows.Forms.DataGridView()
        Me.btnAñadirP = New System.Windows.Forms.Button()
        Me.btnPesaje = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.dgvInfo1 = New System.Windows.Forms.DataGridView()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(317, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Concurso ""Pierde Tu Peso"""
        '
        'dgvInfo
        '
        Me.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfo.Location = New System.Drawing.Point(12, 254)
        Me.dgvInfo.Name = "dgvInfo"
        Me.dgvInfo.RowHeadersWidth = 51
        Me.dgvInfo.RowTemplate.Height = 24
        Me.dgvInfo.Size = New System.Drawing.Size(458, 211)
        Me.dgvInfo.TabIndex = 9
        '
        'btnAñadirP
        '
        Me.btnAñadirP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAñadirP.Location = New System.Drawing.Point(398, 71)
        Me.btnAñadirP.Name = "btnAñadirP"
        Me.btnAñadirP.Size = New System.Drawing.Size(147, 64)
        Me.btnAñadirP.TabIndex = 12
        Me.btnAñadirP.Text = "Añadir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Participante"
        Me.btnAñadirP.UseVisualStyleBackColor = True
        '
        'btnPesaje
        '
        Me.btnPesaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPesaje.Location = New System.Drawing.Point(759, 68)
        Me.btnPesaje.Name = "btnPesaje"
        Me.btnPesaje.Size = New System.Drawing.Size(145, 33)
        Me.btnPesaje.TabIndex = 25
        Me.btnPesaje.Text = "Añadir Pesaje"
        Me.btnPesaje.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(35, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 40)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Cantidad De" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Parcitipante:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.txtCantidad.Location = New System.Drawing.Point(146, 73)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(88, 26)
        Me.txtCantidad.TabIndex = 27
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEnviar.Location = New System.Drawing.Point(66, 115)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(145, 33)
        Me.btnEnviar.TabIndex = 28
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'dgvInfo1
        '
        Me.dgvInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfo1.Location = New System.Drawing.Point(476, 254)
        Me.dgvInfo1.Name = "dgvInfo1"
        Me.dgvInfo1.RowHeadersWidth = 51
        Me.dgvInfo1.RowTemplate.Height = 24
        Me.dgvInfo1.Size = New System.Drawing.Size(483, 211)
        Me.dgvInfo1.TabIndex = 31
        '
        'Prom3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 477)
        Me.Controls.Add(Me.dgvInfo1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnPesaje)
        Me.Controls.Add(Me.btnAñadirP)
        Me.Controls.Add(Me.dgvInfo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Prom3"
        Me.Text = "Prom3"
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvInfo As DataGridView
    Friend WithEvents btnAñadirP As Button
    Friend WithEvents btnPesaje As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents dgvInfo1 As DataGridView
End Class
