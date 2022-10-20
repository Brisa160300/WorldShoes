Public Class ListarMarcas
    Private objNMarca = New NMarca
    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub ListarMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNMarca.cargarGrid(dgvListaMarca)
        dgvListaMarca.ClearSelection()
    End Sub

    Private Sub BEditarMarca_Click(sender As Object, e As EventArgs) Handles BEditarMarca.Click
        If (dgvListaMarca.SelectedRows.Count > 0) Or (dgvListaMarca.SelectedCells.Count > 0) Then
            Dim frmEdit As New ModificarMarca
            frmEdit.fila = dgvListaMarca.CurrentRow.Cells(0).Value.ToString
            frmEdit.TBModMarca.Text = dgvListaMarca.CurrentRow.Cells(1).Value.ToString
            frmEdit.ShowInTaskbar = False
            frmEdit.ShowDialog()
            objNMarca.cargarGrid(dgvListaMarca)

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub BEliminarMarca_Click(sender As Object, e As EventArgs) Handles BEliminarMarca.Click
        If (dgvListaMarca.SelectedRows.Count > 0) Or (dgvListaMarca.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub
End Class