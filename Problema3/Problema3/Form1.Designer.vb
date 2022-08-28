<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lsbImpresiones = New System.Windows.Forms.ListBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(126, 36)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(250, 25)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Estadisticas Automovilisticas"
        '
        'lsbImpresiones
        '
        Me.lsbImpresiones.FormattingEnabled = True
        Me.lsbImpresiones.ItemHeight = 15
        Me.lsbImpresiones.Location = New System.Drawing.Point(12, 126)
        Me.lsbImpresiones.Name = "lsbImpresiones"
        Me.lsbImpresiones.Size = New System.Drawing.Size(476, 154)
        Me.lsbImpresiones.TabIndex = 3
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(223, 314)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 4
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 380)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.lsbImpresiones)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lsbImpresiones As ListBox
    Friend WithEvents btnIniciar As Button
End Class
