﻿Public Class añadirUsuario

    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim Ask1 As MsgBoxResult
        Dim nombre As String = TBNombreUsuario.Text
        Dim pass As String = TBContraseñaUsuario.Text
        If String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(pass) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return True
        Else
            If Not TBContraseñaUsuario.Text.Count = 7 Then
                Ask1 = MsgBox("La contraseña debe ser de 8 caracteres", vbExclamation, "Contraseña invalida")
                TBContraseñaUsuario.Focus()
                Return True
                Return False
            End If
        End If
    End Function

    Private Sub TBNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreUsuario.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")

        End If
    End Sub

    Private Sub TBContraseñaUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBContraseñaUsuario.KeyPress
        If Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            If TBContraseñaUsuario.Text.Count > 7 Then
                e.Handled = True
                MsgBox("La contraseña solo puede tener 8 digitios")
            End If
        End If

    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TBNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles TBNombreUsuario.TextChanged
    End Sub

    Private Sub BRegistrarCliente_Click(sender As Object, e As EventArgs) Handles BRegistrarCliente.Click
        If EspacioEnBlanco() = False Then
            MsgBox("Registrado con exito", vbInformation)
        End If

    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub
End Class