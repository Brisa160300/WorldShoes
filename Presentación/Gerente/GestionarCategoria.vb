Public Class GestionarCategoria
    Dim objNCategoria = New NCategoria
    Private Sub BEditarCategoria_Click(sender As Object, e As EventArgs) Handles BEditarCategoria.Click
        If (dgvListarCategorias.SelectedRows.Count > 0) Or (dgvListarCategorias.SelectedCells.Count > 0) Then
            Dim frmEdit As New ModificarCategoria
            frmEdit.TBNombreCategoria.Text = dgvListarCategorias.CurrentRow.Cells(1).Value.ToString
            frmEdit.ShowInTaskbar = False
            frmEdit.ShowDialog()

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub GestionarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNCategoria.cargarGrid(dgvListarCategorias)
    End Sub
End Class