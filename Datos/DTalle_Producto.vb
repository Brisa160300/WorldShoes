Imports System.Data.Entity
Imports System.Net

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

    Function ActualizarStock(cod As Integer, idtalle As Integer, cantidad As Integer) As Boolean
        Try
            MsgBox("actualiza")
            Dim talleProd = (From tp In ctx.talle_producto
                             Where tp.cod_producto = cod And tp.id_talle = idtalle
                             Select tp).First
            Dim stock = (From tp In ctx.talle_producto
                         Where tp.cod_producto = cod And tp.id_talle = idtalle
                         Select tp.cantidad_talle).First
            talleProd.cantidad_talle = stock - cantidad
            ctx.SaveChanges()
            Dim stock2 = (From tp In ctx.talle_producto
                          Where tp.cod_producto = cod And tp.id_talle = idtalle
                          Select tp.cantidad_talle).First
            If stock2 = 0 Then
                EliminarTalle(talleProd.cod_producto, talleProd.id_talle_prod)
            End If
            Return True
        Catch ex As Exception
            MsgBox(" no actualiza")
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try
    End Function

    Function EliminarTalle(cod As Integer, idtalleProducto As Integer) As Boolean
        Try
            Dim talleProdDelete = (From t In ctx.talle_producto Where t.cod_producto = cod And t.id_talle = idtalleProducto
                                   Select t).First
            talleProdDelete.estado_talle_producto = 0
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
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


    Function validarStock(cod As Integer, talleid As Integer, cant As Integer) As Boolean
        Dim listartalleProducto = (From t In ctx.talle_producto Where t.cod_producto = cod And t.id_talle = talleid Select t.cantidad_talle).First
        If listartalleProducto >= cant Then
            Return False
        Else
            Return True
        End If
    End Function

    Function talleProd(cod As Integer, talldesc As Integer) As Integer
        Dim idtalleProd = (From tp In ctx.talle_producto
                           Where tp.cod_producto = cod And tp.id_talle = talldesc
                           Select tp.id_talle_prod).First
        Return idtalleProd
    End Function

End Class
