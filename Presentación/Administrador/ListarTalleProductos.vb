Public Class ListarTalleProductos
    Private objNProductos = New NProducto
    Private objDProductos = New DProducto
    Dim objDtalleProductos = New DTalle_Producto
    Private Sub BModificarProducto_Click(sender As Object, e As EventArgs) Handles BModificarProducto.Click
        If (dgvDetalleProductos.SelectedRows.Count > 0) Or (dgvDetalleProductos.SelectedCells.Count > 0) Then
            Dim frmEdit As New Mod_Producto
            frmEdit.fila = dgvDetalleProductos.CurrentRow.Cells(0).Value.ToString
            frmEdit.categdesc = dgvDetalleProductos.CurrentRow.Cells(2).Value.ToString
            frmEdit.marcadesc = dgvDetalleProductos.CurrentRow.Cells(4).Value.ToString
            frmEdit.TBNombre.Text = dgvDetalleProductos.CurrentRow.Cells(1).Value.ToString
            frmEdit.CBCategoria.DisplayMember = dgvDetalleProductos.CurrentRow.Cells(2).Value.ToString
            frmEdit.TBPrecio.Text = dgvDetalleProductos.CurrentRow.Cells(3).Value.ToString
            frmEdit.ShowInTaskbar = False
            frmEdit.ShowDialog()
            objDProductos.DetalleProductosAdmin(dgvDetalleProductos)

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If

    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub BEliminarProducto_Click(sender As Object, e As EventArgs) Handles BEliminarProducto.Click
        If (dgvDetalleProductos.SelectedRows.Count > 0) Or (dgvDetalleProductos.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
            If ask = vbYes Then
                Dim codigo As Integer = CInt(dgvDetalleProductos.CurrentRow.Cells(0).Value.ToString)
                Dim talle As Integer = CInt(dgvDetalleProductos.CurrentRow.Cells(6).Value.ToString)
                objDtalleProductos.EliminarTalleProd(codigo, talle)
                objDProductos.DetalleProductosAdmin(dgvDetalleProductos)
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub GestionarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNProductos.cargarComboxCateg(CBCateg)
        objNProductos.cargarComboxMarca(CBMarca)
        objDProductos.DetalleProductosAdmin(dgvDetalleProductos)
    End Sub

    Private Sub BBuscarProducto_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        If TBBuscar.Text = "" Then
            objDProductos.DetalleProductosAdmin(dgvDetalleProductos)
        Else
            objDProductos.buscarProductosDetalleAdmin(TBBuscar.Text, dgvDetalleProductos)
            TBBuscar.Clear()
        End If
    End Sub

    Private Sub CBCateg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCateg.SelectedIndexChanged
        objDProductos.buscarProductosDetalleAdmin(CBCateg.Text, dgvDetalleProductos)
        CBMarca.SelectedValue = -1
        CBMarca.ResetText()
    End Sub

    Private Sub CBMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMarca.SelectedIndexChanged
        CBCateg.SelectedValue = -1
        CBCateg.ResetText()
        objDProductos.buscarProductosDetalleAdmin(CBMarca.Text, dgvDetalleProductos)
    End Sub

    Private Sub GestionarProductos_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        CBCateg.ResetText()
        CBCateg.SelectedValue = -1
        CBMarca.ResetText()
        CBMarca.SelectedValue = -1
        objDProductos.DetalleProductosAdmin(dgvDetalleProductos)
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
            Dim codigo As Integer = CInt(dgvDetalleProductos.CurrentRow.Cells(0).Value.ToString)
            Dim talle As Integer = CInt(dgvDetalleProductos.CurrentRow.Cells(6).Value.ToString)
            If objDtalleProductos.AltaTalleProd(codigo, talle) Then
                objDProductos.DetalleProductosAdmin(dgvDetalleProductos)
                BEliminarProducto.Visible = True
                BAltaProducto.Visible = False
            Else
                MsgBox("No se pudo dar de alta el producto", vbExclamation, "Error")
            End If
        End If
    End Sub

    Private Sub dgvListaProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleProductos.CellClick
        Dim fil As Integer = dgvDetalleProductos.CurrentRow.Index
        If dgvDetalleProductos.Rows(fil).Cells(7).Value = "Activo" Then
            BEliminarProducto.Visible = True
            BAltaProducto.Visible = False
        Else
            BEliminarProducto.Visible = False
            BAltaProducto.Visible = True
        End If
    End Sub
End Class