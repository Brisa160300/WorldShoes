Public Class ModificarTalle
    Private Sub BCancelarModifCliente_Click(sender As Object, e As EventArgs) Handles BCancelarModifCliente.Click
        Me.Close()
    End Sub
    Private Sub TBModTalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBModTalle.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub
End Class