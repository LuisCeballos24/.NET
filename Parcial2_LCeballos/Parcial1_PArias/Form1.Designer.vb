﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PresentaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Problema1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Problema2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Problema3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PresentaciónToolStripMenuItem, Me.Problema1ToolStripMenuItem, Me.Problema2ToolStripMenuItem, Me.Problema3ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1121, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PresentaciónToolStripMenuItem
        '
        Me.PresentaciónToolStripMenuItem.Name = "PresentaciónToolStripMenuItem"
        Me.PresentaciónToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.PresentaciónToolStripMenuItem.Text = "Presentación"
        '
        'Problema1ToolStripMenuItem
        '
        Me.Problema1ToolStripMenuItem.Name = "Problema1ToolStripMenuItem"
        Me.Problema1ToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.Problema1ToolStripMenuItem.Text = "Problema 1"
        '
        'Problema2ToolStripMenuItem
        '
        Me.Problema2ToolStripMenuItem.Name = "Problema2ToolStripMenuItem"
        Me.Problema2ToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.Problema2ToolStripMenuItem.Text = "Problema 2"
        '
        'Problema3ToolStripMenuItem
        '
        Me.Problema3ToolStripMenuItem.Name = "Problema3ToolStripMenuItem"
        Me.Problema3ToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.Problema3ToolStripMenuItem.Text = "Problema 3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 509)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PresentaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema3ToolStripMenuItem As ToolStripMenuItem
End Class
