Imports System.Text.RegularExpressions

Public Class ModificarClienteGerente
    Private objDcliente = New Dcliente
    Public fila As Integer
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Private Sub BModCliente_Click(sender As Object, e As EventArgs) Handles BModCliente.Click
        Dim ask As MsgBoxResult
        ErrorProviderNombre.Clear()
        ErrorProviderApellido.Clear()
        ErrorProviderDNI.Clear()
        ErrorProviderDireccion.Clear()
        ErrorProviderEmail.Clear()
        ErrorProviderTelefono.Clear()
        If EspacioEnBlanco() = False Then
            ask = MsgBox("Seguro que desea modificar a este cliente", vbQuestion + vbYesNo, "Confirmar Modificación")
            If ask = vbYes Then
                If objDcliente.modcliente(fila, TBNombreCliente.Text, TBApellidoCliente.Text, CInt(TBDniCliente.Text), CULng(TBTelCliente.Text), TBDireccion.Text, TBCorreoCliente.Text) Then
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

    Public Function EspacioEnBlanco() As Boolean
        Dim Ask As Boolean = False
        Dim nombre As String = TBNombreCliente.Text.Trim
        Dim apellido As String = TBApellidoCliente.Text.Trim
        Dim dni As String = TBDniCliente.Text.Trim
        Dim tel As String = TBTelCliente.Text.Trim
        Dim correo As String = TBCorreoCliente.Text.Trim
        Dim direccion As String = TBDireccion.Text.Trim

        If nombre = "" Then
            ErrorProviderNombre.SetError(TBNombreCliente, "Ingrese un Nombre")
            Ask = True
        ElseIf nombre.Length < 3 Then
            ErrorProviderNombre.SetError(TBNombreCliente, "El nombre debe tener un minimo de 3 caracteres")
            Ask = True
        End If
        If apellido = "" Then
            ErrorProviderApellido.SetError(TBApellidoCliente, "Ingrese un Apellido")
            Ask = True
        ElseIf apellido.Length < 3 Then
            ErrorProviderApellido.SetError(TBApellidoCliente, "El apellido debe tener un minimo de 3 caracteres")
            Ask = True
        End If
        If dni = "" Then
            ErrorProviderDNI.SetError(TBDniCliente, "Ingrese un DNI")
            Ask = True
        ElseIf dni.Length <> 8 Then
            ErrorProviderDNI.SetError(TBDniCliente, "La extensión del DNI ingresado no es valida")
            Ask = True
        End If
        If tel = "" Then
            ErrorProviderTelefono.SetError(TBTelCliente, "Ingrese un telefono de contacto")
            Ask = True
        End If
        If direccion = "" Then
            ErrorProviderDireccion.SetError(TBDireccion, "Ingrese una direccion")
            Ask = True
        End If
        If correo = "" Then
            ErrorProviderEmail.SetError(TBCorreoCliente, "Ingrese un correo electronico")
            Ask = True
        ElseIf isValidEmail(correo) = False Then
            ErrorProviderEmail.SetError(TBCorreoCliente, "El correo ingresado no es valido")
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