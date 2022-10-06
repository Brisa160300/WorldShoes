Public Class GestionarProductos
    Private Sub BModificarProducto_Click(sender As Object, e As EventArgs) Handles BModificarProducto.Click

        If (dgvListaProductos.SelectedRows.Count > 0) Or (dgvListaProductos.SelectedCells.Count > 0) Then
            Dim frmEdit As New ModificarProducto
            frmEdit.TBNombreProducto.Text = dgvListaProductos.CurrentRow.Cells(1).Value.ToString
            frmEdit.CBCategoriaProducto.Text = dgvListaProductos.CurrentRow.Cells(2).Value.ToString
            frmEdit.TBStockProducto.Text = dgvListaProductos.CurrentRow.Cells(3).Value.ToString
            frmEdit.CBMarcaProducto.Text = dgvListaProductos.CurrentRow.Cells(4).Value.ToString
            frmEdit.ShowInTaskbar = False
            frmEdit.ShowDialog()

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If

    End Sub

    Private Sub TBGestionProductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBGestionProductos.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub BEliminarProducto_Click(sender As Object, e As EventArgs) Handles BEliminarProducto.Click
        If (dgvListaProductos.SelectedRows.Count > 0) Or (dgvListaProductos.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub
End Class



