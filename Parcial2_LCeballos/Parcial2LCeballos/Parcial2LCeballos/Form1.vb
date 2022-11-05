Public Class Form1
    Private Sub PresentaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentaciónToolStripMenuItem.Click
        Presentacion.MdiParent = Me
        Presentacion.WindowState = FormWindowState.Maximized
        Presentacion.Show()
        NotaSemestral.Close()
        Prom3.Close()
    End Sub

    Private Sub Problema1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema1ToolStripMenuItem.Click
        NotaSemestral.MdiParent = Me
        NotaSemestral.WindowState = FormWindowState.Maximized
        NotaSemestral.Show()
        Prom3.Close()
        Presentacion.Close()
    End Sub
    Private Sub Problema2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem.Click
        Cifrado.MdiParent = Me
        Cifrado.WindowState = FormWindowState.Maximized
        Cifrado.Show()
        NotaSemestral.Close()
        Prom3.Close()
    End Sub

    Private Sub Problema3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema3ToolStripMenuItem.Click
        Prom3.MdiParent = Me
        Prom3.WindowState = FormWindowState.Maximized
        Prom3.Show()
        NotaSemestral.Close()
        Presentacion.Close()
    End Sub
End Class
