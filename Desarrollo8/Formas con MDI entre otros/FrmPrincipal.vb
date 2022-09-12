Public Class mnustrPrincipal
    Private Sub RecorridoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecorridoToolStripMenuItem.Click
        FrmRecorrido.MdiParent = Me
        FrmRecorrido.WindowState = FormWindowState.Maximized
        FrmRecorrido.Show()

    End Sub

    Private Sub RadioButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RadioButtonToolStripMenuItem.Click
        FrmOperaciones.MdiParent = Me
        FrmOperaciones.WindowState = FormWindowState.Maximized
        FrmOperaciones.Show()

    End Sub

    Private Sub ComboBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComboBoxToolStripMenuItem.Click
        FormRestaurante.MdiParent = Me
        FormRestaurante.WindowState = FormWindowState.Maximized
        FormRestaurante.Show()
    End Sub
End Class