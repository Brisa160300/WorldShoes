
Public Class BuscarCli
    Public result As Boolean = True
    Private objNcliente = New NCliente
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Private Sub BSeleccionar_Click(sender As Object, e As EventArgs) Handles BSeleccionar.Click
        If dgvListarCliente.SelectedRows.Count() > 0 Or dgvListarCliente.SelectedCells.Count() > 0 Then
            result = False
            Me.Hide()
        End If
    End Sub

    Private Sub BuscarCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNcliente.cargarGrid(dgvListarCliente)
    End Sub

    Private Sub dgvListarCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarCliente.CellDoubleClick
        If dgvListarCliente.SelectedRows.Count() > 0 Or dgvListarCliente.SelectedCells.Count() > 0 Then
            result = False
            Me.Hide()
        End If
    End Sub

End Class