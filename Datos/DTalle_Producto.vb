Public Class DTalle_Producto
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities
    Function Dguardar_talleProducto(otalleProducto As talle_producto) As Boolean
        Try
            ctx.talle_producto.Add(otalleProducto)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getTallesProductoAll() As List(Of talle_producto)
        Dim listartalleProducto = (From t In ctx.talle_producto Select t).ToList
        Return listartalleProducto
    End Function
    Function modTalle(idTalleProducto As Integer, cod As Integer) As Boolean
        Try
            Dim TalleProdMod = (From t In ctx.talle_producto Where t.id_talle = idTalleProducto And t.cod_producto = cod
                                Select t).First
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function ActualizarStock(idTalleProducto As Integer, cantidad As Integer, cod As Integer) As Boolean
        Try
            Dim TalleProdMod = (From t In ctx.talle_producto Where t.id_talle = idTalleProducto And t.cod_producto = cod
                                Select t).First
            TalleProdMod.cantidad_talle = CInt(TalleProdMod.cantidad_talle) - cantidad
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function EliminarTalle(idtalleProducto As Integer, cod As Integer) As Boolean
        Try
            Dim talleProdDelete = (From t In ctx.talle_producto Where t.id_talle = idtalleProducto And t.cod_producto = cod
                                   Select t).First
            talleProdDelete.estado_talle_producto = 0
            ctx.SaveChanges()
            MsgBox("Se ha eliminado con exito", vbInformation, "Confirmar Eliminación")
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function Altatalle(idtalleProducto As Integer, cod As Integer) As Boolean
        Try
            Dim talleProdAlta = (From t In ctx.talle_producto Where t.id_talle = idtalleProducto And t.cod_producto = cod
                                 Select t).First
            talleProdAlta.estado_talle_producto = 1
            MsgBox("Se ha dado de alta con exito", vbInformation, "Confirmar Alta")
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function
End Class
