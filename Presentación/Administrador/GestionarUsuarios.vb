﻿Public Class GestionarUsuarios
    Private Sub BModificarUsuario_Click(sender As Object, e As EventArgs) Handles BModificarUsuario.Click
        Dim frm As New ModificarUsuario
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Private Sub BEliminarUsuario_Click(sender As Object, e As EventArgs) Handles BEliminarUsuario.Click
        If (dgvListaUsuarios.SelectedRows.Count > 0) Or (dgvListaUsuarios.SelectedCells.Count > 0) Then
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub
End Class