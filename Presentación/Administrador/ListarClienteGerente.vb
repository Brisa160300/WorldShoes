Public Class ListarClienteGerente
    Dim objNcliente = New NCliente
    Dim objDcliente = New Dcliente
    Private Sub BEditarCliente_Click(sender As Object, e As EventArgs) Handles BEditarCliente.Click
        If (dgvListarClientes.SelectedRows.Count > 0) Or (dgvListarClientes.SelectedCells.Count > 0) Then
            Dim frm As New ModificarClienteGerente
            frm.fila = dgvListarClientes.CurrentRow.Cells(0).Value.ToString
            frm.TBNombreCliente.Text = dgvListarClientes.CurrentRow.Cells(1).Value.ToString
            frm.TBApellidoCliente.Text = dgvListarClientes.CurrentRow.Cells(2).Value.ToString
            frm.TBDniCliente.Text = dgvListarClientes.CurrentRow.Cells(3).Value
            frm.TBTelCliente.Text = dgvListarClientes.CurrentRow.Cells(4).Value
            frm.TBDireccion.Text = dgvListarClientes.CurrentRow.Cells(5).Value
            frm.TBCorreoCliente.Text = dgvListarClientes.CurrentRow.Cells(6).Value
            frm.ShowDialog()
            objNcliente.cargarGrid(dgvListarClientes)
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If

    End Sub

    Private Sub ListarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNcliente.cargarGrid(dgvListarClientes)
        objNcliente.cargarComboxDNI(CBBuscarDni)
    End Sub
    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub BEliminarClientes_Click(sender As Object, e As EventArgs) Handles BEliminarClientes.Click
        If (dgvListarClientes.SelectedRows.Count > 0) Or (dgvListarClientes.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If TBBuscar.Text.Trim = "" Then
            objNcliente.cargarGrid(dgvListarClientes)
        Else
            objDcliente.buscarClientes(TBBuscar.Text, dgvListarClientes)
            TBBuscar.Clear()
        End If
    End Sub

    Private Sub ComboBoxBuscarDni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscarDni.SelectedIndexChanged
        objDcliente.buscarClientes(CBBuscarDni.Text, dgvListarClientes)
    End Sub

    Private Sub GroupBoxClientes_Click(sender As Object, e As EventArgs) Handles GroupBoxClientes.Click
        CBBuscarDni.ResetText()
        CBBuscarDni.SelectedValue = -1
        objNcliente.cargarGrid(dgvListarClientes)
    End Sub

End Class
