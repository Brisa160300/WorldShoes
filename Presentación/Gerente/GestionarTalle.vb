Public Class GestionarTalle
    Private Sub BModificarTalle_Click(sender As Object, e As EventArgs) Handles BModificarTalle.Click
        Dim frm As New ModificarTalle
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub
    Private Sub TBBuscarTalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBBuscarTalle.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub
End Class