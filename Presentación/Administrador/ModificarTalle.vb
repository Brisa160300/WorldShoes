Public Class ModificarTalle
    Private objDTalle = New DTalle
    Public fila As Integer
    Private Sub BCancelarModifTalle_Click(sender As Object, e As EventArgs) Handles BCancelarModifTalle.Click
        Me.Close()
    End Sub
    Private Sub TBModTalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBModTalle.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub BModificarTalle_Click(sender As Object, e As EventArgs) Handles BModificarTalle.Click
        Dim ask As MsgBoxResult
        If EspacioEnBlanco() = False Then
            ask = MsgBox("Seguro que desea realizar esta modificación", vbQuestion + vbYesNo, "Confirmar Modificación")
            If ask = vbYes Then

                If objDTalle.ModMarca(fila, TBModTalle.Text) Then
                    MsgBox("Se han modificado los datos con exito", vbInformation, "Confirmar Modificacion")
                    Me.Close()
                End If
            Else
                TBModTalle.Focus()
            End If
        End If
    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim descripcion As String = TBModTalle.Text

        If String.IsNullOrWhiteSpace(descripcion) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If
    End Function
End Class