Public Class GestionarUsuarios
    Private objNUsuarios As NUsuario = New NUsuario
    Private objDUsuarios As DUsuario = New DUsuario

    Private Sub BModificarUsuario_Click(sender As Object, e As EventArgs) Handles BModificarUsuario.Click
        If (dgvListaUsuarios.SelectedRows.Count > 0) Or (dgvListaUsuarios.SelectedCells.Count > 0) Then
            Dim frm As New ModificarUsuario
            frm.fila = CInt(dgvListaUsuarios.CurrentRow.Cells(6).Value.ToString)
            frm.perfildesc = dgvListaUsuarios.CurrentRow.Cells(4).Value.ToString
            frm.TBNombreUsuario.Text = dgvListaUsuarios.CurrentRow.Cells(2).Value.ToString
            frm.TBContraseñaUsuario.Text = dgvListaUsuarios.CurrentRow.Cells(3).Value.ToString
            frm.TBConfirmarPass.Text = dgvListaUsuarios.CurrentRow.Cells(3).Value.ToString
            frm.ShowInTaskbar = False
            frm.ShowDialog()
            objNUsuarios.cargarGrid(dgvListaUsuarios)
        Else
            MsgBox("Por favor, seleccione una fila...")
        End If

    End Sub

    Private Sub BEliminarUsuario_Click(sender As Object, e As EventArgs) Handles BEliminarUsuario.Click
        If (dgvListaUsuarios.SelectedRows.Count > 0) Or (dgvListaUsuarios.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar a este usuario?", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDUsuarios.EliminarUsuario(CInt(dgvListaUsuarios.CurrentRow.Cells(6).Value.ToString))
                objNUsuarios.cargarGrid(dgvListaUsuarios)
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub
    Private Sub BAltaUsuario_Click(sender As Object, e As EventArgs) Handles BAltaUsuario.Click
        If (dgvListaUsuarios.SelectedRows.Count > 0) Or (dgvListaUsuarios.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea dar de alta a este usuario?", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDUsuarios.AltaUsuario(CInt(dgvListaUsuarios.CurrentRow.Cells(6).Value.ToString))
                objNUsuarios.cargarGrid(dgvListaUsuarios)
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub GestionarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNUsuarios.cargarGrid(dgvListaUsuarios)
    End Sub

    Private Sub BBuscarUsuario_Click(sender As Object, e As EventArgs) Handles BBuscarUsuario.Click
        objDUsuarios.buscarUsuarios(TBGestionUsuario.Text, dgvListaUsuarios)
    End Sub

    Private Sub dgvListaUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaUsuarios.CellClick
        Dim fil As Integer = dgvListaUsuarios.CurrentRow.Index
        If dgvListaUsuarios.Rows(fil).Cells(5).Value = "Activo" Then
            BEliminarUsuario.Visible = True
            BAltaUsuario.Visible = False
        Else
            BEliminarUsuario.Visible = False
            BAltaUsuario.Visible = True
        End If
    End Sub
End Class