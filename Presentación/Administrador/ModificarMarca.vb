Public Class ModificarMarca
    Private objDmarca = New DMarca
    Public fila As Integer
    Private Sub BModificarMarca_Click(sender As Object, e As EventArgs) Handles BModificarMarca.Click
        Dim ask As MsgBoxResult
        If EspacioEnBlanco() = False Then
            ask = MsgBox("Seguro que desea realizar esta modificación", vbQuestion + vbYesNo, "Confirmar Modificación")
            If ask = vbYes Then

                If objDmarca.ModMarca(fila, TBModMarca.Text) Then
                    MsgBox("Se han modificado los datos con exito", vbInformation, "Confirmar Modificacion")
                    Me.Close()
                End If
            Else
                TBModMarca.Focus()
            End If
        End If
    End Sub

    Private Sub BCancelarModifCliente_Click(sender As Object, e As EventArgs) Handles BCancelarModifCliente.Click
        Me.Close()
    End Sub

    Private Sub TBModMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBModMarca.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim descripcion As String = TBModMarca.Text

        If String.IsNullOrWhiteSpace(descripcion) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If
    End Function
End Class