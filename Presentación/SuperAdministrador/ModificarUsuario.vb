
Public Class ModificarUsuario
    Private objNUsuarios As NUsuario = New NUsuario
    Private objDUsuarios As DUsuario = New DUsuario
    Public fila As Integer
    Public perfildesc As String
    Public Function EspacioEnBlanco() As Boolean
        Dim Ask As Boolean = False
        Dim nombre As String = TBNombreUsuario.Text.Trim
        Dim pass As String = TBContraseñaUsuario.Text.Trim
        Dim confpass As String = TBConfirmarPass.Text.Trim
        Dim perfil As String = CBPerfil.SelectedValue
        If nombre = "" Then
            ErrorProviderNombre.SetError(TBNombreUsuario, "Ingrese un nombre de usuario")
            Ask = True
        ElseIf nombre.Length < 3 Then
            ErrorProviderNombre.SetError(TBNombreUsuario, "El nombre ingresado debe tener un minimo de 3 caracteres")
            Ask = True
        End If
        If pass = "" Then
            ErrorProviderPass.SetError(TBContraseñaUsuario, "Ingrese una contraseña")
            Ask = True
        ElseIf pass <> confpass Then
            ErrorProviderPass.SetError(TBContraseñaUsuario, "Las contraseñas no coinciden")
            ErrorProviderConfPass.SetError(TBConfirmarPass, "Las contraseñas no coinciden")
            Ask = True
        ElseIf pass.Length <> 8 Then
            ErrorProviderPass.SetError(TBContraseñaUsuario, "La contraseña debe debe tener 8 digitos")
            Ask = True
        End If
        If perfil = "" Then
            ErrorProviderPerfil.SetError(CBPerfil, "Seleccione un perfil")
            Ask = True
        End If
        Return Ask
    End Function

    Private Sub TBNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreUsuario.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")

        End If
    End Sub

    Private Sub BModificarUsuario_Click(sender As Object, e As EventArgs) Handles BModificarUsuario.Click
        Dim ask As MsgBoxResult

        ErrorProviderNombre.Clear()
        ErrorProviderEmpleado.Clear()
        ErrorProviderPass.Clear()
        ErrorProviderConfPass.Clear()
        ErrorProviderPerfil.Clear()
        If EspacioEnBlanco() = False Then
            ask = MsgBox("Seguro que desea modificar este usuario", vbQuestion + vbYesNo, "Confirmar Modificación")
            If ask = vbYes Then

                If objDUsuarios.ModUsuario(fila, TBNombreUsuario.Text, TBContraseñaUsuario.Text, CInt(CBPerfil.SelectedValue)) Then
                    MsgBox("Se han modificado los datos con exito", vbInformation, "Confirmar Modificacion")
                    Me.Close()
                End If
            Else
                TBNombreUsuario.Focus()
            End If
        End If
    End Sub

    Private Sub BCancelarModifCliente_Click(sender As Object, e As EventArgs) Handles BCancelarModifCliente.Click
        Me.Close()
    End Sub

    Private Sub ModificarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNUsuarios.cargarComboxPerfiles2(CBPerfil, perfildesc)
    End Sub

End Class