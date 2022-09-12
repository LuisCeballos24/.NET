Public Class FormRestaurante

    Dim objRestaurante As New Restaurante
    Private Sub FormRestaurante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lasCarnes(6) As String
        cboMinestras.Items.Add("Poroto:1.15")
        cboMinestras.Items.Add("Frijoles:0.90")
        cboMinestras.Items.Add("Arvejas:0.95")
        cboMinestras.Items.Add("Garbanzo:0.95")
        lasCarnes(0) = "Carne de RES:1.55"
        lasCarnes(1) = "Carne de Venado:3.50"
        lasCarnes(2) = "Pollo:1.15"
        lasCarnes(3) = "Pavo:2.50"
        lasCarnes(4) = "Pescado:2.35"
        lasCarnes(5) = "Camarones:3.50"
        cboCarnes.DataSource = lasCarnes
    End Sub
    Private Sub cboArroces_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArroces.SelectedIndexChanged
        objRestaurante.asignar(cboArroces.Text)
        txtCuenta.Text = Val(txtCuenta.Text) + objRestaurante.extraerPrecio()
        lstMenu.Items.Add(cboArroces.Text)
    End Sub

    Private Sub cboMinestras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMinestras.SelectedIndexChanged
        objRestaurante.asignar(cboMinestras.Text)
        txtCuenta.Text = Val(txtCuenta.Text) + objRestaurante.extraerPrecio()
        lstMenu.Items.Add(cboMinestras.Text)
    End Sub

    Private Sub cboCarnes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCarnes.SelectedIndexChanged
        objRestaurante.asignar(cboCarnes.Text)
        txtCuenta.Text = Val(txtCuenta.Text) + objRestaurante.extraerPrecio()
        lstMenu.Items.Add(cboCarnes.Text)
    End Sub
End Class