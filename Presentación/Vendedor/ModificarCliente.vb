Public Class ModificarCliente
    Private objDcliente = New Dcliente
    Public fila As Integer
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Private Sub BModCliente_Click(sender As Object, e As EventArgs) Handles BModCliente.Click
        Dim ask As MsgBoxResult
        If EspacioEnBlanco() = False Then
            ask = MsgBox("Seguro que desea modificar a este cliente", vbQuestion + vbYesNo, "Confirmar Modificación")
            If ask = vbYes Then
                If objDcliente.modcliente(fila, TBNombreCliente.Text, TBApellidoCliente.Text, CInt(TBDniCliente.Text), CInt(TBTelCliente.Text), TBDireccion.Text, TBCorreoCliente.Text) Then
                    MsgBox("Se han modificado los datos con exito", vbInformation, "Confirmar Modificacion")
                    Me.Close()
                End If
            Else
                TBDniCliente.Focus()
            End If
        End If
    End Sub
    Private Sub TBNombreCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCliente.KeyPress, TBApellidoCliente.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub TBDniCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelCliente.KeyPress, TBDniCliente.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim nombre As String = TBNombreCliente.Text
        Dim apellido As String = TBApellidoCliente.Text
        Dim dni As String = TBDniCliente.Text
        Dim tel As String = TBTelCliente.Text
        Dim correo As String = TBCorreoCliente.Text
        Dim domicilio As String = TBDireccion.Text
        If String.IsNullOrWhiteSpace(apellido) Or
           String.IsNullOrWhiteSpace(nombre) Or
           String.IsNullOrWhiteSpace(dni) Or
           String.IsNullOrWhiteSpace(tel) Or
           String.IsNullOrWhiteSpace(correo) Or
           String.IsNullOrWhiteSpace(domicilio) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If
    End Function

End Class