Public Class BuscarP
    Private objNProductos = New NProducto
    Dim objDProducto = New DProducto
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
        objNProductos.cargarComboxCateg(CBCatProducto) 'combo As ComboBox, marca As String'
        objNProductos.cargarComboxMarca(CBMarcas)
        objNProductos.cargarGrid(dgvListaProductos)
    End Sub

    Private Sub dgvListaProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaProductos.CellDoubleClick
        If dgvListaProductos.SelectedRows.Count() > 0 Or dgvListaProductos.SelectedCells.Count() > 0 Then
            result = True
        End If
    End Sub

    Private Sub BBuscarProducto_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        If TBBuscar.Text = "" Then
            objNProductos.cargarGrid(dgvListaProductos)
        Else
            objDProducto.buscarProductos(TBBuscar.Text, dgvListaProductos)
            TBBuscar.Clear()
        End If
        'objDProducto.buscarProductos(CBCatProducto.Text, CBMarcas.Text, DataGridViewListaProductos)

    End Sub

    Private Sub CBCatProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCatProducto.SelectedIndexChanged
        objDProducto.buscarProductos(CBCatProducto.Text, dgvListaProductos)
    End Sub

    Private Sub GroupBoxProductos_click(sender As Object, e As EventArgs) Handles GroupBoxProductos.Click
        CBCatProducto.ResetText()
        CBCatProducto.SelectedValue = -1
        CBMarcas.ResetText()
        CBMarcas.SelectedValue = -1
        objNProductos.cargarGrid(dgvListaProductos)
    End Sub

    Private Sub CBMarcas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMarcas.SelectedIndexChanged
        objDProducto.buscarProductos(CBMarcas.Text, dgvListaProductos)
    End Sub
End Class