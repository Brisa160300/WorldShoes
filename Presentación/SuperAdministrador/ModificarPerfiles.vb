Public Class ModificarPerfiles
    Private objDPerfil = New DPerfil
    Public fila As Integer
    Private Sub BCancelarModifCliente_Click(sender As Object, e As EventArgs) Handles BCancelarModifCliente.Click
        Me.Close()
    End Sub

    Private Sub BModificarPerfil_Click(sender As Object, e As EventArgs) Handles BModificarPerfil.Click

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
        Dim Ask As MsgBoxResult
        Dim descripcion As String = TBModPerfil.Text

        If String.IsNullOrWhiteSpace(descripcion) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If

    End Function

    Private Sub TBModPerfil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBModPerfil.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub
End Class