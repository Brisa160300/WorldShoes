Public Class GestionarProductos
    Private Sub BModificarProducto_Click(sender As Object, e As EventArgs) Handles BModificarProducto.Click
        Dim frm As New ModificarProducto
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub
End Class