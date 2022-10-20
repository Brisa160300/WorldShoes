Public Class ModificarEmpleado

    Private objDempleado = New DEmpleado
    Public fila As Integer
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Private Sub BModEmpleado_Click(sender As Object, e As EventArgs) Handles BModEmpleados.Click
        Dim ask As MsgBoxResult
        If EspacioEnBlanco() = False Then
            ask = MsgBox("Seguro que desea modificar a este empleado", vbQuestion + vbYesNo, "Confirmar Modificación")
            If ask = vbYes Then
                If objDempleado.modempleado(fila, TBNombreEmpleado.Text, TBApellidoEmpleado.Text, CInt(TBDniEmpleado.Text), CLng(TBTelEmpleado.Text), TBDireccionEmpleado.Text, TBCorreoEmpleado.Text) Then
                    MsgBox("Se han modificado los datos con exito", vbInformation, "Confirmar Modificacion")
                    Me.Close()
                End If
            Else
                TBDniEmpleado.Focus()
            End If
        End If
    End Sub
    Private Sub TBNombreEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreEmpleado.KeyPress, TBApellidoEmpleado.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub TBDniEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelEmpleado.KeyPress, TBDniEmpleado.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim nombre As String = TBNombreEmpleado.Text
        Dim apellido As String = TBApellidoEmpleado.Text
        Dim dni As String = TBDniEmpleado.Text
        Dim tel As String = TBTelEmpleado.Text
        Dim correo As String = TBCorreoEmpleado.Text
        Dim domicilio As String = TBDireccionEmpleado.Text
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