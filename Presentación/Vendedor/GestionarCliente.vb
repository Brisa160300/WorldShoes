Public Class GestionarCliente
    Private Sub BModificarCliente_Click(sender As Object, e As EventArgs) Handles BModificarCliente.Click
        Dim frm As New ModificarCliente
        frm.TBNombreCliente.Text = dgvRegistroClientes.CurrentRow.Cells(0).Value.ToString
        frm.TBApellidoCliente.Text = dgvRegistroClientes.CurrentRow.Cells(1).Value.ToString
        frm.TBDniCliente.Text = dgvRegistroClientes.CurrentRow.Cells(2).Value
        frm.TBTelCliente.Text = dgvRegistroClientes.CurrentRow.Cells(3).Value
        frm.TBDireccion.Text = dgvRegistroClientes.CurrentRow.Cells(4).Value
        frm.TBCorreoCliente.Text = dgvRegistroClientes.CurrentRow.Cells(5).Value
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Private Sub GestionarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class