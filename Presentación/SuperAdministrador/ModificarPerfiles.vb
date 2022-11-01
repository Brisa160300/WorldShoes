Public Class ModificarPerfiles
    Private objDPerfil = New DPerfil
    Public fila As Integer
    Private Sub BCancelarModifCliente_Click(sender As Object, e As EventArgs) Handles BCancelarModifCliente.Click
        Me.Close()
    End Sub

    Private Sub BModificarPerfil_Click(sender As Object, e As EventArgs) Handles BModificarPerfil.Click
        ErrorProviderNomPerf.Clear()
        Dim ask As MsgBoxResult
        If EspacioEnBlanco() = False Then
            ask = MsgBox("Seguro que desea realizar esta modificación", vbQuestion + vbYesNo, "Confirmar Modificación")
            If ask = vbYes Then
                If objDPerfil.modPerfil(fila, TBModPerfil.Text) Then
                    MsgBox("Se han modificado los datos con exito", vbInformation, "Confirmar Modificacion")
                    Me.Close()
                End If
            Else
                TBModPerfil.Focus()
            End If
        End If
    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As Boolean = False
        Dim descripcion As String = TBModPerfil.Text.Trim
        If descripcion = "" Then
            ErrorProviderNomPerf.SetError(TBModPerfil, "Ingrese un nombre de perfil")
            Ask = True
        ElseIf descripcion.Length < 3 Then
            ErrorProviderNomPerf.SetError(TBModPerfil, "El perfil ingresado debe tener minimo 3 caracteres")
        End If

        Return Ask
    End Function

    Private Sub TBModPerfil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBModPerfil.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub
End Class