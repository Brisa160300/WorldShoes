Public Class GestionarPerfiles
    Private objNPerfil = New NPerfil
    Private objDperfil = New DPerfil
    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub GestionarPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNPerfil.cargarGrid(dgvListaPerfiles)
    End Sub

    Private Sub BModificarPerfiles_Click(sender As Object, e As EventArgs) Handles BModificarPerfiles.Click
        If (dgvListaPerfiles.SelectedRows.Count > 0) Or (dgvListaPerfiles.SelectedCells.Count > 0) Then
            Dim frm As New ModificarPerfiles
            frm.fila = dgvListaPerfiles.CurrentRow.Cells(0).Value.ToString
            frm.TBModPerfil.Text = dgvListaPerfiles.CurrentRow.Cells(1).Value.ToString
            frm.ShowInTaskbar = False
            frm.ShowDialog()
            objNPerfil.cargarGrid(dgvListaPerfiles)
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If

    End Sub

    Private Sub BEliminarPerfiles_Click(sender As Object, e As EventArgs) Handles BEliminarPerfiles.Click
        If (dgvListaPerfiles.SelectedRows.Count > 0) Or (dgvListaPerfiles.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDperfil.EliminarPerfil(CInt(dgvListaPerfiles.CurrentRow.Cells(0).Value.ToString))
                objNPerfil.cargarGrid(dgvListaPerfiles)
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If

    End Sub

    Private Sub BAltaPerfil_Click(sender As Object, e As EventArgs) Handles BAltaPerfil.Click
        If (dgvListaPerfiles.SelectedRows.Count > 0) Or (dgvListaPerfiles.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDperfil.AltaPerfil(CInt(dgvListaPerfiles.CurrentRow.Cells(0).Value.ToString))
                objNPerfil.cargarGrid(dgvListaPerfiles)
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub BBuscarPerfil_Click(sender As Object, e As EventArgs) Handles BBuscarPerfil.Click
        objDperfil.buscarPerfil(TBGestionPerfil.Text, dgvListaPerfiles)
    End Sub
End Class