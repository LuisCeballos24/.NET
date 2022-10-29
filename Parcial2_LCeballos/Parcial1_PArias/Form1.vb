Public Class Form1
    Private Sub PresentaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentaciónToolStripMenuItem.Click
        Presentacion.MdiParent = Me
        Presentacion.WindowState = FormWindowState.Maximized
        Presentacion.Show()
        Prom1.Close()
        Prom2.Close()
        Prom3.Close()
    End Sub

    Private Sub Problema1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema1ToolStripMenuItem.Click
        Prom1.MdiParent = Me
        Prom1.WindowState = FormWindowState.Maximized
        Prom1.Show()
        Prom2.Close()
        Prom3.Close()
        Presentacion.Close()
    End Sub
    Private Sub Problema2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem.Click
        Prom2.MdiParent = Me
        Prom2.WindowState = FormWindowState.Maximized
        Prom2.Show()
        Prom1.Close()
        Prom3.Close()
        Presentacion.Close()
    End Sub

    Private Sub Problema3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema3ToolStripMenuItem.Click
        Prom3.MdiParent = Me
        Prom3.WindowState = FormWindowState.Maximized
        Prom3.Show()
        Prom1.Close()
        Prom2.Close()
        Presentacion.Close()
    End Sub
End Class
