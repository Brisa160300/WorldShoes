﻿Public Class DFactura
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities
    Function Dguardar_factura(ofactura As factura) As Boolean
        Try
            ctx.factura.Add(ofactura)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getFacturaAll() As List(Of factura)
        Dim listarFactura = (From f In ctx.factura
                             Select f).ToList
        Return listarFactura
    End Function

    Function buscarfactura() As Integer
        Dim ultimafactura = (From f In ctx.factura
                             Select f.id_factura).Max
        Return ultimafactura
    End Function

End Class