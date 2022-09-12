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
        Me.btnProblema1 = New System.Windows.Forms.Button()
        Me.btnProblema6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProblema1
        '
        Me.btnProblema1.Location = New System.Drawing.Point(107, 138)
        Me.btnProblema1.Name = "btnProblema1"
        Me.btnProblema1.Size = New System.Drawing.Size(75, 23)
        Me.btnProblema1.TabIndex = 0
        Me.btnProblema1.Text = "Problema 1"
        Me.btnProblema1.UseVisualStyleBackColor = True
        '
        'btnProblema6
        '
        Me.btnProblema6.Location = New System.Drawing.Point(558, 252)
        Me.btnProblema6.Name = "btnProblema6"
        Me.btnProblema6.Size = New System.Drawing.Size(75, 23)
        Me.btnProblema6.TabIndex = 1
        Me.btnProblema6.Text = "Problema 6"
        Me.btnProblema6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnProblema6)
        Me.Controls.Add(Me.btnProblema1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProblema1 As Button
    Friend WithEvents btnProblema6 As Button
End Class
