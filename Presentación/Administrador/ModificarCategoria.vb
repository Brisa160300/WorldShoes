﻿Public Class ModificarCategoria

    Private objDcateg = New DCategoria
    Public fila As Integer
    Private Sub BCancelarModifCategoria_Click(sender As Object, e As EventArgs) Handles BCancelarModifCategoria.Click
        Me.Close()
    End Sub

    Private Sub TBNombreCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCategoria.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub BModificarCategoria_Click(sender As Object, e As EventArgs) Handles BModificarCategoria.Click
        Dim ask As MsgBoxResult
        ErrorProviderNomCateg.Clear()
        If EspacioEnBlanco() = False Then
            ask = MsgBox("Seguro que desea realizar esta modificación", vbQuestion + vbYesNo, "Confirmar Modificación")
            If ask = vbYes Then

                If objDcateg.ModCateg(fila, TBNombreCategoria.Text) Then
                    MsgBox("Se han modificado los datos con exito", vbInformation, "Confirmar Modificacion")
                    Me.Close()
                End If
            Else
                TBNombreCategoria.Focus()
            End If
        End If
    End Sub

    Public Function EspacioEnBlanco()
        Dim Ask As Boolean = False
        Dim descripcion As String = TBNombreCategoria.Text.Trim

        If descripcion = "" Then
            ErrorProviderNomCateg.SetError(TBNombreCategoria, "Ingrese un nombre de categoria")
            Ask = True
        ElseIf descripcion.Length < 3 Then
            ErrorProviderNomCateg.SetError(TBNombreCategoria, "El nombre de categoria debe tener minimo 3 caracteres")
            Ask = True
            Return Ask
        End If
        Return Ask
    End Function

End Class