
Public Class BuscarCli
    Public result As Boolean = True
    Private objNcliente = New NCliente
    Dim objDcliente = New Dcliente
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
        objNcliente.cargarComboxDNI(CBBuscar)
    End Sub

    Private Sub dgvListarCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarCliente.CellDoubleClick
        If dgvListarCliente.SelectedRows.Count() > 0 Or dgvListarCliente.SelectedCells.Count() > 0 Then
            result = False
            Me.Hide()
        End If
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If TBBuscar.Text.Trim = "" Then
            objNcliente.cargarGrid(dgvListarCliente)
        Else
            objDcliente.buscarClientes(TBBuscar.Text, dgvListarCliente)
            TBBuscar.Clear()
        End If
    End Sub

    Private Sub ComboBoxBuscarDni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscar.SelectedIndexChanged
        objDcliente.buscarClientes(CBBuscar.Text, dgvListarCliente)
    End Sub

    Private Sub CBBuscarDni_MouseDown(sender As Object, e As MouseEventArgs) Handles CBBuscar.MouseDown
        objDcliente.buscarClientes(CBBuscar.Text, dgvListarCliente)
    End Sub

    Private Sub GroupBoxClientes_Click(sender As Object, e As EventArgs) Handles GroupBoxClientes.Click
        CBBuscar.ResetText()
        CBBuscar.SelectedValue = -1
        objNcliente.cargarGrid(dgvListarCliente)
    End Sub
End Class