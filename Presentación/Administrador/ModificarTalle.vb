Public Class ModificarTalle
    Private objDTalle = New DTalle
    Public fila As Integer
    Private Sub BCancelarModifTalle_Click(sender As Object, e As EventArgs) Handles BCancelarModifTalle.Click
        Me.Close()
    End Sub
    Private Sub TBModTalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBModTalle.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub

    Private Sub BModificarTalle_Click(sender As Object, e As EventArgs) Handles BModificarTalle.Click
        Dim ask As MsgBoxResult
        ErrorProviderTalle.Clear()
        If EspacioEnBlanco() = False Then
            ask = MsgBox("Seguro que desea realizar esta modificación", vbQuestion + vbYesNo, "Confirmar Modificación")
            If ask = vbYes Then

                If objDTalle.modTalle(fila, TBModTalle.Text) Then
                    MsgBox("Se han modificado los datos con exito", vbInformation, "Confirmar Modificacion")
                    Me.Close()
                End If
            Else
                TBModTalle.Focus()
            End If
        End If
    End Sub

    Public Function EspacioEnBlanco() As Boolean
        Dim ask As Boolean = False
        Dim tal As String = TBModTalle.Text.Trim
        If tal = "" Then
            ErrorProviderTalle.SetError(TBModTalle, "Ingrese un Talle")
            ask = True
        ElseIf tal.Length < 2 Then
            ErrorProviderTalle.SetError(TBModTalle, "El talle ingresado no es valido")
        End If
        Return ask
    End Function


End Class