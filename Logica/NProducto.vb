Public Class NProducto
    Function agregar_producto(nombre As String, categoria As String, stock As Integer, precio As Integer, marca As String) 'talle As String'
        Dim oproducto = New Productos
        With oproducto
            .nombre = nombre
            .id_categoria = categoria
            .stock = stock
            .precio = precio
            .id_marca = marca
            '.id_talle = talle como se le pasa el talle'
            .id_estado_producto = 1
        End With
        Dim objdproducto = New DProducto
        If objdproducto.Dguardar_producto(oproducto) Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
