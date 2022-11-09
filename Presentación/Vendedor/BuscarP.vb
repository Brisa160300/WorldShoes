Public Class BuscarP
    Private objNProductos = New NProducto
    Public result As Boolean = True
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Private Sub BSeleccionar_Click(sender As Object, e As EventArgs) Handles BSeleccionar.Click
        If dgvListaProductos.SelectedRows.Count() > 0 Or dgvListaProductos.SelectedCells.Count() > 0 Then
            result = False
            Me.Hide()
        End If

    End Sub

    Private Sub BuscarP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNProductos.cargarGrid(dgvListaProductos)
    End Sub

    Private Sub dgvListaProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaProductos.CellDoubleClick
        If dgvListaProductos.SelectedRows.Count() > 0 Or dgvListaProductos.SelectedCells.Count() > 0 Then
            result = True
        End If
    End Sub
End Class