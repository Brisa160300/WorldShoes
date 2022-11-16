
Public Class ListarProductos
    Dim objNProducto = New NProducto
    Dim objDProducto = New DProducto

    'Private Sub TBBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBBuscar.KeyPress
    '    If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
    '        e.Handled = True
    '        MsgBox("Solo se aceptan letras", vbCritical, "Error")

    '    End If
    'End Sub

    Private Sub ListarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNProducto.cargarComboxCateg(CBCatProducto) 'combo As ComboBox, marca As String'
        objNProducto.cargarComboxMarca(CBMarcas)
        objDProducto.getProductosVendedorAll(dgvListaProductos)

    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub BBuscarProducto_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        'objDProducto.buscarProductos(CBCatProducto.Text, CBMarcas.Text, DataGridViewListaProductos)
        objDProducto.buscarProductos(TBBuscar.Text, dgvListaProductos)
        TBBuscar.Clear()
    End Sub

    Private Sub CBCatProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCatProducto.SelectedIndexChanged
        objDProducto.buscarProductos(CBCatProducto.Text, dgvListaProductos)
    End Sub

    Private Sub CBMarcas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMarcas.SelectedIndexChanged
        objDProducto.buscarProductos(CBMarcas.Text, dgvListaProductos)
    End Sub
    Private Sub GroupBoxBuscarProducto_Click(sender As Object, e As EventArgs) Handles GroupBoxBuscarProducto.Click
        CBCatProducto.ResetText()
        CBCatProducto.SelectedValue = -1
        CBMarcas.ResetText()
        CBMarcas.SelectedValue = -1
        objDProducto.getProductosVendedorAll(dgvListaProductos)
    End Sub

End Class