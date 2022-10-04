Public Class ListarClientes
    Dim objNcliente = New NCliente
    Private Sub BEditarCliente_Click(sender As Object, e As EventArgs) Handles BEditarCliente.Click
        If (dgvListarClientes.SelectedRows.Count > 0) Or (dgvListarClientes.SelectedCells.Count > 0) Then
            Dim frm As New ModificarCliente
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
    End Sub

    Private Sub TBBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBBuscar.TextChanged
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
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
End Class