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
            ElseIf (usuario = "GABRIEL") And (contraseña = "123") Then
                MenuVendedor.Show()
            End If
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

    Private Sub IconMinimizarLogin_Click(sender As Object, e As EventArgs) Handles IconMinimizarLogin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconCerrarLogin_Click(sender As Object, e As EventArgs) Handles IconCerrarLogin.Click
        Application.Exit()
    End Sub

    Private Sub IconMaximizar_Click(sender As Object, e As EventArgs) Handles IconMaximizar.Click
        IconMaximizar.Visible = False
        IconRestaurarWin.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub IconRestaurarWin_Click(sender As Object, e As EventArgs) Handles IconRestaurarWin.Click
        IconRestaurarWin.Visible = False
        IconMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PictureBoxContraseña_Click(sender As Object, e As EventArgs) Handles PictureBoxContraseña.Click
        If Not PictureBoxContraseña.Tag = "cerrado" Then
            PictureBoxContraseña.Tag = "cerrado"
            TBContraseña.PasswordChar = "*"
            PictureBoxContraseña.BackgroundImage = My.Resources.ojo_cerrado

        Else
            PictureBoxContraseña.Tag = "abierto"
            TBContraseña.PasswordChar = ""
            PictureBoxContraseña.BackgroundImage = My.Resources.ojo_abierto
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs)
        TBUsuario.Focus()
    End Sub
End Class