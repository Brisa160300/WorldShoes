Public Class NFactura
    Function agregar_factura(iduser As Integer, idcli As Integer, cantidad As Integer, importe As Decimal, dgv As DataGridView)
        Dim objdfacturadetalle = New DFacturaDetalle
        Dim objdfactura = New DFactura
        Dim ultimaFactura = objdfactura.buscarfactura()
        Dim row As DataGridViewRow
        Dim dgvConStock As DataGridView = dgv
        Dim i As Integer
        Dim resultado As Boolean = True

        Dim ofactura = New factura
        With ofactura
            .id_usuario = iduser
            .id_cliente = idcli
            .cantidad_factura = cantidad
            .importe_factura = importe
        End With

        For i = 0 To (dgv.Rows().Count().ToString - 1)

            Dim odetalle = New detalles_factura
            row = dgv.Rows(i)
            If odetalle.talle_producto.cantidad_talle < dgv.Item(3, i).Value Then
                resultado = False
                MsgBox("No hay stock disponible, para el producto" + dgv.Item(1, i).Value)
                'Abrir factura'
                Exit Function
            End If
        Next
        If resultado = True Then

            If objdfactura.Dguardar_factura(ofactura) Then

                For i = 0 To (dgv.Rows().Count().ToString - 1)

                    Dim odetalle = New detalles_factura
                    row = dgv.Rows(i)
                    With odetalle
                        .id_factura = ultimaFactura
                        .id_talle_prod = dgv.Item(5, i).Value 'id talle producto'
                        .cantidad_detalle = dgv.Item(3, i).Value ' cantidad de productos'
                        .importe_detalle = dgv.Item(4, i).Value 'precio unitario del producto'
                    End With
                    objdfacturadetalle.Dguardar_facturaDetalle(odetalle)
                    Dim objNTalle_Prod = New DTalle_Producto
                    objNTalle_Prod.ActualizarStock(CInt(dgv.Item(5, i).Value), CInt(dgv.Item(3, i).Value), CInt(dgv.Item(0, i).Value))
                Next

                Return True
            Else
                Return False
            End If
        End If
    End Function
End Class
