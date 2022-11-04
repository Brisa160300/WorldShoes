Public Class ListaVendedores
    Dim objNusuario = New NUsuario
    Dim objDusuario = New DUsuario

    Private Sub ListaVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNusuario.cargarGrid(DataGridViewListaVentas)
    End Sub

    Private Sub BBuscarVendedor_Click(sender As Object, e As EventArgs) Handles BBuscarVendedor.Click
        objDusuario.buscarVendedores(TBBuscarVendedor.Text, DataGridViewListaVentas)
    End Sub

    Private Sub TBBuscarVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBBuscarVendedor.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub



End Class