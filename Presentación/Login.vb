Public Class Login
    Dim state As Integer
    Dim px, py As Integer
    Dim mover As Boolean
    Dim objDusuario = New DUsuario
    Private Sub TBUsuario_Keypress(sender As Object, e As KeyPressEventArgs) Handles TBUsuario.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        Dim usuario As String = TBUsuario.Text
        Dim pass As String = TBContraseña.Text
        If EspacioEnBlanco() = False Then
            'If objDusuario.VerifUser(usuario, pass) Then
            '    Dim user As Usuarios = objDusuario.getLoginUser(usuario, pass)
            '    MenuV.Show()
            '    Me.Hide()
            '    'Select Case user.id_Perfil
            '    '    Case = 1
            '    '        MenuV.Show()
            '    '        Me.Hide()
            '    '    Case = 2
            '    '        MenuGerente.Show()
            '    '        Me.Hide()
            '    '    Case = 3
            '    '        MenuG.Show()
            '    '        Me.Hide()
            '    '    Case = 4
            '    '        MenuA.Show()
            '    '        Me.Hide()
            '    '    Case Else
            '    '        MsgBox("Nombre de Usuario y/o Contraseña no validos", vbCritical, "Datos invalidos")
            '    '        TBUsuario.Clear()
            '    '        TBContraseña.Clear()
            '    '        TBUsuario.Focus()
            '    'End Select
            'End If

        End If


    End Sub


    Public Function EspacioEnBlanco() As Boolean
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
        'TBUsuario.Text = UCase(TBUsuario.Text)
        'TBUsuario.SelectionStart = Len(TBUsuario.Text)
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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBUsuario.Focus()
    End Sub

    Private Sub PanelBarraMenuLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarraMenuLogin.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub PanelBarraMenuLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelBarraMenuLogin.MouseUp
        mover = False
    End Sub

    Private Sub PanelBarraMenuLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraMenuLogin.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - px, MousePosition.Y - Me.Location.Y - py))

        End If
    End Sub

    Private Sub BCerrarMenu_Click(sender As Object, e As EventArgs) Handles BCerrarMenu.Click
        Application.Exit()
    End Sub

    Private Sub BMaximizarMenu_Click(sender As Object, e As EventArgs) Handles BMaximizarMenu.Click
        BMaximizarMenu.Visible = False
        BRestaurarMenu.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BRestaurarMenu_Click(sender As Object, e As EventArgs) Handles BRestaurarMenu.Click
        BRestaurarMenu.Visible = False
        BMaximizarMenu.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BMinimizarMenu_Click(sender As Object, e As EventArgs) Handles BMinimizarMenu.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class