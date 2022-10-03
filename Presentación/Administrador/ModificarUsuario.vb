Public Class ModificarUsuario
    Private Sub PanelModClientes_Paint(sender As Object, e As PaintEventArgs) Handles PanelModUsuarios.Paint

    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim contraseña As String = TBContraseñaUsuario.Text
        Dim nombre As String = TBNombreUsuario.Text
        Dim perfil As String = TBPerfilUsuario.Text


        If String.IsNullOrWhiteSpace(contraseña) Or
           String.IsNullOrWhiteSpace(nombre) Or
           String.IsNullOrWhiteSpace(perfil) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If
    End Function

    Private Sub TBNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreUsuario.KeyPress, TBPerfilUsuario.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")

        End If
    End Sub

    Private Sub BModificarCliente_Click(sender As Object, e As EventArgs) Handles BModificarCliente.Click
        If EspacioEnBlanco() = False Then
            MsgBox("Seguro que desea modificar este usuario", vbQuestion + vbYesNo, "Confirmar Modificación")
        End If
    End Sub
End Class