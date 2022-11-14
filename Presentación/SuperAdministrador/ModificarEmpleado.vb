Imports System.Text.RegularExpressions

Public Class ModificarEmpleado

    Private objDempleado = New DEmpleado
    Public fila As Integer
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Private Sub BModEmpleado_Click(sender As Object, e As EventArgs) Handles BModEmpleados.Click
        Dim ask As MsgBoxResult
        ErrorProviderNombre.Clear()
        ErrorProviderApellido.Clear()
        ErrorProviderDNI.Clear()
        ErrorProviderDireccion.Clear()
        ErrorProviderEmail.Clear()
        ErrorProviderTelefono.Clear()
        If EspacioEnBlanco() = False Then
            Dim nombre As String = TBNombreEmpleado.Text
            Dim apellido As String = TBApellidoEmpleado.Text
            Dim dni As Integer = CInt(TBDniEmpleado.Text)
            Dim tel As Long = CLng(TBTelEmpleado.Text)
            Dim correo As String = TBCorreoEmpleado.Text
            Dim direccion As String = TBDireccionEmpleado.Text
            ask = MsgBox("Seguro que desea modificar a este empleado", vbQuestion + vbYesNo, "Confirmar Modificación")
            If ask = vbYes Then
                If objDempleado.modempleado(fila, nombre, apellido, dni, tel, direccion, correo) Then
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
        Dim Ask As Boolean = False
        Dim nombre As String = TBNombreEmpleado.Text
        Dim apellido As String = TBApellidoEmpleado.Text
        Dim dni As String = TBDniEmpleado.Text
        Dim tel As String = TBTelEmpleado.Text
        Dim correo As String = TBCorreoEmpleado.Text
        Dim direccion As String = TBDireccionEmpleado.Text

        If nombre = "" Then
            ErrorProviderNombre.SetError(TBNombreEmpleado, "Ingrese un Nombre")
            Ask = True
        ElseIf nombre.Length < 3 Then
            ErrorProviderNombre.SetError(TBNombreEmpleado, "El nombre ingresado debe tener un minimo de 3 caracteres")
            Ask = True
        End If
        If apellido = "" Then
            ErrorProviderApellido.SetError(TBApellidoEmpleado, "Ingrese un Apellido")
            Ask = True
        ElseIf apellido.Length < 3 Then
            ErrorProviderApellido.SetError(TBApellidoEmpleado, "El apellido debe tener un minimo de 3 caracteres")
            Ask = True
        End If
        If dni = "" Then
            ErrorProviderDNI.SetError(TBDniEmpleado, "Ingrese un DNI")
            Ask = True
        ElseIf dni.Length <> 8 Then
            ErrorProviderDNI.SetError(TBDniEmpleado, "La extensión del DNI ingresado no es valida")
            Ask = True
        End If
        If tel = "" Then
            ErrorProviderTelefono.SetError(TBTelEmpleado, "Ingrese un telefono de contacto")
            Ask = True
        End If
        If direccion = "" Then
            ErrorProviderDireccion.SetError(TBDireccionEmpleado, "Ingrese una direccion")
            Ask = True
        End If
        If correo = "" Then
            ErrorProviderEmail.SetError(TBCorreoEmpleado, "Ingrese un correo electronico")
            Ask = True
        ElseIf isValidEmail(correo) = False Then
            ErrorProviderEmail.SetError(TBCorreoEmpleado, "El correo ingresado no es valido")
            Ask = True
        End If
        Return Ask
    End Function

    Function isValidEmail(ByVal email As String) As Boolean
        Dim re As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If re.IsMatch(email) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class