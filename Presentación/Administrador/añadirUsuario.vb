Public Class añadirUsuario

    Private Sub TBNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreUsuario.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")

        End If
    End Sub

    Private Sub TBContraseñaUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBContraseñaUsuario.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub
End Class