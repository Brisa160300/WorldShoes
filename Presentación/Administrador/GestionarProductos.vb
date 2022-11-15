Public Class GestionarProductos
    Private objNProductos = New NProducto
    Private objDProductos = New DProducto
    Private Sub BModificarProducto_Click(sender As Object, e As EventArgs) Handles BModificarProducto.Click
        If (dgvListaProductos.SelectedRows.Count > 0) Or (dgvListaProductos.SelectedCells.Count > 0) Then
            Dim frmEdit As New Mod_Producto
            frmEdit.fila = dgvListaProductos.CurrentRow.Cells(0).Value.ToString
            frmEdit.categdesc = dgvListaProductos.CurrentRow.Cells(2).Value.ToString
            frmEdit.marcadesc = dgvListaProductos.CurrentRow.Cells(4).Value.ToString
            frmEdit.TBNombre.Text = dgvListaProductos.CurrentRow.Cells(1).Value.ToString
            frmEdit.CBCategoria.DisplayMember = dgvListaProductos.CurrentRow.Cells(2).Value.ToString
            frmEdit.TBPrecio.Text = dgvListaProductos.CurrentRow.Cells(3).Value.ToString
            frmEdit.ShowInTaskbar = False
            frmEdit.ShowDialog()
            objDProductos.getProductosAll(dgvListaProductos)

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If

    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub BEliminarProducto_Click(sender As Object, e As EventArgs) Handles BEliminarProducto.Click
        If (dgvListaProductos.SelectedRows.Count > 0) Or (dgvListaProductos.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDProductos.EliminarProducto(CInt(dgvListaProductos.CurrentRow.Cells(0).Value.ToString))
                objDProductos.getProductosAll(dgvListaProductos)
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub GestionarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNProductos.cargarComboxCateg(CBCateg)
        objNProductos.cargarComboxMarca(CBMarca)
        objDProductos.getProductosAll(dgvListaProductos)
    End Sub

    Private Sub BBuscarProducto_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        If TBBuscar.Text = "" Then
            objDProductos.getProductosAll(dgvListaProductos)
        Else
            objDProductos.buscarProductosGeneralAdmin(TBBuscar.Text, dgvListaProductos)
            TBBuscar.Clear()
        End If
    End Sub

    Private Sub CBCateg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCateg.SelectedIndexChanged
        objDProductos.buscarProductosGeneralAdmin(CBCateg.Text, dgvListaProductos)
        CBMarca.SelectedValue = -1
        CBMarca.ResetText()
    End Sub

    Private Sub CBMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMarca.SelectedIndexChanged
        CBCateg.SelectedValue = -1
        CBCateg.ResetText()
        objDProductos.buscarProductosGeneralAdmin(CBMarca.Text, dgvListaProductos)
    End Sub

    Private Sub GestionarProductos_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        CBCateg.ResetText()
        CBCateg.SelectedValue = -1
        CBMarca.ResetText()
        CBMarca.SelectedValue = -1
        objDProductos.getProductosAll(dgvListaProductos)
    End Sub

    Private Sub CBCateg_Click(sender As Object, e As EventArgs) Handles CBCateg.Click
        If CBMarca.Text <> "" Then
            CBMarca.ResetText()
            CBMarca.SelectedValue = -1
        End If
    End Sub

    Private Sub CBMarca_Click(sender As Object, e As EventArgs) Handles CBMarca.Click
        If CBCateg.Text <> "" Then
            CBCateg.ResetText()
            CBCateg.SelectedValue = -1
        End If
    End Sub

    Private Sub BAltaProducto_Click(sender As Object, e As EventArgs) Handles BAltaProducto.Click
        Dim ask As MsgBoxResult = MsgBox("Seguro desea dar de alta este producto?", vbExclamation + vbYesNo)
        If ask = vbYes Then
            If objDProductos.AltaProducto(CInt(dgvListaProductos.CurrentRow.Cells(0).Value.ToString)) Then
                objDProductos.getProductosAll(dgvListaProductos)
                BEliminarProducto.Visible = True
                BAltaProducto.Visible = False
            Else
                MsgBox("No se pudo dar de alta el producto", vbExclamation, "Error")
            End If

        End If
    End Sub

    Private Sub dgvListaProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaProductos.CellClick
        Dim fil As Integer = dgvListaProductos.CurrentRow.Index
        If dgvListaProductos.Rows(fil).Cells(5).Value = 1 Then
            BEliminarProducto.Visible = True
            BAltaProducto.Visible = False
        Else
            BEliminarProducto.Visible = False
            BAltaProducto.Visible = True
        End If
    End Sub
End Class



