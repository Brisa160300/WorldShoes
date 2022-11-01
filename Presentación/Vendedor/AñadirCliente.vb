﻿Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class AñadirCliente
    Dim objNcliente = New NCliente
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


    Private Sub BRegistrarCliente_Click(sender As Object, e As EventArgs) Handles BRegistrarCliente.Click
        ErrorProviderNombre.Clear()
        ErrorProviderApellido.Clear()
        ErrorProviderDNI.Clear()
        ErrorProviderDireccion.Clear()
        ErrorProviderEmail.Clear()
        ErrorProviderTelefono.Clear()


        If EspacioEnBlanco() = False Then
            Dim nombre As String = TBNombreCliente.Text
            Dim apellido As String = TBApellidoCliente.Text
            Dim dni As Integer = CInt(TBDniCliente.Text)
            Dim tel As ULong = CULng(TBTelCliente.Text)
            Dim direccion As String = TBDireccion.Text
            Dim email As String = TBCorreoCliente.Text
            MsgBox("Seguro que desea insertar un nuevo Cliente?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If vbYes Then

                If objNcliente.agregar_cliente(nombre, apellido, dni, tel, direccion, email) Then
                    MsgBox("El Cliente: " + apellido + " " + nombre + " se registró correctamente", vbOKOnly + MsgBoxStyle.Information, "Registro exitoso")
                    objNcliente.cargarGrid(DataGridViewRegistroClientes)
                    TBDniCliente.Clear()
                    TBNombreCliente.Clear()
                    TBApellidoCliente.Clear()
                    TBTelCliente.Clear()
                    TBDireccion.Clear()
                    TBCorreoCliente.Clear()
                Else
                    MsgBox("El cliente ya se encuentra registrado", vbOKOnly + MsgBoxStyle.Critical, "DNI duplicado")
                    TBDniCliente.Clear()
                    TBDniCliente.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub TBNombreCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCliente.KeyPress

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

    Private Sub BCancelar_Click(sender As Object, e As EventArgs)

        If EspacioEnBlanco() = False Then
            MsgBox("¿Realmente desea cancelar la operación de registro?", vbExclamation + vbYesNo + vbDefaultButton2, "Confirmar Eliminación")
            If vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TBApellidoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoCliente.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub AñadirCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNcliente.cargarGrid(DataGridViewRegistroClientes)
    End Sub

    Private Sub BCancelar_Click_1(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

End Class