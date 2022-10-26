Public Class NTalle_Producto
    Function agregar_talle_producto(codigo As Integer, id_talle As Integer) As Boolean
        Dim otalleProd = New talle_producto
        With otalleProd
            .cod_producto = codigo
            .id_talle = id_talle
            .estado_talle_producto = 1
        End With
        Dim objdtalleProd = New DTalle_Producto
        If objdtalleProd.Dguardar_talleProducto(otalleProd) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub cargarGrid(grid As DataGridView)
        Dim talProd As DTalle_Producto = New DTalle_Producto
        grid.DataSource = talProd.getTallesProductoAll()
        grid.Columns(0).HeaderText = "ID"
        grid.Columns(1).HeaderText = "Descripción"
        grid.Columns(2).Visible = False
        grid.Columns(3).Visible = False
        grid.ClearSelection()
    End Sub

End Class
