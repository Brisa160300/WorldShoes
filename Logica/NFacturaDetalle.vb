Public Class NFacturaDetalle
    Function agregar_facturaDetalle(iduser As Integer, idcli As Integer, cantidad As Integer, importe As Decimal)
        Dim ofacturadetalle = New detalles_factura
        With ofacturadetalle
            '.id_usuario = iduser
            '.id_cliente = idcli
            '.cantidad_factura = cantidad
            '.importe_factura = importe
        End With

        Dim objdfacturadetalle = New DFacturaDetalle
        If objdfacturadetalle.Dguardar_facturaDetalle(ofacturadetalle) Then

            Return True
        Else
            Return False
        End If

    End Function
End Class
