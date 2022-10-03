Public Class GestionarProductos
    Private Sub BModificarProducto_Click(sender As Object, e As EventArgs) Handles BModificarProducto.Click
        Dim frm As New ModificarProducto
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Private Sub TBGestionProductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBGestionProductos.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub
End Class