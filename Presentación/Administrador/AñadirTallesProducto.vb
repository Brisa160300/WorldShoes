Public Class AñadirTallesProducto
    Private objNProducto = New NProducto
    Private objNTalle = New NTalle
    Private objNTalleProd = New NTalle_Producto
    Private objDTalle = New DTalle
    Private Sub AñadirTallesProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNProducto.cargarGrid(dgvListarProductos)
        objNProducto.cargarGrid2(dgvDetalleProductos)
        CBTalle.Enabled = False
    End Sub

    Public Function EspacioEnBlanco() As Boolean
        Dim Ask As Boolean = False
        Dim talle As String = CBTalle.Text
        Dim producto As String = TBCodProducto.Text.Trim
        Dim cantidad As String = TBCantidadProducto.Text.Trim

        If talle = "" Then
            ErrorPTalle.SetError(CBTalle, "Selecciones un talle")
            Ask = True
        End If
        If producto = "" Then
            ErrorPProd.SetError(TBCodProducto, "Seleccione un producto de la lista de productos")
            Ask = True
        End If
        If cantidad = "" Then
            ErrorPCant.SetError(TBCantidadProducto, "Ingrese un stock")
            Ask = True
        ElseIf CInt(cantidad) <= 0 Then
            ErrorPCant.SetError(TBCantidadProducto, "El stock minimo es de 100 unidades")
            Ask = True
        ElseIf CInt(cantidad) > 1000 Then
            ErrorPCant.SetError(TBCantidadProducto, "El stock maximo es de 1000 unidades")
            Ask = True
        End If
        Return Ask
    End Function

    Private Sub BRegistrarTalle_Click(sender As Object, e As EventArgs) Handles BRegistrarTalle.Click
        Dim ask As MsgBoxResult
        ErrorPCant.Clear()
        ErrorPProd.Clear()
        ErrorPTalle.Clear()
        If EspacioEnBlanco() = False Then
            Dim cod_producto As Integer = TBCodProducto.Text
            Dim talleProducto As Integer = Int(CBTalle.SelectedValue)
            Dim cantidad As Integer = TBCantidadProducto.Text
            ask = MsgBox("Esta seguro que desea añadir el talle y stock", vbYesNo + vbQuestion, "Confirmar operacion")
            If ask = vbYes Then
                If objNTalleProd.agregar_talle_producto(cod_producto, talleProducto, cantidad) Then
                    objNProducto.cargarGrid(dgvListarProductos)
                    MsgBox("Registrado con exito", vbInformation)
                Else
                    MsgBox("El producto ya cuanta con inventario para el talle ingresado", vbCritical, "Error")
                End If
            End If
        End If
    End Sub
    Private Sub dgvListarProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarProductos.CellClick
        Dim codProd As Integer = CInt(dgvListarProductos.CurrentRow.Cells(0).Value.ToString)
        TBCodProducto.Text = codProd
        objNProducto.cargarComboxTalle(CBTalle)
        CBTalle.Enabled = True
        Dim fil As Integer = dgvListarProductos.CurrentRow.Index
    End Sub
    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub
End Class