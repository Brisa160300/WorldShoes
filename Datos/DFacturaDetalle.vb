Public Class DFacturaDetalle
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities
    Function Dguardar_facturaDetalle(ofacturadetalle As detalles_factura) As Boolean
        Try
            ctx.detalles_factura.Add(ofacturadetalle)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Function getFacturaDetalleAll() As List(Of detalles_factura)
        Dim listarFacturaDetalle = (From fd In ctx.detalles_factura
                                    Select fd).ToList
        Return listarFacturaDetalle
    End Function


End Class
