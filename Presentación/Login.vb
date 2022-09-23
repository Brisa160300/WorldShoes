Public Class Login
    Private Sub TBUsuario_Keypress(sender As Object, e As KeyPressEventArgs) Handles TBUsuario.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        Dim usuario As String = TBUsuario.Text
        Dim contraseña As String = TBContraseña.Text
        If EspacioEnBlanco() = False Then
            If (usuario = "BRISA") And (contraseña = "123") Then
                'MenuVendedor.Show()
                MenuGerente.Show()
                Me.Hide()
            End If
        ElseIf (usuario = "GABRIEL") And (contraseña = "123") Then
            MenuGerente.Show()
            Me.Hide()



        End If

    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim usuario As String = TBUsuario.Text
        Dim contraseña As String = TBContraseña.Text


        If String.IsNullOrWhiteSpace(usuario) Or
           String.IsNullOrWhiteSpace(contraseña) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If
    End Function

    Private Sub TBUsuario_TextChanged(sender As Object, e As EventArgs) Handles TBUsuario.TextChanged
        TBUsuario.Text = UCase(TBUsuario.Text)
        TBUsuario.SelectionStart = Len(TBUsuario.Text)
    End Sub
End Class