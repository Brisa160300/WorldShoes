Public Class GestionarCategoria
    Dim objNCategoria = New NCategoria
    Private Sub BEditarCategoria_Click(sender As Object, e As EventArgs) Handles BEditarCategoria.Click
        If (dgvListarCategorias.SelectedRows.Count > 0) Or (dgvListarCategorias.SelectedCells.Count > 0) Then
            Dim frmEdit As New ModificarCategoria
            frmEdit.fila = dgvListarCategorias.CurrentRow.Cells(0).Value.ToString
            frmEdit.TBNombreCategoria.Text = dgvListarCategorias.CurrentRow.Cells(1).Value.ToString
            frmEdit.ShowInTaskbar = False
            frmEdit.ShowDialog()
            objNCategoria.cargarGrid(dgvListarCategorias)

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub TBGestionCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBGestionCategoria.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")

        End If
    End Sub
    Private Sub GestionarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNCategoria.cargarGrid(dgvListarCategorias)
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub BEliminarCategoria_Click(sender As Object, e As EventArgs) Handles BEliminarCategoria.Click
        If (dgvListarCategorias.SelectedRows.Count > 0) Or (dgvListarCategorias.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub
End Class