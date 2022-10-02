Public Class ListarClientes
    Dim objNcliente = New NCliente
    Private Sub BEditarCliente_Click(sender As Object, e As EventArgs) Handles BEditarCliente.Click
        If (dgvListarClientes.SelectedRows.Count > 0) Or (dgvListarClientes.SelectedCells.Count > 0) Then
            Dim frm As New ModificarCliente
            frm.TBNombreCliente.Text = dgvListarClientes.CurrentRow.Cells(1).Value.ToString
            frm.TBApellidoCliente.Text = dgvListarClientes.CurrentRow.Cells(2).Value.ToString
            frm.TBDniCliente.Text = dgvListarClientes.CurrentRow.Cells(3).Value
            frm.TBTelCliente.Text = dgvListarClientes.CurrentRow.Cells(4).Value
            frm.TBDireccion.Text = dgvListarClientes.CurrentRow.Cells(5).Value
            frm.TBCorreoCliente.Text = dgvListarClientes.CurrentRow.Cells(6).Value
            frm.ShowDialog()

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If

    End Sub

    Private Sub ListarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNcliente.cargarGrid(dgvListarClientes)
    End Sub
End Class