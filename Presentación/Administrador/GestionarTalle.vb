Public Class GestionarTalle
    Private objNTalle As NTalle = New NTalle
    Private objDtalle As DTalle = New DTalle
    Private Sub BModificarTalle_Click(sender As Object, e As EventArgs) Handles BModificarTalle.Click
        If (dgvRegTalles.SelectedRows.Count > 0) Or (dgvRegTalles.SelectedCells.Count > 0) Then
            Dim frm As New ModificarTalle
            frm.fila = dgvRegTalles.CurrentRow.Cells(0).Value.ToString
            frm.TBModTalle.Text = dgvRegTalles.CurrentRow.Cells(1).Value.ToString
            frm.ShowInTaskbar = False
            frm.ShowDialog()
            objNTalle.cargarGrid(dgvRegTalles)

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If

    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub GestionarTalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNTalle.cargarGrid(dgvRegTalles)
    End Sub

    Private Sub BEliminarTalle_Click(sender As Object, e As EventArgs) Handles BEliminarTalle.Click
        If (dgvRegTalles.SelectedRows.Count > 0) Or (dgvRegTalles.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro que desea eliminar este talle", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDtalle.EliminarTalle(CInt(dgvRegTalles.CurrentRow.Cells(0).Value.ToString))
                objNTalle.cargarGrid(dgvRegTalles)
                BEliminarTalle.Visible = False
                BAltaTalle.Visible = True
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If

    End Sub

    Private Sub BAltaTalle_Click(sender As Object, e As EventArgs) Handles BAltaTalle.Click
        If (dgvRegTalles.SelectedRows.Count > 0) Or (dgvRegTalles.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea dar de alta este registro", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDtalle.Altatalle(CInt(dgvRegTalles.CurrentRow.Cells(0).Value.ToString))
                objNTalle.cargarGrid(dgvRegTalles)
                BEliminarTalle.Visible = True
                BAltaTalle.Visible = False
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub dgvRegTalles_Click(sender As Object, e As EventArgs) Handles dgvRegTalles.Click
        Dim fil As Integer = dgvRegTalles.CurrentRow.Index
        Dim codigo As Integer = dgvRegTalles.Rows(fil).Cells(2).Value
        If codigo = 1 Then
            BEliminarTalle.Visible = True
            BAltaTalle.Visible = False
        Else
            BEliminarTalle.Visible = False
            BAltaTalle.Visible = True
        End If
    End Sub

End Class